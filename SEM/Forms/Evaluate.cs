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
using SEM.Forms;

namespace SEM
{
    public partial class Evaluate : Form
    {
        Conexion c = null;
        static int idMaestro =0, idMateria=0;
        public Evaluate(Conexion c)
        {

            InitializeComponent();
            this.c = c;
        
            CBMaestros();
            if (idMaestro != 0)
            {
                cbMaestro.SelectedIndex = idMaestro;
               CBMaterias();
                cbMateria.SelectedIndex = idMateria;
            }
            else {
                int n = -1;
                cbMateria.Items.Clear();
             
                foreach (Materia materia in c.MATERIAS)
                {
                    n++;
                    cbMateria.Items.Add(materia.ToString());
                    if (materia.ToString() == c.SMateria)
                    {
                        cbMateria.SelectedIndex = n;
                    }
                }
            }
            

        }

        private void cbMaestro_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            CBMaterias();
        }
        public void CBMaestros() {
            int n = -1;
            foreach (Maestro maestro in c.MAESTROS)
            {
                n++;
                cbMaestro.Items.Add(maestro.ToString());
                if (maestro.ToString() == c.SMaestro)
                {
                    idMaestro = n;
                }
            }
        }
        public int getIDMaestro() {
            int id = 0;
            foreach (Maestro maestro in c.MAESTROS)
            { 
                if (maestro.ToString().Equals(cbMaestro.SelectedItem.ToString()))
                {
                    id = maestro.ID;

                }
            }

           

            return id;
        }
        public int getIDMateria()
        {
            int id = 0;
            foreach (Materia materia in c.CLASES)
            {
                Console.WriteLine(materia.ToString());
                Console.WriteLine(cbMateria.SelectedItem);
                if (materia.ToString().Equals(cbMateria.SelectedItem.ToString()))
                {
              
                    id = materia.ID;
                    Console.WriteLine("Entra con " + id);
                }
            }



            return id;
        }

        public void CBMaterias()
        {
            int n = -1;
            cbMateria.Items.Clear();
            c.getClases(getIDMaestro());
            foreach (Materia materia in c.CLASES)
            {
                n++;
                cbMateria.Items.Add(materia.ToString());
                if (materia.ToString()==c.SMateria)
                {
                    idMateria = n;
                }
            }
            
        }

        private void cbMateria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                var iDM = getIDMaestro(); 
               var iDMat = getIDMateria();
                c.guardarEvaluacion(iDM, iDMat, txtComentarios.Text, tbCalificacion.Value);
                MessageBox.Show("Completado");
                this.Hide();
                new Searcher(c).Show();


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Error");
            }
            
            
        }

        private void Evaluate_Load(object sender, EventArgs e)
        {

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            new TeacherMenu(c).Show();
        }

        private void btnRegresar_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            new TeacherMenu(c).Show();
        }

        private void CargarCBMaestro() { 
        
        }
        
    }
}
