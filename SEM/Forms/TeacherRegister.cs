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
    public partial class TeacherRegister : Form
    {
        List<Materia> Materias = new List<Materia>();
        Conexion c = null;
        public TeacherRegister(Conexion c)
        {
            this.c = c;
            InitializeComponent();
            foreach (Materia materia in c.MATERIAS)
            {
                cbMaterias.Items.Add(materia.ToString()) ;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var m = cbMaterias.SelectedItem.ToString();
            listMaterias.Items.Add(m);
           
            foreach (Materia materia in c.MATERIAS)
            {
                if (materia.ToString().Equals(m))
                {
                    Materias.Add(materia);
                }
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Searcher(c).Show();
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
           
            foreach (Materia materia in c.MATERIAS)
            {
                if (materia.ToString().Equals(listMaterias.SelectedItem.ToString()))
                {
                    Materias.Remove(materia);
                }
            }
            var index = listMaterias.SelectedIndex;
            listMaterias.Items.RemoveAt(index);

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            String Errores = " ";
            if (txtNombre.Text.Length == 0 || txtApellido.Text.Length == 0)
            {
                Errores = "Nombre y apellido no pueden estar vacios";
            }
            if (txtNombre.Text.Any(char.IsDigit) || txtApellido.Text.Any(char.IsDigit))
            {
                Errores = Errores + Environment.NewLine + "Nombre y Apellido deben de ser puras letras";

            }
            if (listMaterias.Items.Count == 0)
            {
                Errores = Errores + Environment.NewLine + "El maestro debe contar con almenos una materia";
            }
            if (!Errores.Equals(" "))
            {
                MessageBox.Show(Errores);
            }
            else
            {
                c.guardarDocente(txtNombre.Text, txtApellido.Text, txtAlias.Text, Materias);
                this.Hide();
                new Searcher(c).Show();
            }
        }
    }
}
