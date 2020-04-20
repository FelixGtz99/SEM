using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SEM.Forms
{
    public partial class Terminos : Form
    {
        public Terminos()
        {
            InitializeComponent();
            //Datos de la barra superior
            //this.ActiveControl = panel2;
            btnClose.Height = panel2.Height;
            btnClose.Location = new Point(this.Width - btnClose.Width, 0);
            panel2.Location = new Point(0, 0);
            panel2.Width = this.Width;

            btnVolver.Focus();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
