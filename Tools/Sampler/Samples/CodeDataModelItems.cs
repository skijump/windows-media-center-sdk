using System;
using Microsoft.MediaCenter.UI;

namespace Sampler.CodeData.ModelItems
{
    //
    // Clock ModelItem.
    //

    public class Clock : ModelItem
    {
        public Clock()
        {
            //
            // Set up our clock refresh timer. The timer itself
            // is also a ModelItem. This clock is the "owner" of
            // the Timer. So, when this clock is disposed, all
            // its owned objects will be disposed automatically.
            //

            _timer = new Timer(this);
            _timer.Interval = 1000;
            _timer.Tick += delegate { RefreshTime(); };
            _timer.Enabled = true;

            RefreshTime();
        }

        //
        // Current time. 
        //
        // This is the standard pattern for exposing properties on
        // your code/data that accessible via markup.
        //

        public string Time
        {
            get
            {
                return _time;
            }

            set
            {
                if (_time != value)
                {
                    _time = value;

                    FirePropertyChanged("Time");
                }
            }
        }


        // Try to update the time.
        private void RefreshTime()
        {
            Time = DateTime.Now.ToString();
        }


        private string _time = String.Empty;
        private Timer _timer;
    }
}
