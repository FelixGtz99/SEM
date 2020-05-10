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
    public partial class CreateEvaluation : Form
    {
        Conexion c = null;
      
        public CreateEvaluation(Conexion c, String d)
            
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

            var path = new System.Drawing.Drawing2D.GraphicsPath();

            pictureBox1.ImageLocation = c.getlogo() ;
            labelCarrera.Text = c.getUniversidad();
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            path.AddEllipse(0, 0, label6.Width, label6.Height);
            this.label6.Region = new Region(path);
            this.label3.Region = new Region(path);
            this.label11.Region = new Region(path);
            this.label13.Region = new Region(path);

            txtComentarios.GotFocus += Comment_GotFocus;
            txtComentarios.LostFocus += Comment_LostFocus;
            if (d.Equals("maestro"))
            {
                CBMaestros();
                cbMaestro.SelectedItem = c.SMaestro;
                CBClases();
                cbMateria.SelectedIndex = 0;
            }
            if (d.Equals("materia"))
            {
                cbMaestro.DataSource = c.cbMaestros();
                cbMaestro.SelectedIndex = 0;
                CBMaterias();
                cbMateria.SelectedItem = c.SMateria;
            
            }
            else {
              

            }
            

        }
        public void CBMaestros()
        {
         
            foreach (Maestro maestro in c.MAESTROS)
            {
               
                cbMaestro.Items.Add(maestro.ToString());
               
            }
        }
        public int getIDMaestro()
        {
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
         
            foreach (Materia materia in c.MATERIAS)
            {
                cbMateria.Items.Add(materia.ToString());
            }

        }
        public void CBClases()
        {

            cbMateria.Items.Clear();
            c.getClases(getIDMaestro());
            foreach (Materia materia in c.CLASES)
            {
                cbMateria.Items.Add(materia);
            }

        }
        public void CBClases2()
        {

            cbMaestro.Items.Clear();
            
            foreach (Materia materia in c.CLASES)
            {
                cbMateria.Items.Add(materia);
            }

        }
        private void CreateEvaluation_Load(object sender, EventArgs e)
        {

        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                var iDM = getIDMaestro();
                var iDMat = getIDMateria();
                if (c.checkEvaluaciones(iDM, iDMat))
                {
                    new SemBox("short", "Ya has evaluado este clase", "", "Aceptar").Show();
                }
                else
                {
                    c.guardarEvaluacion(iDM, iDMat, txtComentarios.Text, tbCalificacion.Value);
                    //MessageBox.Show("Completado");
                    SemBox sb = new SemBox("short", "Evaluación realizada con éxito", "", "Aceptar");
                    this.Hide();
                    new Searcher(c).Show();
                    sb.Show();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                //MessageBox.Show("Error");
                SemBox sb = new SemBox("long", "Ha ocurrido un error",ex.Message, "Aceptar");
                sb.Show();
            }

        }

        private void cbMaestro_SelectedIndexChanged(object sender, EventArgs e)
        {
            CBMaterias();
            this.checkFields();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Searcher(c).Show();
        }

        private void BtnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TxtComentarios_TextChanged(object sender, EventArgs e)
        {
            //limitWarning.Visible = true;
            limitWarning.Text = "Tienes " + (txtComentarios.MaxLength - txtComentarios.TextLength) + " caracteres restantes.";
            this.checkFields();
        }

        private void Comment_GotFocus(object sender, EventArgs e)
        {
            limitWarning.Visible = true;
        }

        private void Comment_LostFocus(object sender, EventArgs e)
        {
            limitWarning.Visible = false;

            this.checkFields();
        }

        


        private void checkFields()
        {
            if(string.IsNullOrWhiteSpace(txtComentarios.Text) || cbMaestro.SelectedIndex == -1 || cbMateria.SelectedIndex == -1)
            {
                btnGuardar.Enabled = false;
                btnGuardar.ButtonColor = Color.FromArgb(130, 170, 255);
                btnGuardar.TextColor = Color.Silver;
            }
            else
            {
                btnGuardar.Enabled = true;
                btnGuardar.ButtonColor = Color.FromArgb(13, 70, 255);
                btnGuardar.TextColor = Color.White;
            }
        }

        private void CbMateria_SelectedIndexChanged(object sender, EventArgs e)
        {
            c.SMateria = cbMateria.SelectedItem.ToString();
            cbMaestro.DataSource = c.cbMaestros();
            this.checkFields();
        }
    }
}
