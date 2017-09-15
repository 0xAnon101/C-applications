using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessRandomNumber
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
          
        }


        struct TextboxDisplay
        {
            public int hello;
            
        } 

        //this is where the word is defined
        public static String[] words = new String[]{"appreciate","arithmetic","artificial","earthquake","economical","elasticity",
                                       "population","positively","screenplay","toothpaste"};
        public static  char[] alpha = new char[10];
        static Random random = new Random();
        public static int i = 0,count =0;
        //public static TextBox[,] textboxes = new TextBox[2, 5];
        List<int> list1 = getRandomIndexWords(10);
        static string x = "";
        static int yourMarks;







        // give u a unique random number for words...
        public static List<int> getRandomIndexWords(int count)
        {  
            HashSet<int> candidates = new HashSet<int>();
            while (candidates.Count < count)
            {
                int value = random.Next(0, 10);
                if (!candidates.Contains(value))
                     candidates.Add(value);
            }

            List<int> result = new List<int>();
            result.AddRange(candidates);

            // shuffle the results responsible for randomness...
            int i = result.Count;
            while (i > 1)
            {
                i--;
                int k = random.Next(i + 1);
                int value = result[k];
                result[k] = result[i];
                result[i] = value;
            }
            return result; // list returned for random Index of words array
            
        }








        // generates character for each word...
        public  void DisplayCharArray(String mx)
        {
            alpha = mx.ToCharArray();
           
        }





        // display the above generated character into random positon( only 5 character)...
        public void SetRandomPositionOfChar(string xy)
        {
            List<int> shuffledIndex = getRandomIndexWords(10); // the index get shuffled
            shuffledIndex.RemoveRange(6, 4);
            shuffledIndex.Sort();
            int m = 0 , foo =0;

            // program to put the text in text box....
             foreach (Control control in this.Controls)
             {
            
                if (control.GetType() == typeof(TextBox))
                 {

                    TextBox textbox = (TextBox)control;
                    if (m<5 && (textbox.TabIndex == shuffledIndex[m]))
                    {             
                        textbox.Text = alpha[shuffledIndex[m]].ToString();       
                        m++;
                      
                    }
               
                 }
               
            }
            
        }




        // fetch_data input by you.....
        public void takeInput()
        {
            
            foreach (Control control in this.Controls)
            {

                if (control.GetType() == typeof(TextBox))
                {

                    TextBox textbox = (TextBox)control;
                    x = x + textbox.Text;
                }
            }
            
        }




        // test for validation of above user inputed string...
        public  void testValidationString()
        {
            if(words.Contains(x) && !String.IsNullOrWhiteSpace(x))
            {
                yourMarks = yourMarks + 5;
                marks.Text = "Your Current Score:: \n " + yourMarks;
              //  MessageBox.Show(yourMarks.ToString());

            }
            else if(!words.Contains(x) && !String.IsNullOrWhiteSpace(x))
            {
                yourMarks = yourMarks - 5;
                marks.Text = "Your Current Score:: \n " + yourMarks;
                //MessageBox.Show(yourMarks.ToString());

            }
    
        }



        //display everthing ....wraps up result remove textbox.
        public void lastDisplayResult()
        {
            if (yourMarks <= 0)
            {
                marks.Text = "You score is poor! lol:: \n" + yourMarks;
            }
            if(yourMarks >=15)
            {
                marks.Text = "You score is good! lol:: \n" + yourMarks;
            }
        }


        // initializer before game starts :: Entry point to Game...
        private void Form1_Load(object sender, EventArgs e)
        {
            var x = MessageBox.Show("Here are the Rules ! Before Playing ::  \n " +
                "* You will given character of length 10 \n " +
                "* You have to guess only Five \n " +
                "* For each correct ans 5 points will be credited \n " +
                "* For wrong character 5 points is deducted \n ", "Welcome To HangMan", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (x ==  System.Windows.Forms.DialogResult.Yes)
            {
                MessageBox.Show("Well good luck", "Transferring...", MessageBoxButtons.OK, MessageBoxIcon.Hand);
           
            }
            else
            {
                System.Windows.Forms.Application.Exit();
            }
        }




        // This is nothing :-)
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }





        // OUR ATTEMPT BUTTON .
        private void make_attempt(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (control.GetType() == typeof(TextBox))
                {
                    TextBox textbox = (TextBox)control;
                    textbox.Clear();  // clear text Box each time
                }
            }

                string xy= "";
                if (count<5)
                {
                    xy = words[list1[count]];    // a unique word is returned here...
                    this.DisplayCharArray(xy);
                    this.SetRandomPositionOfChar(xy);
                    count++;
                   
                    list1.Remove(count);                  // remove the word  index from  list for safety.
                
            }

                else
                  {
                      
                  }
               
                if(count == 5)
            {
                this.lastDisplayResult();
            }
              
               
            
         
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            x = "";
            this.takeInput();
            testValidationString(); 
           
        }








        //OUR CLEAR BUTTON.
        private void make_attempt_clear(object sender, EventArgs e)
        {
                t1.Text = t2.Text = t3.Text = t4.Text = t5.Text = t6.Text =
                t7.Text = t8.Text = t9.Text = t10.Text = String.Empty;
                count = 0;
            x = "";
            yourMarks = 0;
        }
    }
}
