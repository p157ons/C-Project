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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
           
        }
        private void text_box_model_validation(object sender, CancelEventArgs e)
        {
            if (model_box.Text == "")
            {
                e.Cancel = true;
                MessageBox.Show("Typie Wpisz Model!");
            }
        }
        private void text_box_rokProdukcji_validation(object sender, CancelEventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(rok_produkcji_box.Text, "[^0-9]"))
            {
                MessageBox.Show("Wpisać Datę produkcji z zakresu 1950 - 2021");
                rok_produkcji_box.Text = "";
               // e.Cancel = true;
            }
        }
        private void Dodaj_Pojazd_Click(object sender, EventArgs e)
        {
            

                try
                {
                    string db_adress = "server = localhost; user id = root; password = 23099796; database = sakila";
                    MySqlConnection connect = new MySqlConnection(db_adress);
                    string nr_rejestracyjny = "INSERT INTO sakila.ciezarowka(model_pojazdu,nr_rejestracyjny,rok_produkcji) values('" + this.model_box.Text + "','" + this.nr_rejestracyjny_box.Text + "','" + this.rok_produkcji_box.Text + "'); ";
                    MySqlCommand wprowadz_rejestracje = new MySqlCommand(nr_rejestracyjny, connect);
                    connect.Open();
                    wprowadz_rejestracje.ExecuteReader();
                    MessageBox.Show("Dodano Pojazd do Bazy");
                    connect.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            
        }
        private void nr_rejestracyjny_box_TextChanged(object sender, EventArgs e)
        {

        }
        private void WrócDoForm2(object sender, EventArgs e)

        {
            Form2 f4 = new Form2();
            f4.Show();
            this.Close();
        }
    }
}
