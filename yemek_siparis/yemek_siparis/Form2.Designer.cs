namespace yemek_siparis
{
    partial class Form2
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
            richTextBox1 = new RichTextBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            groupBox1 = new GroupBox();
            checkBox3 = new CheckBox();
            button2 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(163, 99);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(273, 186);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(125, 14);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(312, 23);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(124, 47);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(312, 23);
            textBox2.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(163, 285);
            button1.Name = "button1";
            button1.Size = new Size(274, 53);
            button1.TabIndex = 3;
            button1.Text = "gönder";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(5, 20);
            label1.Name = "label1";
            label1.Size = new Size(114, 15);
            label1.TabIndex = 4;
            label1.Text = "restoran Gmail yazın";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(2, 50);
            label2.Name = "label2";
            label2.Size = new Size(113, 15);
            label2.TabIndex = 5;
            label2.Text = " adres ve  bilgileriniz";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Red;
            label3.Location = new Point(98, 85);
            label3.Name = "label3";
            label3.Size = new Size(368, 15);
            label3.TabIndex = 6;
            label3.Text = "yemek istediginiz yemeği ve alerji olduğunuz ürünler yazınız lütfen !! ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(6, 1);
            label4.Name = "label4";
            label4.Size = new Size(151, 15);
            label4.TabIndex = 7;
            label4.Text = "yemek fiyatları restoran";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(0, 16);
            label5.Name = "label5";
            label5.Size = new Size(158, 15);
            label5.TabIndex = 8;
            label5.Text = " tarafından belirlencektir";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(16, 48);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(117, 19);
            checkBox1.TabIndex = 9;
            checkBox1.Text = "kredi kart /havale";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(16, 77);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(52, 19);
            checkBox2.TabIndex = 10;
            checkBox2.Text = "nakit";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(checkBox3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Controls.Add(checkBox2);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Location = new Point(2, 105);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(160, 235);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(16, 102);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(128, 19);
            checkBox3.TabIndex = 12;
            checkBox3.Text = "gel - al %50 inidirm";
            checkBox3.UseVisualStyleBackColor = true;
            checkBox3.CheckedChanged += checkBox3_CheckedChanged;
            // 
            // button2
            // 
            button2.Location = new Point(27, 138);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 11;
            button2.Text = "onayla";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(462, 352);
            Controls.Add(groupBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(richTextBox1);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "Form2";
            Text = "kayıt yeri";
            Load += Form2_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private GroupBox groupBox1;
        private CheckBox checkBox3;
        private Button button2;
    }
}