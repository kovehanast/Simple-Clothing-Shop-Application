using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Admin
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string login = textBox1.Text;
            string pass = "";
            if (textBox2.Text == textBox3.Text)
            {
                pass = textBox2.Text;
                string full_name = textBox4.Text;
                DB dB = new DB();
                dB.Insert_User(login, pass, full_name);
                MessageBox.Show("Успешная регистрация!");
            }
            else MessageBox.Show("Пароли не совпадают!");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignIn form1 = new SignIn();
            form1.Closed += (s, args) => this.Close();
            form1.Show();

        }
    }
}
