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
    public partial class Form1 : Form
    {
        MySqlConnection conn = new MySqlConnection("server = localhost; user id = root; database = mysql123");
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string user = txtuser.Text;
            string pass = txtpass.Text;
            // open connection
            conn.Open();
            // create cmd with sql and connections
            MySqlCommand cmd = new MySqlCommand("select count(*) from login123 where username ='" + txtuser.Text + "' and password = '" + txtpass.Text + "'", conn);

            int count = int.Parse(cmd.ExecuteScalar() + "");

            conn.Close();
            if(count> 0)
            {
                MessageBox.Show("usernaam and password are matched", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                Form3 nex1 = new Form3(txtuser.Text);
                nex1.ShowDialog();
            }
            else
            {
                MessageBox.Show("incorrect username and password", "alter", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }





            //MySqlDataAdapter sda = new MySqlDataAdapter("select count(*) from login123 where username ='" + txtuser.Text+"' and password = '" +txtpass.Text+ "'", conn);
            //DataTable dt = new DataTable();
            //sda.Fill(dt);
            //if (dt.Rows[0][0].ToString() == "1")
            //{
            //    MessageBox.Show("usernaam and password are matched", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    this.Hide();
            //    Form2 nex1 = new Form2();
            //    nex1.ShowDialog();
            //}

            //else
            //{
            //    MessageBox.Show("incorrect username and password", "alter", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registrerencs nex1 = new Registrerencs();
            nex1.ShowDialog();
            
                
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
