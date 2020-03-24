using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SEM
{
    public partial class AccountMenu : Form
    {
        Conexion c = null;
        public AccountMenu(Conexion c)
        {
            InitializeComponent();
            this.c = c;
            if (c.USER == 0)
            {
                btnCerrar.Visible = false;

            }
            else {
                btnIngresar.Visible = false;
                btnRegistrar.Visible = false;
            
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login(c).Show();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            c.USER = 0;
            this.Hide();
            new Menu(c).Show();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Register(c).Show();
        }
    }
}
