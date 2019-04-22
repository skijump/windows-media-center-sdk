//
// McmlPadController.cs
//
// Copyright (C) 2007 by Microsoft Corporation.  All rights reserved.
//

using System;
using System.Text;
using System.Runtime.InteropServices;
using System.Drawing;

namespace McmlPadAuto
{
    //
    //
    //

    class McmlPadController
    {
        private string windowTitle;

        //
        //
        //

        public string ID
        {
            set
            {
                this.windowTitle = value;
            }

            get
            {
                return this.windowTitle;
            }
        }

        //
        //
        //

        public bool PadExists
        {
            get
            {
                return (GetPadControlWindow() != IntPtr.Zero);
            }
        }

        //
        //
        //

        private IntPtr GetPadControlWindow()
        {
            IntPtr hwnd = IntPtr.Zero;

            if ( windowTitle != null )
                hwnd = Win32Api.FindWindow("McmlPad Control Window",windowTitle);

            return hwnd;
        }

        //
        //
        //

        public bool GetPositionAndSize(out Point pos,out Size size)
        {
            IntPtr hwnd = GetPadControlWindow();
            IntPtr atom;
            bool success = false;
            string result = null;

            pos  = new Point();
            size = new Size();

            if ( hwnd != IntPtr.Zero )
            {
                atom = Win32Api.SendMessage(hwnd,s_cmdIdGetPosAndSize);

                if ( atom != IntPtr.Zero )
                    result = GetResultFromAtom(atom);
            }

            if ( result != null )
            {
                string[] parts = result.Split(new char[] {','});

                if ( parts.Length == 4 )
                {
                    pos.X       = Int32.Parse(parts[0]);
                    pos.Y       = Int32.Parse(parts[1]);
                    size.Width  = Int32.Parse(parts[2]);
                    size.Height = Int32.Parse(parts[3]);

                    success = true;
                }
            }

            return success;
        }


        //
        //
        //

        public void Refresh()
        {
            IntPtr hwnd = GetPadControlWindow();

            if ( hwnd != IntPtr.Zero )
                Win32Api.SendMessage(hwnd,s_cmdIdRefresh);
        }

        //
        //
        //

        public void Close()
        {
            IntPtr hwnd = GetPadControlWindow();

            if ( hwnd != IntPtr.Zero )
                Win32Api.SendMessage(hwnd,s_cmdIdClose);
        }

        //
        //
        //

        public void Load(string uri)
        {
            IntPtr hwnd = GetPadControlWindow();
            Win32Api.COPYDATASTRUCT cds;

            if ( hwnd != IntPtr.Zero )
            {
                cds = new Win32Api.COPYDATASTRUCT(s_cmdIdLoad,uri);

                Win32Api.SendMessage(
                    hwnd,
                    Win32Api.WM_COPYDATA,
                    IntPtr.Zero,
                    ref cds
                    );
            }
        }

        //
        //
        //

        private static string GetResultFromAtom(IntPtr atom)
        {
            string result = null;

            try
            {
                StringBuilder sb = new StringBuilder(255);

                if ( 0 != Win32Api.GlobalGetAtomName(atom,sb,sb.Capacity) )
                    result = sb.ToString();
            }
            finally
            {
                Win32Api.GlobalDeleteAtom(atom);
            }

            return result;
        }

        static McmlPadController()
        {
            // Register MCMLPad's automation command IDs.  Note that these
            // strings must be kept in sync with those found in the MCMLPad
            // source.
            //
            // Most of these commands are window messages, however some of
            // them are WM_COPYDATA command IDs.

            // Window messages.

            s_cmdIdRefresh       = RegisterPadCommandID("REFRESH");
            s_cmdIdClose         = RegisterPadCommandID("CLOSE");
            s_cmdIdGetPosAndSize = RegisterPadCommandID("GETPOSANDSIZE");

            // WM_COPYDATA based commands.

            s_cmdIdLoad        = RegisterPadCommandID("LOAD");
        }

        private static uint RegisterPadCommandID(string name)
        {
            return Win32Api.RegisterWindowMessage("MCMLPAD_COMMAND_" + name);
        }

        private static uint s_cmdIdRefresh;
        private static uint s_cmdIdClose;
        private static uint s_cmdIdLoad;
        private static uint s_cmdIdGetPosAndSize;
    }

    //
    // Raw Win32 API Utilities.
    //

    internal sealed class Win32Api
    {
        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern uint RegisterWindowMessage(string name);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr SendMessage(IntPtr hWnd,uint uMsg,IntPtr wParam,IntPtr lParam);

        public static IntPtr SendMessage(IntPtr hWnd, uint uMsg)
        {
            return SendMessage(hWnd, uMsg, IntPtr.Zero, IntPtr.Zero);
        }

        public const uint WM_COPYDATA = 0x004A;

        public struct COPYDATASTRUCT
        {
            public IntPtr dwData;
            public int cbData;
            [MarshalAs(UnmanagedType.LPWStr)]
            public string lpData;

            public COPYDATASTRUCT(uint commandID,string data)
            {
                dwData = (IntPtr)commandID;
                lpData = data;
                cbData = (data != null) ? (data.Length * 2) : 0;
            }
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool SendMessage(
            IntPtr hWnd,
            uint   uMsg,
            IntPtr wParam,
            ref COPYDATASTRUCT cds
            );


        [DllImport("kernel32.dll", CharSet=CharSet.Unicode)]
        public static extern uint GlobalGetAtomName(
            IntPtr atom,
            StringBuilder strAtomName,
            int cbSize
            );

        [DllImport("kernel32.dll", CharSet=CharSet.Unicode)]
        public static extern IntPtr GlobalAddAtom(string atomName);

        [DllImport("kernel32.dll")]
        public static extern IntPtr GlobalDeleteAtom(IntPtr a);
    }
}

