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
using SEM.items;
namespace SEM
{
    public partial class Login : Form
    {
        Conexion c = null;
        
        public Login(Conexion c)
        {
            InitializeComponent();

            this.c = c;
            //this.Size = Screen.PrimaryScreen.WorkingArea.Size*.75;
            this.Height = 900;
            this.Width = 1440;
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            panelAnonimo.Visible = false;
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
            Cursor.Current = Cursors.WaitCursor;
            if (panelogin.Visible==true)
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
                    }
                    else if (c.Login(txtEmail.Text, txtPass.Text) != 0)
                    {
                        if (c.itsAdmin())
                        {
                            var AdminPanel = new AdminPanel(c);
                            var sb = new SemBox("short", "¡Bienvenido de Regreso!", "", "Aceptar");
                            AdminPanel.Shown += (o, args) => { this.Hide(); sb.Show(); };

                            sb.Shown += (o, args) => { AdminPanel.Enabled = false; };
                            sb.FormClosed += (o, args) => { AdminPanel.Enabled = true; };
                            AdminPanel.Show();
                            /*this.Hide();
                            new AdminPanel(c).Show();*/

                        }

                        else
                        {
                            if (c.CARRERA == -1)
                            {
                                var AddCareer = new AddCareer(c);
                                //var sb = new SemBox("short", "¡Bienvenido de Regreso!", "", "Aceptar");
                                AddCareer.Shown += (o, args) => { this.Hide();  };

                                /*sb.Shown += (o, args) => { Searcher.Enabled = false; };
                                sb.FormClosed += (o, args) => { Searcher.Enabled = true; };*/
                                AddCareer.Show();
                                /*this.Hide();
                                new AddCareer(c).Show();*/
                            }
                            else
                            {
                                var Searcher = new Searcher(c);
                                var sb = new SemBox("short", "¡Bienvenido de Regreso!", "", "Aceptar");
                                Searcher.Shown += (o, args) => { this.Hide(); sb.Show(); };
                                
                                sb.Shown += (o, args) => { Searcher.Enabled = false; };
                                sb.FormClosed += (o, args) => { Searcher.Enabled = true; };
                                Searcher.Show();
                                /*this.Hide();
                                new Searcher(c).Show();*/
                            }
                        }
                        /*SemBox sb = new SemBox("short", "¡Bienvenido de regreso!", "", "Aceptar");
                        sb.Show();*/
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


            }
            else
            {
                c.USER = 0;
                c.CARRERA = c.getIDCarrera();
                c.ESCUELA = c.getIDEscuela();
                // c.SCarrera= cbCarrera.SelectedItem.ToString();
                // c.SEscuela = cbEscuela.SelectedItem.ToString();
                var Searcher = new Searcher(c);
                //var sb = new SemBox("short", "¡Bienvenido de Regreso!", "", "Aceptar");
                Searcher.Shown += (o, args) => { this.Hide();  };

                /*sb.Shown += (o, args) => { Searcher.Enabled = false; };
                sb.FormClosed += (o, args) => { Searcher.Enabled = true; };*/
                Searcher.Show();
                /*this.Hide();
                    new Searcher(c).Show();*/


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
            Cursor.Current = Cursors.Arrow;
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            var Register = new Register(c);
            //var sb = new SemBox("short", "¡Bienvenido de Regreso!", "", "Aceptar");
            Register.Shown += (o, args) => { this.Hide();  };

            //sb.Shown += (o, args) => { Searcher.Enabled = false; };
            //sb.FormClosed += (o, args) => { Searcher.Enabled = true; };
            Register.Show();
            /*this.Hide();
            new Register(c).Show();*/
            Cursor.Current = Cursors.Arrow;
        }

        private void BtnAnonimo_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (panelAnonimo.Visible == false)
            {
                panelogin.Visible = false;
                panelAnonimo.Visible = true;
                cbCarrera.Enabled = false;
                btnAnonimo.Text = "Ingresar registrado";
                btnLogin1.Enabled = false;
                foreach (Escuela item in c.ESCUELAS)
                {
                    cbEscuela.Items.Add(item.ToString());
                }
            }
            else {
                panelogin.Visible = true;
                panelAnonimo.Visible = false;
                btnAnonimo.Text = "Ingresar Anónimo";

            }

            Cursor.Current = Cursors.Arrow;
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

        private void cbEscuela_SelectedIndexChanged(object sender, EventArgs e)
        {
            c.SEscuela = cbEscuela.SelectedItem.ToString();
            cbCarrera.Enabled = true;
            c.getCarreras();
            cbCarrera.Items.Clear();
            foreach (Carrera item in c.CARRERAS)
            {
                cbCarrera.Items.Add(item.ToString());
            }
        }

        private void panelAnonimo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbCarrera_SelectedIndexChanged(object sender, EventArgs e)
        {
            c.SCarrera = cbCarrera.SelectedItem.ToString();
            btnLogin1.Enabled = true;
        }
    }
}
