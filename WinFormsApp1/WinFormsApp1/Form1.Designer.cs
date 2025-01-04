namespace WinFormsApp1
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
            components = new System.ComponentModel.Container();
            splitContainer1 = new SplitContainer();
            label1 = new Label();
            textBox1 = new TextBox();
            button3 = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            Help_b = new Button();
            text_help = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            timer2 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Location = new Point(570, 338);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Paint += splitContainer1_Panel2_Paint;
            splitContainer1.Size = new Size(150, 21);
            splitContainer1.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(12, 91);
            label1.Name = "label1";
            label1.Size = new Size(265, 21);
            label1.TabIndex = 4;
            label1.Text = "Введите клавиши для автокликера: ";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 134);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(129, 23);
            textBox1.TabIndex = 5;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 11F);
            button3.Location = new Point(12, 17);
            button3.Name = "button3";
            button3.Size = new Size(147, 59);
            button3.TabIndex = 7;
            button3.Text = "Включить автокликер";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // Help_b
            // 
            Help_b.Font = new Font("Segoe UI", 12F);
            Help_b.Location = new Point(12, 175);
            Help_b.Name = "Help_b";
            Help_b.Size = new Size(75, 33);
            Help_b.TabIndex = 8;
            Help_b.Text = "Help";
            Help_b.UseVisualStyleBackColor = true;
            Help_b.Click += Help_b_Click;
            // 
            // text_help
            // 
            text_help.AutoSize = true;
            text_help.Font = new Font("Segoe UI", 12F);
            text_help.Location = new Point(12, 211);
            text_help.Name = "text_help";
            text_help.Size = new Size(0, 21);
            text_help.TabIndex = 9;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(353, 32);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(46, 23);
            textBox2.TabIndex = 10;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(450, 32);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(44, 23);
            textBox3.TabIndex = 11;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(543, 32);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(45, 23);
            textBox4.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(331, 40);
            label2.Name = "label2";
            label2.Size = new Size(16, 15);
            label2.TabIndex = 13;
            label2.Text = "a:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(427, 40);
            label3.Name = "label3";
            label3.Size = new Size(17, 15);
            label3.TabIndex = 14;
            label3.Text = "b:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(521, 40);
            label4.Name = "label4";
            label4.Size = new Size(16, 15);
            label4.TabIndex = 15;
            label4.Text = "c:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(300, 91);
            label5.Name = "label5";
            label5.Size = new Size(17, 21);
            label5.TabIndex = 16;
            label5.Text = "x";
            label5.Click += label5_Click;
            // 
            // timer2
            // 
            timer2.Interval = 1;
            timer2.Tick += timer2_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(text_help);
            Controls.Add(Help_b);
            Controls.Add(button3);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(splitContainer1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private SplitContainer splitContainer1;
        private Label label1;
        private TextBox textBox1;
        private Button button3;
        private System.Windows.Forms.Timer timer1;
        private Button Help_b;
        private Label text_help;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private System.Windows.Forms.Timer timer2;
    }
}
