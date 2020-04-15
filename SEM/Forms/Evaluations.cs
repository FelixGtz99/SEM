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
    public partial class Evaluations : Form
    {
        public Evaluations()
        {
            InitializeComponent();
            //Datos de la barra superior
            this.ActiveControl = panel2;
            btnClose.Height = panel2.Height;
            btnClose.Location = new Point(this.Width - btnClose.Width, 0);
            btnMin.Location = new Point(this.Width - btnClose.Width - btnMin.Width, 0);
            btnMin.Height = panel2.Height;
            panel2.Location = new Point(0, 0);
            panel2.Width = this.Width;

            for(int i = 1; i<10; i++)
            {
                dataGridView1.Rows.Add("0"+i+"/00/2020", "Comentario "+i, "X"+i, "Y"+i, "Z"+i);
            }
            dataGridView1.Columns[0].Width = dataGridView1.Width / 9;
            dataGridView1.Columns[1].Width = dataGridView1.Width*33 / 72;
            dataGridView1.Columns[2].Width = dataGridView1.Width / 8;
            dataGridView1.Columns[3].Width = dataGridView1.Width / 9;
            dataGridView1.Columns[4].Width = dataGridView1.Width / 9;

            pictureBox1.ImageLocation = "https://i0.wp.com/umap.org/wp-content/uploads/2018/08/Logo_unison.png?fit=500%2C500";
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            var path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddEllipse(0, 0, label6.Width, label6.Height);
            this.label6.Region = new Region(path);
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Evaluations_Load(object sender, EventArgs e)
        {

        }
    }
}
