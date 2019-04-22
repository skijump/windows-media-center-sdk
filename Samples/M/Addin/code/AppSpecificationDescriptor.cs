using System;
using System.Collections.Generic;

namespace ItvApp
{
    internal sealed class AppSpecificationDescriptor
    {
        // App specific variables
        private int _width;
        private int _height;
        private int _rows;
        private int _columns;
        private int _cellWidth;
        private int _cellHeight;

        // Holds the extra information per cell.
        List<InfoTextFormat> _infoTextFormats = new List<InfoTextFormat>();

        // The list of channel boxes (cells) on this page.
        List<ChannelBox> _channelBoxes = new List<ChannelBox>();        

        // Constructor
        public AppSpecificationDescriptor(int iRowCount, int iColCount, int iVideoWidth, int iVideoHeight, int iCellWidth, int iCellHeight)
        {
            _width = iVideoWidth;
            _height = iVideoHeight;
            _rows = iRowCount;
            _columns = iColCount;
            _cellWidth = iCellWidth;
            _cellHeight = iCellHeight;
        }        

        // Get the number of rows
        public int Rows
        {
            get
            {
                return _rows;
            }           
        }

        // Get the number of Columns
        public int Columns
        {
            get
            {
                return _columns;
            }            
        }

        // get the width of the cell
        public int CellWidth
        {
            get
            {
                return _cellWidth;
            }            
        }

        // get the height of the cell
        public int CellHeight
        {
            get
            {
                return _cellHeight;
            }            
        }

        // get the height of the app
        public int VideoHeight
        {
            get
            {
                return _height;
            }            
        }

        // get the width of the app
        public int VideoWidth
        {
            get
            {
                return _width;
            }            
        }

        // Get the list of available channel boxes in this page.
        public List<ChannelBox> Channels
        {
            get
            {
                return _channelBoxes;
            }
        } 
       
        // Gets the InfoTextFormat collection
        public List<InfoTextFormat> InfoTexts
        {
            get
            {
                return _infoTextFormats;
            }
        }

        // Return the Channel box at the position detailed in the parameter
        public ChannelBox Lookup(int column, int row)
        {
            foreach (ChannelBox channelBox in _channelBoxes)
            {
                if (row == channelBox.Row && column == channelBox.Column)
                {
                    return channelBox;
                }
            }

            return null;
        }

        // Get the channel box which is closes to the location detailed in the [arameters.
        public ChannelBox Nearest(int column, int row)
        {
            ChannelBox bestBox = _channelBoxes[0];

            foreach (ChannelBox channelBox in _channelBoxes)
            {
                int x1 = Math.Abs(bestBox.Column - column);
                int y1 = Math.Abs(bestBox.Row - row);
                int x2 = Math.Abs(channelBox.Column - column);
                int y2 = Math.Abs(channelBox.Row - row);

                if ((x2 < x1 && y2 <= y1) || (x2 <= x1 && y2 < y1))
                {
                    bestBox = channelBox;
                }
            }

            return bestBox;
        }
        
        // Return the Audio PID for this channel box
        public int GetAudioPid(ChannelBox channelBox)
        {
            return channelBox.AudioPID;
        }        
    }

    public class ChannelBox
    {
        // information about a channel box
        private int _row;
        private int _column;
        private String _tuningString;
        private int _left;
        private int _top;
        private int _audioPid;
              
        // additional information for the channel
        public List<String> _infoText = new List<String>();

        // constructor
        public ChannelBox(int iRowIndex, int iColIndex, int iAudioPid, int iLeft, int iTop, string tuneString)
        {
            _row = iRowIndex;
            _column = iColIndex;
            _audioPid = iAudioPid;
            _left = iLeft;
            _top = iTop;
            _tuningString = tuneString;
        }

        // add information for the channel 
        public void AddInfoText(string sInfo)
        {
            _infoText.Add(sInfo);
        }

        // get the row index
        public int Row
        {
            get
            {
                return _row;
            }
        }

        // get the column index
        public int Column
        {
            get
            {
                return _column;
            }
        }

        // get the left co-rd
        public int Left
        {
            get
            {
                return _left;
            }
        }

        // get the top co-rd
        public int Top
        {
            get
            {
                return _top;
            }
        }

        // get the audioPID of the channel
        public int AudioPID
        {
            get
            {
                return _audioPid;
            }
        }

        // get the tuneXML of the channel
        public string TuneString
        {
            get
            {
                return _tuningString;
            }
        }        
    }

    // hold information about the details of a channel;
    public struct InfoTextFormat
    {        
        public String infoColor;
        public String infoFont;
        public int infoFontSize;

        public int left;
        public int top;
        public int width;                
    }
}
