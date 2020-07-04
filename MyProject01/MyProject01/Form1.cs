using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyProject01
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void jia_Click(object sender, EventArgs e)
        {
            var x = int.Parse(this.diyigeshu.Text);
            var y = int.Parse(this.diergeshu.Text);
            var z = x + y;
            this.label1.Text = z.ToString();
        }

        private void jian_Click(object sender, EventArgs e)
        {
            var x = int.Parse(this.diyigeshu.Text);
            var y = int.Parse(this.diergeshu.Text);
            var z = x - y;
            this.label1.Text = z.ToString();
        }

        private void cheng_Click(object sender, EventArgs e)
        {
            var x = int.Parse(this.diyigeshu.Text);
            var y = int.Parse(this.diergeshu.Text);
            var z = x * y;
            this.label1.Text = z.ToString();
        }

        private void chu_Click(object sender, EventArgs e)
        {
            var x = int.Parse(this.diyigeshu.Text);
            var y = int.Parse(this.diergeshu.Text);
            var z = 0;
            if (y != 0) {
                z = x / y;
                this.label1.Text = z.ToString();
            }
            else 
            this.label1.Text = z.ToString("除数不能为零！！！");
        }
    }
}
