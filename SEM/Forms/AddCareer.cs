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
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            var path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddEllipse(0, 0, help1.Width, help1.Height);
            this.help1.Region = new Region(path);
            this.help2.Region = new Region(path);
            lbUniversidad.Text = c.getUniversidad();
            lbNombre.Text = c.NOMBRE + " " + c.APELLIDO;
        }

        private void Button_WOC1_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            c.setCarrera(materias, txtCarrera.Text);
            var AdminPanel = new AdminPanel(c);
            var sb = new SemBox("short", "Carrera agregada correctamente", "", "Aceptar");
            AdminPanel.Shown += (o, args) => { this.Hide(); sb.Show(); };

            sb.Shown += (o, args) => { AdminPanel.Enabled = false; };
            sb.FormClosed += (o, args) => { AdminPanel.Enabled = true; };
            AdminPanel.Show();
            /*new SemBox("short", "Carrera agregada correctamente", "", "Aceptar").Show();
            this.Hide();
            new Searcher(c).Show();*/
            Cursor.Current = Cursors.Arrow;
        }

        private void txtMaterias_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            var m = txtMateria.Text;
            if (!m.Equals(""))
            {
                materias.Add(m);
                lbMaterias.Items.Add(m);
                txtMateria.Text = "";
            }
            Cursor.Current = Cursors.Arrow; 
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            c.logout();
            var Login = new Login(c);
            //var sb = new SemBox("short", "¡Bienvenido de Regreso!", "", "Aceptar");
            Login.Shown += (o, args) => { this.Hide(); };

            //sb.Shown += (o, args) => { Searcher.Enabled = false; };
            //sb.FormClosed += (o, args) => { Searcher.Enabled = true; };
            Login.Show();
            Cursor.Current = Cursors.Arrow;
        }
    }
}
