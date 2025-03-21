namespace Simple_Clothing_Shop_Application
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.topWearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tShirtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shirtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bottomWearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pantsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.longPantsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accessoriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shoesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.othersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dgvCart = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSubTotal = new System.Windows.Forms.TextBox();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.btnAddKiri = new System.Windows.Forms.Button();
            this.btnAddTengah = new System.Windows.Forms.Button();
            this.btnAddKanan = new System.Windows.Forms.Button();
            this.lbKiri = new System.Windows.Forms.Label();
            this.lbTengah = new System.Windows.Forms.Label();
            this.lbKanan = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.lbHargaKanan = new System.Windows.Forms.Label();
            this.lbHargaTengah = new System.Windows.Forms.Label();
            this.lbHargaKiri = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lbUpload = new System.Windows.Forms.Label();
            this.btnUpload = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbItemName = new System.Windows.Forms.TextBox();
            this.tbItemPrice = new System.Windows.Forms.TextBox();
            this.pnlUpload = new System.Windows.Forms.Panel();
            this.btnAddUpload = new System.Windows.Forms.Button();
            this.pbUpload = new System.Windows.Forms.PictureBox();
            this.payBtn = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlUpload.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUpload)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.topWearToolStripMenuItem,
            this.bottomWearToolStripMenuItem,
            this.accessoriesToolStripMenuItem,
            this.othersToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(871, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // topWearToolStripMenuItem
            // 
            this.topWearToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tShirtToolStripMenuItem,
            this.shirtToolStripMenuItem});
            this.topWearToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.topWearToolStripMenuItem.Name = "topWearToolStripMenuItem";
            this.topWearToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.topWearToolStripMenuItem.Text = "Верх";
            // 
            // tShirtToolStripMenuItem
            // 
            this.tShirtToolStripMenuItem.Name = "tShirtToolStripMenuItem";
            this.tShirtToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tShirtToolStripMenuItem.Text = "Футболки";
            this.tShirtToolStripMenuItem.Click += new System.EventHandler(this.tShirtToolStripMenuItem_Click);
            // 
            // shirtToolStripMenuItem
            // 
            this.shirtToolStripMenuItem.Name = "shirtToolStripMenuItem";
            this.shirtToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.shirtToolStripMenuItem.Text = "Рубашки";
            this.shirtToolStripMenuItem.Click += new System.EventHandler(this.shirtToolStripMenuItem_Click);
            // 
            // bottomWearToolStripMenuItem
            // 
            this.bottomWearToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pantsToolStripMenuItem,
            this.longPantsToolStripMenuItem});
            this.bottomWearToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bottomWearToolStripMenuItem.Name = "bottomWearToolStripMenuItem";
            this.bottomWearToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.bottomWearToolStripMenuItem.Text = "Низ";
            // 
            // pantsToolStripMenuItem
            // 
            this.pantsToolStripMenuItem.Name = "pantsToolStripMenuItem";
            this.pantsToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.pantsToolStripMenuItem.Text = "Джинсы";
            this.pantsToolStripMenuItem.Click += new System.EventHandler(this.pantsToolStripMenuItem_Click);
            // 
            // longPantsToolStripMenuItem
            // 
            this.longPantsToolStripMenuItem.Name = "longPantsToolStripMenuItem";
            this.longPantsToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.longPantsToolStripMenuItem.Text = "Штаны";
            this.longPantsToolStripMenuItem.Click += new System.EventHandler(this.longPantsToolStripMenuItem_Click);
            // 
            // accessoriesToolStripMenuItem
            // 
            this.accessoriesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.shoesToolStripMenuItem});
            this.accessoriesToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.accessoriesToolStripMenuItem.Name = "accessoriesToolStripMenuItem";
            this.accessoriesToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.accessoriesToolStripMenuItem.Text = "Обувь";
            // 
            // shoesToolStripMenuItem
            // 
            this.shoesToolStripMenuItem.Name = "shoesToolStripMenuItem";
            this.shoesToolStripMenuItem.Size = new System.Drawing.Size(95, 22);
            this.shoesToolStripMenuItem.Text = "Все";
            this.shoesToolStripMenuItem.Click += new System.EventHandler(this.shoesToolStripMenuItem_Click);
            // 
            // othersToolStripMenuItem
            // 
            this.othersToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.othersToolStripMenuItem.Name = "othersToolStripMenuItem";
            this.othersToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.othersToolStripMenuItem.Text = "Прочее";
            this.othersToolStripMenuItem.Click += new System.EventHandler(this.othersToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // dgvCart
            // 
            this.dgvCart.AllowUserToDeleteRows = false;
            this.dgvCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCart.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvCart.Location = new System.Drawing.Point(533, 85);
            this.dgvCart.Margin = new System.Windows.Forms.Padding(2);
            this.dgvCart.Name = "dgvCart";
            this.dgvCart.RowHeadersWidth = 51;
            this.dgvCart.RowTemplate.Height = 24;
            this.dgvCart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCart.Size = new System.Drawing.Size(313, 210);
            this.dgvCart.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(532, 306);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Без доставки:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(586, 339);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Сумма:";
            // 
            // tbSubTotal
            // 
            this.tbSubTotal.Location = new System.Drawing.Point(656, 307);
            this.tbSubTotal.Margin = new System.Windows.Forms.Padding(2);
            this.tbSubTotal.Name = "tbSubTotal";
            this.tbSubTotal.Size = new System.Drawing.Size(116, 20);
            this.tbSubTotal.TabIndex = 5;
            // 
            // tbTotal
            // 
            this.tbTotal.Location = new System.Drawing.Point(656, 337);
            this.tbTotal.Margin = new System.Windows.Forms.Padding(2);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.Size = new System.Drawing.Size(116, 20);
            this.tbTotal.TabIndex = 6;
            this.tbTotal.TextChanged += new System.EventHandler(this.tbTotal_TextChanged);
            // 
            // btnAddKiri
            // 
            this.btnAddKiri.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddKiri.Location = new System.Drawing.Point(15, 297);
            this.btnAddKiri.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddKiri.Name = "btnAddKiri";
            this.btnAddKiri.Size = new System.Drawing.Size(78, 27);
            this.btnAddKiri.TabIndex = 10;
            this.btnAddKiri.Text = "В корзину";
            this.btnAddKiri.UseVisualStyleBackColor = true;
            this.btnAddKiri.Click += new System.EventHandler(this.btnAddKiri_Click);
            // 
            // btnAddTengah
            // 
            this.btnAddTengah.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddTengah.Location = new System.Drawing.Point(180, 297);
            this.btnAddTengah.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddTengah.Name = "btnAddTengah";
            this.btnAddTengah.Size = new System.Drawing.Size(78, 27);
            this.btnAddTengah.TabIndex = 11;
            this.btnAddTengah.Text = "В корзину";
            this.btnAddTengah.UseVisualStyleBackColor = true;
            this.btnAddTengah.Click += new System.EventHandler(this.btnAddTengah_Click);
            // 
            // btnAddKanan
            // 
            this.btnAddKanan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddKanan.Location = new System.Drawing.Point(346, 297);
            this.btnAddKanan.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddKanan.Name = "btnAddKanan";
            this.btnAddKanan.Size = new System.Drawing.Size(78, 27);
            this.btnAddKanan.TabIndex = 12;
            this.btnAddKanan.Text = "В корзину";
            this.btnAddKanan.UseVisualStyleBackColor = true;
            this.btnAddKanan.Click += new System.EventHandler(this.btnAddKanan_Click);
            // 
            // lbKiri
            // 
            this.lbKiri.AutoSize = true;
            this.lbKiri.Location = new System.Drawing.Point(13, 240);
            this.lbKiri.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbKiri.Name = "lbKiri";
            this.lbKiri.Size = new System.Drawing.Size(35, 13);
            this.lbKiri.TabIndex = 13;
            this.lbKiri.Text = "label3";
            // 
            // lbTengah
            // 
            this.lbTengah.AutoSize = true;
            this.lbTengah.Location = new System.Drawing.Point(178, 240);
            this.lbTengah.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTengah.Name = "lbTengah";
            this.lbTengah.Size = new System.Drawing.Size(35, 13);
            this.lbTengah.TabIndex = 14;
            this.lbTengah.Text = "label3";
            // 
            // lbKanan
            // 
            this.lbKanan.AutoSize = true;
            this.lbKanan.Location = new System.Drawing.Point(344, 240);
            this.lbKanan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbKanan.Name = "lbKanan";
            this.lbKanan.Size = new System.Drawing.Size(35, 13);
            this.lbKanan.TabIndex = 15;
            this.lbKanan.Text = "label3";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.lbHargaKanan);
            this.panel1.Controls.Add(this.lbHargaTengah);
            this.panel1.Controls.Add(this.lbHargaKiri);
            this.panel1.Controls.Add(this.lbKanan);
            this.panel1.Controls.Add(this.lbTengah);
            this.panel1.Controls.Add(this.lbKiri);
            this.panel1.Controls.Add(this.btnAddKanan);
            this.panel1.Controls.Add(this.btnAddTengah);
            this.panel1.Controls.Add(this.btnAddKiri);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(20, 74);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(497, 373);
            this.panel1.TabIndex = 16;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.button2.Location = new System.Drawing.Point(15, 329);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(78, 23);
            this.button2.TabIndex = 19;
            this.button2.Text = "подробнее";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbHargaKanan
            // 
            this.lbHargaKanan.AutoSize = true;
            this.lbHargaKanan.Location = new System.Drawing.Point(344, 254);
            this.lbHargaKanan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbHargaKanan.Name = "lbHargaKanan";
            this.lbHargaKanan.Size = new System.Drawing.Size(35, 13);
            this.lbHargaKanan.TabIndex = 18;
            this.lbHargaKanan.Text = "label3";
            // 
            // lbHargaTengah
            // 
            this.lbHargaTengah.AutoSize = true;
            this.lbHargaTengah.Location = new System.Drawing.Point(178, 254);
            this.lbHargaTengah.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbHargaTengah.Name = "lbHargaTengah";
            this.lbHargaTengah.Size = new System.Drawing.Size(35, 13);
            this.lbHargaTengah.TabIndex = 17;
            this.lbHargaTengah.Text = "label3";
            // 
            // lbHargaKiri
            // 
            this.lbHargaKiri.AutoSize = true;
            this.lbHargaKiri.Location = new System.Drawing.Point(13, 254);
            this.lbHargaKiri.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbHargaKiri.Name = "lbHargaKiri";
            this.lbHargaKiri.Size = new System.Drawing.Size(35, 13);
            this.lbHargaKiri.TabIndex = 16;
            this.lbHargaKiri.Text = "label3";
            // 
            // pictureBox3
            // 
            this.pictureBox3.InitialImage = global::Simple_Clothing_Shop_Application.Properties.Resources.TshirtBunga;
            this.pictureBox3.Location = new System.Drawing.Point(346, 11);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(130, 210);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(180, 11);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(130, 210);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(15, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 210);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // btnRemove
            // 
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRemove.Location = new System.Drawing.Point(776, 303);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(69, 25);
            this.btnRemove.TabIndex = 17;
            this.btnRemove.Text = "Удалить";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // lbUpload
            // 
            this.lbUpload.AutoSize = true;
            this.lbUpload.Location = new System.Drawing.Point(16, 16);
            this.lbUpload.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbUpload.Name = "lbUpload";
            this.lbUpload.Size = new System.Drawing.Size(130, 13);
            this.lbUpload.TabIndex = 18;
            this.lbUpload.Text = "Загрузить изображение";
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(146, 9);
            this.btnUpload.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(97, 25);
            this.btnUpload.TabIndex = 19;
            this.btnUpload.Text = "Загрузить";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(169, 46);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Название предмета:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(169, 106);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Цена предмета:";
            // 
            // tbItemName
            // 
            this.tbItemName.Location = new System.Drawing.Point(171, 72);
            this.tbItemName.Margin = new System.Windows.Forms.Padding(2);
            this.tbItemName.Name = "tbItemName";
            this.tbItemName.Size = new System.Drawing.Size(116, 20);
            this.tbItemName.TabIndex = 22;
            this.tbItemName.TextChanged += new System.EventHandler(this.tbItemName_TextChanged);
            // 
            // tbItemPrice
            // 
            this.tbItemPrice.Location = new System.Drawing.Point(171, 131);
            this.tbItemPrice.Margin = new System.Windows.Forms.Padding(2);
            this.tbItemPrice.Name = "tbItemPrice";
            this.tbItemPrice.Size = new System.Drawing.Size(116, 20);
            this.tbItemPrice.TabIndex = 23;
            this.tbItemPrice.TextChanged += new System.EventHandler(this.tbItemPrice_TextChanged);
            this.tbItemPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbItemPrice_KeyPress);
            // 
            // pnlUpload
            // 
            this.pnlUpload.Controls.Add(this.btnAddUpload);
            this.pnlUpload.Controls.Add(this.tbItemPrice);
            this.pnlUpload.Controls.Add(this.tbItemName);
            this.pnlUpload.Controls.Add(this.label4);
            this.pnlUpload.Controls.Add(this.label3);
            this.pnlUpload.Controls.Add(this.pbUpload);
            this.pnlUpload.Controls.Add(this.btnUpload);
            this.pnlUpload.Controls.Add(this.lbUpload);
            this.pnlUpload.Location = new System.Drawing.Point(20, 77);
            this.pnlUpload.Margin = new System.Windows.Forms.Padding(2);
            this.pnlUpload.Name = "pnlUpload";
            this.pnlUpload.Size = new System.Drawing.Size(308, 268);
            this.pnlUpload.TabIndex = 24;
            // 
            // btnAddUpload
            // 
            this.btnAddUpload.Location = new System.Drawing.Point(171, 176);
            this.btnAddUpload.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddUpload.Name = "btnAddUpload";
            this.btnAddUpload.Size = new System.Drawing.Size(78, 27);
            this.btnAddUpload.TabIndex = 19;
            this.btnAddUpload.Text = "Добавить в корзину";
            this.btnAddUpload.UseVisualStyleBackColor = true;
            this.btnAddUpload.Click += new System.EventHandler(this.btnAddUpload_Click);
            // 
            // pbUpload
            // 
            this.pbUpload.Location = new System.Drawing.Point(18, 46);
            this.pbUpload.Margin = new System.Windows.Forms.Padding(2);
            this.pbUpload.Name = "pbUpload";
            this.pbUpload.Size = new System.Drawing.Size(130, 210);
            this.pbUpload.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUpload.TabIndex = 19;
            this.pbUpload.TabStop = false;
            // 
            // payBtn
            // 
            this.payBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.payBtn.Location = new System.Drawing.Point(698, 375);
            this.payBtn.Margin = new System.Windows.Forms.Padding(2);
            this.payBtn.Name = "payBtn";
            this.payBtn.Size = new System.Drawing.Size(148, 39);
            this.payBtn.TabIndex = 25;
            this.payBtn.Text = "Оплатить";
            this.payBtn.UseVisualStyleBackColor = true;
            this.payBtn.Click += new System.EventHandler(this.payBtn_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Simple_Clothing_Shop_Application.Properties.Resources.complogo1;
            this.pictureBox4.Location = new System.Drawing.Point(20, 22);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(211, 50);
            this.pictureBox4.TabIndex = 26;
            this.pictureBox4.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(533, 375);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 39);
            this.button1.TabIndex = 27;
            this.button1.Text = "На сайт";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 490);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.payBtn);
            this.Controls.Add(this.pnlUpload);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tbTotal);
            this.Controls.Add(this.tbSubTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvCart);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Продажа";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlUpload.ResumeLayout(false);
            this.pnlUpload.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUpload)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem topWearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bottomWearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accessoriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem othersToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.DataGridView dgvCart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbSubTotal;
        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnAddKiri;
        private System.Windows.Forms.Button btnAddTengah;
        private System.Windows.Forms.Button btnAddKanan;
        private System.Windows.Forms.Label lbKiri;
        private System.Windows.Forms.Label lbTengah;
        private System.Windows.Forms.Label lbKanan;
        private System.Windows.Forms.ToolStripMenuItem tShirtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shirtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pantsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem longPantsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shoesToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbHargaKiri;
        private System.Windows.Forms.Label lbHargaKanan;
        private System.Windows.Forms.Label lbHargaTengah;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label lbUpload;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.PictureBox pbUpload;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbItemName;
        private System.Windows.Forms.TextBox tbItemPrice;
        private System.Windows.Forms.Panel pnlUpload;
        private System.Windows.Forms.Button btnAddUpload;
        private System.Windows.Forms.Button payBtn;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

