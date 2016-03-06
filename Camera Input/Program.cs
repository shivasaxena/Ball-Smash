using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.Util;

using System.Runtime.InteropServices;

namespace MetalopEmgucvBallSmashUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            if (!IsPlaformCompatable()) return;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MainApplicationForm M = new MainApplicationForm();
            Application.Run(M);
            
        }

        /// <summary>
        /// Check if both the managed and unmanaged code are compiled for the same architecture
        /// </summary>
        /// <returns>Returns true if both the managed and unmanaged code are compiled for the same architecture</returns>
        static bool IsPlaformCompatable()
        {
            // TODO: have a check find that the bitness of unmanaged dlls and and compiler output is same
            return true;
        }
    }
}
