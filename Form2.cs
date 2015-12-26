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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            Random rand = new Random();
            int x = rand.Next(20, 600);
            int y = rand.Next(10, 300);
            button2.Location = new Point(x, y);
            MessageBox.Show("哈哈！\n早知道你会这么做的，你要下手快点！");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("我也爱你，宝贝，么么");
            Form3 form3 = new Form3();
            this.Hide();
            form3.Show();
        }
    }
}
