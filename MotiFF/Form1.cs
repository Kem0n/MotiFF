﻿using System;
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
            timer2.Interval = 600000;
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
            label20.Text = String.Empty;
            label30.Text = String.Empty;
            label40.Text = String.Empty;
            label50.Text = String.Empty;
        }
    }
}