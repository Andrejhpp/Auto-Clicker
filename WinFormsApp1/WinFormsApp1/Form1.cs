using System;

using System.Diagnostics;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        bool Clicker = false;
        int time = 0;
        int i = 0;
        int n = 0;

        int t_1 = 10;
        int t_2 = 0;
        int t_3 = 100000000;

        int time0 = (int)(DateTime.Now - DateTime.Today).TotalSeconds;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label5.Text = "a: диапозон между нажатиями клавиш(мс)\n" +
                "b: через сколько включить (сек)\n" +
                "c: через сколько выключить (сек).";
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            try
            {
                t_1 = int.Parse(textBox2.Text);
            }
            catch (System.FormatException)
            {
                t_1 = 10;
            }

            try
            {
                t_2 = int.Parse(textBox3.Text);
            }
            catch (System.FormatException)
            {
                t_2 = 0;
            }

            try
            {
                t_3 = int.Parse(textBox4.Text);
            }
            catch (System.FormatException)
            {
                t_3 = 10000000;
            }
            
            switch (timer1.Enabled)
            {
                case false:
                    timer1.Start();
                    time = 0;
                    button3.Text = "Выключить автокликер";
                    button3.Update();
                    timer1.Interval = t_1;
                    Thread.Sleep(t_2*1000);
                    time0 = (int)(DateTime.Now - DateTime.Today).TotalSeconds;
                    break;

                case true:
                    timer1.Stop();
                    button3.Text = "Включить автокликер";
                    button3.Update();
                    break;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Help_b_Click(object sender, EventArgs e)
        {
            text_help.Text = "Буквенные клавиши и клавиши\n" +
                "с цифрами вводите просто,\n" +
                "а клавиши типа: ENTER, SPACE\n" +
                "такие клавиши вводите в скобках {}\n" +
                "заглавными буквами,\n" +
                "все необходимые клавиши\n" +
                "вводите по порядку.\n" +
                "*Из-за нажатия кнопок\n" +
                "автокликер не выключается\n" +
                "мышью.Нажимайте Enter!";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            i++;
            time = i * timer1.Interval;

            if (((int)(DateTime.Now - DateTime.Today).TotalSeconds) >= time0 + t_3)
            {
                button3.Text = "Включить автокликер";
                timer1.Stop();
            }

            string str = (n).ToString();
            try
            {
                SendKeys.Send(textBox1.Text);
            }
            catch (System.ArgumentException)
            {
                timer1.Stop();
                button3.Text = "Включить автокликер";
                MessageBox.Show("Неправильно введены клавиши!!");
            }

        }

        private void timer2_Tick(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

    }
}
