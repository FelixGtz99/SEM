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
    public partial class Login : Form
    {
        Conexion c = null;
        
        public Login(Conexion c)
        {
            InitializeComponent();

            this.c = c;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
      //que pex
            //Datos de la barra superior
            this.ActiveControl = panel2;
            btnClose.Height = panel2.Height;
            btnClose.Location = new Point(this.Width - btnClose.Width, 0);
            btnMin.Location = new Point(this.Width - btnClose.Width - btnMin.Width, 0);
            btnMin.Height = panel2.Height;
            panel2.Location = new Point(0, 0);
            panel2.Width = this.Width;
            //Datos del panel de Actividad
            panel.Height = this.Height - panel2.Height;
            panel.Width = this.Width / 2;
            panel.Location = new Point(this.Width/2, panel2.Height);
            //Datos del panel de Información
            panel1.Height = this.Height - panel2.Height;
            panel1.Width = this.Width / 2;
            panel1.Location = new Point(0, panel2.Height);
            
            //Eventos de los campos de texto
            this.txtEmail.GotFocus += txtEmail_GotFocus;
            this.txtEmail.LostFocus += txtEmail_LostFocus;
            this.txtPass.GotFocus += txtPass_GotFocus;
            this.txtPass.LostFocus += txtPass_LostFocus;

        }

               

        private void txtEmail_GotFocus(object sender, EventArgs e)
        {
            line1.BackColor = Color.FromArgb(13, 70, 255);
            label1.ForeColor = Color.FromArgb(13, 70, 255);
            txtEmail.ForeColor = Color.White;
            if (txtEmail.Text == "ejemplo@escuela.com")
            {
                txtEmail.Text = "";
            }
        }
        private void txtEmail_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text)){
                txtEmail.Text = "ejemplo@escuela.com";
                txtEmail.ForeColor = Color.DimGray;
                line1.BackColor = Color.White;
                label1.ForeColor = Color.White;
                errorEmail.Visible = false;
            } else if (c.CheckEmail(txtEmail.Text)) 
            {
                txtEmail.ForeColor = Color.DimGray;
                line1.BackColor = Color.White;
                label1.ForeColor = Color.White;
                errorEmail.Visible = false;
            }
            else
            {
                txtEmail.ForeColor = Color.DimGray;
                line1.BackColor = Color.FromArgb(255,13,70);
                label1.ForeColor = Color.FromArgb(255,13,70);
                errorEmail.Text = "Correo electrónico no registrado";
                errorEmail.Visible = true;
            }
            
        }
        private void txtPass_GotFocus(object sender, EventArgs e)
        {
            line2.BackColor = Color.FromArgb(13, 70, 255);
            label2.ForeColor = Color.FromArgb(13, 70, 255);
            txtPass.ForeColor = Color.White;
            if (txtPass.Text == "placeholder")
            {
                txtPass.Text = "";
            }
        }
        private void txtPass_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPass.Text))
            {
                errorPass.Text = "Introduce una contraseña";
                line2.BackColor = Color.FromArgb(255,13,70);
                label2.ForeColor = Color.FromArgb(255,13,70);
                errorPass.Visible = true;
            }
            else
            {
                line2.BackColor = Color.White;
                label2.ForeColor = Color.White;
                errorPass.Visible = false;
            }
            

            
            txtPass.ForeColor = Color.DimGray;
            
        }

        private void BtnLogin1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPass.Text) || txtPass.Text == "placeholder")
            {
                errorPass.Text = "Introduce una contraseña";
                line2.BackColor = Color.FromArgb(255, 13, 70);
                label2.ForeColor = Color.FromArgb(255, 13, 70);
                errorPass.Visible = true;
                if (string.IsNullOrWhiteSpace(txtEmail.Text))
                {
                    line1.BackColor = Color.FromArgb(255, 13, 70);
                    label1.ForeColor = Color.FromArgb(255, 13, 70);
                    errorEmail.Text = "Introduce un correo electrónico";
                    errorEmail.Visible = true;
                }
                else if (!c.CheckEmail(txtEmail.Text))
                {
                    line1.BackColor = Color.FromArgb(255, 13, 70);
                    label1.ForeColor = Color.FromArgb(255, 13, 70);
                    errorEmail.Text = "Correo electrónico no registrado";
                    errorEmail.Visible = true;
                }
            }
            else
            {
                errorPass.Visible = false;
                if (string.IsNullOrWhiteSpace(txtEmail.Text))
                {
                    line1.BackColor = Color.FromArgb(255, 13, 70);
                    label1.ForeColor = Color.FromArgb(255, 13, 70);
                    errorEmail.Text = "Introduce un correo electrónico";
                    txtPass.Text = "";
                    errorEmail.Visible = true;
                }
                else if (!c.CheckEmail(txtEmail.Text))
                {
                    line1.BackColor = Color.FromArgb(255, 13, 70);
                    label1.ForeColor = Color.FromArgb(255, 13, 70);
                    errorEmail.Text = "Correo electrónico no registrado";
                    txtPass.Text = "";
                    errorEmail.Visible = true;
                } else if (c.Login(txtEmail.Text, txtPass.Text) != 0)
                {
                    if (c.USER == 999)
                    {
                        this.Hide();
                        new AdminPanel(c).Show();
                      
                    }
                    else {
                        this.Hide();
                        new Searcher(c).Show();
                        
                    }
                    SemBox sb = new SemBox("short", "¡Bienvenido de regreso!", "", "Aceptar");
                    sb.Show();
                }
                else
                {
                    line1.BackColor = Color.FromArgb(255, 13, 70);
                    label1.ForeColor = Color.FromArgb(255, 13, 70);
                    errorEmail.Text = "Correo y contraseña no coinciden";
                    errorEmail.Visible = true;
                    txtPass.Text = "";
                }
            }
            
            
            

            /*if (c.Login(txtEmail.Text, txtPass.Text) != 0)
            {
                
                this.Hide();
                new Searcher(c).Show();
                SemBox sb = new SemBox("short", "¡Bienvenido de regreso!", "", "Aceptar");
                sb.Show();
            }
            else
            {
                //MessageBox.Show("Correo/Contraseña Incorrectos");
                SemBox sb = new SemBox("longerror", "Datos incorrectos", "Parece que tu correo o\r\ntu contraseña son\r\nerróneos. Intenta de nuevo", "Aceptar");
                sb.Show();
            }*/
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Register(c).Show();
        }

        private void BtnAnonimo_Click(object sender, EventArgs e)
        {
            c.USER = 0;
            this.Hide();
            new Searcher(c).Show();
        }

        private void BtnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TxtEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                BtnLogin1_Click(this, new EventArgs());
            }
        }
    }
}
