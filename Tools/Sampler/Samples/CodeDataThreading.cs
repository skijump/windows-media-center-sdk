using System;
using System.Diagnostics;
using System.Collections;
using System.Threading;
using Microsoft.MediaCenter.UI;

namespace Sampler.CodeData.Threading
{
    //
    // PrimeFinder model item - 
    //
    // It is forbidden to call most MCML APIs from a background thread 
    // (for example, creating model items, or calling FirePropertyChanged).  
    // However, if you are doing an operation that blocks or could take a long
    // time, you don't want to do it on the main application thread, because that
    // will hang the rest of the app.
    //
    // Two APIs are provided to make it easier to do work on a background thread
    // and communicate back to the main Application thread:
    //
    // Application.DeferredInvoke can be called from any thread, and it takes a 
    // DeferredHandlerthat will be invoked at some future point on the 
    // application thread.  This function is asynchronous - it returns 
    // immediately, even if you're already on the application thread.
    //
    //
    // Application.DeferredInvokeOnWorkerThread is similar, except that it takes
    // *two* DeferredHandlers - the first one will be invoked on a background thread,
    // and the second will be invoked on the application thread after the first
    // one has completed.  However, like DeferredInvoke, this API does not 
    // call the delegates directly before returning.
    //
    // This class demonstrates the use of these APIs - it uses a brute force
    // method to search for prime numbers on a background thread; the search
    // is started using Application.DeferredInvokeOnWorkerThread.  While on the
    // background thread, it uses Application.DeferredInvoke to communicate
    // status back to the application thread so that it can update it's properties
    // and the UI.
    //
    // One last note about DeferredInvoke is that it is truly asynchronous, and 
    // "fire and forget" - you can be called back *even after you've been disposed*.
    // Fortunately, ModelItem provides an "IsDisposed" property that you can (and 
    // should) check before doing any work in a callback.
    //
    public class PrimeFinder : ModelItem
    {
        public PrimeFinder()
        {
            _status = RunningStatus.Stopped;
            _primes = new ArrayListDataSet(this);
            _stopwatch = new Stopwatch();

            DetermineInitialCandidate();
        }
        
        //
        // Called to dispose this model item - call Stop
        // to make sure our background search exits.
        //        
        protected override void Dispose(bool fDispose)
        {
            base.Dispose(fDispose);

            if (fDispose)
            {
                Stop();

                if (_primes != null)
                {
                    _primes.Dispose();
                    _primes = null;
                }
            }            
        }

        //
        // Called to start the search - if we're currently
        // in the stopped state, then change our status to 
        // Started and call DeferredInvokeOnWorkerThread to
        // kick off our search.
        //
        public void Start()
        {
            if (Status == RunningStatus.Stopped)
            {
                Status = RunningStatus.Started;

                Application.DeferredInvokeOnWorkerThread
                                (                                                         
                                 // Delegate to be invoked on background thread
                                 RunTest,

                                 // Delegate to be invoked on app thread
                                 TestFinished,

                                 // Parameter to be passed to both delegates, we don't need it
                                 null
                                 );
            }
        }


        //
        // Called to stop a search in progress.
        // Sets our status to PendingStop, which is
        // a signal to the background search that it 
        // should terminate.
        //
        public void Stop()
        {
            if (Status == RunningStatus.Started)
            {
                Status = RunningStatus.PendingStop;
            }
        }

        //
        // Called to reset our state - clears our list
        // of primes, resets our stopwatch, and calculates
        // a new starting candidate for our next search.
        //
        public void Reset()
        {
            if (Status == RunningStatus.Stopped)
            {
                _primes.Clear();
                _stopwatch.Reset();
                DetermineInitialCandidate();
            }
        }

        //
        // Called to randomly compute a starting number for our
        // next search.  We pick a number slightly larger than 
        // UInt32.MaxValue so that the searches take a bit of time, 
        // but hopefully not too long (i.e. minutes) to find
        // each prime.
        //
        
        private void DetermineInitialCandidate()
        {
            Random random = new Random();

            ulong candidate = (ulong)random.Next() + 1;
            while (candidate < (ulong.MaxValue >> 8))
                candidate *= (ulong)random.Next(32) + 1;

            CurrentCandidate = candidate;            
        }

        
        //
        // The list of primes that we've found so far.
        //
        public IList Primes
        {
            get { return _primes; }
        }

