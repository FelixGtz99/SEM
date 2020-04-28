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

namespace SEM.Forms
{
    public partial class EditTeacher : Form
    {
        Conexion c = null;
        public EditTeacher(Conexion c)
        {
            this.c = c;
            InitializeComponent();
            titleLabel.Text = c.SMaestro;
            listMaterias.Items.Clear();
            //c.getClases(c.getIDMaestro());
            foreach (Materia materia in c.MATERIAS)
            {
                cbMaterias.Items.Add(materia.ToString());
            }
            foreach (Materia materia in c.CLASES)
            {
                cbMaterias.Items.Remove(materia);
                //Mexicanada ¿Donde?
                listMaterias.Items.Add(materia);
            }
       

        }

        private void titleLabel_Click(object sender, EventArgs e)
        {

        }

        private void defButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Evaluations(c).Show();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var m= cbMaterias.SelectedItem.ToString();
            c.SMateria = m;
            c.guardarClaseDocente( c.getIDMateria(), c.getIDMaestro());
          
            listMaterias.Items.Add(m);
            cbMaterias.Items.Remove(m);
        }
    }
}
