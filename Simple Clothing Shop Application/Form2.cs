using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_Clothing_Shop_Application
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("C:/Users/priko/OneDrive/Рабочий стол/Simple Clothing Shop Application/Simple Clothing Shop Application/image/5391349147203925547.jpg");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
