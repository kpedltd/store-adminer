﻿using StoreAdminer.Data;
using StoreAdminer.Forms;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreAdminer {
    static class Program {

        [STAThread]
        static void Main() {
            if (Environment.OSVersion.Version.Major >= 6)
                SetProcessDPIAware();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new ContainerForm());
        }

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();
    }
}
