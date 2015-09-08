using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeByNetSpeed
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //if ((e.KeyChar <= 48 || e.KeyChar >= 57) && (e.KeyChar != 8) && (e.KeyChar != 46))
                //    e.Handled = true;  

                double speed = Convert.ToDouble(this.textBox1.Text.Trim());
                double size = Convert.ToDouble(this.textBox2.Text.Trim());
                double kbsize = size * 1024;

                double time = kbsize / speed;
                double minutes = time / 60;
                int hour =Convert.ToInt32(minutes / 60);
                int day = hour / 24;
                int hour1 = hour % 24;
                int minutes1 = Convert.ToInt32( minutes % 60);
                int second = Convert.ToInt32(time % 60);
                label4.Text =day+"天"+hour1.ToString() + "小时" + minutes1 + "分钟" + second + "秒";
            }
            catch {
                MessageBox.Show("不能为空！");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                double MB = Convert.ToDouble(textBox4.Text.Trim());
                textBox1.Text = (MB * 1024).ToString();

            }
            catch {
                MessageBox.Show("请输入正确的数字！");
            
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                double GB = Convert.ToDouble(textBox3.Text.Trim());
                textBox2.Text = (GB * 1024).ToString();
            }
            catch {

                MessageBox.Show("请输入正确的数字！");
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                double bandwidth = Convert.ToDouble(textBox5.Text.Trim());
                textBox1.Text = (bandwidth * 128).ToString();
            }
            catch {
                MessageBox.Show("请输入正确的数字");
            }
        }
    }
}
