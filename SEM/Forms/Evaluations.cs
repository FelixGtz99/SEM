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
    public partial class Evaluations : Form
    {
        Conexion c = null;
        String Comentario=" ", Calificacion = " ";
        public Evaluations(Conexion c)
        {
            this.c = c;
            InitializeComponent();
            //Datos de la barra superior
            this.ActiveControl = panel2;
            btnClose.Height = panel2.Height;
            btnClose.Location = new Point(this.Width - btnClose.Width, 0);
            btnMin.Location = new Point(this.Width - btnClose.Width - btnMin.Width, 0);
            btnMin.Height = panel2.Height;
            panel2.Location = new Point(0, 0);
            panel2.Width = this.Width;
            label1.Text = c.SMaestro;
            CBMaterias();
            cbMateria.SelectedIndex = 0;
            c.SMateria = cbMateria.SelectedItem.ToString();
           dataGridView1.DataSource= c.verEvaluaciones();
           
            //dataGridView1.Columns[0].Width = dataGridView1.Width / 9;
            //dataGridView1.Columns[1].Width = dataGridView1.Width*33 / 72;
           // dataGridView1.Columns[2].Width = dataGridView1.Width / 8;
            //dataGridView1.Columns[3].Width = dataGridView1.Width / 9;
            //dataGridView1.Columns[4].Width = dataGridView1.Width / 9;

            pictureBox1.ImageLocation = "https://i0.wp.com/umap.org/wp-content/uploads/2018/08/Logo_unison.png?fit=500%2C500";
            string urlImg = c.getImgM();
            if(urlImg == "null" || string.IsNullOrEmpty(urlImg) || urlImg == "no")
            {
                imgMaestro.ImageLocation = "https://fotos.subefotos.com/a77a9fc14733c78d00746a077a874ce5o.png";
            }
            else
            {
                imgMaestro.ImageLocation = urlImg;

            }
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            var path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddEllipse(0, 0, label6.Width, label6.Height);
            this.label6.Region = new Region(path);
            if (c.USER==0)

            {
                likeBtn.Visible = false;
                dislikeBtn.Visible = false;
                btnADD.Visible = false;
            }
            /*panel2.Focus();
            dataGridView1.ClearSelection();*/
        }

        

        private void Evaluations_Load(object sender, EventArgs e)
        {

        }
        public void CBMaterias()
        {

            cbMateria.Items.Clear();
            c.getClases(c.getIDMaestro());
            foreach (Materia materia in c.CLASES)
            {
                cbMateria.Items.Add(materia);
            }

        }

        private void cbMateria_SelectedIndexChanged(object sender, EventArgs e)
        {
            c.SMateria = cbMateria.SelectedItem.ToString();
        
            dataGridView1.DataSource = c.verEvaluaciones();
        }

        private void button_WOC1_Click(object sender, EventArgs e)
        {
            if (Calificacion.Equals(" "))
            {
                //MessageBox.Show("No has seleccionado ninguna evaluacion");
                SemBox sb = new SemBox("shorterror", "No has seleccionado ninguna evaluación", "", "Aceptar");
                sb.Show();
            }
            else
            {
                int id = c.getIDEvaluacion(Comentario, Calificacion);

                if (c.chechUserVote(id))
                {
                    //MessageBox.Show("No puedes votar otra vez por esta evaluacion");
                    SemBox sb = new SemBox("shorterror", "Ya realizaste tu voto en esta evaluación", "", "Aceptar");
                    sb.Show();
                }
                else
                {

                    c.updateLikes(c.getLikes(id), id);
                    c.updateVotos(id);
                    dataGridView1.DataSource = c.verEvaluaciones();

                }
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Searcher(c).Show();
        }

        private void button_WOC2_Click(object sender, EventArgs e)
        {
            if (Calificacion.Equals(" "))
            {
                //MessageBox.Show("No has seleccionado ninguna evaluacion");
                SemBox sb = new SemBox("shorterror", "No has seleccionado ninguna evaluación", "", "Aceptar");
                sb.Show();
            }
            else
            {
                int id = c.getIDEvaluacion(Comentario, Calificacion);

                if (c.chechUserVote(id))
                {
                    //MessageBox.Show("No puedes votar otra vez por esta evaluacion");
                    SemBox sb = new SemBox("shorterror", "Ya realizaste tu voto en esta evaluación", "", "Aceptar");
                    sb.Show();
                }
                else
                {

                    c.updateDislikes(c.getDislikes(id), id);
                    c.updateVotos(id);
                    dataGridView1.DataSource = c.verEvaluaciones();

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

        private void button_WOC1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            new EditTeacher(c).Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var index = e.RowIndex;
                DataGridViewRow SelectedRow = dataGridView1.Rows[index];
                Comentario = SelectedRow.Cells[1].Value.ToString();
                Calificacion = SelectedRow.Cells[2].Value.ToString();
                likeBtn.ButtonColor = Color.FromArgb(13, 70, 255);
                likeBtn.TextColor = Color.White;
                likeBtn.Enabled = true;
                dislikeBtn.ButtonColor = Color.FromArgb(255, 13, 70);
                dislikeBtn.TextColor = Color.White;
                dislikeBtn.Enabled = true;
                dataGridView1.DefaultCellStyle.SelectionBackColor = Color.FromArgb(1, 120, 213);
                dataGridView1.DefaultCellStyle.SelectionForeColor = Color.White;
            }
            catch (Exception)
            {

              
            }
            
        }
    }
}
