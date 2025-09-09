using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace MobileFoodTruck_63269996
{
    public partial class Form2 : Form
    {
        //public values that we will use throughout
        double Total = 0;
        double checkBoxTotal = 0;
        double radioTotal = 0;

        //public values that we will capture to copy to form3
        string radioButtonItem = "";
        string comboboxItem = "";
        string totalItem = "";

        string dateSelected = "";

        string[] checkBoxItems;



        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            radioButton1.Select();
            monthCalendar1.MinDate = DateTime.Today;
            monthCalendar1.MaxDate = DateTime.Today.AddMonths(1);

            //update the total box when the form loads

            //txtTotal.Text = radioInfo;
            txtTotal.Text = getValueAfterR(radioButton1.Text);

            //add code to listen to the groupbox with radiobuttons
            foreach (Control control in groupBox1.Controls)
            {
                if (control is RadioButton radioButton)
                {
                    radioButton.CheckedChanged += radioButton_CheckedChanged;
                }
            }



            //Code for the listener:
            checkedListBox1.ItemCheck += checkedListBox1_ItemCheck;

            //add code to listen to the calender
            monthCalendar1.DateSelected += monthCalendar1_DateSelected;
        }

        private void monthCalendar1_DateSelected(object? sender, DateRangeEventArgs e)
        {
            DateTime selectedDate = e.Start;
            txtBookingDate.Text = selectedDate.ToShortDateString();
        }

        private void checkedListBox1_ItemCheck(object? sender, ItemCheckEventArgs e)
        {
            string theString = "";
            string item = checkedListBox1.Items[e.Index].ToString();
            bool itemChecked = (e.NewValue == CheckState.Checked);
            if (itemChecked)
            {
                theString = getValueAfterR(item);   //100
                checkBoxTotal = checkBoxTotal + double.Parse(theString);
            }
            else
            {
                theString = getValueAfterR(item);  //100
                checkBoxTotal = checkBoxTotal - double.Parse(theString);
            }
            Total = radioTotal + getTotalCheckBoxes();
            txtTotal.Text = Total.ToString();  //display the total in txtTotal
        }

        private string getValueAfterR(string text)
        {
            Match match = Regex.Match(text, @"R\s*(\d+(\.\d+)?)");  // Matches R followed by number
            if (match.Success)
            {
                return match.Groups[1].Value;  // Returns just the number, like "35" or "35.50"
            }

            return "0";
        }


        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;
            if (radioButton != null && radioButton.Checked)
            {

                // MessageBox.Show(radioButton.Text);
                radioButtonItem = radioButton.Text; // This now holds the value of the selected RadioButton – to be passed to Form3
                
                string getValue = getValueAfterR(radioButton.Text);
                radioTotal = double.Parse(getValue);
                Total = radioTotal + getTotalCheckBoxes();
                txtTotal.Text = Total.ToString();
            }
        }

        private double getTotalCheckBoxes()
        {
            //this is where we will calculate the check boxes
            return checkBoxTotal;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            totalItem = txtTotal.Text;
            //MessageBox.Show(totalItem);
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Create a string array with the same size as the number of checked items
            string[] selectedItemsArray = new string[checkedListBox1.CheckedItems.Count];

            // Loop through and fill the array
            int i = 0;
            foreach (object item in checkedListBox1.CheckedItems)
            {
                selectedItemsArray[i] = item.ToString();
                i++;
            }
            checkBoxItems = selectedItemsArray;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboboxItem = comboBox1.Text;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtBookingDate.Text.Length < 1)
            {
                MessageBox.Show("First select a date for your booking.");
            }
            else
            {

                Form3 form3 = new Form3(radioButtonItem, checkBoxItems, comboboxItem, dateSelected, totalItem);
                form3.Show();
            }
        }

        private void txtBookingDate_TextChanged(object sender, EventArgs e)
        {
            dateSelected = txtBookingDate.Text;
        }
    }
}
