using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.username = Convert.ToString(textBox2.Text);
            login.password = Convert.ToString(textBox1.Text);
            string pass = login.password;
            if (string.Compare(pass, "pbo123") == 0)               
            {
                Form2 VILAS = new Form2();
                VILAS.Show();
                this.Hide();
            } 
        }
    }
}
