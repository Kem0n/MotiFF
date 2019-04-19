using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MotiFF
{
    public partial class Form1 : Form
    {
        List<string> list = new List<string>();

        public Form1()
        {
            InitializeComponent();

            timer1.Enabled=true;
            timer1.Start();
            timer1.Interval = 6000;

            ReadFile();

            timer2.Enabled = true;
            timer2.Start();
            timer2.Interval = 6000;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var a = list.Count;
            var b = new Random().Next(0,1);
            textBox1.Text = list[new Random().Next(0,list.Count)];
        }

        public void ReadFile()
        {
            if (File.Exists(@"..\..\Source\afo.txt"))
            {
                StreamReader reader = new StreamReader(@"..\..\Source\afo.txt");
                while (!reader.EndOfStream)
                {
                    list.Add(reader.ReadLine());
                }
                reader.Close();
            }
            else
            {
                MessageBox.Show("Файл не найден!", "Ошибка",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            label20.Text = countYear(Form_Start.number, 20).ToString() + " часов";
            label30.Text = countYear(Form_Start.number, 30).ToString() + " часов";
            label40.Text = countYear(Form_Start.number, 40).ToString() + " часов";
            label50.Text = countYear(Form_Start.number, 50).ToString() + " часов";
        }
        //TODO: Сделать корректировку на высокосные года.
        public int countYear(int number,int futureYear)
        {
            int currentYaer = Int32.Parse(DateTime.Now.Year.ToString());
            int result = currentYaer - number;

            int hour = 16;
            int dayInYaer = 365;

            if (futureYear > result)
            {
                switch (futureYear)
                {
                    case 20:
                        return (hour * dayInYaer) * 20;
                    case 30:
                        return (hour * dayInYaer) * 30;
                    case 40:
                        return (hour * dayInYaer) * 40;
                    case 50:
                        return (hour * dayInYaer) * 50;
                    default:
                        return 0;
                }
            }
            else
            {
                return 0;
            }
        }

        public int LivedInHour(DateTime date)
        {

        }
    }
}
