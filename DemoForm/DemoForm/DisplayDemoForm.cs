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
    public partial class DisplayDemoForm : Form
    {
        public Form1 fors;
        
        public DisplayDemoForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

            
        }

        private void DisplayDemoForm_Load(object sender, EventArgs e)
        {
            label11.Text = "Hi your first name is " + fors.firstname.Text;
            label2.Text = (fors.middlename.Text == "") ? "<<No middle Name>>" : fors.middlename.Text;
            label3.Text = "Hi your lastname is " + fors.lastname.Text;
            label4.Text = "Your email " +fors.email.Text + " is coool, but it is vulnerable";
            label5.Text = "Hi your phone no is :) "+ fors.phone.Text;
            label6.Text = "Your Home Address is "+fors.add1.Text;
            label7.Text = "You don't have optional address "+ fors.add2.Text;
            label8.Text = "Your resenditial pin is "+ fors.pincode.Text;
            label9.Text = "You are a "+ ((fors.maleradio.Checked) ? fors.maleradio.Text : fors.femaleradio.Text);
            DateTime x = fors.dateTimePicker1.Value;
            label10.Text = "Your Date of birth is " + x;

            label13.Text = "Your country is " + fors.country.SelectedItem.ToString();
            label14.Text = "Your state is " + fors.state.SelectedItem.ToString();


        }
    }
}
