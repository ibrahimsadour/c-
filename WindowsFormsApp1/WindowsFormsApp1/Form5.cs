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
    public partial class Form5 : Form
    {
        MySqlConnection con = new MySqlConnection(@"server = localhost; user id = root; database = mysql123");
        public Form5()
        {
           

            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            dgvmelding.DataSource = loadform();
        }
        public DataTable loadform()



        {


            con.Open();
            DataTable dt = new DataTable();

            String query = "SELECT * FROM meldingdata";

            MySqlCommand cmd = new MySqlCommand(query, con);

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            da.Fill(dt);

            con.Close();

            return dt;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //Form3 nex1 = new Form3();
            //nex1.ShowDialog();
        }

        private void dgvmelding_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            DataTable dt = new DataTable();

            String query = "SELECT * FROM meldingdata Where id LIKE '%" + txtzoek.Text + "%'";

            MySqlCommand cmd = new MySqlCommand(query, con);

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            da.Fill(dt);

            con.Close();
            dgvmelding.DataSource = dt;
        }
    }
}
