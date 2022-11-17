using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab01_Ponomarenko
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int counterLoginMax = 3;
        int count = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            while (count < counterLoginMax)
            {
                if (textBox_login.Text == "Savage" && textBox_Password.Text == "123")
                {
                    label_ok.BackColor = Color.Green;
                    label_ok.Text = "ok";
                    MessageBox.Show("Hello, Savage");
                    break;
                }
                else
                {
                    label_ok.Text = "wrong";
                    label_ok.BackColor = Color.Red;
                    MessageBox.Show("Error login or password");
                    count++;
                    label3.Text = (counterLoginMax - count).ToString();
                    if (count >= counterLoginMax)
                    {
                        button1.Enabled = false;
                        label3.Text = "Max try to login, Sorry";
                    }
                    break;
                }
            }
        }
    }
}
        
