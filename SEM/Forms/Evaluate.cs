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

namespace SEM
{
    public partial class Evaluate : Form
    {
        Conexion c = null;
        public Evaluate(Conexion c)
        {

            InitializeComponent();
            this.c = c;
            c.getMaestros();
            c.getMaterias();
            CBMaestros();
            cbMaestro.SelectedIndex = 0;
            CBMaterias();

        }

        private void cbMaestro_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            CBMaterias();
        }
        public void CBMaestros() {
            foreach (Maestro maestro in c.MAESTROS)
            {
                cbMaestro.Items.Add(maestro.ToString());

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

            cbMateria.Items.Clear();
            c.getClases(getIDMaestro());
            foreach (Materia materia in c.CLASES)
            {
                cbMateria.Items.Add(materia);
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
                new Menu(c).Show();


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Error");
            }
            
            
        }
        
    }
}
