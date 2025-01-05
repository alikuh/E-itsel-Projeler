namespace final_calismasi
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
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button4 = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 342);
            label1.Name = "label1";
            label1.Size = new Size(101, 20);
            label1.TabIndex = 0;
            label1.Text = "Toplam tutar :";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(34, 15);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(177, 144);
            listBox1.TabIndex = 1;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.Location = new Point(34, 178);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(177, 144);
            listBox2.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(330, 26);
            button1.Name = "button1";
            button1.Size = new Size(94, 58);
            button1.TabIndex = 2;
            button1.Text = "sepete ekle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(330, 90);
            button2.Name = "button2";
            button2.Size = new Size(94, 52);
            button2.TabIndex = 2;
            button2.Text = "sepeti temizle";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(330, 148);
            button3.Name = "button3";
            button3.Size = new Size(94, 52);
            button3.TabIndex = 2;
            button3.Text = "çıkış";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(118, 149);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(118, 190);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 3;
            // 
            // button4
            // 
            button4.Location = new Point(131, 233);
            button4.Name = "button4";
            button4.Size = new Size(94, 52);
            button4.TabIndex = 2;
            button4.Text = "EKLE";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(118, 107);
            label2.Name = "label2";
            label2.Size = new Size(120, 20);
            label2.TabIndex = 4;
            label2.Text = "YENİ ÜRÜN EKLE";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 149);
            label3.Name = "label3";
            label3.Size = new Size(76, 20);
            label3.TabIndex = 4;
            label3.Text = "ürün ismi :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(37, 195);
            label4.Name = "label4";
            label4.Size = new Size(82, 20);
            label4.TabIndex = 4;
            label4.Text = "ürün fiyatı :";
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSalmon;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBox2);
            panel1.Location = new Point(478, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(319, 448);
            panel1.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox listBox1;
        private ListBox listBox2;
        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button4;
        private Label label2;
        private Label label3;
        private Label label4;
        private Panel panel1;
    }
}
