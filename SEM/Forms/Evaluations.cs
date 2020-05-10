using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        String idEvaluacion = " ";
        byte[] ImgByteA = null;
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

            //Datos del panel de materias y evaluaciones
            panelEvaluaciones.Location = panelMaterias.Location;
            dataGridView2.DataSource = c.verMateriasM();
            dataGridView2.Columns["Promedio"].DefaultCellStyle.Format = "N2";

            label1.Text = c.SMaestro;
            toolTip2.SetToolTip(this.imgMaestro, c.SMaestro);
            /*CBMaterias();
            cbMateria.SelectedIndex = 0;
            c.SMateria = cbMateria.SelectedItem.ToString();
           dataGridView1.DataSource= c.verEvaluaciones();
           */
            /*dataGridView1.Columns[0].Width = dataGridView1.Width / 9;
            dataGridView1.Columns[1].Width = dataGridView1.Width*33 / 72;
            dataGridView1.Columns[2].Width = dataGridView1.Width / 8;
            dataGridView1.Columns[3].Width = dataGridView1.Width / 9;
            dataGridView1.Columns[4].Width = dataGridView1.Width / 9;*/

            escuelaPicture.ImageLocation = c.getlogo();
            labelCarrera.Text = c.getUniversidad();
            //string urlImg = c.getImgM();
            byte[] imagen = c.getImgM2();

            if (imagen == null)
            {
                Console.WriteLine("Faros en vinagre");
                //  MessageBox.Show("WHAT THE FUCK");
                //imgMaestro.ImageLocation = "https://fotos.subefotos.com/a77a9fc14733c78d00746a077a874ce5o.png";

            }
            else
            {
                using (MemoryStream productImageStream = new System.IO.MemoryStream(imagen))
                {
                    ImageConverter imageConverter = new System.Drawing.ImageConverter();
                    imgMaestro.Image = imageConverter.ConvertFrom(imagen) as System.Drawing.Image;
                }
                //imageConverter = c.getImgM2();

                Console.WriteLine("Faros en vinagre del else");

            }
            escuelaPicture.SizeMode = PictureBoxSizeMode.Zoom;

            //Para darle la forma circular a los tooltips
            var path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddEllipse(0, 0, label6.Width, label6.Height);
            this.label6.Region = new Region(path);
            this.label4.Region = new Region(path);
            var path2 = new System.Drawing.Drawing2D.GraphicsPath();
            path2.AddEllipse(0, 0, imgMaestro.Width, imgMaestro.Height);
            this.imgMaestro.Region = new Region(path2);
            

            if (c.USER == 0)

            {
                likeBtn.Visible = false;
                dislikeBtn.Visible = false;
                btnADD.Visible = false;
                btnEvaluate.Visible = false;
            }
             
            c.getClases(c.getIDMaestro());

            c.SMateria = dataGridView2.Rows[0].Cells[0].Value.ToString();
            /*panel2.Focus();
            dataGridView1.ClearSelection();*/
        }



        private void Evaluations_Load(object sender, EventArgs e)
        {

        }
        /* public void CBMaterias()
         {

             cbMateria.Items.Clear();
             c.getClases(c.getIDMaestro());
             foreach (Materia materia in c.CLASES)
             {
                 cbMateria.Items.Add(materia);
             }

         }*/

        /* private void cbMateria_SelectedIndexChanged(object sender, EventArgs e)
         {
             c.SMateria = cbMateria.SelectedItem.ToString();

             dataGridView1.DataSource = c.verEvaluaciones();
         }*/

        private void button_WOC1_Click(object sender, EventArgs e)
        {
            if (idEvaluacion.Equals(" "))
            {
                //MessageBox.Show("No has seleccionado ninguna evaluacion");
                SemBox sb = new SemBox("shorterror", "No has seleccionado ninguna evaluación", "", "Aceptar");
                sb.Show();
            }
            else
            {
                int id = int.Parse(idEvaluacion);

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
                    dataGridView1.Columns["id_evaluacion"].Visible = false;
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
            if (idEvaluacion.Equals(" "))
            {
                //MessageBox.Show("No has seleccionado ninguna evaluacion");
                SemBox sb = new SemBox("shorterror", "No has seleccionado ninguna evaluación", "", "Aceptar");
                sb.Show();
            }
            else
            {
                int id = int.Parse(idEvaluacion);

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
                    dataGridView1.Columns["id_evaluacion"].Visible = false;

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
            //this.Hide();
            var et = new EditTeacher(c,"alumno");
            et.Shown += (o, args) => { this.Enabled = false; };
            et.FormClosed += (o, args) => {
                this.Enabled = true;
                this.c.getClases(c.getIDMaestro());
                dataGridView2.DataSource = c.verMateriasM();
                dataGridView2.Refresh();
            };
            et.Show();
            //new EditTeacher(c).Show();

        }

        private void DataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var index = e.RowIndex;
            DataGridViewRow SelectedRow = dataGridView2.Rows[index];
            c.SMateria = SelectedRow.Cells[0].Value.ToString();

            /*btnEvaluate.ButtonColor = Color.FromArgb(13, 70, 255);
            btnEvaluate.TextColor = Color.White;
            btnEvaluate.Enabled = true;
            btnEvaluations.ButtonColor = Color.FromArgb(13, 70, 255);
            btnEvaluations.TextColor = Color.White;
            btnEvaluations.Enabled = true;*/
            /*dataGridView2.DefaultCellStyle.SelectionBackColor = Color.FromArgb(1, 120, 213);
            dataGridView2.DefaultCellStyle.SelectionForeColor = Color.White;*/
        }

        private void BtnEvaluate_Click(object sender, EventArgs e)
        {
            this.Hide();
            new CreateEvaluation(c, "maestro").Show();
        }

        private void BtnEvaluations_Click(object sender, EventArgs e)
        {
            panelEvaluaciones.Location = panelMaterias.Location;
            panelMaterias.Visible = false;
            panelEvaluaciones.Visible = true;
            materiaLabel.Text = c.SMateria;
            /*btnEvaluate.ButtonColor = Color.FromArgb(130, 170, 255);
            btnEvaluate.TextColor = Color.Silver;
            btnEvaluate.Enabled = false;
            btnEvaluations.ButtonColor = Color.FromArgb(130, 170, 255);
            btnEvaluations.TextColor = Color.Silver;
            btnEvaluations.Enabled = false;
            dataGridView2.DefaultCellStyle.SelectionBackColor = Color.White;
            dataGridView2.DefaultCellStyle.SelectionForeColor = Color.DimGray;*/
            dataGridView1.DataSource = c.verEvaluaciones();
            dataGridView1.Columns["id_evaluacion"].Visible = false;
            /*dataGridView1.Columns[0].Width = dataGridView1.Width / 9;
            dataGridView1.Columns[1].Width = dataGridView1.Width * 33 / 72;
            dataGridView1.Columns[2].Width = dataGridView1.Width / 8;
            dataGridView1.Columns[3].Width = dataGridView1.Width / 9;
            dataGridView1.Columns[4].Width = dataGridView1.Width / 9;*/
            if (dataGridView1.Rows.Count > 0)
            {
                idEvaluacion = dataGridView1.Rows[0].Cells[0].Value.ToString();
                likeBtn.ButtonColor = Color.FromArgb(13, 70, 255);
                likeBtn.Enabled = true;
                dislikeBtn.ButtonColor = Color.FromArgb(255, 13, 70);
                dislikeBtn.Enabled = true;
                label2.Text = "Evaluaciones de la materia:";
            }
            else
            {
                likeBtn.ButtonColor = Color.FromArgb(130, 170, 255);
                likeBtn.Enabled = false;
                dislikeBtn.ButtonColor = Color.FromArgb(255, 130, 170);
                dislikeBtn.Enabled = false;
                label2.Text = "No hay evaluaciones de la materia:";
            }

        }

        private void BtnMaterias_Click(object sender, EventArgs e)
        {
            panelMaterias.Visible = true;
            panelEvaluaciones.Visible = false;
            /* likeBtn.TextColor = Color.Silver;
             likeBtn.ButtonColor = Color.FromArgb(130, 170, 255);
             likeBtn.Enabled = false;
             dislikeBtn.ButtonColor = Color.FromArgb(255, 130, 170);
             dislikeBtn.TextColor = Color.Silver;
             dislikeBtn.Enabled = false;
             dataGridView1.DefaultCellStyle.SelectionBackColor = Color.White;
             dataGridView1.DefaultCellStyle.SelectionForeColor = Color.DimGray;*/
            dataGridView2.DataSource = c.verMateriasM();
            c.SMateria = dataGridView2.Rows[0].Cells[0].Value.ToString();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var index = e.RowIndex;
                DataGridViewRow SelectedRow = dataGridView1.Rows[index];
                idEvaluacion = SelectedRow.Cells[0].Value.ToString();

                /* likeBtn.ButtonColor = Color.FromArgb(13, 70, 255);
                 likeBtn.TextColor = Color.White;
                 likeBtn.Enabled = true;
                 dislikeBtn.ButtonColor = Color.FromArgb(255, 13, 70);
                 dislikeBtn.TextColor = Color.White;
                 dislikeBtn.Enabled = true;*/
                /*dataGridView1.DefaultCellStyle.SelectionBackColor = Color.FromArgb(1, 120, 213);
                dataGridView1.DefaultCellStyle.SelectionForeColor = Color.White;*/

            }
            catch (Exception)
            {


            }

        }

        private void BtnRA_Click(object sender, EventArgs e)
        {
            this.Hide();
            new RA(c).Show();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            c.logout();
            this.Hide();
            new Login(c).Show();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenFileDialog1 = new OpenFileDialog();
            try
            {
                OpenFileDialog1.Filter = "Archivos de imágen (*.jpg)(*.jpeg)|*.jpg;*.jpeg|PNG(*.png)|*.png";
                if (OpenFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    String imagen = OpenFileDialog1.FileName;
                    Console.WriteLine("Aqui estan el string de la imagen: " + imagen);

                    imgMaestro.Image = Image.FromFile(imagen);
                    imgMaestro.SizeMode = PictureBoxSizeMode.Zoom;

                    using (FileStream pgFileStream = new FileStream(imagen, FileMode.Open, FileAccess.Read))
                    {

                        using (BinaryReader pgReader = new BinaryReader(new BufferedStream(pgFileStream)))
                        {
                            ImgByteA = pgReader.ReadBytes(Convert.ToInt32(pgFileStream.Length));
                            c.ChangeImage(ImgByteA);
                            //MessageBox.Show("Guardado Correctamente");
                            SemBox sb = new SemBox("short", "Se realizo la actualización", "", "Aceptar");
                            sb.Show();
                            
                            
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("El archivo seleccionado no es un tipo de imagen válido");


            }
        }

        private void button_WOC1_Click_2(object sender, EventArgs e)
        {
            if (c.checkProfileVote())
            {
               new SemBox("short", "Ya evaluaste este perfil", "", "Aceptar").Show();
            }
            else {
                c.setProfileVote("like");
            }
        }

        private void button_WOC2_Click_1(object sender, EventArgs e)
        {
            if(c.checkProfileVote())
            {
                new SemBox("short", "Ya evaluaste este perfil", "", "Aceptar").Show();
            }
            else
            {
                c.setProfileVote("dislike");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
