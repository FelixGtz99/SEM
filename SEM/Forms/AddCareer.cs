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
        List<String> materias = new List<string>();
        Conexion c = null;
        public AddCareer(Conexion c)
        {
            this.c = c;
            InitializeComponent();
            pictureBox1.ImageLocation = c.getlogo();
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            var path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddEllipse(0, 0, help1.Width, help1.Height);
            this.help1.Region = new Region(path);
            this.help2.Region = new Region(path);
            lbUniversidad.Text = c.getUniversidad();
            lbNombre.Text = c.NOMBRE + " " + c.APELLIDO;
        }

        private void Button_WOC1_Click(object sender, EventArgs e)
        {
            c.setCarrera(materias, txtCarrera.Text);
            new SemBox("short", "Carrera agregada correctamente", "", "Aceptar").Show();
            this.Hide();
            new Searcher(c).Show();
        }

        private void txtMaterias_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            var m = txtMateria.Text;
            if (!m.Equals(""))
            {
                materias.Add(m);
                lbMaterias.Items.Add(m);
                txtMateria.Text = "";
            }
          
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            c.logout();
        }
    }
}
