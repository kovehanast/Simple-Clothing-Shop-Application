namespace Admin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DB dB = new DB();

            dataGridView1.DataSource = dB.Select();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int idgood;
            string img_path = @"img\";
            foreach (DataGridViewRow Rows in this.dataGridView1.Rows)

            {
                try
                {
                    if (Rows.Selected)
                    {
                        DB dB = new DB();
                        idgood = Convert.ToInt32(Rows.Cells[0].Value);
                        pictureBox1.ImageLocation = img_path + dB.Select_path(idgood);
                        labelGName.Text = dB.Select_name(idgood);
                        textBoxDesc.Text = dB.Select_description(idgood);
                        labelGQuantity.Text = dB.Select_quantity(idgood);

                    }
                }
                catch (InvalidCastException ex)
                {
                    // MessageBox.Show(ex.ToString());
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Add form1 = new Add();
            form1.Closed += (s, args) => this.Close();
            form1.Show();
        }
    }
}
