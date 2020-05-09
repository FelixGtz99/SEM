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
    public partial class AdminPanel : Form
    {
        Conexion c = null;
        public AdminPanel(Conexion c)
        {
            this.c = c;
            InitializeComponent();
            c.getMaestros();
            c.getMaterias();
            c.getCarreras();
            c.getEscuela();
            CBMaestros();
            CBMaterias();
            lbCarrera.Text = c.SCarrera;
            lbEscuela.Text = c.SEscuela;
            lbNombre.Text = c.NOMBRE + " " + c.APELLIDO;
            if (cbMaterias.Items.Count!=0)
            {   
                cbMaterias.SelectedIndex = 0;
            }
            if (cbMaestros.Items.Count!=0)
            {
                cbMaestros.SelectedIndex = 0;
            }
            
           
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

            notifications.DataSource = c.getNotifications();
            //this.notifications.Rows.Add("El maestro José Luis Ochoa Hernández ha recibido muchos votos negativos en su perfil.");
            //this.notifications.Rows.Add("El promedio del maestro Guzmán Gerardo Alfonso Sánchez Schmitz ha bajado de 6.0.");
            //this.notifications.Rows.Add("Se ha añadido al maestro Jesús Daniel Alfaro Soto.");
            //this.notifications.Rows.Add("El maestro Alonso Pérez Soltero ha recibido muchos votos negativos en su perfil");
            //this.notifications.Rows.Add("El promedio del maestro Raquel Torres Peralta ha bajado de 6.0.");
            //this.notifications.Rows.Add("Se ha añadido al maestro René Francisco Navarro Hernández.");
            
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        public void CBMaterias()
        {

            cbMaterias.Items.Clear();

            foreach (Materia materia in c.MATERIAS)
            {
                cbMaterias.Items.Add(materia);
            }

        }
        public void CBMaestros()
        {

            cbMaestros.Items.Clear();

            foreach (Maestro maestro in c.MAESTROS)
            {
                cbMaestros.Items.Add(maestro);
            }

        }

        private void cbMaterias_SelectedIndexChanged(object sender, EventArgs e)
        {
            c.SMateria = cbMaterias.SelectedItem.ToString();
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
          
            c.deleteMateria();
            c.getMaterias();
            CBMaterias();
        }

        private void cbMaestros_SelectedIndexChanged(object sender, EventArgs e)
        {
            c.SMaestro = cbMaestros.SelectedItem.ToString();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            this.Hide();
            new RegisterTeacher(c,"Editar").Show();
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            c.setMateria(txtMaterias.Text);
            txtMaterias.Text = " ";
            c.getMaterias();
            CBMaterias();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            c.logout();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
