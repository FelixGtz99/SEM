using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SEM.items;

namespace SEM.Forms
{
    public partial class EditAdmin : Form
    {
        Conexion c = null;
        public EditAdmin(Conexion c)
        {

            InitializeComponent();
            this.c = c;
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
            c.getCarreras();
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            labelOldCorreo.Text = c.CORREO;
            labelEstudiante.Text = c.NOMBRE + " " + c.APELLIDO;
            labelCarrera.Text = c.SCarrera;
            pictureBox1.ImageLocation = c.getlogo();

            btnChangeNombre_Click(this, new EventArgs());
            //panelOpciones.Location = new Point((this.Width / 2 - panelOpciones.Width / 2), (this.Height / 2 - panelOpciones.Height / 2));
            //panelBorrar.Location = new Point((this.Width / 2 - panelBorrar.Width / 2), (this.Height / 2 - panelBorrar.Height / 2));
            //panelContra.Location = new Point((this.Width / 2 - panelContra.Width / 2), (this.Height / 2 - panelContra.Height / 2));
            //panelCarrera.Location = new Point((this.Width / 2 - panelCarrera.Width / 2), (this.Height / 2 - panelCarrera.Height / 2));
            //panelBorrar.Visible = false;
            //panelContra.Visible = false;
            //panelCarrera.Visible = false;
            //btnVolver.Location = new Point((this.Width-btnVolver.Width), (this.Height/2+panelOpciones.Height/2));

           pictureBox1.ImageLocation = c.getlogo();
            
            //forma circular en los labels de ayuda
            var path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddEllipse(0, 0, helpContraseña.Width, helpContraseña.Height);
            //this.helpCarrera.Region = new Region(path);
            this.helpConfirm.Region = new Region(path);
            this.helpContraseña.Region = new Region(path);
            this.helpCorreo.Region = new Region(path);
            this.helpName.Region = new Region(path);
           // this.helpDelete.Region = new Region(path);


            //visibilidad de las opciones
            //changePassPanel.Visible = false;
           // changeCareerPanel.Visible = false;
           // deletePanel.Visible = false;

            //eventos para que se desaparezca el texto
           /* txtNewContra.GotFocus += NewContra_GotFocus;
            txtCPass.GotFocus += ConfirmNewPass_GotFocus;
            //cbCarrera.GotFocus += Carrera_GotFocus;
            txtPass.GotFocus += ConfirmPass1_GotFocus;
            textBox1.GotFocus += ConfirmPass2_GotFocus;
            txtNewContra.LostFocus += NewContra_LostFocus;
            txtCPass.LostFocus += ConfirmNewPass_LostFocus;
            //cbCarrera.LostFocus += Carrera_LostFocus;
            txtPass.LostFocus += ConfirmPass1_LostFocus;
            textBox1.LostFocus += ConfirmPass2_LostFocus;*/

        }

        private void NewContra_GotFocus(object sender, EventArgs e)
        {
            label18.BackColor = Color.FromArgb(13, 70, 255);
            labelContraseña.ForeColor = Color.FromArgb(13, 70, 255);
            txtNewContra.ForeColor = Color.White;
            if (txtNewContra.Text == "placeholder")
            {
                txtNewContra.Text = "";
            }
        }

        private void NewContra_LostFocus(object sender, EventArgs e)
        {
            label18.BackColor = Color.White;
            labelContraseña.ForeColor = Color.White;
            txtNewContra.ForeColor = Color.DimGray;
            /*if (txtNewContra.Text == "placeholder")
            {
                txtNewContra.Text = "";
            }*/
        }

        private void ConfirmNewPass_GotFocus(object sender, EventArgs e)
        {
            lineConfirmar.BackColor = Color.FromArgb(13, 70, 255);
            labelConfirmar.ForeColor = Color.FromArgb(13, 70, 255);
            txtCPass.ForeColor = Color.White;
            if (txtCPass.Text == "placeholder")
            {
                txtCPass.Text = "";
            }
        }

        private void ConfirmNewPass_LostFocus(object sender, EventArgs e)
        {
            lineConfirmar.BackColor = Color.White;
            labelConfirmar.ForeColor = Color.White;
            txtCPass.ForeColor = Color.DimGray;
            
        }
        private void Carrera_GotFocus(object sender, EventArgs e)
        {
            //labelNorreo.ForeColor = Color.FromArgb(13, 70, 255);

        }
        private void Carrera_LostFocus(object sender, EventArgs e)
        {
            //labelNorreo.ForeColor = Color.White;

        }

