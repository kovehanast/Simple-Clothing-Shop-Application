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
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();
        }
        string img_path = @"img\";
        int idcategory = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            string g_name = textBox1.Text;
            string description = textBox2.Text;
            int gender = 0;
            if (radioButton1.Checked)
            {
                gender = 1;
            }
            else if (radioButton2.Checked)
            {
                gender = 2;
            }
            else
            {
                MessageBox.Show("Выберите пол!");
            }
            //
            //int gender = ;
            //string path = ;
            DB dB = new DB();
            if (gender > 0) dB.Insert_Goods(g_name, description, idcategory, gender, path);
        }

        private void Add_Load(object sender, EventArgs e)
        {
            DB dB = new DB();

            dataGridView2.DataSource = dB.Select_cat();

            DB db2 = new DB();
            dataGridView1.DataSource = db2.Select_size();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            foreach (DataGridViewRow Rows in this.dataGridView2.Rows)

            {
                try
                {
                    if (Rows.Selected)
                    {
                        idcategory = Convert.ToInt32(Rows.Cells[0].Value);

                    }
                }
                catch (InvalidCastException ex)
                {

                }
            }
        }
        string path;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                OpenFileDialog dialog = new OpenFileDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    //    pictureBox1_logo.ImageLocation = dialog.FileName.ToString();

                    path = Path.GetFileName(dialog.FileName.ToString());
                    pictureBox1.ImageLocation = img_path + path;
                }
            }
            catch (Exception ex) { }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
