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
    public partial class CreateEvaluation : Form
    {
        public CreateEvaluation()
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

            var path = new System.Drawing.Drawing2D.GraphicsPath();

            pictureBox1.ImageLocation = "https://i0.wp.com/umap.org/wp-content/uploads/2018/08/Logo_unison.png?fit=500%2C500";
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            path.AddEllipse(0, 0, label6.Width, label6.Height);
            this.label6.Region = new Region(path);
            this.label3.Region = new Region(path);
            this.label11.Region = new Region(path);
            this.label13.Region = new Region(path);



        }

        private void CreateEvaluation_Load(object sender, EventArgs e)
        {

        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {

        }
    }
}
