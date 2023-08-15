using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsHomeWorkDemo1
{
    public partial class UserInfo : Form
    {
        BindingList<string> firstNames = new BindingList<string>();
        BindingList<string> lastNames = new BindingList<string>();

        public UserInfo()
        {
            InitializeComponent();
        }

        private void AddNameToList(BindingList<string> nameList, TextBox inputText, string errorMessage)
        {
            if (string.IsNullOrEmpty(inputText.Text))
            {
                MessageBox.Show("Please enter your first name and last name.", "Blank Message Field", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                nameList.Add(inputText.Text);
                inputText.Text = "";
            }

            inputText.Focus();
        }

        private void addFirstNameButton_Click(object sender, EventArgs e)
        {
            AddNameToList(firstNames, firstNameText, "Please enter your first name.");
        }

        private void addLastName_Click(object sender, EventArgs e)
        {
            AddNameToList(lastNames, lastNameText, "Please enter your last name.");
        }

        private void greetButton_Click(object sender, EventArgs e)
        {
            if (firstNames.Count > 0 && lastNames.Count > 0)
            {
                MessageBox.Show($"Hi {firstNames[firstNames.Count - 1]} {lastNames[lastNames.Count - 1]}");
            }
            else
            {
                MessageBox.Show("Please enter both first and last name.", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        
    }
}
