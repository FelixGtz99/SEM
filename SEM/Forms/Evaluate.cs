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
        public Evaluate(Conexion c)
        {
            InitializeComponent();
            c.getMaestros();
            foreach (Maestro maestro in c.MAESTROS) {
                cbMaestro.Items.Add(maestro.ToString());
             
            }
            
        }

        private void cbMaestro_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
