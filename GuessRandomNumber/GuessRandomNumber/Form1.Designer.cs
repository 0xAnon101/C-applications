namespace GuessRandomNumber
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.t1 = new System.Windows.Forms.TextBox();
            this.t2 = new System.Windows.Forms.TextBox();
            this.t3 = new System.Windows.Forms.TextBox();
            this.t4 = new System.Windows.Forms.TextBox();
            this.t5 = new System.Windows.Forms.TextBox();
            this.t6 = new System.Windows.Forms.TextBox();
            this.t7 = new System.Windows.Forms.TextBox();
            this.t8 = new System.Windows.Forms.TextBox();
            this.t9 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.t10 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.marks = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(232, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 32);
            this.label1.TabIndex = 20;
            this.label1.Text = "HANGMAN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(233, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 25);
            this.label2.TabIndex = 21;
            this.label2.Text = " - Guess the character";
            // 
            // t1
            // 
            this.t1.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.t1.Location = new System.Drawing.Point(477, 136);
            this.t1.Name = "t1";
            this.t1.Size = new System.Drawing.Size(37, 20);
            this.t1.TabIndex = 9;
            this.t1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.t1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // t2
            // 
            this.t2.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.t2.Location = new System.Drawing.Point(434, 136);
            this.t2.Name = "t2";
            this.t2.Size = new System.Drawing.Size(37, 20);
            this.t2.TabIndex = 8;
            // 
            // t3
            // 
            this.t3.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.t3.Location = new System.Drawing.Point(391, 136);
            this.t3.Name = "t3";
            this.t3.Size = new System.Drawing.Size(37, 20);
            this.t3.TabIndex = 7;
            // 
            // t4
            // 
            this.t4.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.t4.Location = new System.Drawing.Point(348, 136);
            this.t4.Name = "t4";
            this.t4.Size = new System.Drawing.Size(37, 20);
            this.t4.TabIndex = 6;
            // 
            // t5
            // 
            this.t5.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.t5.Location = new System.Drawing.Point(305, 136);
            this.t5.Name = "t5";
            this.t5.Size = new System.Drawing.Size(37, 20);
            this.t5.TabIndex = 5;
            // 
            // t6
            // 
            this.t6.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.t6.Location = new System.Drawing.Point(262, 136);
            this.t6.Name = "t6";
            this.t6.Size = new System.Drawing.Size(37, 20);
            this.t6.TabIndex = 4;
            // 
            // t7
            // 
            this.t7.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.t7.Location = new System.Drawing.Point(219, 136);
            this.t7.Name = "t7";
            this.t7.Size = new System.Drawing.Size(37, 20);
            this.t7.TabIndex = 3;
            // 
            // t8
            // 
            this.t8.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.t8.Location = new System.Drawing.Point(176, 136);
            this.t8.Name = "t8";
            this.t8.Size = new System.Drawing.Size(37, 20);
            this.t8.TabIndex = 2;
            // 
            // t9
            // 
            this.t9.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.t9.Location = new System.Drawing.Point(133, 136);
            this.t9.Name = "t9";
            this.t9.Size = new System.Drawing.Size(37, 20);
            this.t9.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(90, 229);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 40);
            this.button1.TabIndex = 12;
            this.button1.Text = "Attempt";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.make_attempt);
            // 
            // t10
            // 
            this.t10.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.t10.Location = new System.Drawing.Point(90, 136);
            this.t10.Name = "t10";
            this.t10.Size = new System.Drawing.Size(37, 20);
            this.t10.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(181, 229);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 40);
            this.button2.TabIndex = 14;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.make_attempt_clear);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(90, 275);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(166, 39);
            this.button3.TabIndex = 22;
            this.button3.Text = "fetch_data";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // marks
            // 
            this.marks.AutoSize = true;
            this.marks.Location = new System.Drawing.Point(451, 256);
            this.marks.Name = "marks";
            this.marks.Size = new System.Drawing.Size(0, 13);
            this.marks.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(652, 423);
            this.Controls.Add(this.marks);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.t10);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.t9);
            this.Controls.Add(this.t8);
            this.Controls.Add(this.t7);
            this.Controls.Add(this.t6);
            this.Controls.Add(this.t5);
            this.Controls.Add(this.t4);
            this.Controls.Add(this.t3);
            this.Controls.Add(this.t2);
            this.Controls.Add(this.t1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(668, 462);
            this.MinimumSize = new System.Drawing.Size(668, 462);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hangman";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox t1;
        private System.Windows.Forms.TextBox t2;
        private System.Windows.Forms.TextBox t3;
        private System.Windows.Forms.TextBox t4;
        private System.Windows.Forms.TextBox t5;
        private System.Windows.Forms.TextBox t6;
        private System.Windows.Forms.TextBox t7;
        private System.Windows.Forms.TextBox t8;
        private System.Windows.Forms.TextBox t9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox t10;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label marks;
    }
}

