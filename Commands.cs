using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Threading;

namespace ZAPPINProject
{
    class Commands
    {

        public const int NEXT_TRACK = 0xB0;
        public const int PLAY_PAUSE_TRACK = 0xB3;
        public const int PREV_TRACK = 0xB1;

        [DllImport("user32.dll")]
        public static extern void keybd_event(byte virtualKey, byte scanCode, uint flags, IntPtr extraInfo);

        public static void PLAY_PAUSE_SONG()
        {
            keybd_event(PLAY_PAUSE_TRACK, 0, 1, IntPtr.Zero);
        }

        public static void NEXT_SONG()
        {
            keybd_event(NEXT_TRACK, 0, 1, IntPtr.Zero);
        }

        public static void PREV_SONG()
        {
            keybd_event(PREV_TRACK, 0, 1, IntPtr.Zero);
        }

        public static void ZAPPIN()
        {
            for (int i = 0; i < 100; i++)
            {
                Commands.NEXT_SONG();
                Thread.Sleep(91000);
            }

        }
        
    }
}
