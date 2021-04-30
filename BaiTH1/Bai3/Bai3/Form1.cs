using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai3
{
    public partial class Form1 : Form
    {
        int so1 = 0, so2 = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            int kq = so1 - so2;
            textBox3.Text = "" + kq;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            int kq = so1 + so2;
            textBox3.Text = "" + kq;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            try
            {
                so1 = int.Parse(textBox1.Text);
                
            }
            catch
            {
                MessageBox.Show("dữ liệu nhập vào phải là số", "Thông báo");
            }
            try
            {
                if (textBox2.Text != "")
                {
                    so2 = int.Parse(textBox2.Text);
                    int tong = so1 + so2;
                    int tru = so1 - so2;
                    int chia = so1 / so2;
                    int nhan = so1 * so2;
                    if (radioButton1.Checked == true)
                    {
                        textBox3.Text = "" + tong;
                    }
                    else if(radioButton2.Checked == true)
                    {
                        textBox3.Text = "" + tru;
                    }
                    else if (radioButton3.Checked == true)
                    {
                        textBox3.Text = "" + nhan;
                    }
                    else if (radioButton4.Checked == true)
                    {
                        textBox3.Text = "" + chia;
                    }
                }
            }
            catch
            {
                textBox3.Text = "";
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            int kq = so1 * so2;
            textBox3.Text = "" + kq;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            int kq = so1 / so2;
            textBox3.Text = "" + kq;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                
                so2 = int.Parse(textBox2.Text);
            }
            catch
            {
                MessageBox.Show("dữ liệu nhập vào phải là số", "Thông báo");
            }
            try
            {
                if (textBox1.Text != "")
                {
                    so1 = int.Parse(textBox1.Text);
                    int tong = so1 + so2;
                    int tru = so1 - so2;
                    int chia = so1 / so2;
                    int nhan = so1 * so2;
                    if (radioButton1.Checked == true)
                    {
                        textBox3.Text = "" + tong;
                    }
                    else if (radioButton2.Checked == true)
                    {
                        textBox3.Text = "" + tru;
                    }
                    else if (radioButton3.Checked == true)
                    {
                        textBox3.Text = "" + nhan;
                    }
                    else if (radioButton4.Checked == true)
                    {
                        textBox3.Text = "" + chia;
                    }
                }
            }
            catch
            {
                textBox3.Text = "";
            }
        }
    }
}
