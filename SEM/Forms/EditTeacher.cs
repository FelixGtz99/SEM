﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SEM.Forms;
using SEM.items;

namespace SEM.Forms
{
    public partial class EditTeacher : Form
    {
        Conexion c = null;
        String pf = " ";
        public EditTeacher(Conexion c, String pf)
        {
            this.pf = pf;
            this.c = c;
            InitializeComponent();
            //Datos de la barra superior
            //this.ActiveControl = panel2;
            btnClose.Height = panel2.Height;
            btnClose.Location = new Point(this.Width - btnClose.Width, 0);
            panel2.Location = new Point(0, 0);
            panel2.Width = this.Width;

            titleBox.SelectAll();
            titleBox.SelectionAlignment = HorizontalAlignment.Center;
            titleBox.Text = c.SMaestro;
            listMaterias.Items.Clear();
            c.getClases(c.getIDMaestro());
            foreach (Materia materia in c.MATERIAS)
            {
                cbMaterias.Items.Add(materia.ToString());
            }
            foreach (Materia materia in c.CLASES)
            {
                cbMaterias.Items.Remove(materia.ToString());
                //Mexicanada ¿Donde?
                listMaterias.Items.Add(materia);
            }

            //Datos del tooltip
            var path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddEllipse(0, 0, helpAdd.Width, helpAdd.Height);
            this.helpAdd.Region = new Region(path);



        }

        private void titleLabel_Click(object sender, EventArgs e)
        {

        }

        private void defButton_Click(object sender, EventArgs e)
        {
            this.Close();
            /*this.Hide();
            if (pf.Equals("admin"))
            {
                
                new AdminPanel(c).Show();
            }
            else {
                new Evaluations(c).Show();
            }*/

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var m= cbMaterias.SelectedItem.ToString();
            c.SMateria = m;
            c.guardarClaseDocente( c.getIDMateria(), c.getIDMaestro());
          
            listMaterias.Items.Add(m);
            cbMaterias.Items.Remove(m);
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
