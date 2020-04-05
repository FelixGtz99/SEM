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
    public partial class Searcher : Form
    { Conexion c = null;
        public Searcher(Conexion c)
        {
            InitializeComponent();
            this.c = c;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            panel.Location = new Point((this.Width / 2 - panel.Width / 2), (this.Height / 2 - panel.Height/2 ));
            panelCuenta.Location = new Point((this.Width - panelCuenta.Width), 0);
              panelUniversidad.Location = new Point((this.Width / 2 - panel.Width / 2), (this.Height / 2 + panel.Height/8));
            if (c.USER==0)
            {
                btnEvaluate.Visible = false;
                label1.Visible = false;
            }
            label1.Text = "Hola " + c.NOMBRE + " " + c.APELLIDO;
        }

        private void data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (cbEleccion.SelectedItem.ToString()=="Docente")
            {
                data.DataSource = c.verMaestros(txtBuscar.Text);
            }
            if (cbEleccion.SelectedItem.ToString() == "Materia")
            {
                data.DataSource = c.verMaterias(txtBuscar.Text);
            }
            // data.DataSource = c.getEvaluacion();
        }

        private void cbEleccion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AccountMenu(c).Show();

        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            this.Hide();
            new EditAccount(c).Show();
        }

        private void btnEvaluate_Click(object sender, EventArgs e)
        {
            this.Hide();
            new TeacherMenu(c).Show();
        }

        private void data_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (cbEleccion.SelectedItem.ToString()=="Docente")
            {
                var index = e.RowIndex;
                DataGridViewRow SelectedRow = data.Rows[index];
                c.SMaestro = SelectedRow.Cells[0].Value.ToString();
           
           
            }
            else
            {
                var index = e.RowIndex;
                DataGridViewRow SelectedRow = data.Rows[index];
                c.SMateria = SelectedRow.Cells[0].Value.ToString();
                Console.WriteLine("Entto aqi");
            }
           
        }

        private void Searcher_Load(object sender, EventArgs e)
        {

        }
    }
}
