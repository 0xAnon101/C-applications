namespace DemoForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.submit = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.firstname = new System.Windows.Forms.TextBox();
            this.middlename = new System.Windows.Forms.TextBox();
            this.lastname = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.phone = new System.Windows.Forms.TextBox();
            this.add1 = new System.Windows.Forms.TextBox();
            this.add2 = new System.Windows.Forms.TextBox();
            this.pincode = new System.Windows.Forms.TextBox();
            this.maleradio = new System.Windows.Forms.RadioButton();
            this.femaleradio = new System.Windows.Forms.RadioButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.country = new System.Windows.Forms.ListBox();
            this.state = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(241, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Middle Name : ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(469, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Last name : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Address 1*  : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Address 2 : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 302);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Country : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(241, 302);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "State : ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 60);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Email : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 417);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Pin Code : ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 96);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Phone : ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 134);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Date of Birth : ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(18, 175);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "Gender : ";
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(22, 481);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(75, 23);
            this.submit.TabIndex = 12;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_click);
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(119, 481);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(75, 23);
            this.reset.TabIndex = 13;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(22, 450);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(222, 17);
            this.checkBox1.TabIndex = 14;
            this.checkBox1.Text = "I agree to abide by Terms and  Conditions";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // firstname
            // 
            this.firstname.Location = new System.Drawing.Point(96, 20);
            this.firstname.Name = "firstname";
            this.firstname.Size = new System.Drawing.Size(122, 20);
            this.firstname.TabIndex = 15;
            // 
            // middlename
            // 
            this.middlename.Location = new System.Drawing.Point(325, 20);
            this.middlename.Name = "middlename";
            this.middlename.Size = new System.Drawing.Size(122, 20);
            this.middlename.TabIndex = 16;
            // 
            // lastname
            // 
            this.lastname.Location = new System.Drawing.Point(540, 20);
            this.lastname.Name = "lastname";
            this.lastname.Size = new System.Drawing.Size(122, 20);
            this.lastname.TabIndex = 17;
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(96, 57);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(122, 20);
            this.email.TabIndex = 18;
            // 
            // phone
            // 
            this.phone.Location = new System.Drawing.Point(96, 93);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(122, 20);
            this.phone.TabIndex = 19;
            // 
            // add1
            // 
            this.add1.Location = new System.Drawing.Point(96, 222);
            this.add1.Multiline = true;
            this.add1.Name = "add1";
            this.add1.Size = new System.Drawing.Size(285, 33);
            this.add1.TabIndex = 20;
            // 
            // add2
            // 
            this.add2.Location = new System.Drawing.Point(96, 259);
            this.add2.Multiline = true;
            this.add2.Name = "add2";
            this.add2.Size = new System.Drawing.Size(285, 35);
            this.add2.TabIndex = 21;
            // 
            // pincode
            // 
            this.pincode.Location = new System.Drawing.Point(96, 410);
            this.pincode.Name = "pincode";
            this.pincode.Size = new System.Drawing.Size(122, 20);
            this.pincode.TabIndex = 22;
            // 
            // maleradio
            // 
            this.maleradio.AutoSize = true;
            this.maleradio.Location = new System.Drawing.Point(96, 175);
            this.maleradio.Name = "maleradio";
            this.maleradio.Size = new System.Drawing.Size(48, 17);
            this.maleradio.TabIndex = 23;
            this.maleradio.TabStop = true;
            this.maleradio.Text = "Male";
            this.maleradio.UseVisualStyleBackColor = true;
            this.maleradio.CheckedChanged += new System.EventHandler(this.maleradio_CheckedChanged);
            // 
            // femaleradio
            // 
            this.femaleradio.AutoSize = true;
            this.femaleradio.Location = new System.Drawing.Point(159, 175);
            this.femaleradio.Name = "femaleradio";
            this.femaleradio.Size = new System.Drawing.Size(59, 17);
            this.femaleradio.TabIndex = 24;
            this.femaleradio.TabStop = true;
            this.femaleradio.Text = "Female";
            this.femaleradio.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(96, 134);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 25;
            // 
            // country
            // 
            this.country.FormattingEnabled = true;
            this.country.Items.AddRange(new object[] {
            "South Korea",
            "Japan",
            "Nepal"});
            this.country.Location = new System.Drawing.Point(96, 301);
            this.country.Name = "country";
            this.country.Size = new System.Drawing.Size(98, 95);
            this.country.TabIndex = 26;
            this.country.SelectedIndexChanged += new System.EventHandler(this.country_SelectedIndexChanged);
            // 
            // state
            // 
            this.state.FormattingEnabled = true;
            this.state.Location = new System.Drawing.Point(288, 302);
            this.state.Name = "state";
            this.state.Size = new System.Drawing.Size(98, 95);
            this.state.TabIndex = 27;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 516);
            this.Controls.Add(this.state);
            this.Controls.Add(this.country);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.femaleradio);
            this.Controls.Add(this.maleradio);
            this.Controls.Add(this.pincode);
            this.Controls.Add(this.add2);
            this.Controls.Add(this.add1);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.email);
            this.Controls.Add(this.lastname);
            this.Controls.Add(this.middlename);
            this.Controls.Add(this.firstname);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(685, 555);
            this.MinimumSize = new System.Drawing.Size(685, 555);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personal Info";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.CheckBox checkBox1;
        public System.Windows.Forms.TextBox firstname;
        private System.Windows.Forms.Button submit;
        public System.Windows.Forms.TextBox middlename;
        public System.Windows.Forms.TextBox lastname;
        public System.Windows.Forms.TextBox email;
        public System.Windows.Forms.TextBox phone;
        public System.Windows.Forms.TextBox add1;
        public System.Windows.Forms.TextBox add2;
        public System.Windows.Forms.TextBox pincode;
        public System.Windows.Forms.RadioButton maleradio;
        public System.Windows.Forms.RadioButton femaleradio;
        public System.Windows.Forms.DateTimePicker dateTimePicker1;
        public System.Windows.Forms.ListBox country;
        public System.Windows.Forms.ListBox state;
    }
}

