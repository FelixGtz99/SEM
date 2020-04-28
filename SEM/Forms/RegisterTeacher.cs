﻿using System;
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
    public partial class RegisterTeacher : Form
    {
        List<Materia> Materias = new List<Materia>();
        Conexion c = null;
        public RegisterTeacher(Conexion c)
            
        {
            this.c = c;
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
            this.helpNombre.Region = new Region(path);
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

        }

        private void Nombre_GotFocus(object sender, EventArgs e)
        {
            lineNombre.BackColor = Color.FromArgb(13, 70, 255);
            labelNombre.ForeColor = Color.FromArgb(13, 70, 255);
            txtNombre.ForeColor = Color.White;
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
            txtNombre.ForeColor = Color.DimGray;
            lineNombre.BackColor = Color.White;
            labelNombre.ForeColor = Color.White;
        }

        private void Apellido_GotFocus(object sender, EventArgs e)
        {
            lineApellido.BackColor = Color.FromArgb(13, 70, 255);
            labelApellido.ForeColor = Color.FromArgb(13, 70, 255);
            txtApellido.ForeColor = Color.White;
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
            txtApellido.ForeColor = Color.DimGray;
            lineApellido.BackColor = Color.White;
            labelApellido.ForeColor = Color.White;
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
                c.guardarDocente(txtNombre.Text, txtApellido.Text, txtAlias.Text, Materias);
                //MessageBox.Show("Guardado Correctamente");
                SemBox sb = new SemBox("short", "Maestro registrado correctamente", "", "Aceptar");
                sb.Show();
                this.Hide();
                new Searcher(c).Show();
            }
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            var m = cbMaterias.SelectedItem.ToString();
            listMaterias.Items.Add(m);

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
            this.Hide();
            new Searcher(c).Show();
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            foreach (Materia materia in c.MATERIAS)
            {
                if (materia.ToString().Equals(listMaterias.SelectedItem.ToString()))
                {
                    Materias.Remove(materia);
                }
            }
            cbMaterias.Items.Add(listMaterias.SelectedItem.ToString());
            var index = listMaterias.SelectedIndex;
            listMaterias.Items.RemoveAt(index);
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
    }
}
