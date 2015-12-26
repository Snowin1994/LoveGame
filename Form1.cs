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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button3_Click_1(object sender, EventArgs e)
        {
            String username = "宝贝";
            String password = "07300524";
            if(username.Equals(textBox1.Text.ToString())&&password.Equals(textBox2.Text.ToString()))
            {
                MessageBox.Show("终于！终于！猜对了！你个熊孩子");
                this.Hide();
                Form2 form2 = new Form2();
                form2.Show();
            }
            else if(!username.Equals(textBox1.Text.ToString()) &&password.Equals(textBox2.Text.ToString()))
            {
                MessageBox.Show("名字猜错了，好好看看提示吧^_^");
            }
            else if (username.Equals(textBox1.Text.ToString()) &&!password.Equals(textBox2.Text.ToString()))
            {
                MessageBox.Show("密码不对哟");
            }
            else if (!username.Equals(textBox1.Text.ToString()) &&!password.Equals(textBox2.Text.ToString()))
            {
                MessageBox.Show("都不对！\n笨蛋！");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("真的离开吗？> <", "乖乖不要呀！", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                MessageBox.Show("宝贝再见");
                this.Close();
            }
            else
            {
                MessageBox.Show("宝贝你真好");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("名字！名字！\n你名字！");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("就知道你会猜错，想想我怎么叫你的");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("我还有更喜欢的称呼，再想想，宝贝");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("生日生日，一共八位，你生日还是我的生日呢？这是个问题？");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("都告诉你了，你生日我生日，就不能都填上吗？乖乖");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("-_-||\n上一个都告诉你了");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("有顺序的，宝贝，再填错就没有提示喽！");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            MessageBox.Show("要是你打开这个时还没有猜到名字和密码，唉！你是要气死我呀。来来，亲我一下，问你就告诉你，不然你休想知道后面还有什么");
        }
    }
}
