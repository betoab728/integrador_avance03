﻿using AllqovetBLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Allqovet
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmDashboard());

            DashboardBLL dashboardBLL = new DashboardBLL();
            int numClientes = dashboardBLL.ContarNumClientes();
            Console.WriteLine("Número de clientes: " + numClientes);
        }
    }
}
