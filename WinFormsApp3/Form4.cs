using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySqlConnector;

namespace WinFormsApp3
{
    public partial class Form4 : Form
    {


        public Form4()
        {
            InitializeComponent();
            Bind();
           
        }

        private void Bind()
        {
            DataTable dt = new DataTable();

            string connectionString = "server = localhost; user id = root; password = 23099796; database = sakila";
            using (MySqlConnection cn = new MySqlConnection(connectionString))
            {
                MySqlCommand cmd = new MySqlCommand("select * from ciezarowka", cn);
                cn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                dt.Load(reader);
                dataGridView1.DataSource = dt;

            }

        }




        private void WrócDoForm2(object sender, EventArgs e)

        {
            Form2 f4 = new Form2();
            f4.Show();
            this.Close();
        }
    }
}
