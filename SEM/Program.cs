﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using SEM.Forms;

namespace SEM
{
    static class Program
    {
        static Conexion c = new Conexion();
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            c.iniciar();
            c.getMaestros();
            c.getMaterias();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login(c));
            //Application.Run(new EditAccount(c));
        }
    }
}
