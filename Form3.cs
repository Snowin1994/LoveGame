using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ForMyLove
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("在你男朋友面前，轻轻的闭上眼睛5秒钟");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("对男朋友说三遍“我爱你”！");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("弹你男朋友个脑倍儿");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("让你男朋友点一个");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("深情的看着你男朋友10秒钟");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("要是你真的选中这个，算你机智，哼！");
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("哈哈，想逃？\n终极考验：\n主动亲吻你男朋友30秒!");
            if (DialogResult.None == MessageBox.Show("I LOVE YOU FOREVER!"))
            {
               
            }
            else
            {
                MessageBox.Show("哈哈，想逃？\n终极考验：\n主动亲吻你男朋友30秒!");
                this.Hide();
                Form4 form4 = new Form4();
            }
        }
    }
}
