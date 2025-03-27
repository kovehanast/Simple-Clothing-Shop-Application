namespace Admin
{
    partial class Register
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
            label1 = new Label();
            button1 = new Button();
            label3 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label4 = new Label();
            textBox3 = new TextBox();
            label5 = new Label();
            textBox4 = new TextBox();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(150, 32);
            label1.TabIndex = 1;
            label1.Text = "Регистрация";
            // 
            // button1
            // 
            button1.Location = new Point(149, 168);
            button1.Name = "button1";
            button1.Size = new Size(119, 29);
            button1.TabIndex = 10;
            button1.Text = "Готово";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(80, 80);
            label3.Name = "label3";
            label3.Size = new Size(63, 21);
            label3.TabIndex = 9;
            label3.Text = "Пароль";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(91, 51);
            label2.Name = "label2";
            label2.Size = new Size(54, 21);
            label2.TabIndex = 8;
            label2.Text = "Логин";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(149, 78);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(249, 23);
            textBox2.TabIndex = 7;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(151, 49);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(249, 23);
            textBox1.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(1, 109);
            label4.Name = "label4";
            label4.Size = new Size(142, 21);
            label4.TabIndex = 11;
            label4.Text = "Повторите пароль";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(151, 107);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(249, 23);
            textBox3.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(91, 134);
            label5.Name = "label5";
            label5.Size = new Size(46, 21);
            label5.TabIndex = 13;
            label5.Text = "ФИО";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(151, 136);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(249, 23);
            textBox4.TabIndex = 14;
            // 
            // button2
            // 
            button2.Location = new Point(149, 268);
            button2.Name = "button2";
            button2.Size = new Size(119, 29);
            button2.TabIndex = 15;
            button2.Text = "Авторизация";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(textBox4);
            Controls.Add(label5);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Register";
            Text = "Register";
            Load += Register_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Label label3;
        private Label label2;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label4;
        private TextBox textBox3;
        private Label label5;
        private TextBox textBox4;
        private Button button2;
    }
}