        private void ConfirmPass1_GotFocus(object sender, EventArgs e)
        {
            /*label12.BackColor = Color.FromArgb(13, 70, 255);
            //labelContraseña.ForeColor = Color.FromArgb(13, 70, 255);
            txtPass.ForeColor = Color.White;
            if (txtPass.Text == "placeholder")
            {
                txtPass.Text = "";
            }*/
        }
        private void ConfirmPass1_LostFocus(object sender, EventArgs e)
        {
            /*label12.BackColor = Color.White;
            //labelContraseña.ForeColor = Color.FromArgb(13, 70, 255);
            txtPass.ForeColor = Color.DimGray;
           /* if (txtPass.Text == "placeholder")
            {
                txtPass.Text = "";
            }*/
        }
        private void ConfirmPass2_GotFocus(object sender, EventArgs e)
        {
           /* label15.BackColor = Color.FromArgb(13, 70, 255);
            //labelContraseña.ForeColor = Color.FromArgb(13, 70, 255);
            textBox1.ForeColor = Color.White;
            if (textBox1.Text == "placeholder")
            {
                textBox1.Text = "";
            }*/
        }
        private void ConfirmPass2_LostFocus(object sender, EventArgs e)
        {
            /*label15.BackColor = Color.White;
            //labelContraseña.ForeColor = Color.FromArgb(13, 70, 255);
            textBox1.ForeColor = Color.DimGray;
            /* if (txtPass.Text == "placeholder")
             {
                 txtPass.Text = "";
             }*/
        }

        private void panelOpciones_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        

        

        

        

