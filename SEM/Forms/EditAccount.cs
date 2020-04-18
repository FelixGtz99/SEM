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
    public partial class EditAccount : Form
    {
        Conexion c = null;
        public EditAccount(Conexion c)
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

            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            lbCarrera.Text = c.CARRERA;
            panelOpciones.Location = new Point((this.Width / 2 - panelOpciones.Width / 2), (this.Height / 2 - panelOpciones.Height / 2));
            panelBorrar.Location = new Point((this.Width / 2 - panelBorrar.Width / 2), (this.Height / 2 - panelBorrar.Height / 2));
            panelContra.Location = new Point((this.Width / 2 - panelContra.Width / 2), (this.Height / 2 - panelContra.Height / 2));
            panelCarrera.Location = new Point((this.Width / 2 - panelCarrera.Width / 2), (this.Height / 2 - panelCarrera.Height / 2));
            panelBorrar.Visible = false;
            panelContra.Visible = false;
            panelCarrera.Visible = false;
            btnRegresar.Location = new Point((this.Width-btnRegresar.Width), (this.Height/2+panelOpciones.Height/2));

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

        private void btnCarrera_Click(object sender, EventArgs e)
        {
            panelOpciones.Visible = false;
            panelCarrera.Visible = true;
        }

        private void btnContra_Click(object sender, EventArgs e)
        {
            panelOpciones.Visible = false;
            panelContra.Visible = true;
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            panelOpciones.Visible = false;
            panelBorrar.Visible = true;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Searcher(c).Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (c.CONTRA==txtContra.Text)
            {
                if (txtContra.Text==txtNewContra.Text)
                {
                    MessageBox.Show("No puede ser la misma contraseña");
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
                            MessageBox.Show("Contraseña cambiada satisfactoriamente");
                            new Searcher(c).Show();
                        }
                        catch (Exception ex) {
                            Console.WriteLine(ex.Message);
                        }
                        }
                    else
                    {
                        MessageBox.Show(check);
                    }

                }
            }
            else
            {
                MessageBox.Show("Contraseña Incorrecta");
            }
        }
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

        private void button10_Click(object sender, EventArgs e)
        {
            if (txtContraBorrar.Text==c.CONTRA)
            {
                try
                {
                    c.DeleteUser();
                    MessageBox.Show("Usuario eliminado correctamente");
                    this.Hide();
                    new Login(c).Show();
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }
              
            }
            else
            {
                MessageBox.Show("Contraseña Incorrecta");
            }
        }

        private void BtnComfirPass_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (c.CONTRA == txtPass.Text)
            {
                if (txtPass.Text == txtCPass.Text)
                {
                    MessageBox.Show("No puede ser la misma contraseña");
                }
                else
                {
                    String check = validarContra(txtNewContra.Text);
                    if (check == " ")
                    {
                        try
                        {
                            c.ChangePass(txtNewContra.Text);
                            this.Hide();
                            MessageBox.Show("Cambios hechos correctamente");
                            new Searcher(c).Show();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }
                    else
                    {
                        MessageBox.Show(check);
                    }

                }
            }
            else
            {
                MessageBox.Show("Contraseña Incorrecta");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == c.CONTRA)
            {
                try
                {
                    c.DeleteUser();
                    MessageBox.Show("Usuario eliminado correctamente");
                    this.Hide();
                    new Login(c).Show();
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }

            }
            else
            {
                MessageBox.Show("Contraseña Incorrecta");
            }
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
            label16.Visible = true;
            helpDelete.Visible = true;
            textBox1.Visible = true;
            label15.Visible = true;
            btnEliminar.Visible = true;

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (labelACarrera.Visible == false)
            {
                labelACarrera.Visible = true;
                helpCarrera.Visible = true;
                labelCarrera.Visible = true;
                labelNCarrera.Visible = true;
                cbCarrera.Visible = true;
                
            }
            else
            {
                labelACarrera.Visible = false;
                helpCarrera.Visible = false;
                labelCarrera.Visible = false;
                labelNCarrera.Visible = false;
                cbCarrera.Visible = false;
            }    
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            if (labelContraseña.Visible == false)
            {
                labelContraseña.Visible = true;
                txtNpass.Visible = true;
                label18.Visible = true;
                helpContraseña.Visible = true;
                txtCPass.Visible = true;
                labelConfirmar.Visible = true;
                lineConfirmar.Visible = true;
                btnChangeCarrera.Location = new Point(65, 248);
                panel3.Location = new Point(34, 324);
            }
            else
            {
                labelContraseña.Visible = false;
                txtNpass.Visible = false;
                label18.Visible = false;
                helpContraseña.Visible = false;
                txtCPass.Visible = false;
                labelConfirmar.Visible = false;
                lineConfirmar.Visible = false;
                btnChangeCarrera.Location = new Point(63, 187);
                panel3.Location = new Point(34, 275);
            }
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label10_Click_1(object sender, EventArgs e)
        {

        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
