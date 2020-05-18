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
    public partial class Register : Form
    {
        Conexion c;
        public Register(Conexion c)
        {
            InitializeComponent();
            this.c = c;
            //this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Height = 900;
            this.Width = 1440;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            c.getEscuelas();
            c.getCarreras();
            //Datos de la barra superior
            this.ActiveControl = panel2;
            btnClose.Height = panel2.Height;
            btnClose.Location = new Point(this.Width - btnClose.Width, 0);
            btnMin.Location = new Point(this.Width - btnClose.Width - btnMin.Width, 0);
            btnMin.Height = panel2.Height;
            panel2.Location = new Point(0, 0);
            panel2.Width = this.Width;
            //Datos del panel de Información
            panel1.Height = this.Height - panel2.Height;
            panel1.Width = this.Width / 4;
            panel1.Location = new Point(0, panel2.Height);
            
            
            //Datos del panel de Actividad
            //panel.Height = this.Height * 10 / 17;
            panel.Width = this.Width * 3 / 4;
            //panel.Location = new Point(panel1.Width, this.Height * 10/36);
           /// panel.Height = this.Height * 483 / 786;
            /*checkBox1.Location = new Point(this.Height * 664 / 768-panel2.Height, this.Width * 757 / 1366);
            linkLabel1.Location = new Point(this.Height * 666 / 768-panel2.Height, this.Width * 884 / 1366);
            btnRegistrar.Location = new Point(this.Height * 697 / 768-panel2.Height, this.Width * 757 / 1366);*/

            //Eventos de los campos de texto
            this.cbEscuela.GotFocus += Escuela_GotFocus;
            this.cbCarrera.GotFocus += Carrera_GotFocus;
            this.txtExpediente.GotFocus += Expediente_GotFocus;
            this.txtNombre.GotFocus += Nombre_GotFocus;
            this.txtApellido.GotFocus += Apellido_GotFocus;
            this.txtCorreo.GotFocus += Correo_GotFocus;
            this.txtContraseña.GotFocus += Contraseña_GotFocus;
            this.txtConContra.GotFocus += Confirmar_GotFocus;

            this.cbEscuela.LostFocus += Escuela_LostFocus;
            this.cbCarrera.LostFocus += Carrera_LostFocus;
            this.txtExpediente.LostFocus += Expediente_LostFocus;
            this.txtNombre.LostFocus += Nombre_LostFocus;
            this.txtApellido.LostFocus += Apellido_LostFocus;
            this.txtCorreo.LostFocus += Correo_LostFocus;
            this.txtContraseña.LostFocus += Contraseña_LostFocus;
            this.txtConContra.LostFocus += Confirmar_LostFocus;

            var path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddEllipse(0, 0, helpEscuela.Width, helpEscuela.Height);
            this.helpEscuela.Region = new Region(path);
            this.helpExpediente.Region = new Region(path);
            this.helpNombre.Region = new Region(path);
            var path2 = new System.Drawing.Drawing2D.GraphicsPath();
            path2.AddEllipse(0, 0, helpEmail.Width, helpEmail.Height);
            this.helpEmail.Region = new Region(path2);
            this.helpContraseña.Region = new Region(path2);
            CBEscuela();
            cbCarrera.Enabled = false;

            


            // panel.Location = new Point((this.Width / 2 - panel.Width / 2), (this.Height / 2 - panel.Height / 2));
            this.c = c;
            cbCarrera.SelectedIndex=0;
        }

        
        public String validarCampos(String email, String Experiente, String Pass, String Carrera, String nombre, String Apellido)
        {

            String Errores = " ";
            if (email.Length==0 || Experiente.Length==0 || Pass.Length==0 || nombre.Length==0 || Apellido.Length==0)
            {
                Errores = "Nesesitas llenar todos los campos";
            }
            if (txtContraseña.Text!=txtConContra.Text)
            {
                Errores = Errores + Environment.NewLine + "Las contraseñas son diferentes";
            }
            foreach (Escuela escuela in c.ESCUELAS)
            {
                if (c.SEscuela.Equals(escuela))
                {
                    if (email.EndsWith("@" + escuela.Correo))
                               {
                        Errores = Errores + Environment.NewLine + "El correo debe terminar en @" + escuela.Correo;
                    }
                }
            }
           
            if (c.CheckID(Experiente))
            {
                Errores= Errores + Environment.NewLine + "Ya hay un usuario asociado a este experiente";
            }
            if (Pass.Length < 9)
            {
                Errores = Errores + Environment.NewLine + "La contraseña debe contar con almenos 9 caracteres";
            }
            if (!Experiente.Any(char.IsDigit))
            {
                Errores = Errores + Environment.NewLine + "El experiente debe ser puros numeros";
            }
            if (Pass.Count(char.IsLower)<1)
            {
                Errores = Errores + Environment.NewLine + "La contraseña debe contener minusculas";
            }
            if (Pass.Count(char.IsUpper) < 1)
            {
                Errores = Errores + Environment.NewLine + "La contraseña debe contener mayusculas";
            }
           /* if (Pass.Count(char.is) < 2)
            {
                Errores = Errores + Environment.NewLine + "La contraseña debe contener caracteres especiales";
            }*/
            if (!Experiente.StartsWith("21")) 
            {
                Errores = Errores + Environment.NewLine + "Experiente no valido";
            }
       
            if (Pass.Count(char.IsDigit)<2)
            {
                Errores = Errores + Environment.NewLine + "La contraseña debe de tener al menos 2 numeros";
            }
         
            if (nombre.Any(char.IsDigit) || Apellido.Any(char.IsDigit))
            {
                Errores = Errores + Environment.NewLine + "Los nombres o apellidos no debe de contener numeros";
            }

          
            return Errores;
        }

        

        

        private void Errors_Click(object sender, EventArgs e)
        {

        }

        private void TxtExperiente_KeyDown(object sender, KeyEventArgs e)
        {
           // String Expediente = txtExperiente.Text + e.KeyValue;
            //if(Expediente !=""&& Expediente.All(char.IsDigit))
           // {
                //if (c.CheckID(Expediente))
                //{
                //  errors.Text = "Expediente inválido";
                //}
           //     errors.Text = "";
                
           // }
           // else
           // {
            //    errors.Text = "Expediente inválido";
           // }
           // errors2.Text = Expediente;
           // Expediente = txtExperiente.Text;
        }

        private void TxtExperiente_KeyUp(object sender, KeyEventArgs e)
        {
            String Expediente = txtExpediente.Text;
            if (Expediente != "" && Expediente.All(char.IsDigit))
            {
                //if (c.CheckID(Expediente))
                //{
                //  errors.Text = "Expediente inválido";
                //}
                errors.Text = "";

            }
            else
            {
                errors.Text = "Expediente inválido";
            }
           // errors2.Text = Expediente;
            Expediente = txtExpediente.Text;
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }
        //Metodos para minimizar y cerrar
        private void BtnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Métodos para cambiar el color del input seleccionado
        private void Escuela_GotFocus(object sender, EventArgs e)
        {
            labelEscuela.ForeColor = Color.FromArgb(13, 70, 255);
            
        }
        private void Escuela_LostFocus(object sender, EventArgs e)
        {
            labelEscuela.ForeColor = Color.White;
        }
        private void Carrera_GotFocus(object sender, EventArgs e)
        {
            labelCarrera.ForeColor = Color.FromArgb(13, 70, 255);

        }
        private void Carrera_LostFocus(object sender, EventArgs e)
        {
            labelCarrera.ForeColor = Color.White;
        }
        private void Expediente_GotFocus(object sender, EventArgs e)
        {
            lineExpediente.BackColor = Color.FromArgb(13, 70, 255);
            labelExpediente.ForeColor = Color.FromArgb(13, 70, 255);
            txtExpediente.ForeColor = Color.White;
            if (txtExpediente.Text == "Clave, Matrícula, etc.")
            {
                txtExpediente.Text = "";
            }
        }
        private void Expediente_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtExpediente.Text))
            {
                txtExpediente.Text = "Clave, Matrícula, etc.";
            } else if (!txtExpediente.Text.Any(char.IsDigit) || !txtExpediente.Text.StartsWith("21"))
            {

            }
            txtExpediente.ForeColor = Color.DimGray;
            lineExpediente.BackColor = Color.White;
            labelExpediente.ForeColor = Color.White;
        }
        private void Nombre_GotFocus(object sender, EventArgs e)
        {
            lineNombre.BackColor = Color.FromArgb(13, 70, 255);
            labelNombre.ForeColor = Color.FromArgb(13, 70, 255);
            txtNombre.ForeColor = Color.White;
            if (txtNombre.Text == "¿Cómo te llamas?")
            {
                txtNombre.Text = "";
            }
        }
        private void Nombre_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                txtNombre.Text = "¿Cómo te llamas?";
            }
            txtNombre.ForeColor = Color.DimGray;
            lineNombre.BackColor = Color.White;
            labelNombre.ForeColor = Color.White;
        }
        private void Apellido_GotFocus(object sender, EventArgs e)
        {
            lineApellido.BackColor = Color.FromArgb(13, 70, 255);
            labelApellido.ForeColor = Color.FromArgb(13, 70, 255);
            txtApellido.ForeColor = Color.White;
            if (txtApellido.Text == "¿Cómo te apellidas?")
            {
                txtApellido.Text = "";
            }
        }
        private void Apellido_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtApellido.Text))
            {
                txtApellido.Text = "¿Cómo te apellidas?";
            }
            txtApellido.ForeColor = Color.DimGray;
            lineApellido.BackColor = Color.White;
            labelApellido.ForeColor = Color.White;
        }
        private void Correo_GotFocus(object sender, EventArgs e)
        {
            lineCorreo.BackColor = Color.FromArgb(13, 70, 255);
            labelCorreo.ForeColor = Color.FromArgb(13, 70, 255);
            txtCorreo.ForeColor = Color.White;
            if (txtCorreo.Text == "Correo institucional.")
            {
                txtCorreo.Text = "";
            }
        }
        private void Correo_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCorreo.Text))
            {
                txtCorreo.Text = "Correo institucional.";
            }
            txtCorreo.ForeColor = Color.DimGray;
            lineCorreo.BackColor = Color.White;
            labelCorreo.ForeColor = Color.White;
        }
        private void Contraseña_GotFocus(object sender, EventArgs e)
        {
            lineContraseña.BackColor = Color.FromArgb(13, 70, 255);
            labelContraseña.ForeColor = Color.FromArgb(13, 70, 255);
            txtContraseña.ForeColor = Color.White;
            if (txtContraseña.Text == "placeholder")
            {
                txtContraseña.Text = "";
            }
        }
        private void Contraseña_LostFocus(object sender, EventArgs e)
        {
            lineContraseña.BackColor = Color.White;
            labelContraseña.ForeColor = Color.White;


            txtContraseña.ForeColor = Color.DimGray;
        }
        private void Confirmar_GotFocus(object sender, EventArgs e)
        {
            lineConfirmar.BackColor = Color.FromArgb(13, 70, 255);
            labelConfirmar.ForeColor = Color.FromArgb(13, 70, 255);
            txtConContra.ForeColor = Color.White;
            if (txtConContra.Text == "placeholder")
            {
                txtConContra.Text = "";
            }
        }
        private void Confirmar_LostFocus(object sender, EventArgs e)
        {
            


            txtConContra.ForeColor = Color.DimGray;
            /*if(txtConContra.Text != txtContraseña.Text)
            {
                labelEConfirmar.ForeColor = Color.Red;
                lineConfirmar.BackColor = Color.Red;
                labelConfirmar.ForeColor = Color.Red;
            }*/
           // else
            //{
                labelEConfirmar.ForeColor = Color.FromArgb(48, 48, 48);
                lineConfirmar.BackColor = Color.White;
                labelConfirmar.ForeColor = Color.White;
         //   }
        }

        private void BtnLogin1_Click(object sender, EventArgs e)
        {
            var Login = new Login(c);
            //var sb = new SemBox("short", "¡Bienvenido de Regreso!", "", "Aceptar");
            Login.Shown += (o, args) => { this.Hide(); };

            //sb.Shown += (o, args) => { Searcher.Enabled = false; };
            //sb.FormClosed += (o, args) => { Searcher.Enabled = true; };
            Login.Show();
            /*this.Hide();
            new Login(c).Show();*/
        }

        

        private void Button_WOC1_Click(object sender, EventArgs e)
        {
            String check = validarCampos(txtCorreo.Text, txtExpediente.Text, txtContraseña.Text, cbCarrera.SelectedItem.ToString(), txtNombre.Text, txtApellido.Text);
            if (check == " ")
            {
                try
                {
                    c.SCarrera = cbCarrera.SelectedItem.ToString();
                    c.RegisterUser(txtExpediente.Text, txtNombre.Text, txtApellido.Text, txtContraseña.Text, txtCorreo.Text);
                    //MessageBox.Show("Registrado correctamente");

                    var Searcher = new Searcher(c);
                    var sb = new SemBox("long", "¡Bienvenido a SEM!",
                        "Hola, bienvenido al Sistema Evaluador de Maestros\r\n" +
                        "aquí podrás evaluar los distintos maestros con los\r\n" +
                        "que hayas llevado clases con el objetivo de ayudar\r\n" +
                        "a otros estudiantes en su toma de decisiones, y\r\n" +
                        "claro, tú también serás ayudado. SEM es completamente\r\n" +
                        "anónimo, no te preocupes porque te puedan delatar.\r\n" +
                        "Solo recuerda en todo momento mantener el respeto.", "Aceptar");

                    Searcher.Shown += (o, args) => { this.Hide(); sb.Show(); };

                    sb.Shown += (o, args) => { Searcher.Enabled = false; };
                    sb.FormClosed += (o, args) => { Searcher.Enabled = true; };
                    Searcher.Show();
                    /*this.Hide();
                    new Searcher(c).Show();
                    SemBox sb = new SemBox("long", "¡Bienvenido a SEM!",
                        "Hola, bienvenido al Sistema Evaluador de Maestros\r\n" +
                        "aquí podrás evaluar los distintos maestros con los\r\n" +
                        "que hayas llevado clases con el objetivo de ayudar\r\n" +
                        "a otros estudiantes en su toma de decisiones, y\r\n" +
                        "claro, tú también serás ayudado. SEM es completamente\r\n" +
                        "anónimo, no te preocupes porque te puedan delatar.\r\n" +
                        "Solo recuerda en todo momento mantener el respeto.", "Aceptar");
                    sb.Show();*/
                }
                catch (Exception ex)
                {
                    //MessageBox.Show(ex.Message);
                    SemBox sb = new SemBox("long", "Parece que hubo un error", ex.Message, "Aceptar");
                    sb.Show();
                }
            }
            else
            {
                SemBox sb = new SemBox("long", "No has completado correctamente tu registro", check, "Aceptar");
                sb.Show();
                //MessageBox.Show(check);
            }
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            var Terminos= new Terminos();
            Terminos.Shown += (o, args) => { this.Enabled = false; };
            Terminos.FormClosed += (o, args) => { this.Enabled = true; };
            Terminos.Show();

        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (btnRegistrar.Enabled == true)
            {
                btnRegistrar.Enabled = false;
            }
            else
            {
                btnRegistrar.Enabled = true;
            }
        }

        private void BtnRegistrar_EnabledChanged(object sender, EventArgs e)
        {
            if(btnRegistrar.Enabled == true)
            {
                btnRegistrar.ButtonColor = Color.FromArgb(13, 70, 255);
                btnRegistrar.TextColor = Color.White;
            }
            else
            {
                btnRegistrar.ButtonColor = Color.FromArgb(130, 170, 255);
                btnRegistrar.TextColor = Color.Silver;
            }
        }

        private void cbEscuela_SelectedIndexChanged(object sender, EventArgs e)
        {
            c.SEscuela = cbEscuela.SelectedItem.ToString();
            cbCarrera.Enabled = true;
            
            CBCarreras();
        }
        public void CBEscuela() {
            cbEscuela.Items.Clear();
            
            foreach (Escuela escuela in c.ESCUELAS)
            {
                cbEscuela.Items.Add(escuela);
            }

        }
        public void CBCarreras() {
            cbCarrera.Items.Clear();
            c.getCarreras();
            foreach (Carrera carrera in c.CARRERAS)
            {
                cbCarrera.Items.Add(carrera);
            }

        }

        private void helpEscuela_Click(object sender, EventArgs e)
        {

        }
    }
}
