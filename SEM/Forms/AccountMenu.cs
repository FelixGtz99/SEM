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
            c.iniciar();
            //this.Location = Screen.PrimaryScreen.WorkingArea.Location;
           // this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.BackColor = Color.FromArgb(33, 33, 33);
            btnAnonimo.BackColor = Color.FromArgb(48, 48, 48);
            btnIngresar.BackColor = Color.FromArgb(48, 48, 48);
            btnRegistrar.BackColor = Color.FromArgb(48, 48, 48);
            this.ActiveControl = panel1;
            btnClose.Height = panel1.Height;
            btnClose.Location = new Point(this.Width - btnClose.Width,0);
            btnMin.Location = new Point(this.Width - btnClose.Width - btnMin.Width,0);
            btnMin.Height = panel1.Height;
            panel1.Location = new Point(0, 0);
            panel1.Width = this.Width;
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
            new Menu(c).Show();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Register(c).Show();
        }

        private void AccountMenu_Load(object sender, EventArgs e)
        {

        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
