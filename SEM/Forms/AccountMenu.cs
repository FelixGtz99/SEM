using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SEM.Forms;
namespace SEM
{
    public partial class AccountMenu : Form
    {
        Conexion c = null;
        public AccountMenu(Conexion c)
        {
            InitializeComponent();
            this.c = c;
            c.iniciar();
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            panel.Location=new Point((this.Width/2-panel.Width/2), (this.Height / 2 - panel.Height / 2));

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
            new Searcher(c).Show();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Register(c).Show();
        }
    }
}
