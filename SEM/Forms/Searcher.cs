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
            c.getMaestros();
            c.getMaterias();
            c.getCarreras();
            c.getEscuela();
            labelCarrera.Text = c.SCarrera;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;

            //Datos de la barra superior
            this.ActiveControl = panel2;
            btnClose.Height = panel2.Height;
            btnClose.Location = new Point(this.Width - btnClose.Width, 0);
            btnMin.Location = new Point(this.Width - btnClose.Width - btnMin.Width, 0);
            btnMin.Height = panel2.Height;
            panel2.Location = new Point(0, 0);
            panel2.Width = this.Width;

            //Para darle la forma circular a los tooltips
            var path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddEllipse(0, 0, searchBack1.Width, searchBack1.Height);
            this.searchBack1.Region = new Region(path);
            this.searchBack3.Region = new Region(path);
            var path2 = new System.Drawing.Drawing2D.GraphicsPath();
            path2.AddEllipse(0, 0, helpSearch.Width, helpSearch.Height);
            this.helpSearch.Region = new Region(path2);
            this.helpResults.Region = new Region(path2);

            //Para que se borre o llene la barra de búsqueda al darle click
            txtBuscar.GotFocus += txtBuscar_GotFocus;
            txtBuscar.LostFocus += txtBuscar_LostFocus;

            //panel.Location = new Point((this.Width / 2 - panel.Width / 2), (this.Height / 2 - panel.Height/2 ));
            //panelCuenta.Location = new Point((this.Width - panelCuenta.Width), 0);
            // panelUniversidad.Location = new Point((this.Width / 2 - panel.Width / 2), (this.Height / 2 + panel.Height/8));
            pictureBox2.ImageLocation = "https://i0.wp.com/umap.org/wp-content/uploads/2018/08/Logo_unison.png?fit=500%2C500";
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;

            label1.Text = c.NOMBRE + " " + c.APELLIDO;
            btnVer.Visible = false; btnEvaluar.Visible = false;
            //maestrosRadio.Checked = true;
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
            btnVer.Visible = false;
            string searched = "";
            if(txtBuscar.Text != "Buscar")
            {
                searched = txtBuscar.Text;
            }
            if (c.USER != 0)
            {
                btnEvaluar.Visible = true;
                if (materiasRadio.Checked == true)
                {


                }
                else
                {

                    btnVer.Visible = true;
                }

            }
            else {
                //if (cbEleccion.SelectedItem.ToString() != "Materia")
                if(materiasRadio.Checked != true)
                {
                    btnVer.Visible = true;
                }
            }
            //if (cbEleccion.SelectedItem.ToString()=="Docente")
            if(maestrosRadio.Checked == true)
            {
                data.DataSource = c.verMaestros(searched);
                data.Columns["Promedio"].DefaultCellStyle.Format = "N2";
                data.Sort(this.data.Columns["maestro"], ListSortDirection.Ascending);

            }
            //if (cbEleccion.SelectedItem.ToString() == "Materia")
            if(materiasRadio.Checked == true)
            {
                data.DataSource = c.verMaterias(searched);
                data.Sort(this.data.Columns["materia"], ListSortDirection.Ascending);

            }
            
            foreach(DataGridViewColumn dgc in data.Columns)
            {
                
                dgc.DividerWidth = 1;
            }
            data.Rows[0].Cells[0].Selected = true;
            if (maestrosRadio.Checked == true)
            {
                //var index = e.RowIndex;
                //DataGridViewRow SelectedRow = data.Rows[index];
                c.SMaestro = data.Rows[0].Cells[0].Value.ToString();


            }
            else
            {
                //var index = e.RowIndex;
                //DataGridViewRow SelectedRow = data.Rows[index];
                c.SMateria = data.Rows[0].Cells[0].Value.ToString();
                Console.WriteLine("Entto aqi");
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
            //if (cbEleccion.SelectedItem.ToString().Equals("Docente"))
            if(maestrosRadio.Checked == true)
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
            //if (cbEleccion.SelectedItem.ToString().Equals("Materia"))
            if(materiasRadio.Checked == true)
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
                //if (cbEleccion.SelectedItem.ToString() == "Docente")
                if(maestrosRadio.Checked == true)
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
            //if (cbEleccion.SelectedItem.ToString().Equals("Docente"))
            if(maestrosRadio.Checked == true)
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
            //if (cbEleccion.SelectedItem.ToString().Equals("Materia"))
            if(materiasRadio.Checked == true)
            {
                if (c.SMateria == "Ninguna we xd")
                {
                    MessageBox.Show("No has seleccionado ningun materia");
                }
                else
                {
                    this.Hide();
                    new CreateEvaluation(c).Show();
                }
            }

        }

        private void BtnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TxtBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnBuscar_Click(this, new EventArgs());
            }
        }

        private void txtBuscar_GotFocus(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "Buscar")
            {
                txtBuscar.Text = "";
            }
        }
        private void txtBuscar_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBuscar.Text))
            {
                txtBuscar.Text = "Buscar";
            }
            

        }

        private void MateriasRadio_CheckedChanged(object sender, EventArgs e)
        {
            btnBuscar_Click(this, new EventArgs());
        }
    }
}
