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
            label1.Text = "Hola " + c.NOMBRE + " " + c.APELLIDO;
            btnVer.Visible = false; btnEvaluar.Visible = false;
            cbEleccion.SelectedIndex =0;
            c.SMaestro = "Ninguno we xd";
            c.SMateria = "Ninguna we xd";
            if (c.USER==0)
            {
                btnRegistrarD.Visible = false;
                btnEditar.Visible = false;
              
            }
        }

        private void data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
        
            btnEvaluar.Visible = true;
            if (c.USER!=0)
            {
                if (cbEleccion.SelectedItem.ToString() == "Materia")
                {
                    btnVer.Visible = false;
                }
                else {
                    btnVer.Visible = true;
                }
                
            }
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
            c.SMaestro = "Ninguno we xd";
            c.SMateria = "Ninguna we xd";
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            c.USER = 0;
            this.Hide();
            new Login(c).Show();

        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            this.Hide();
            new EditAccount(c).Show();
        }

        private void Searcher_Load(object sender, EventArgs e)
        {

        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            if (cbEleccion.SelectedItem.ToString().Equals("Docente"))
            {
                if (c.SMaestro == "Ninguno we xd")
                {
                    MessageBox.Show("No has seleccionado ningun maestro");
                }
                else {
                    this.Hide();
                    new Evaluations(c).Show();
                }
            }
            if (cbEleccion.SelectedItem.ToString().Equals("Materia"))
            {
                if (c.SMateria == "Ninguna we xd")
                {
                    MessageBox.Show("No has seleccionado ningun materia");
                }
                else
                {
                 
                }
            }

        }

        private void data_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (cbEleccion.SelectedItem.ToString() == "Docente")
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
            catch (Exception)
            {

            }
            
        }

        private void btnRA_Click(object sender, EventArgs e)
        {
            this.Hide();
            new RA(c).Show();
        }

        private void btnRegistrarD_Click(object sender, EventArgs e)
        {
            this.Hide();
           new RegisterTeacher(c).Show();
        }

        private void btnEvaluar_Click(object sender, EventArgs e)
        {
            if (cbEleccion.SelectedItem.ToString().Equals("Docente"))
            {
                if (c.SMaestro == "Ninguno we xd")
                {
                    MessageBox.Show("No has seleccionado ningun maestro");
                }
                else
                {
                    this.Hide();
                    new CreateEvaluation(c).Show();
                }
            }
            if (cbEleccion.SelectedItem.ToString().Equals("Materia"))
            {
                if (c.SMateria == "Ninguna we xd")
                {
                    MessageBox.Show("No has seleccionado ningun materia");
                }
                else
                {

                }
            }

        }
    }
}
