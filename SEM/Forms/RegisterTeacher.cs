using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SEM.items;

namespace SEM.Forms
{
    public partial class RegisterTeacher : Form
    {
        List<Materia> Materias = new List<Materia>();
        Conexion c = null;
        byte[] ImgByteA = null;
        String d = "";
        public RegisterTeacher(Conexion c, String d)
            
        {
            this.c = c;
            this.d = d;
            InitializeComponent();
            //Datos de la barra superior
            this.ActiveControl = panel2;
            btnClose.Height = panel2.Height;
            btnClose.Location = new Point(this.Width - btnClose.Width, 0);
            btnMin.Location = new Point(this.Width - btnClose.Width - btnMin.Width, 0);
            btnMin.Height = panel2.Height;
            panel2.Location = new Point(0, 0);
            panel2.Width = this.Width;

            listMaterias.HorizontalScrollbar = true;

            pictureBox1.ImageLocation = "https://i0.wp.com/umap.org/wp-content/uploads/2018/08/Logo_unison.png?fit=500%2C500";
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            var path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddEllipse(0, 0, label6.Width, label3.Height);
            this.label3.Region = new Region(path);
            this.label4.Region = new Region(path);
            this.label6.Region = new Region(path);
            this.label8.Region = new Region(path);

            this.helpNombre.Region = new Region(path);
            var path2 = new System.Drawing.Drawing2D.GraphicsPath();
            path2.AddEllipse(0, 0, imgMaestro.Width, imgMaestro.Height);
            this.imgMaestro.Region = new Region(path2);

            toolTip2.SetToolTip(this.pictureBox1, c.SEscuela);



            labelCarrera.Text = c.SCarrera;
            labelEstudiante.Text = c.NOMBRE + " " + c.APELLIDO;

            foreach (Materia materia in c.MATERIAS)
            {
                cbMaterias.Items.Add(materia.ToString());
            }

            //Eventos para cambiar el estado de los inputs
            txtNombre.GotFocus += Nombre_GotFocus;
            txtApellido.GotFocus += Apellido_GotFocus;
            txtAlias.GotFocus += Alias_GotFocus;
            txtNombre.LostFocus += Nombre_LostFocus;
            txtApellido.LostFocus += Apellido_LostFocus;
            txtAlias.LostFocus += Alias_LostFocus;
            if (d == "Editar")
            {
                this.BackColor = Color.FromArgb(222, 222, 222);
                panel1.BackColor = Color.White;
                ImgByteA = c.getImgM2();
                if (ImgByteA != null)
                {
                    using(MemoryStream productImageStream = new System.IO.MemoryStream(ImgByteA))
                    {
                        ImageConverter imageConverter = new System.Drawing.ImageConverter();
                        imgMaestro.Image = imageConverter.ConvertFrom(ImgByteA) as System.Drawing.Image;
                        
                    }
                }
                label9.Text = "Editar Maestro";
                label9.BackColor = Color.FromArgb(222, 222, 222);
                label9.ForeColor = Color.Black;
                label10.Text = "Asegúrese de que los datos sean correctos.";
                label10.ForeColor = Color.FromArgb(81, 81, 81);
                labelCarrera.ForeColor = Color.Black;
                labelEstudiante.ForeColor = Color.FromArgb(81, 81, 81);
                label11.Text = "Administrador";
                label11.ForeColor = Color.FromArgb(13, 70, 255);
                labelNombre.ForeColor = Color.FromArgb(81, 81, 81);
                labelApellido.ForeColor = Color.FromArgb(81, 81, 81);
                lineNombre.BackColor = Color.FromArgb(81, 81, 81);
                lineApellido.BackColor = Color.FromArgb(81, 81, 81);
                btnRegistrar.Text = "Guardar Nombres";
                btnRegistrar.Location = new Point(lineApellido.Location.X, btnRegistrar.Location.Y);
                btnRegistrar.Width = 300;

                label5.ForeColor = Color.FromArgb(81, 81, 81);
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                txtAlias.Visible = false;
                txtNombre.BackColor = Color.FromArgb(222, 222, 222);
                txtNombre.ForeColor = Color.FromArgb(100, 100, 100);
                txtApellido.BackColor = Color.FromArgb(222, 222, 222);
                txtApellido.ForeColor = Color.FromArgb(100, 100, 100);

                btnVolver.Visible = false;
                btnRA.ButtonColor = Color.White;
                btnRA.OnHoverButtonColor = Color.FromArgb(207, 207, 207);
                btnRA.TextColor = Color.FromArgb(48, 48, 48);
                btnRA.OnHoverTextColor = Color.FromArgb(33, 33, 33);
                btnRA.Image = SEM.Properties.Resources.backarrow;
                btnRA.Text = "Volver";

                btnCerrar.ButtonColor = Color.White;
                btnCerrar.OnHoverButtonColor = Color.FromArgb(207, 207, 207);
                btnCerrar.TextColor = Color.FromArgb(48, 48, 48);
                btnCerrar.OnHoverTextColor = Color.FromArgb(33, 33, 33);


                foreach (Maestro m in c.MAESTROS)
                {
                    if (m.ID.Equals(c.getIDMaestro()))
                    {
                        txtNombre.Text = m.NOMBRE;
                        txtApellido.Text = m.APELLIDO;
                        
                        c.getClases(c.getIDMaestro());
                        foreach(Materia materia in c.CLASES)
                        {
                            listMaterias.Items.Add(materia.ToString());
                            cbMaterias.Items.Remove(materia.ToString());
                        }
                    }
                }

            }
        }

