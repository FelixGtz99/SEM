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
        String notif;
        public AdminPanel(Conexion c)
        {
            this.c = c;
            InitializeComponent();
            c.getMaestros();
            c.getMaterias();
            c.getCarreras();
            c.getEscuela();
            c.getEscuelas();
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
          
                    pictureBox1.ImageLocation = c.getlogo();
              
            
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
            if (notifications.Rows.Count > 0)
            {
                Notifications_CellClick(this.notifications, new DataGridViewCellEventArgs(0, 0));
                btnVer.Enabled = true;
                btnVer.ButtonColor = Color.FromArgb(13, 70, 255);
                btnEliminarnotif.Enabled = true;
                btnEliminarnotif.ButtonColor = Color.FromArgb(255, 13, 70);
            }
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
            cbMaterias.SelectedIndex = 0;
        }

        private void cbMaestros_SelectedIndexChanged(object sender, EventArgs e)
        {
            c.SMaestro = cbMaestros.SelectedItem.ToString();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            var RegisterTeacher = new RegisterTeacher(c, "Editar");
            //var sb = new SemBox("short", "¡Bienvenido de Regreso!", "", "Aceptar");
            RegisterTeacher.Shown += (o, args) => { this.Hide(); };

            //sb.Shown += (o, args) => { Searcher.Enabled = false; };
            //sb.FormClosed += (o, args) => { Searcher.Enabled = true; };
            RegisterTeacher.Show();
            /*new RegisterTeacher(c,"Editar").Show();
            this.Hide();*/

        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            
                
            
            
                if (txtMaterias.Text!=" ")
                {
                    c.setMateria(txtMaterias.Text);
                   
                    c.getMaterias();
                    CBMaterias();
                    txtMaterias.Text = " ";
                }
               
            
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            c.logout();
            var Login = new Login(c);
            //var sb = new SemBox("short", "¡Bienvenido de Regreso!", "", "Aceptar");
            Login.Shown += (o, args) => { this.Hide(); };

            //sb.Shown += (o, args) => { Searcher.Enabled = false; };
            //sb.FormClosed += (o, args) => { Searcher.Enabled = true; };
            Login.Show();
            /*this.Hide();
            new Login(c).Show();*/
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_WOC1_Click(object sender, EventArgs e)
        {
            var materia = cbMaterias.SelectedItem.ToString();
            c.SMateria = materia;
            txtMaterias.Text = materia;
            btnAñadir.Visible = false;
            editPanel.Visible = true;
            editPanel.Location = new Point(1017, 415);
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            var EditAdmin = new EditAdmin(c);
            //var sb = new SemBox("short", "¡Bienvenido de Regreso!", "", "Aceptar");
            EditAdmin.Shown += (o, args) => { this.Hide(); };

            //sb.Shown += (o, args) => { Searcher.Enabled = false; };
            //sb.FormClosed += (o, args) => { Searcher.Enabled = true; };
            EditAdmin.Show();
            /*this.Hide();
            new EditAdmin(c).Show();*/
        }

        private void button_WOC4_Click(object sender, EventArgs e)
        {
            c.deleteMateria();
            c.getMaterias();
            CBMaterias();
        }

        private void Notifications_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var index = e.RowIndex;
                DataGridViewRow SelectedRow = notifications.Rows[index];
                /* c.SMateria = SelectedRow.Cells[0].Value.ToString();
                 c.SMaestro = SelectedRow.Cells[1].Value.ToString();
                 Comentario = SelectedRow.Cells[2].Value.ToString();
                 Calificacion = SelectedRow.Cells[3].Value.ToString();*/
                string selectedActivity = SelectedRow.Cells[0].Value.ToString();
                notif = SelectedRow.Cells[0].Value.ToString();
                if (selectedActivity.Contains("maestro:"))
                {
                    btnVer.Enabled = true;
                    btnVer.ButtonColor = Color.FromArgb(13, 70, 255);
                    btnEliminarnotif.Enabled = true;
                    btnEliminarnotif.ButtonColor = Color.FromArgb(255, 13, 70);
                    int begin = selectedActivity.IndexOf(':');
                    int end = selectedActivity.IndexOf('.');
                    int selectLength = end - begin - 2;
                    c.SMaestro = selectedActivity.Substring(begin + 2, selectLength);
                }
                else
                {
                    btnVer.Enabled = false;
                    btnVer.ButtonColor = Color.FromArgb(130, 170, 255);
                    btnEliminarnotif.Enabled = false;
                    btnEliminarnotif.ButtonColor = Color.FromArgb(255, 130, 170);
                }

            }
            catch (Exception)
            {


            }

        }

        private void BtnVer_Click(object sender, EventArgs e)
        {
            var RegisterTeacher = new RegisterTeacher(c,"Editar");
            //var sb = new SemBox("short", "¡Bienvenido de Regreso!", "", "Aceptar");
            RegisterTeacher.Shown += (o, args) => { this.Hide(); };

            //sb.Shown += (o, args) => { Searcher.Enabled = false; };
            //sb.FormClosed += (o, args) => { Searcher.Enabled = true; };
            RegisterTeacher.Show();
            /*new RegisterTeacher(c, "Editar").Show();
            
            this.Hide();*/
            //MessageBox.Show(c.SMaestro);

        }

        private void BtnEliminarnotif_Click(object sender, EventArgs e)
        {
            c.deleteNotificacion(notif);
            notifications.DataSource = c.getNotifications();
            notifications.Refresh();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            c.updateMateria(txtMaterias.Text);
            c.getMaterias();
            CBMaterias();
            txtMaterias.Text = "";
            editPanel.Visible = false;
            btnAñadir.Visible = true;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            editPanel.Visible = false;
            btnAñadir.Visible = true;
            txtMaterias.Text = "";
        }
    }
}