        /*private void button4_Click(object sender, EventArgs e)
        {
            if (c.CONTRA==txtContra.Text)
            {
                if (txtContra.Text==txtNewContra.Text)
                {
                    //MessageBox.Show("No puede ser la misma contraseña");
                    SemBox sb = new SemBox("shorterror", "No puede ser la misma contraseña", "", "Aceptar");
                    sb.Show();
                }
                else
                {
                    String check = validarContra(txtNewContra.Text);
                    if (check==" ")
                    {
                        try
                        {
                            c.ChangePass(txtNewContra.Text);
                            this.Hide();
                            //MessageBox.Show("Contraseña cambiada satisfactoriamente");
                            SemBox sb = new SemBox("short", "Contraseña cambiada satisfactoriamente", "", "Aceptar");
                            sb.Show();
                            new Searcher(c).Show();
                        }
                        catch (Exception ex) {
                            Console.WriteLine(ex.Message);
                        }
                        }
                    else
                    {
                        //MessageBox.Show(check);
                        SemBox sb = new SemBox("longerror", "Error al guardar", check, "Aceptar");
                        sb.Show();
                    }

                }
            }
            else
            {
                //MessageBox.Show("Contraseña Incorrecta");
                SemBox sb = new SemBox("shorterror", "Contraseña incorrecta", "", "Aceptar");
                sb.Show();
            }
        }*/
        public String validarContra(String Pass)
        {

            String Errores = " ";
            if (Pass.Length == 0 )
            {
                Errores = "La contraseña no puede esta vacia";
            }

          
            if (Pass.Length < 9)
            {
                Errores = Errores + Environment.NewLine + "La contraseña debe contar con almenos 9 caracteres";
            }
         
            if (Pass.Count(char.IsLower) < 1)
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
           

            if (Pass.Count(char.IsDigit) < 2)
            {
                Errores = Errores + Environment.NewLine + "La contraseña debe de tener al menos 2 numeros";
            }
           


            return Errores;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        /*private void button10_Click(object sender, EventArgs e)
        {
            if (txtContraBorrar.Text==c.CONTRA)
            {
                try
                {
                    c.DeleteUser();
                    //MessageBox.Show("Usuario eliminado correctamente");
                    this.Hide();
                    new Login(c).Show();
                    SemBox sb = new SemBox("long", "Has eliminado tu cuenta",
                        "¡Te vamos a extrañar!\r\n" +
                        "Considera regresar alguna vez.",
                        "Aceptar");
                    sb.Show();
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }
              
            }
            else
            {
                //MessageBox.Show("Contraseña Incorrecta");
                SemBox sb = new SemBox("shorterror", "Contraseña incorrecta", "", "Aceptar");
                sb.Show();
            }
        }*/

        private void BtnComfirPass_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Boolean error = false;
             if (c.CONTRA == txtPass.Text)
            {
                if (!String.IsNullOrEmpty(txtNewContra.Text)  && !String.IsNullOrEmpty(txtCPass.Text))
                {


                    if (txtPass.Text == txtCPass.Text)
                    {
                        //MessageBox.Show("No puede ser la misma contraseña");
                     new SemBox("shorterror", "No puede ser la misma contraseña", "", "Aceptar").Show();
                    }
                    else
                    {
                        String check = validarContra(txtNewContra.Text);
                        if (check == " ")
                        {
                            try
                            {
                                // c.SCarrera = cbCarrera.SelectedItem.ToString();

                                c.ChangePass(txtNewContra.Text);
                                this.Hide();
                                //MessageBox.Show("Cambios hechos correctamente");
                               
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                        }
                        else
                        {
                            error = true;
                            //MessageBox.Show(check);
                            new SemBox("longerror", "Error al guardar", check, "Aceptar").Show() ;
                            //sb.Show();
                            
                        }

                    }
                }
                if (!String.IsNullOrEmpty(txtNombre.Text))
                {
                    c.updateNombre(txtNombre.Text);
                    c.NOMBRE = txtNombre.Text;
                }
                if (!String.IsNullOrEmpty(txtApellido.Text))
                {
                    c.updateApellido(txtApellido.Text);
                    c.APELLIDO = txtApellido.Text;
                }
                if (!String.IsNullOrEmpty(txtCorreo.Text))
                {
                    c.updateCorreo(txtCorreo.Text);
                    c.CORREO = txtCorreo.Text;
                }
                if (!error)
                {
                    new AdminPanel(c).Show();
                    SemBox sb = new SemBox("short", "Se han guardado los cambios", "", "Aceptar");
                    sb.Show();
                }
               
            }
            else
            {
                //MessageBox.Show("Contraseña Incorrecta");
                SemBox sb = new SemBox("shorterror", "Contraseña incorrecta", "", "Aceptar");
                sb.Show();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
           /* if (textBox1.Text == c.CONTRA)
            {
                try
                {
                    c.DeleteUser();
                    //MessageBox.Show("Usuario eliminado correctamente");
                    this.Hide();
                    new Login(c).Show();
                    SemBox sb = new SemBox("long", "Has eliminado tu cuenta",
                        "¡Te vamos a extrañar!\r\n" +
                        "Considera regresar alguna vez.",
                        "Aceptar");
                    sb.Show();
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }

            }
            else
            {
                //MessageBox.Show("Contraseña Incorrecta");
                SemBox sb = new SemBox("shorterror", "Contraseña incorrecta", "", "Aceptar");
                sb.Show();
            }*/
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Searcher(c).Show();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        //    if (deletePanel.Visible == false)
        //    {
        //        button1.Text = "- Eliminar cuenta";
        //        deletePanel.Visible = true;
        //        deletePanel.Parent = panel3;
        //        deletePanel.Location = new Point(row4.Location.X, row4.Location.Y + row4.Height);
        //        blineDelete.Location = new Point(blineDelete.Location.X, blineDelete.Location.Y + deletePanel.Height);
        //        //row2.Location = new Point(row2.Location.X, row2.Location.Y + changePassPanel.Height);
        //        //row3.Location = new Point(row3.Location.X, row3.Location.Y + changeCareerPanel.Height + 7);
        //        //row4.Location = new Point(row4.Location.X, row4.Location.Y + changeCareerPanel.Height + 7);
        //        //changePassPanel.Location = new Point(changePassPanel.Location.X, changePassPanel.Location.Y + changeCareerPanel.Height);
        //        //deletePanel.Location = new Point(deletePanel.Location.X, deletePanel.Location.Y + changePassPanel.Height + 7);


        //    }
        //    else
        //    {
        //        button1.Text = "+ Eliminar cuenta";
        //        deletePanel.Visible = false;
        //        deletePanel.Parent = panel3;
        //        deletePanel.Location = new Point(row4.Location.X, row4.Location.Y + row4.Height);
        //        blineDelete.Location = new Point(blineDelete.Location.X, blineDelete.Location.Y - deletePanel.Height);
        //        //row2.Location = new Point(row2.Location.X, row2.Location.Y + changePassPanel.Height);
        //        //row3.Location = new Point(row3.Location.X, row3.Location.Y - changeCareerPanel.Height - 7);
        //        //row4.Location = new Point(row4.Location.X, row4.Location.Y - changeCareerPanel.Height - 7);
        //        //changePassPanel.Location = new Point(changePassPanel.Location.X, changePassPanel.Location.Y - changeCareerPanel.Height);
        //        //deletePanel.Location = new Point(deletePanel.Location.X, deletePanel.Location.Y - changePassPanel.Height - 7);

        //    }

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            btnChangePass.BackColor = Color.FromArgb(13, 98, 255);
            btnChangePass.ForeColor = Color.White;
            btnChangeNombre.BackColor = Color.FromArgb(222, 222, 222);
            btnChangeNombre.ForeColor = Color.FromArgb(81, 81, 81);
            btnChangeCorreo.BackColor = Color.FromArgb(222, 222, 222);
            btnChangeCorreo.ForeColor = Color.FromArgb(81, 81, 81);
            changePassPanel.Location = changePassPanel.Location;
            changePassPanel.Visible = true;
            changeEmailPanel.Visible = false;
            namePanel.Visible = false;
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label10_Click_1(object sender, EventArgs e)
        {

        }

        private void BtnChangeCarrera_Click(object sender, EventArgs e)
        {
            btnChangeCorreo.BackColor = Color.FromArgb(13, 98, 255);
            btnChangeCorreo.ForeColor = Color.White;
            btnChangePass.BackColor = Color.FromArgb(222, 222, 222);
            btnChangePass.ForeColor = Color.FromArgb(81, 81, 81);
            btnChangeNombre.BackColor = Color.FromArgb(222, 222, 222);
            btnChangeNombre.ForeColor = Color.FromArgb(81, 81, 81);
            changeEmailPanel.Location = changePassPanel.Location;
            changeEmailPanel.Visible = true;
            changePassPanel.Visible = false;
            namePanel.Visible = false;
        }

        private void BtnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TxtPass_TextChanged_1(object sender, EventArgs e)
        {
            if(txtPass.Text == "")
            {
                btnGuardar.Enabled = false;
                btnGuardar.ButtonColor = Color.FromArgb(130, 170,255);
                btnGuardar.TextColor = Color.Silver;
            }
            else
            {
                btnGuardar.Enabled = true;
                btnGuardar.ButtonColor = Color.FromArgb(13,70,255);
                btnGuardar.TextColor = Color.White;
            }
        }

        private void TextBox1_TextChanged_1(object sender, EventArgs e)
        {
           /* if (textBox1.Text == "")
            {
                btnEliminar.Enabled = false;
                btnEliminar.ButtonColor = Color.FromArgb(255,130, 170);
                btnEliminar.TextColor = Color.Silver;
            }
            else
            {
                btnEliminar.Enabled = true;
                btnEliminar.ButtonColor = Color.FromArgb(255,13, 70);
                btnEliminar.TextColor = Color.White;
            }*/
        }

        private void changePassPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void EditAdmin_Load(object sender, EventArgs e)
        {

        }

        private void btnChangeNombre_Click(object sender, EventArgs e)
        {
            btnChangeNombre.BackColor = Color.FromArgb(13, 98, 255);
            btnChangeNombre.ForeColor = Color.White;
            btnChangePass.BackColor = Color.FromArgb(222,222,222);
            btnChangePass.ForeColor = Color.FromArgb(81,81,81);
            btnChangeCorreo.BackColor = Color.FromArgb(222,222,222);
            btnChangeCorreo.ForeColor = Color.FromArgb(81,81,81);
            namePanel.Location = changePassPanel.Location;
            namePanel.Visible = true;
            changePassPanel.Visible = false;
            changeEmailPanel.Visible = false;



        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void BtnRA_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AdminPanel(c).Show();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            c.logout();

            this.Hide();
            new Login(c).Show();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
