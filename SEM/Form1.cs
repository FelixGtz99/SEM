using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace SEM
{
    public partial class Form1 : Form
    {
        public NpgsqlConnection conexion = new NpgsqlConnection();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conexion.ConnectionString = "Username = AdminDB; Password=1234; Host = localhost; Port = 5432; Database = SEM";
               conexion.Open();
                MessageBox.Show("Conexion correcta");
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
              
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();

                    MessageBox.Show("Conexion cerrada ");
                }
                else {
                    MessageBox.Show("No hay conexion");
                }
            }
            catch (Exception x)
            {

                MessageBox.Show(x.Message);
                
            }
        }
    }
}