        //
        // The amount of time we've spent on a background thread
        // searching for primes.
        //        
        public TimeSpan ElapsedTime
        {
            get { return _stopwatch.Elapsed; }
        }

        //
        // Our current running state
        // 
        public RunningStatus Status
        {
            get { return _status; }
            set
            {
                if (_status != value)
                {
                    _status = value;
                    FirePropertyChanged("Status");
                }
            }
        }

        //
        // The number we're currently testing
        //        
        public ulong CurrentCandidate
        {
            get { return _currentCandidate; }
            set
            {
                if (_currentCandidate!= value)
                {
                    _currentCandidate = value;
                    FirePropertyChanged("CurrentCandidate");
                }
            }
        }

        //
        // Callback from our background search to notify us
        // that a new number is being tested.
        //
        // Notice that since this is a deferred call, 
        // (from Application.DeferredInvoke),
        // we have to check IsDisposed before doing any work.
        // 
        private void TestingCandidate(object obj)
        {
            if (!IsDisposed)
            {
                CurrentCandidate = (ulong)obj;
            }
        }

        //
        // Callback from our background search to notify us
        // that a new prime has been found.
        //
        // Notice that since this is a deferred call, 
        // (from Application.DeferredInvoke),        
        // we have to check IsDisposed before doing any work.
        // 
        private void PrimeFound(object obj)
        {
            if (!IsDisposed)
            {
                _primes.Add((ulong)obj);
            }
        }

        //
        // This is the second DeferredHandler that we passed to
        // Application.DeferredInvokeOnWorkerThread; it 
        // is called after our background search has 
        // completed.
        //
        // Notice that since this is a deferred call,
        // (from Application.DeferredInvokeOnWorkerThread),        
        // we have to check IsDisposed before doing any work.
        // 

        private void TestFinished(object obj)
        {
            if (!IsDisposed)
            {
                Status = RunningStatus.Stopped;
            }
        }

        //
        // This is the first DeferredHandler that we passed to 
        // Application.DeferredInvokeOnWorkerThread; it
        // is called from a background thread, meaning
        // that we can't directly call any MCML APIs.
        //
        // This function uses a brute force method of searching 
        // for prime numbers - for an integer N, it is prime IFF
        // for every integer M such that 2<= M <= sqrt(N)
        // N mod M != 0.
        //
        // It searches every number from _currentCandidate up to
        // UInt64.MaxValue, or until we're signalled to stop.
        //
        // There are more efficient ways of weeding out composites,
        // but the whole point of this is to be an operation that
        // takes a long time :)
        //
        private void RunTest(object obj)
        {
            //
            // Drop the priority of our thread so that we don't
            // interfere with other processing
            //
            
            ThreadPriority priority = Thread.CurrentThread.Priority;
            Thread.CurrentThread.Priority = ThreadPriority.Lowest;
            
            try
            {
                
                // Start our stopwatch to time the amount of time we spend here
                _stopwatch.Start();


                for(ulong candidate = _currentCandidate;  candidate < UInt64.MaxValue && Status != RunningStatus.PendingStop; candidate++)
                {
                    
                    //
                    // Let the app thread know that we're testing a new number.
                    // Note that this returns immediately - the delegate is NOT 
                    // invoked synchronously from here.
                    //
                    
                    Application.DeferredInvoke(TestingCandidate, candidate);

                    
                    bool anyDivisors = false;
                    ulong maxTest = (ulong)Math.Floor(Math.Sqrt(candidate));
                    
                    for (ulong i = 2; i <= maxTest && !anyDivisors && Status != RunningStatus.PendingStop; i++)
                    {
                        
                        if (candidate % i == 0)
                            anyDivisors = true;
                    }

                    if (Status != RunningStatus.PendingStop && !anyDivisors)
                    {
                        // Found a prime, send it back to the app thread!
                        Application.DeferredInvoke(PrimeFound, candidate);
                    }                                
                }

                _stopwatch.Stop();
            }
            finally
            {
                //
                // Reset our thread's priority back to its previous value
                //
                Thread.CurrentThread.Priority = priority;
            }
        }


        public enum RunningStatus 
        {
            Started,
            PendingStop,
            Stopped
        }

        private Stopwatch _stopwatch;
        private volatile RunningStatus _status;
        private ulong _currentCandidate;
        private ArrayListDataSet _primes;
    }
}
