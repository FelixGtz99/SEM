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
    public partial class AdminPanel : Form
    {
        public AdminPanel()
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

            //Datos de la imagen y los tooltips
            pictureBox1.ImageLocation = "https://i0.wp.com/umap.org/wp-content/uploads/2018/08/Logo_unison.png?fit=500%2C500";
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            var path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddEllipse(0, 0, helpMaterias.Width, helpMaterias.Height);
            this.helpMaterias.Region = new Region(path);
            this.helpMaestros.Region = new Region(path);

            this.notifications.Rows.Add("El maestro José Luis Ochoa Hernández ha recibido muchos votos negativos en su perfil.");
            this.notifications.Rows.Add("El promedio del maestro Guzmán Gerardo Alfonso Sánchez Schmitz ha bajado de 6.0.");
            this.notifications.Rows.Add("Se ha añadido al maestro Jesús Daniel Alfaro Soto.");
            this.notifications.Rows.Add("El maestro Alonso Pérez Soltero ha recibido muchos votos negativos en su perfil");
            this.notifications.Rows.Add("El promedio del maestro Raquel Torres Peralta ha bajado de 6.0.");
            this.notifications.Rows.Add("Se ha añadido al maestro René Francisco Navarro Hernández.");

        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
