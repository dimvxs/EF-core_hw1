namespace hww
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
            groupBox1 = new GroupBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            groupBox2 = new GroupBox();
            button3 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBox5);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(69, 57);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(454, 541);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Country Info";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(44, 407);
            label5.Name = "label5";
            label5.Size = new Size(120, 32);
            label5.TabIndex = 5;
            label5.Text = "Continent";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(44, 321);
            label4.Name = "label4";
            label4.Size = new Size(88, 32);
            label4.TabIndex = 5;
            label4.Text = "Square";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(44, 234);
            label3.Name = "label3";
            label3.Size = new Size(128, 32);
            label3.TabIndex = 6;
            label3.Text = "Population";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 139);
            label2.Name = "label2";
            label2.Size = new Size(87, 32);
            label2.TabIndex = 5;
            label2.Text = "Capital";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 49);
            label1.Name = "label1";
            label1.Size = new Size(78, 32);
            label1.TabIndex = 4;
            label1.Text = "Name";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(44, 442);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(357, 39);
            textBox5.TabIndex = 1;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(44, 356);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(357, 39);
            textBox4.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(44, 269);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(357, 39);
            textBox3.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(44, 174);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(357, 39);
            textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(44, 84);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(357, 39);
            textBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(123, 77);
            button1.Name = "button1";
            button1.Size = new Size(150, 46);
            button1.TabIndex = 7;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(123, 158);
            button2.Name = "button2";
            button2.Size = new Size(150, 46);
            button2.TabIndex = 1;
            button2.Text = "Remove";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(button2);
            groupBox2.Location = new Point(686, 57);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(400, 329);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Actions";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // button3
            // 
            button3.Location = new Point(123, 243);
            button3.Name = "button3";
            button3.Size = new Size(150, 46);
            button3.TabIndex = 8;
            button3.Text = "Change";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1122, 610);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Geography national";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label5;
        private Button button1;
        private Button button2;
        private GroupBox groupBox2;
        private Button button3;
    }
}
