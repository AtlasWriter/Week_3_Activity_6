using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week_1_Activity_2
{
    // This form is for the conversion of miles to kilometers.
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
           // Begin the conversion process method
        private void beginConversionButton_Click(object sender, EventArgs e)
        {  // Parse the user entered miles into a double varable
            double miles = double.Parse(userInputMiles.Text);
           // Create a varable with the logic conversion formula
            var newConversion = miles / 0.62137;
           // Creat a to-string varable to display to user
            string Conversion = newConversion.ToString("n2");
           // Display conversion to label kilometers on form 
            kilometers.Text = Conversion;   
        }

        private void closeButton_Click(object sender, EventArgs e)
        {   // Close the form
            this.Close();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {   // Clear the TextBox controls.
            userInputMiles.Text = "";
            // Set the focus to userInputMiles.
            userInputMiles.Focus();
        }
    }
}
