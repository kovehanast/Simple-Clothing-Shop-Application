namespace Admin
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            panel1 = new Panel();
            label2 = new Label();
            textBoxDesc = new TextBox();
            button2 = new Button();
            labelGQuantity = new Label();
            labelGName = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(139, 32);
            label1.TabIndex = 0;
            label1.Text = "Все товары";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 62);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(419, 316);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button1
            // 
            button1.Location = new Point(12, 384);
            button1.Name = "button1";
            button1.Size = new Size(153, 23);
            button1.TabIndex = 2;
            button1.Text = "Добавить товар";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBoxDesc);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(labelGQuantity);
            panel1.Controls.Add(labelGName);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(513, 62);
            panel1.Name = "panel1";
            panel1.Size = new Size(275, 376);
            panel1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 318);
            label2.Name = "label2";
            label2.Size = new Size(75, 15);
            label2.TabIndex = 6;
            label2.Text = "Количество:";
            // 
            // textBoxDesc
            // 
            textBoxDesc.Location = new Point(34, 255);
            textBoxDesc.Multiline = true;
            textBoxDesc.Name = "textBoxDesc";
            textBoxDesc.ReadOnly = true;
            textBoxDesc.Size = new Size(221, 60);
            textBoxDesc.TabIndex = 5;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button2.Location = new Point(34, 336);
            button2.Name = "button2";
            button2.Size = new Size(221, 26);
            button2.TabIndex = 4;
            button2.Text = "Изменить";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // labelGQuantity
            // 
            labelGQuantity.AutoSize = true;
            labelGQuantity.Location = new Point(115, 318);
            labelGQuantity.Name = "labelGQuantity";
            labelGQuantity.Size = new Size(40, 15);
            labelGQuantity.TabIndex = 3;
            labelGQuantity.Text = "Пусто";
            // 
            // labelGName
            // 
            labelGName.AutoSize = true;
            labelGName.Location = new Point(34, 237);
            labelGName.Name = "labelGName";
            labelGName.Size = new Size(40, 15);
            labelGName.TabIndex = 1;
            labelGName.Text = "Пусто";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(34, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(221, 210);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Все товары";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private Button button1;
        private Panel panel1;
        private Button button2;
        private Label labelGQuantity;
        private Label labelGName;
        private PictureBox pictureBox1;
        private TextBox textBoxDesc;
        private Label label2;
    }
}
