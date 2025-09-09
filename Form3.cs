using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.IO;

namespace MobileFoodTruck_63269996
{
    public partial class Form3 : Form
    {
        //public values
        string pubRadioButton, pubComboboxItem, pubDate, pubTotal;
        string[] pubCheckBoxItems;
        public Form3(string radioButtonItem, string[] checkBoxItems, string comboboxItems, string dateSelected, string totalItem)
        {
            InitializeComponent();
            //MessageBox.Show(radioButtonItem);
            //MessageBox.Show(comboboxItems);
            //MessageBox.Show(dateSelected);
            //MessageBox.Show(totalItem);
            //MessageBox.Show(checkBoxItems.Length.ToString());
            pubRadioButton = radioButtonItem;
            pubComboboxItem = comboboxItems;
            pubDate = dateSelected;
            pubTotal = totalItem;
            pubCheckBoxItems = checkBoxItems;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            txtName.Focus();
        }


        private void txtName_Leave(object sender, EventArgs e)
        {
            {
                string nameInput = txtName.Text;
                //pattern to allow only letters and spaces

                string allowedPattern = @"^[A-Za-z\s]+$";
                //count only the letters

                int letterCount = Regex.Matches(nameInput, "[A-za-z]").Count;
                if (Regex.IsMatch(nameInput, allowedPattern) && letterCount >= 2)
                {
                    // Console.WriteLine("Valid name.");
                    txtName.Text = txtName.Text.ToUpper();
                }
                else
                {
                    // Console.WriteLine("Invalud name. Use letters and spaces only");
                    MessageBox.Show("Invalid name. Use letters and spaces only, with atleast 2 letters.");
                }
            }
        }

        private void txtCellphone_Leave(object sender, EventArgs e)
        {
            string input = txtCellphone.Text.Trim();

            // Pattern: starts with 0, then 9 digits (total 10 digits)
            string pattern = @"^0\d{9}$";

            if (!Regex.IsMatch(input, pattern))
            {
                MessageBox.Show("Invalid cellphone number. It should start with 0 and have 10 digits total.");
                txtCellphone.Focus();
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

            if (!Regex.IsMatch(email, emailPattern))
            {
                MessageBox.Show("Please enter a valid email address.");
                txtEmail.Focus();
            }
        }

        private void txtIDNumber_Leave(object sender, EventArgs e)
        {
            string id = txtIDNumber.Text.Trim();

            if (!Regex.IsMatch(id, @"^\d{13}$"))
            {
                MessageBox.Show("ID number must be exactly 13 digits.");
                txtIDNumber.Focus();
                return;
            }
            string dobPart = id.Substring(0, 6);
            if (!DateTime.TryParseExact(dobPart, "yyMMdd", null, System.Globalization.DateTimeStyles.None, out _))
            {
                MessageBox.Show("ID number contains an invalid date.");
                txtIDNumber.Focus();
            }
        }

        private void txtIDNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Save the information to C:\\myData\\OrderInfo.txt
            string path = @"C:\MyData\OrderInfo.txt";

            

            DateTime currentDateOnly = DateTime.Today;
            //Append info to the file.  Separate entries by ;
            string currentDate = currentDateOnly.ToString("yyyy/MM/dd");
            File.AppendAllText(path, currentDate + ";");
            File.AppendAllText(path, txtName.Text + ";");
            File.AppendAllText(path, txtCellphone.Text + ";");
            File.AppendAllText(path, txtEmail.Text + ";");
            File.AppendAllText(path, txtIDNumber.Text + ";");

            //add the array items to a string, separated by ;
            string checkboxitems = "";
            for (int i = 0; i < pubCheckBoxItems.Length; i++)
            {
                checkboxitems = checkboxitems + pubCheckBoxItems[i] + ","; //Separated by comma
            }
            File.AppendAllText(path, checkboxitems);

            File.AppendAllText(path, pubRadioButton + ";");
            File.AppendAllText(path, pubComboboxItem + ";");
            File.AppendAllText(path, pubTotal + ";");
            File.AppendAllText(path, pubDate);
            File.AppendAllText(path, "\n");

        }
    }
}
