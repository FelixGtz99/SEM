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
    public partial class TeacherMenu : Form
    {
        Conexion c = null;
        public TeacherMenu(Conexion c)
        {
            this.c = c;
            InitializeComponent();
            lbNombre.Text = c.SMaestro;
            label3.Visible = false;
            lbMateria.Visible = false;
            clases();
            
        }

        private void TeacherMenu_Load(object sender, EventArgs e)
        {
           
        }
        public void clases() {
            foreach (Maestro maestro in c.MAESTROS)
            {
                Console.WriteLine(maestro.ToString());
                if (maestro.ToString().Equals(c.SMaestro))
                {
                    Console.WriteLine("Entro al if");
                 data.DataSource = c.verClases(maestro.ID);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            this.Hide();
            new Evaluate(c).Show();
        }

        private void data_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var index = e.RowIndex;
            DataGridViewRow SelectedRow = data.Rows[index];
            c.SMateria = SelectedRow.Cells[0].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lbMateria.Text = c.SMateria;
            label3.Visible = true;
            lbMateria.Visible = true;
            data.DataSource = c.verEvaluaciones();
        }
    }
}
