using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace WindowsFormsApplication1
{
    public partial class exerpage1 : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();
        public exerpage1()
        {
            InitializeComponent();
            con.ConnectionString = @"Data Source=.;Initial Catalog=learn;Integrated Security=True";
        }

        private void exerpage1_Load(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            

            if (name.Text == "" || id.Text == "" || Q1.Text == "" || Q2.Text == "" || Q3.Text == "" || Q4.Text == "" )
            {
                MessageBox.Show("fields are empty", "warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                dgv1.Rows.Add(name.Text, id.Tag, Q1.Text, Q2.Text, Q3.Text, Q4.Text);
                Cleartxt();

              
                
            }

        }
        void Cleartxt()
        {
            name.Clear();
            id.Clear();
            Q1.Clear();
            Q2.Clear();
            Q3.Clear();
            Q4.Clear();
            

        }
         private void refreshdata()
        {
            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {


SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=learn;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("select * from exerpag1", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            dgv1.DataSource = dt;

        }
    }
}
