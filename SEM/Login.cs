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
    public partial class Login : Form
    {
        Conexion c = null;
        public Login(Conexion c)
        {
            InitializeComponent();
            this.c = c;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (c.Login(txtEmail.Text, txtPass.Text) != 0)
            {
                MessageBox.Show("Ingresaste correctamente");
                this.Hide();
                new Menu(c).Show();
            }
            else {
                MessageBox.Show("Correo/Contraseña Incorrectos");

            }

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AccountMenu(c).Show();
        }
    }
}
