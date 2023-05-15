using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
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

        private void button1_Click(object sender, EventArgs e)
        {
            var left = Convert.ToInt32(textBox1.Text);
            var right = Convert.ToInt32(textBox2.Text);

            textBox3.Text = Convert.ToString((left + right));
            textBox4.Text = Convert.ToString(left - right);
            textBox5.Text = Convert.ToString(left * right);
            textBox6.Text = Convert.ToString(left / right);

        }


    }
}