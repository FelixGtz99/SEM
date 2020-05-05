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
    public partial class AddCareer : Form
    {
        public AddCareer()
        {
            InitializeComponent();
            pictureBox1.ImageLocation = "https://i0.wp.com/umap.org/wp-content/uploads/2018/08/Logo_unison.png?fit=500%2C500";
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            var path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddEllipse(0, 0, help1.Width, help1.Height);
            this.help1.Region = new Region(path);
            this.help2.Region = new Region(path);
        }

        private void Button_WOC1_Click(object sender, EventArgs e)
        {

        }
    }
}
