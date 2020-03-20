 using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;


namespace SEM
{
    public partial class Menu : Form
    {
      private Conexion c=null;
        public Menu(Conexion c)
        {
           
            InitializeComponent();
            this.c = c;
     
                c.iniciar();

            if (c.USER == 0)
            {
                btnEvaluar.Visible = false;
                btnRegister.Visible = false;

            }
        }

     

        private void btnCuenta_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AccountMenu(c).Show();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
