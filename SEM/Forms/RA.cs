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
        String Comentario = " ", Calificacion = " ";
        public RA(Conexion c)
        {
            this.c = c;
            InitializeComponent();
            data.DataSource = c.verRA();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Searcher(c).Show();
        }

        private void data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnLike_Click(object sender, EventArgs e)
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
                data.DataSource = c.verRA();

            }
        }

        private void btnDislike_Click(object sender, EventArgs e)
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
                data.DataSource = c.verRA();

            }
        }

        private void data_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var index = e.RowIndex;
            DataGridViewRow SelectedRow = data.Rows[index];
            c.SMateria = SelectedRow.Cells[0].Value.ToString();
            c.SMaestro = SelectedRow.Cells[1].Value.ToString();
            Comentario = SelectedRow.Cells[2].Value.ToString();
            Calificacion = SelectedRow.Cells[3].Value.ToString();

        }
    }
}
