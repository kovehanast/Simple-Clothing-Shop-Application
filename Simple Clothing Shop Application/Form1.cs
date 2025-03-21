using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Simple_Clothing_Shop_Application
{
    public partial class Form1 : Form
    {
        DataTable dtCarts = new DataTable();
        DataTable dtProducts = new DataTable();
        int quantity = 1;
        int price = 0;
        int total = 0;
        bool containsRow = false;
        public Form1()
        {
            InitializeComponent();            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tbSubTotal.Enabled = false; 
            tbTotal.Enabled = false;

            panel1.Visible = false;
            pnlUpload.Visible = false;
            dtCarts.Columns.Add("Название");
            dtCarts.Columns.Add("Количество");
            dtCarts.Columns.Add("Цена");
            dtCarts.Columns.Add("Итого");
            dgvCart.DataSource = dtCarts;

            dtProducts.Columns.Add("Товары");
            dtProducts.Columns.Add("Цена");
            dtProducts.Columns.Add("Категория");
            dtProducts.Rows.Add("Кофейная футболка оверсайз", 700, 1);
            dtProducts.Rows.Add("Серая футболка оверсайз", 1399, 1);
            dtProducts.Rows.Add("Белая футболка свободная", 999, 1);
            dtProducts.Rows.Add("Рубашка белая базовая", 2000, 2);
            dtProducts.Rows.Add("Рубашка голубая в полоску", 3000, 2);
            dtProducts.Rows.Add("Рубашка голубая льняная", 2999, 2);
            dtProducts.Rows.Add("Джинсы 1", 3800, 3);
            dtProducts.Rows.Add("Джинсы 2", 3500, 3);
            dtProducts.Rows.Add("Джинсы 3", 3000, 3);
            dtProducts.Rows.Add("Штаны 1", 5000, 4);
            dtProducts.Rows.Add("Штаны 2", 7000, 4);
            dtProducts.Rows.Add("Штаны 3", 6000, 4);
            dtProducts.Rows.Add("Ботинки утепленные", 12000, 5);
            dtProducts.Rows.Add("Челси", 10000, 5);
            dtProducts.Rows.Add("Кроссовки Heels", 7000, 5);
            dtProducts.Rows.Add("Kalung berlian", 10000000, 6);
            dtProducts.Rows.Add("Anting-anting", 500000, 6);
            dtProducts.Rows.Add("Gelang tali", 300000, 6);
        }
        
        
        private void tShirtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            pnlUpload.Visible = false;
            //int a = Convert.ToInt32(dtProducts.Rows[0][1].ToString());
            //string harga = a.ToString("C");
            //MessageBox.Show(harga);
            //string temp = Convert.ToString(dtProducts.Rows[1][0].ToString("C2").Remove(1, 0));
            pictureBox1.Image = Properties.Resources.TshirtBiru;
            pictureBox2.Image = Properties.Resources.TshirtGaris;
            pictureBox3.Image = Properties.Resources.TshirtBunga;
            lbKiri.Text = dtProducts.Rows[0][0].ToString();
            lbHargaKiri.Text = Convert.ToInt32(dtProducts.Rows[0][1]).ToString("C");
            lbTengah.Text = dtProducts.Rows[1][0].ToString();
            lbHargaTengah.Text = Convert.ToInt32(dtProducts.Rows[1][1]).ToString("C");
            lbKanan.Text = dtProducts.Rows[2][0].ToString();
            lbHargaKanan.Text = Convert.ToInt32(dtProducts.Rows[2][1]).ToString("C");            
        }

        private void shirtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            pnlUpload.Visible = false;
            pictureBox1.Image = Properties.Resources.ShirtKotak;
            pictureBox2.Image = Properties.Resources.ShirtPutih;
            pictureBox3.Image = Properties.Resources.ShirtGambar;
            lbKiri.Text = dtProducts.Rows[3][0].ToString();
            lbHargaKiri.Text = Convert.ToInt32(dtProducts.Rows[3][1]).ToString("C");
            lbTengah.Text = dtProducts.Rows[4][0].ToString();
            lbHargaTengah.Text = Convert.ToInt32(dtProducts.Rows[4][1]).ToString("C");
            lbKanan.Text = dtProducts.Rows[5][0].ToString();
            lbHargaKanan.Text = Convert.ToInt32(dtProducts.Rows[5][1]).ToString("C");
        }

        private void pantsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            pnlUpload.Visible = false;
            pictureBox1.Image = Properties.Resources.Jeans;
            pictureBox2.Image = Properties.Resources.PantsHitam;
            pictureBox3.Image = Properties.Resources.PantsPutih;
            lbKiri.Text = dtProducts.Rows[6][0].ToString();
            lbHargaKiri.Text = Convert.ToInt32(dtProducts.Rows[6][1]).ToString("C");
            lbTengah.Text = dtProducts.Rows[7][0].ToString();
            lbHargaTengah.Text = Convert.ToInt32(dtProducts.Rows[7][1]).ToString("C");
            lbKanan.Text = dtProducts.Rows[8][0].ToString();
            lbHargaKanan.Text = Convert.ToInt32(dtProducts.Rows[8][1]).ToString("C");
        }

        private void longPantsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            pnlUpload.Visible = false;
            pictureBox1.Image = Properties.Resources.Kulot;
            pictureBox2.Image = Properties.Resources.LongJeans;
            pictureBox3.Image = Properties.Resources.LongPutih;
            lbKiri.Text = dtProducts.Rows[9][0].ToString();
            lbHargaKiri.Text = Convert.ToInt32(dtProducts.Rows[9][1]).ToString("C");
            lbTengah.Text = dtProducts.Rows[10][0].ToString();
            lbHargaTengah.Text = Convert.ToInt32(dtProducts.Rows[10][1]).ToString("C");
            lbKanan.Text = dtProducts.Rows[11][0].ToString();
            lbHargaKanan.Text = Convert.ToInt32(dtProducts.Rows[11][1]).ToString("C");
        }

        private void shoesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            pnlUpload.Visible = false;
            pictureBox1.Image = Properties.Resources.FlatShoes;
            pictureBox2.Image = Properties.Resources.Sneakers;
            pictureBox3.Image = Properties.Resources.Heels;
            lbKiri.Text = dtProducts.Rows[12][0].ToString();
            lbHargaKiri.Text = Convert.ToInt32(dtProducts.Rows[12][1]).ToString("C");
            lbTengah.Text = dtProducts.Rows[13][0].ToString();
            lbHargaTengah.Text = Convert.ToInt32(dtProducts.Rows[13][1]).ToString("C");
            lbKanan.Text = dtProducts.Rows[14][0].ToString();
            lbHargaKanan.Text = Convert.ToInt32(dtProducts.Rows[14][1]).ToString("C");
        }

        private void jewelriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            pnlUpload.Visible = false;
            pictureBox1.Image = Properties.Resources.Kalung;
            pictureBox2.Image = Properties.Resources.Anting;
            pictureBox3.Image = Properties.Resources.Gelang;
            lbKiri.Text = dtProducts.Rows[15][0].ToString();
            lbHargaKiri.Text = Convert.ToInt32(dtProducts.Rows[15][1]).ToString("C");
            lbTengah.Text = dtProducts.Rows[16][0].ToString();
            lbHargaTengah.Text = Convert.ToInt32(dtProducts.Rows[16][1]).ToString("C");
            lbKanan.Text = dtProducts.Rows[17][0].ToString();
            lbHargaKanan.Text = Convert.ToInt32(dtProducts.Rows[17][1]).ToString("C");
        }

        private void btnAddKiri_Click(object sender, EventArgs e)
        {
            containsRow = false;
            price = int.Parse(lbHargaKiri.Text, NumberStyles.Currency);                   
            for (int i = 0; i < dtCarts.Rows.Count; i++)
            {
                if (dtCarts.Rows[i][0].ToString() == lbKiri.Text)
                {
                    containsRow = true;
                    quantity = Convert.ToInt16(dtCarts.Rows[i][1]);
                    quantity++;
                    dtCarts.Rows[i][1] = quantity;
                    dtCarts.Rows[i][3] = (quantity * price).ToString("C");
                    break;
                }
                else 
                {                    
                    containsRow = false;                    
                }
            }
            if (dtCarts.Rows.Count < 1 || containsRow == false)
            {
                quantity = 1;
                dtCarts.Rows.Add(lbKiri.Text, quantity, lbHargaKiri.Text, (price * quantity).ToString("C"));
            }
            tbSubTotal.Text = TotalPrice(dtCarts, total).ToString("C");
            tbTotal.Text = (TotalPrice(dtCarts, total) + (TotalPrice(dtCarts, total) * 0.1)).ToString("C");
        }

        private void btnAddTengah_Click(object sender, EventArgs e)
        {
            containsRow = false;
            price = int.Parse(lbHargaTengah.Text, NumberStyles.Currency);
            for (int i = 0; i < dtCarts.Rows.Count; i++)
            {
                if (dtCarts.Rows[i][0].ToString() == lbTengah.Text)
                {
                    containsRow = true;
                    quantity = Convert.ToInt16(dtCarts.Rows[i][1]);
                    quantity++;
                    dtCarts.Rows[i][1] = quantity;
                    dtCarts.Rows[i][3] = (quantity * price).ToString("C");
                    break;
                }
                else
                {
                    containsRow = false;
                }
            }
            if (dtCarts.Rows.Count < 1 || containsRow == false)
            {
                quantity = 1;
                dtCarts.Rows.Add(lbTengah.Text, quantity, lbHargaTengah.Text, (price * quantity).ToString("C"));
            }
            tbSubTotal.Text = TotalPrice(dtCarts, total).ToString("C");
            tbTotal.Text = (TotalPrice(dtCarts, total) + (TotalPrice(dtCarts, total) * 0.1)).ToString("C");
        }

        private void btnAddKanan_Click(object sender, EventArgs e)
        {
            containsRow = false;
            price = int.Parse(lbHargaKanan.Text, NumberStyles.Currency);
            for (int i = 0; i < dtCarts.Rows.Count; i++)
            {
                if (dtCarts.Rows[i][0].ToString() == lbKanan.Text)
                {
                    containsRow = true;
                    quantity = Convert.ToInt16(dtCarts.Rows[i][1]);
                    quantity++;
                    dtCarts.Rows[i][1] = quantity;
                    dtCarts.Rows[i][3] = (quantity * price).ToString("C");
                    break;
                }
                else
                {
                    containsRow = false;
                }
            }
            if (dtCarts.Rows.Count < 1 || containsRow == false)
            {
                quantity = 1;                
                dtCarts.Rows.Add(lbKanan.Text, quantity, lbHargaKanan.Text, (price * quantity).ToString("C"));
            }            
            tbSubTotal.Text = TotalPrice(dtCarts, total).ToString("C");
            tbTotal.Text = (TotalPrice(dtCarts, total) + (TotalPrice(dtCarts, total)*0.1)).ToString("C");
        }

        private int TotalPrice(DataTable dtCarts, int total)
        {
            int harga = 0;
            for (int i = 0; i < dtCarts.Rows.Count;i++)
            {
                harga = int.Parse(dtCarts.Rows[i][3].ToString(), NumberStyles.Currency);
                total += harga;
            }
            return total;
        }
        private void othersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            pnlUpload.Visible = true;
            if(pbUpload.Image == null)
            {
                tbItemName.Enabled = false;
                tbItemPrice.Enabled = false;
                btnAddUpload.Enabled = false;
            }            
            
        }

        private void tbItemPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "JPEG File (*.JPEG)|*.JPEG|JPG File (*.jpg)|*.jpg|All Files (*.*)|*.*";
            ofd.ShowDialog();
            string fileName = ofd.FileName;
            pbUpload.Image = new Bitmap(fileName);
            tbItemName.Enabled = true;
            tbItemPrice.Enabled = true;
            
        }

        private void tbItemPrice_TextChanged(object sender, EventArgs e)
        {
            if (pbUpload != null && tbItemName.Text.Length > 0 && tbItemPrice.Text.Length > 0)
            {
                btnAddUpload.Enabled = true;
            }
            else
            {
                btnAddUpload.Enabled = false;
            }
        }

        private void tbItemName_TextChanged(object sender, EventArgs e)
        {
            if (pbUpload != null && tbItemName.Text.Length > 0 && tbItemPrice.Text.Length > 0)
            {
                btnAddUpload.Enabled = true;
            }
            else
            {
                btnAddUpload.Enabled = false;
            }
        }

        private void btnAddUpload_Click(object sender, EventArgs e)
        {
            containsRow = false;
            price = Convert.ToInt32(tbItemPrice.Text);
            for (int i = 0; i < dtCarts.Rows.Count; i++)
            {
                if (dtCarts.Rows[i][0].ToString() == tbItemName.Text)
                {
                    containsRow = true;
                    quantity = Convert.ToInt16(dtCarts.Rows[i][1]);
                    quantity++;
                    dtCarts.Rows[i][1] = quantity;
                    dtCarts.Rows[i][3] = (quantity * price).ToString("C");
                    break;
                }
                else
                {
                    containsRow = false;
                }
            }
            if (dtCarts.Rows.Count < 1 || containsRow == false)
            {
                quantity = 1;                
                dtCarts.Rows.Add(tbItemName.Text, quantity, price.ToString("C"), (price * quantity).ToString("C"));
            }
            tbSubTotal.Text = TotalPrice(dtCarts, total).ToString("C");
            tbTotal.Text = (TotalPrice(dtCarts, total) + (TotalPrice(dtCarts, total) * 0.1)).ToString("C");
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int total = int.Parse(tbSubTotal.Text, NumberStyles.Currency);
            int harga = int.Parse(dgvCart.CurrentRow.Cells[3].Value.ToString(), NumberStyles.Currency);
            total = total - harga;
            tbSubTotal.Text = total.ToString("C");
            tbTotal.Text = (total + (total * 10 / 100)).ToString("C");
            if (dgvCart.SelectedCells != null)
            {
                foreach (DataGridViewRow row in dgvCart.SelectedRows)
                {
                    dgvCart.Rows.RemoveAt(row.Index);
                }
            }
           
        }

        private void tbTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void payBtn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("msedge.exe", "http://ecommerce-store-main2/product_details.html");


        }

        private void свитшотыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //panel1.Visible = true;
            //pnlUpload.Visible = false;
         
            //pictureBox1.Image = Properties.Resources.SW1;
            //pictureBox2.Image = Properties.Resources.SW2;
            //pictureBox3.Image = Properties.Resources.SW3;
            //lbKiri.Text = dtProducts.Rows[0][0].ToString();
            //lbHargaKiri.Text = Convert.ToInt32(dtProducts.Rows[0][1]).ToString("C");
            //lbTengah.Text = dtProducts.Rows[1][0].ToString();
            //lbHargaTengah.Text = Convert.ToInt32(dtProducts.Rows[1][1]).ToString("C");
            //lbKanan.Text = dtProducts.Rows[2][0].ToString();
            //lbHargaKanan.Text = Convert.ToInt32(dtProducts.Rows[2][1]).ToString("C");
        }

        private void button1_Click(object sender, EventArgs e)
        {

            System.Diagnostics.Process.Start("msedge.exe", "http://ecommerce-store-main2/index.html");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 Form2 = new Form2();
            Form2.Show(); // или Form2.ShowDialog(); для модального окна
        }
    }
}
