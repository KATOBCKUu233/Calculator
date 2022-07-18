using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void linkLabel1_Click(object sender, EventArgs e)
        {
            Form frm = new Form3();
                frm.Show();
        }

        private void linkLabel2_Click(object sender, EventArgs e)
        {
            Form frm = new Form4();
            frm.Show();
        }

        private void linkLabel3_Click(object sender, EventArgs e)
        {
            Form frm = new Form5();
            frm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string password = Form2.Show("Вход","Введите ваш пароль");

            if(password != "233")
            {
                MessageBox.Show("Вы были сьедены гусем", "Проиграл",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                this.Close();
            }
        }
    }
}