        private void Nombre_GotFocus(object sender, EventArgs e)
        {
            if (d == "Editar")
            {
                lineNombre.BackColor = Color.FromArgb(13, 70, 255);
                labelNombre.ForeColor = Color.FromArgb(13, 70, 255);
                txtNombre.ForeColor = Color.Black;

            }
            else
            {
                lineNombre.BackColor = Color.FromArgb(13, 70, 255);
                labelNombre.ForeColor = Color.FromArgb(13, 70, 255);
                txtNombre.ForeColor = Color.White;

            }
            if (txtNombre.Text == "¿Cómo se llama tu maestro?")
            {
                txtNombre.Text = "";
            }
        }
        private void Nombre_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                txtNombre.Text = "¿Cómo se llama tu maestro?";
            }
            if(d == "Editar")
            {
                txtNombre.ForeColor = Color.FromArgb(81,81,81);
                lineNombre.BackColor = Color.FromArgb(81,81,81);
                labelNombre.ForeColor = Color.FromArgb(81,81,81);
            }
            else
            {
                txtNombre.ForeColor = Color.DimGray;
                lineNombre.BackColor = Color.White;
                labelNombre.ForeColor = Color.White;

            }
        }

        private void Apellido_GotFocus(object sender, EventArgs e)
        {
            if (d == "Editar")
            {
                lineApellido.BackColor = Color.FromArgb(13, 70, 255);
                labelApellido.ForeColor = Color.FromArgb(13, 70, 255);
                txtApellido.ForeColor = Color.Black;

            }
            else
            {
                lineApellido.BackColor = Color.FromArgb(13, 70, 255);
                labelApellido.ForeColor = Color.FromArgb(13, 70, 255);
                txtApellido.ForeColor = Color.White;

            }
            if (txtApellido.Text == "¿Cómo se apellida?")
            {
                txtApellido.Text = "";
            }
        }
        private void Apellido_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtApellido.Text))
            {
                txtApellido.Text = "¿Cómo se apellida?";
            }
            if (d == "Editar")
            {
                txtApellido.ForeColor = Color.FromArgb(81,81,81);
                lineApellido.BackColor = Color.FromArgb(81,81,81);
                labelApellido.ForeColor = Color.FromArgb(81,81,81);

            }
            else
            {
                txtApellido.ForeColor = Color.DimGray;
                lineApellido.BackColor = Color.White;
                labelApellido.ForeColor = Color.White;

            }
        }

        private void Alias_GotFocus(object sender, EventArgs e)
        {
            label2.BackColor = Color.FromArgb(13, 70, 255);
            label1.ForeColor = Color.FromArgb(13, 70, 255);
            txtAlias.ForeColor = Color.White;
            if (txtAlias.Text == "¿Tiene algún apodo?")
            {
                txtAlias.Text = "";
            }
        }
        private void Alias_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAlias.Text))
            {
                txtAlias.Text = "¿Tiene algún apodo?";
            }
            txtAlias.ForeColor = Color.DimGray;
            label2.BackColor = Color.White;
            label1.ForeColor = Color.White;
        }

        private void RegisterTeacher_Load(object sender, EventArgs e)
        {

        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            String Errores = " ";
            if (txtNombre.Text.Length == 0 || txtApellido.Text.Length == 0)
            {
                Errores = "Nombre y apellido no pueden estar vacios";
            }
            if (txtNombre.Text.Any(char.IsDigit) || txtApellido.Text.Any(char.IsDigit))
            {
                Errores = Errores + Environment.NewLine + "Nombre y Apellido deben de ser puras letras";

            }
            if (listMaterias.Items.Count == 0)
            {
                Errores = Errores + Environment.NewLine + "El maestro debe contar con almenos una materia";
            }
            if (!Errores.Equals(" "))
            {
                //MessageBox.Show(Errores);
                SemBox sb = new SemBox("longerror", "Error en el regisro", Errores, "Aceptar");
                sb.Show();
            }
            else
            {
                if (d == "Editar")
                {
                    c.updateDocente(txtNombre.Text, txtApellido.Text, txtAlias.Text, Materias, ImgByteA);
                    SemBox sb = new SemBox("short", "Maestro editado correctamente", "", "Aceptar");
                    sb.Show();
                    this.Hide();
                    new AdminPanel(c).Show();
                }
                else
                {
                    c.guardarDocente(txtNombre.Text, txtApellido.Text, txtAlias.Text, Materias, ImgByteA);
                    //MessageBox.Show("Guardado Correctamente");
                    SemBox sb = new SemBox("short", "Maestro registrado correctamente", "", "Aceptar");
                    sb.Show();
                    this.Hide();
                    new Searcher(c).Show();
                }
                
            }
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            var m = cbMaterias.SelectedItem.ToString();
            listMaterias.Items.Add(m);
            if (d == "Editar")
            {
                c.guardarClaseDocente(c.getIDMateria(), c.getIDMaestro());
            }
            foreach (Materia materia in c.MATERIAS)
            {
                if (materia.ToString().Equals(m))
                {
                    Materias.Add(materia);
                }
            }
            cbMaterias.Items.Remove(m);
        
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            if (d == "Editar")
            {
                this.Hide();
                new AdminPanel(c).Show();
            }
            else
            {
                this.Hide();
                new Searcher(c).Show();
            }
            
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            var index = listMaterias.SelectedItem.ToString();
            c.SMateria = index;
            if (d == "Editar")
            {
                c.borrarClaseDocente(c.getIDMateria(), c.getIDMaestro());
            }
            foreach (Materia materia in c.MATERIAS)
            {
                if (materia.ToString().Equals(listMaterias.SelectedItem.ToString()))
                {
                    Materias.Remove(materia);
                }
            }
            cbMaterias.Items.Add(listMaterias.SelectedItem.ToString());

            listMaterias.Items.Remove(index);
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text== "¿Cómo se llama tu maestro?")
            {
                txtNombre.Text = " ";
            }
        }

        private void BtnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Subir_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenFileDialog1 = new OpenFileDialog();
            try
            {
                OpenFileDialog1.Filter = "Archivos de imágen(*.jpg)(*.jpeg)|*.jpg;*.jpeg|PNG(*.png)|*.png";
                if (OpenFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    String imagen = OpenFileDialog1.FileName;
                    Console.WriteLine("Aqui estan el string de la imagen: " + imagen);

                    imgMaestro.Image = Image.FromFile(imagen);
                    imgMaestro.SizeMode = PictureBoxSizeMode.Zoom;

                    using (FileStream pgFileStream = new FileStream(imagen, FileMode.Open, FileAccess.Read))
                    {

                        using (BinaryReader pgReader = new BinaryReader(new BufferedStream(pgFileStream)))
                        {


                            ImgByteA = pgReader.ReadBytes(Convert.ToInt32(pgFileStream.Length));
                            //command.CommandText = "insert into abc (id, image) VALUES ('65', @Image)";

                            //NpgsqlParameter param = command.CreateParameter();
                            //param.ParameterName = "@Image";
                            //param.NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Bytea;
                            //param.Value = ImgByteA;
                            //Console.WriteLine("Aqui estan los bytes: " + Encoding.Default.GetString(ImgByteA));
                            //command.Parameters.Add(param);

                            //command.Parameters.Add(new NpgsqlParameter("Image", ImgByteA));
                            //command.Parameters.Add("@Image", NpgsqlTypes.NpgsqlDbType.Bytea).Value = ImgByteA;

                            //command.ExecuteNonQuery();


                        }
                    }

                }
                /*string sQL = "SELECT image from abc WHERE id = 65";
                using (var command = new NpgsqlCommand(sQL, conn))
                {
                    byte[] productImageByte = null;
                    //conn.Open();
                    var rdr = command.ExecuteReader();
                    if (rdr.Read())
                    {
                        productImageByte = (byte[])rdr[0];
                    }
                    rdr.Close();
                    if (productImageByte != null)
                    {
                        using (MemoryStream productImageStream = new System.IO.MemoryStream(productImageByte))
                        {
                            ImageConverter imageConverter = new System.Drawing.ImageConverter();
                            pictureBox3.Image = imageConverter.ConvertFrom(productImageByte) as System.Drawing.Image;
                        }
                    }
                }*/

            }
            catch (Exception ex)
            {
                SemBox sb = new SemBox("longerror", "El archivo seleccionado no es un tipo de imagen válido", "","Aceptar");
                    sb.Show();


            }
        }

        private void BtnRA_Click(object sender, EventArgs e)
        {
            if (d == "Edit")
            {
                this.Hide();
                new RA(c).Show();
            }
            else
            {
                this.Hide();
                new AdminPanel(c).Show();
            }
            
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            c.logout();

            this.Hide();
            new Login(c).Show();
        }

        private void Button_WOC1_Click(object sender, EventArgs e)
        {
            ImgByteA = null;
            imgMaestro.Image = imgMaestro.InitialImage;
        }
    }
}
