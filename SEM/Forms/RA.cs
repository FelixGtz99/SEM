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
    public partial class RA : Form
    {
        Conexion c = null;
        
        public RA(Conexion c)
        {
            this.c = c;
            InitializeComponent();
            //data.DataSource = c.verRA();
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            //this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Height = 900;
            this.Width = 1440;
            /*if (c.USER==0)
            {
                btnLike.Visible = false;
                btnDislike.Visible = false;

            }*/

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
            path.AddEllipse(0, 0, helpRecent.Width, helpRecent.Height);
            this.helpRecent.Region = new Region(path);
            this.helpData.Region = new Region(path);

            //Miscelaneous
            label1.Text = c.NOMBRE + " " + c.APELLIDO;
            pictureBox2.ImageLocation = c.getlogo();
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;

            data.DataSource = c.verRA();
            //this.data.Rows.Add("Se publicó un comentario en el perfil del maestro: Luis Ochoa.", "30/04/2020");
            //this.data.Rows.Add("Se asoció la materia Ingeniería de Software 2 con el maestro: Abril Lopez.", "29/04/2020");
            //this.data.Rows.Add("Se ha añadido al maestro: Pedro Hernandez.", "28/04/2020");
            //this.data.Rows.Add("Se subipo una foto para el maestro: Alonso Perez Soltero.", "27/04/2020");
            //this.data.Rows.Add("El administrador añadió la materia Introducción al Derecho 4", "26/04/2020");
            //this.data.Rows.Add("El administrador cambió la foto del maestro: Leslie Garcia Montijo.","25/04/2020");
            try
            {
                string selectedActivity = data.Rows[0].Cells[0].Value.ToString();
                if (selectedActivity.Contains("maestro:"))
                {
                    btnVer.Enabled = true;
                    btnVer.ButtonColor = Color.FromArgb(13, 70, 255);
                    int begin = selectedActivity.IndexOf(':');
                    int end = selectedActivity.IndexOf('.');
                    int selectLength = end - begin - 2;
                    c.SMaestro = selectedActivity.Substring(begin + 2, selectLength);
                }
                else
                {
                    btnVer.Enabled = false;
                    btnVer.ButtonColor = Color.FromArgb(130, 170, 255);
                }
            }
            catch (Exception)
            {

                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            var Searcher = new Searcher(c);
            //var sb = new SemBox("short", "Maestro editado correctamente", "", "Aceptar");
            Searcher.Shown += (o, args) => { this.Hide();};

            //sb.Shown += (o, args) => { Searcher.Enabled = false; };
            //sb.FormClosed += (o, args) => { Searcher.Enabled = true; };
            Searcher.Show();
            /*this.Hide();
            new Searcher(c).Show();*/
        }

        private void data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnLike_Click(object sender, EventArgs e)
        {
            //int id = c.getIDEvaluacion(Comentario, Calificacion);

            //if (c.chechUserVote(id))
            //{
            //    MessageBox.Show("No puedes votar otra vez por esta evaluacion");
            //}
            //else
            //{

            //    c.updateLikes(c.getLikes(id), id);
            //    c.updateVotos(id);
            //    data.DataSource = c.verRA();

            //}
        }

        private void btnDislike_Click(object sender, EventArgs e)
        {
            //int id = c.getIDEvaluacion(Comentario, Calificacion);

            //if (c.chechUserVote(id))
            //{
            //    MessageBox.Show("No puedes votar otra vez por esta evaluacion");
            //}
            //else
            //{

            //    c.updateDislikes(c.getDislikes(id), id);
            //    c.updateVotos(id);
            //    data.DataSource = c.verRA();

            //}
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            var EditAccount = new EditAccount(c);
            //var sb = new SemBox("short", "Maestro editado correctamente", "", "Aceptar");
            EditAccount.Shown += (o, args) => { this.Hide(); };

            //sb.Shown += (o, args) => { EditAccount.Enabled = false; };
            //sb.FormClosed += (o, args) => { EditAccount.Enabled = true; };
            EditAccount.Show();
            /*this.Hide();
            new EditAccount(c).Show();*/

        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            c.logout();
            var Login = new Login(c);
            //var sb = new SemBox("short", "Maestro editado correctamente", "", "Aceptar");
            Login.Shown += (o, args) => { this.Hide();  };

            //sb.Shown += (o, args) => { Login.Enabled = false; };
            //sb.FormClosed += (o, args) => { Login.Enabled = true; };
            Login.Show();
            /*this.Hide();
            new Login(c).Show();*/
        }

        private void BtnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnVer_Click(object sender, EventArgs e)
        {
            var Evaluations = new Evaluations(c);
           // var sb = new SemBox("short", "Maestro editado correctamente", "", "Aceptar");
            Evaluations.Shown += (o, args) => { this.Hide(); };

            //sb.Shown += (o, args) => { Evaluations.Enabled = false; };
            //sb.FormClosed += (o, args) => { Evaluations.Enabled = true; };
            Evaluations.Show();
            /*this.Hide();
            new Evaluations(c).Show();*/
        }

        private void data_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                var index = e.RowIndex;
                DataGridViewRow SelectedRow = data.Rows[index];
                /* c.SMateria = SelectedRow.Cells[0].Value.ToString();
                 c.SMaestro = SelectedRow.Cells[1].Value.ToString();
                 Comentario = SelectedRow.Cells[2].Value.ToString();
                 Calificacion = SelectedRow.Cells[3].Value.ToString();*/
                string selectedActivity = SelectedRow.Cells[0].Value.ToString();
                if (selectedActivity.Contains("maestro:"))
                {
                    btnVer.Enabled = true;
                    btnVer.ButtonColor = Color.FromArgb(13, 70, 255);
                    int begin = selectedActivity.IndexOf(':');
                    int end = selectedActivity.IndexOf('.');
                    int selectLength = end - begin - 2;
                    c.SMaestro = selectedActivity.Substring(begin + 2, selectLength);
                }
                else
                {
                    btnVer.Enabled = false;
                    btnVer.ButtonColor = Color.FromArgb(130, 170, 255);
                }

            }
            catch (Exception)
            {

                
            }
        }
    }
}
