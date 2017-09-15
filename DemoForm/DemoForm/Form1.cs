using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

  

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var x = MessageBox.Show("Welcome To Fill our Form ! \n Wanna Continue ?", "Welcome", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (x != System.Windows.Forms.DialogResult.Yes)
            {
                MessageBox.Show("You are exiting now!", "Exit Window", MessageBoxButtons.OK, MessageBoxIcon.Error);
                System.Windows.Forms.Application.Exit();
            }
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Value = DateTime.Today;
        }

        private void submit_click(object sender, EventArgs e)
        {

            if(email.Text == "")
            {
                MessageBox.Show("Email Required!", "#######", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if(pincode.Text == "")
            {
                MessageBox.Show("Pincode required!", "#######", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if(!maleradio.Checked && !femaleradio.Checked)
            {
                MessageBox.Show("Select Gender! ", "#######", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if(add1.Text == "")
            {
                MessageBox.Show("Address 1 is mandatory!", "#######", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            var x = MessageBox.Show(" Wanna Submit ?", "View", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (x == System.Windows.Forms.DialogResult.Yes && checkBox1.Checked)
            {
                DisplayDemoForm a = new DisplayDemoForm();
                a.fors = this;
                a.Show();
            }
            else {
                MessageBox.Show("Sorry! something is incomplete.","#######", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
        }
      

        private void reset_click(object sender, EventArgs e)
        {
            firstname.Text = lastname.Text=middlename.Text=email.Text=phone.Text=pincode.Text=
                add1.Text=add2.Text="";
            checkBox1.Checked = maleradio.Checked = femaleradio.Checked = false;
            state.Items.Clear();
            for(int i = 0; i< country.Items.Count; i ++)
            {
                country.SetSelected(i, false);
            }
            for (int i = 0; i < state.Items.Count; i++)
            {
                country.SetSelected(i, false);
            }

        }

        public void country_SelectedIndexChanged(object sender, EventArgs e)
        {
            string c = (string)country.SelectedItem;
            if(c == "South Korea" )
            {
                state.Items.Clear();
                state.Items.Add("Seoul");
                state.Items.Add("Busan");
                state.Items.Add("Daegu");
                state.Items.Add("Pohang");

            }
            if(c == "Japan")
            {
                state.Items.Clear();
                state.Items.Add("Tokyo");
                state.Items.Add("Hokaida");
                state.Items.Add("Nagasaki");
                state.Items.Add("Osaka");
            }
            if(c == "Nepal")
            {
                state.Items.Clear();
                state.Items.Add("Lumbini");
                state.Items.Add("Gorkha");
                state.Items.Add("Banke");
                state.Items.Add("Achham");
            }
        }




        // radio button 
        private void maleradio_CheckedChanged(object sender, EventArgs e)
        { 
        }
    }
}
