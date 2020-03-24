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
    public partial class Register : Form
    {
        Conexion c;
        public Register(Conexion c)
        {
            InitializeComponent();
            this.c = c;
            cbCarrera.SelectedIndex=0;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        public String validarCampos(String email, String Experiente, String Pass, String Carrera, String nombre, String Apellido)
        {

            String Errores = " ";
            if (email.Length==0 || Experiente.Length==0 || Pass.Length==0 || nombre.Length==0 || Apellido.Length==0)
            {
                Errores = "Nesesitas llenar todos los campos";
            }
            if (Pass.Length < 9)
            {
                Errores = Errores + Environment.NewLine + "La contraseña debe contar con almenos 9 caracteres";
            }
            if (!Experiente.Any(char.IsDigit))
            {
                Errores = Errores + Environment.NewLine + "El experiente debe ser puros numeros";
            }
            if (!Experiente.StartsWith("21")) 
            {
                Errores = Errores + Environment.NewLine + "Experiente no valido";
            }
            int cp = Pass.Split('1','2','3','4','5','6','7','8','9').Length - 1;
            if (cp<2)
            {
                Errores = Errores + Environment.NewLine + "La contraseña debe de tener al menos 2 numeros";
            }
            if (!email.StartsWith("a"+Experiente) || !(email.EndsWith("@unison.mx") || email.EndsWith("@alumnos.unison.mx")))
            {
                Errores = Errores + Environment.NewLine + "Correo no valido";
            }
            if (nombre.Any(char.IsDigit) || Apellido.Any(char.IsDigit))
            {
                Errores = Errores + Environment.NewLine + "Los nombres o apellidos no debe de contener numeros";
            }

          
            return Errores;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
           String check= validarCampos(txtCorreo.Text, txtExperiente.Text, txtContraseña.Text, cbCarrera.SelectedItem.ToString(), txtNombre.Text, txtApellido.Text);
            if (check == " ")
            {
                try
                {
                    c.RegisterUser(txtExperiente.Text, txtNombre.Text, txtApellido.Text, txtContraseña.Text, txtCorreo.Text, cbCarrera.SelectedItem.ToString());
                    MessageBox.Show("Registrado correctamente");
                    this.Hide();
                    new Menu(c).Show();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else {

                MessageBox.Show(check);
            }
                        
        
        }
    }
}
