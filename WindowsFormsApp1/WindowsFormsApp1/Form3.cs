using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        MySqlConnection cwww = new MySqlConnection(@"server = localhost; user id = root; database = mysql123");
        public Form3(string get)
        {
            
            InitializeComponent();
            label4.Text = get;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 nex1 = new Form1();
            nex1.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            cwww.Open();

            string StrNaam = txtmeldingen.Text;
            string Stand = listBox1.Text;
            string Bericht = listBox2.Text;
            string meldingen1 = "insert into meldingdata (allemeldingen, locatie, Soort, Behandelaar) values (@param1, @param2, @param3, @param4)";
            MySqlCommand cmd = new MySqlCommand(meldingen1, cwww);
            
            cmd.Parameters.AddWithValue ("@param1", StrNaam);
            cmd.Parameters.AddWithValue("@param2", Stand);
            cmd.Parameters.AddWithValue("@param3", Bericht);
            cmd.Parameters.AddWithValue("@param4", label4.Text);
           
            cmd.ExecuteNonQuery();


            //String meldingen1 = "INSERT INTO meldingdata (allemeldingen) VALUES(@allemeldingen)";
            //MySqlCommand cmd = new MySqlCommand(meldingen1, cwww);


            //cmd.Parameters.AddWithValue("@allemeldingen", txtmeldingen.Text);
            //cmd.Parameters.AddWithValue("@locatie", listBox1);
            //cmd.Parameters.AddWithValue("@Soort", listBox2);
            //cmd.ExecuteNonQuery();




            cwww.Close();
            MessageBox.Show("jouw melding is opgeslagen");

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            
          
        }

        private void btnnext5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 next1 = new Form5();
            next1.ShowDialog();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
