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
        String Comentario = " ", Calificacion=" ";
        
        public TeacherMenu(Conexion c)
        {
            this.c = c;
            InitializeComponent();
            lbNombre.Text = c.SMaestro;
            label3.Visible = false;
            lbMateria.Visible = false;
            panel2.Visible = false;
            clases();
            c.SMateria = "Ninguna we xd";
            if (c.USER==0)
            {
                button1.Visible = false;
              
            }
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
            if (c.SMateria == "Ninguna we xd")
            {
                MessageBox.Show("No has seleccionado ningua a evaluar");
            }
            else {
                if (c.checkUserEvaluation())
                {
                    Console.WriteLine("Ya existe");
                    MessageBox.Show("Ya Evaluaste a este maestro en esta clase");
                }
                else
                {
                    Console.WriteLine("No exite");
                    this.Hide();
                    new Evaluate(c).Show();
                }
            }
           }

        private void data_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (panel1.Visible)
                {
                    var index = e.RowIndex;
                    DataGridViewRow SelectedRow = data.Rows[index];
                    c.SMateria = SelectedRow.Cells[0].Value.ToString();
                }
                if (panel2.Visible)
                {
                    var index = e.RowIndex;
                    DataGridViewRow SelectedRow = data.Rows[index];
                    Comentario = SelectedRow.Cells[0].Value.ToString();
                    Calificacion = SelectedRow.Cells[1].Value.ToString();
                }

            }
            catch (Exception)
            {

                
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (c.SMateria == "Ninguna we xd")
            {
                MessageBox.Show("No has seleccionado ninguna mataeria a evaluar");
            }
            else
            {
                lbMateria.Text = c.SMateria;
                label3.Visible = true;
                lbMateria.Visible = true;
                data.DataSource = c.verEvaluaciones();
                panel1.Visible = false;
                if (c.USER!=0)
                {
                    panel2.Visible = true;
                }
                
            }
        }

        private void btnLike_Click(object sender, EventArgs e)
        {
            if (Calificacion.Equals(" "))
            {
                MessageBox.Show("No has seleccionado ninguna evaluacion");
            }
            else
            {
                int id = c.getIDEvaluacion(Comentario, Calificacion);

                if (c.chechUserVote(id))
                {
                    MessageBox.Show("No puedes votar otra vez por esta evaluacion");
                }
                else
                {

                    c.updateLikes(c.getLikes(id), id);
                    c.updateVotos(id);
                    data.DataSource = c.verEvaluaciones();

                }
            }
        }

        private void btnDislike_Click(object sender, EventArgs e)
        {
            if (Calificacion.Equals(" "))
            {
                MessageBox.Show("No has seleccionado ninguna evaluacion");
            }
            else
            {
                int id = c.getIDEvaluacion(Comentario, Calificacion);

                if (c.chechUserVote(id))
                {
                    MessageBox.Show("No puedes votar otra vez por esta evaluacion");
                }
                else
                {

                    c.updateDislikes(c.getDislikes(id), id);
                    c.updateVotos(id);
                    data.DataSource = c.verEvaluaciones();

                }
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            if (panel1.Visible)
            {
                this.Hide();
                new Searcher(c).Show();
            }
            if (panel2.Visible)
            {
                clases();
                panel2.Visible = false;
                panel1.Visible = true;
                label3.Visible = false;
                lbMateria.Visible = false;

            }
        }

        private void data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
