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
    public partial class Form2 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=learn;Integrated Security=True");

       
     
       
        public Form2()
        {
            InitializeComponent();
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if ((textBox1.Text == "") || (textBox2.Text == "") || (textBox3.Text == "") || (textBox4.Text == "") || (textBox5.Text == "") || (textBox6.Text == "") || (comboBox1.Text == "") || (comboBox2.Text == "") || (comboBox3.Text == ""))
            {
                MessageBox.Show("يرجى تعبئة القائمة");
            }
            else
            {



                string sql_Query = "insert into sick values (@id,@namefirst ,@namesecond ,@namelast,@age,@gerend,@phone,@section,@dector)";
                SqlCommand cmd = new SqlCommand(sql_Query, con);
                cmd.Parameters.AddWithValue("@id", textBox1.Text);
                cmd.Parameters.AddWithValue("@namefirst", textBox2.Text);
                cmd.Parameters.AddWithValue("@namesecond", textBox3.Text);
                cmd.Parameters.AddWithValue("@namelast", textBox4.Text);
                cmd.Parameters.AddWithValue("@age", textBox5.Text);
                cmd.Parameters.AddWithValue("@gerend", comboBox1.Text);
                cmd.Parameters.AddWithValue("@phone", textBox6.Text);
                cmd.Parameters.AddWithValue("@section", comboBox2.Text);
                cmd.Parameters.AddWithValue("@dector", comboBox3.Text);
               
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("تمت عملية الحفظ للبيانات المريض بنجاح");


            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sql_Query = "select * from sick where id = @id ";
            SqlCommand cmd = new SqlCommand(sql_Query, con);
            cmd.Parameters.AddWithValue("@id", textBox1.Text );
           
            SqlDataReader r;
            con.Open();
            r = cmd.ExecuteReader();
            if(r.HasRows== true)
            {
                while(r.Read())
                {
                    textBox2.Text = r["namefirst"].ToString();
                    textBox3.Text = r["namesecond"].ToString();
                    textBox4.Text = r["namelast"].ToString();
                    textBox5.Text = r["age"].ToString();
                    textBox6.Text = r["phone"].ToString();
                    comboBox1.Text= r["gerend"].ToString();
                    comboBox2.Text= r["section"].ToString();
                    comboBox3.Text = r["dector"].ToString();
                    textBox2.Text = r["namesecond"].ToString();
                    
                }
                
            }
            else
            {
                MessageBox.Show("المريض غير مسجل في العيادة سابقا");
            }
            con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
           
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

            Form3 frmMain = new Form3();
            this.Hide();
            frmMain.Show();

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            /*
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            */
        }

        private void button4_Click_2(object sender, EventArgs e)
        {

            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox4.Clear();


        }
    }
}
