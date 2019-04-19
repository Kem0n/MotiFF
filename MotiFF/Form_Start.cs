using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MotiFF
{
    public partial class Form_Start : Form
    {
        public int number;
        Form1 form_end = new Form1();
        public Form_Start()
        {
            InitializeComponent();
        }
        private void forms(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void button_Start_Click(object sender, EventArgs e)
        {
            bool success = Int32.TryParse(textBox_Start.Text, out number);
            if (success && 1930<number && number < 2019)
            {
                form_end.ShowDialog();
            }
            else
            {
                MessageBox.Show("Ошибка ввода года рождения."+Environment.NewLine+"Скорректируйте год рождения!","Ошибка",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
