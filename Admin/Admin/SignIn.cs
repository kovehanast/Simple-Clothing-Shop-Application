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
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.F))
            {
                this.Hide();
                Form1 form1 = new Form1();
                form1.Closed += (s, args) => this.Close();
                form1.Show();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string login = textBox1.Text;
            string pass = textBox2.Text;

            DB db = new DB();
            int enter = db.Select_user(login, pass);
            if (enter == 0)
            {
                MessageBox.Show("Нет такого пользователя!");

            }
            else
            {
                this.Hide();
                Form1 form1 = new Form1();
                form1.Closed += (s, args) => this.Close();
                form1.Show();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register form1 = new Register();
            form1.Closed += (s, args) => this.Close();
            form1.Show();

        }

        private void SignIn_Load(object sender, EventArgs e)
        {

        }
    }
}
