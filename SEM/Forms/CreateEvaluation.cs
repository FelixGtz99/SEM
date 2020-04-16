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
        int n = 1;
        public CreateEvaluation(Conexion c)
            
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

            pictureBox1.ImageLocation = "https://i0.wp.com/umap.org/wp-content/uploads/2018/08/Logo_unison.png?fit=500%2C500";
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            path.AddEllipse(0, 0, label6.Width, label6.Height);
            this.label6.Region = new Region(path);
            this.label3.Region = new Region(path);
            this.label11.Region = new Region(path);
            this.label13.Region = new Region(path);

           
           
            CBMaestros();
            cbMaestro.SelectedIndex = n;
            CBMaterias();

        }
        public void CBMaestros()
        {
            int x = -1;
            foreach (Maestro maestro in c.MAESTROS)
            {
                x++;
                cbMaestro.Items.Add(maestro.ToString());
                if (maestro.ToString().Equals(c.SMaestro))
                {
                    n = x;
                }
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
            c.getClases(getIDMaestro());
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
                c.guardarEvaluacion(iDM, iDMat, txtComentarios.Text, tbCalificacion.Value);
                MessageBox.Show("Completado");
                this.Hide();
                new Menu(c).Show();


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Error");
            }

        }

        private void cbMaestro_SelectedIndexChanged(object sender, EventArgs e)
        {
            CBMaterias();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Searcher(c).Show();
        }
    }
}
