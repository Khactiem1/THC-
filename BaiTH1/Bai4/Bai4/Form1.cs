using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.ForeColor = radioButton4.ForeColor;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.ForeColor = radioButton3.ForeColor;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.ForeColor = radioButton2.ForeColor;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox2.Text = textBox1.Text;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.ForeColor = radioButton1.ForeColor;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true)
            {
                textBox2.Font = new Font(textBox2.Font.Name, textBox2.Font.Size, textBox2.Font.Style ^ FontStyle.Bold);
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                textBox2.Font = new Font(textBox2.Font.Name, textBox2.Font.Size, textBox2.Font.Style ^ FontStyle.Italic);
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                textBox2.Font = new Font(textBox2.Font.Name, textBox2.Font.Size, textBox2.Font.Style ^ FontStyle.Underline);
            }
        }
    }
}
