namespace LoginPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            button2 = new Button();
            button3 = new Button();
            linkLabel1 = new LinkLabel();
            checkBox1 = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Monotype Corsiva", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(101, 83);
            label1.Name = "label1";
            label1.Size = new Size(124, 25);
            label1.TabIndex = 0;
            label1.Text = "Kullanıcı Adı :";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.LavenderBlush;
            textBox1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(257, 83);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(264, 31);
            textBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Monotype Corsiva", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(168, 148);
            label2.Name = "label2";
            label2.Size = new Size(57, 25);
            label2.TabIndex = 2;
            label2.Text = "Şifre :";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.LavenderBlush;
            textBox2.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(257, 144);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(264, 31);
            textBox2.TabIndex = 3;
            textBox2.UseSystemPasswordChar = true;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ScrollBar;
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Location = new Point(318, 279);
            button2.Name = "button2";
            button2.Size = new Size(125, 34);
            button2.TabIndex = 5;
            button2.Text = "GİRİŞ YAP";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.Location = new Point(584, 12);
            button3.Name = "button3";
            button3.Size = new Size(57, 39);
            button3.TabIndex = 6;
            button3.Text = "X";
            button3.UseVisualStyleBackColor = true;
            button3.BackgroundImageChanged += button2_Click;
            button3.Click += button3_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.Transparent;
            linkLabel1.Font = new Font("Segoe UI", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            linkLabel1.Location = new Point(407, 216);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(114, 20);
            linkLabel1.TabIndex = 7;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Şifremi Unuttum";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.BackColor = Color.Transparent;
            checkBox1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox1.Location = new Point(257, 219);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(106, 24);
            checkBox1.TabIndex = 8;
            checkBox1.Text = "Beni Hatırla";
            checkBox1.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AcceptButton = button3;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(662, 374);
            Controls.Add(checkBox1);
            Controls.Add(linkLabel1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(textBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            DoubleClick += button2_Click;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private Button button2;
        private Button button3;
        private LinkLabel linkLabel1;
        private CheckBox checkBox1;
    }
}