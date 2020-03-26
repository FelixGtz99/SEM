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
        public void CBMaterias()
        {
            foreach (Maestro maestro in c.MAESTROS)
            {

                Console.WriteLine(maestro.ToString());
                if (maestro.ToString().Equals(cbMaestro.SelectedItem))
                {

                    c.getClases(maestro.ID);
                }

            }
            foreach (Materia materia in c.CLASES)
            {
                cbMateria.Items.Add(materia);
            } 
           
        }
    }
}
