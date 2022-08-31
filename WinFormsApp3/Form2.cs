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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
            
          
        }

        private void Nowy_Pojazd_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 shit = new Form3();
            shit.ShowDialog();
            
        }
        private void ZmodyfikujObecneDane(object sender, EventArgs e)
        {
            this.Hide();
            Form4 shit = new Form4();
            shit.ShowDialog();

        }
    }
}
