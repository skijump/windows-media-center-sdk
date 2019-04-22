using System;
using System.Collections.Generic;
using Microsoft.MediaCenter.TVVM;

namespace ItvApp
{
    internal sealed class AudioStreamSwitcher
    {        
        // the TVVM StreamSelector object
        StreamSelector _streamSelector;

        // Audio Streams in the inbound data
        List<StreamInfo> _audioStreams;
        
        // Constructor
        internal AudioStreamSwitcher(ItvApp.AddIn addin)
        {
            _streamSelector = addin.StreamSelector;
            _audioStreams = new List<StreamInfo>();
        }

        // Initialize the AudioStreamSwitcher class.
        public void Initialize()
        {
            EnumerateStreams();

            // let Windows Media Center know that we are going to modify audio stream handling
            _streamSelector.SetModifyingStreams(StreamType.Audio);
        }

        // Uninitialize the AudioStreamSwitcher class.
        public void Uninitialize()
        {
            if (null != _audioStreams)
            {
                _audioStreams = null;
            }

            // let Windows Media Center know that we are not going to modify any streams
            _streamSelector.SetModifyingStreams(StreamType.None);
        }
            
        // Get all the audio streams in the inbound data.
        private void EnumerateStreams()
        {   
            // clear out any old elements in the list
            _audioStreams.Clear();

            // get the available streams
            StreamInfo[] tempStreams = _streamSelector.AvailableStreams;

            // check if the tempStreams is valid to work with 
            if ((null != tempStreams) && (tempStreams.Length >= 1))
            {
                foreach (StreamInfo sInfo in tempStreams)
                {
                    // if the stream is an audio stream, add to the list.
                    if (sInfo.StreamType == StreamType.Audio)
                    {
                        _audioStreams.Add(sInfo);                    
                    }
                }
            }           
        }        

        // Get the TVVM.StreamInfo for an audio stream with the PID passed as parameter
        private StreamInfo GetStreamWithPid(int pid)
        {
            if (null != _audioStreams)
            {
                foreach (StreamInfo strInfo in _audioStreams)
                {
                    if (strInfo.PID == pid)
                        return strInfo;
                }
            }
            return null;
        }

        // Called by the UI when the user asked the audio stream to switch. 
        public void SelectStream(int pid)
        {
            if (null != _audioStreams)
            {
                StreamInfo[] streamToEnable = new StreamInfo[1];
                StreamInfo[] streamToDisable = new StreamInfo[1];

                // Check if the the PID exists
                streamToEnable[0] = GetStreamWithPid(pid);                

                // If this is the active stream, return
                if ((null != streamToEnable[0]) && (true == streamToEnable[0].IsActive))
                    return;

                // Iterate through the array to check if which stream to disable. 
                foreach (StreamInfo strInfo in _audioStreams)
                {
                    if (true == strInfo.IsActive)
                    {
                        streamToDisable[0] = strInfo;
                        _streamSelector.DeselectStream(streamToDisable);
                        break;
                    }
                }
                
                // Select the stream that we need to enable and commit                
                if (null != streamToEnable[0])
                {
                    _streamSelector.SelectStream(streamToEnable);
                }

                _streamSelector.CommitSelection();
            }
        }
    }
}
