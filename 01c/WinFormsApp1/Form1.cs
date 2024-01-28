using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbl1.Text = "정승민";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lbl2.Text = "두원공과대학교 19학번";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lbl3.Text = "전화번호는 010-5772-6604";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            lbl1.Text = "";
            lbl2.Text = "";
            lbl3.Text = "";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
