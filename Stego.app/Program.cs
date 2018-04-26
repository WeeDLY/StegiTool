﻿using Library.Utility;
using System;
using System.Windows.Forms;

namespace Stego.app
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Settings.LoadSettings();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new EncodeForm());
        }
    }
}