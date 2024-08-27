using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class exerpages : Form
    {
        public exerpages()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            exerpage1 frmMain = new exerpage1();
            this.Hide();
            frmMain.Show();
        }
    }
}
