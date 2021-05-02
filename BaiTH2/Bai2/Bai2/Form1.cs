using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            while(listBox1.SelectedIndices.Count > 0)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndices[0]);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = int.Parse(textBox1.Text);
            listBox1.Items.Add(x);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.RemoveAt(0);
            listBox1.Items.RemoveAt(listBox1.Items.Count - 1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sum = 0;
            for(int i = 0; i < listBox1.Items.Count; i++)
            {
                int x = (int)listBox1.Items[i];
                sum += x;
            }
            MessageBox.Show("Tổng là: " + sum);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                int x = (int)listBox1.Items[i] + 2;
                listBox1.Items[i] = x;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                int x = (int)listBox1.Items[i] * (int)listBox1.Items[i];
                listBox1.Items[i] = x;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            listBox1.SelectedIndex = -1;
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                if((int)listBox1.Items[i] % 2 == 0)
                {
                    listBox1.SelectedIndex = i;
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            listBox1.SelectedIndex = -1;
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                if ((int)listBox1.Items[i] % 2 != 0)
                {
                    listBox1.SelectedIndex = i;
                }
            }
        }
    }
}
