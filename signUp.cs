using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace member_space
{
    public partial class signUp : Form
    {
        // Define the connection string for your database
        public string connectionString = "Server=127.0.0.1;Database=together_culture;Uid=root;Pwd=;";



        public signUp()
        {
            InitializeComponent();

        }

        // Event handler for Form Load
        private void signUp_Load(object sender, EventArgs e)
        {
            // Populate the combo box with security questions
            //combobxSecurityQues.Items.Add("Name of the city you were born in?");
            //combobxSecurityQues.Items.Add("Name of the first school you went to?");
           // combobxSecurityQues.Items.Add("Name of your first pet?");
        }

        // Register Button Click event handler
        private void ButtonRegister_Click(object sender, EventArgs e)
        {
            // Check for empty fields
            if (string.IsNullOrEmpty(txtbUsername.Text) ||
                string.IsNullOrEmpty(txtbPassword.Text) ||
                string.IsNullOrEmpty(txtbConfirmpass.Text) ||
                 string.IsNullOrEmpty(textBxFirstName.Text) ||
                string.IsNullOrEmpty(textBxLastname.Text) ||
                string.IsNullOrEmpty(dateTimePicker2.ToString()) ||
                combobxSecurityQues.SelectedItem == null ||
                string.IsNullOrEmpty(textbSecurityQuesAns.Text))

            {
                MessageBox.Show("All fields are required.", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (txtbPassword.Text == txtbConfirmpass.Text)
            {

                try
                {
                    // Initialize the database helper
                    dataBaseHelper dbHelper = new dataBaseHelper();
                    string errorMessage;

                    // Insert logindetails using the helper class
                    bool isInserted = dbHelper.InsertLogindetailsAndNonmember(

                        textBxFirstName.Text,
                        textBxLastname.Text,
                        txtbUsername.Text,
                        txtbPassword.Text,
                        combobxSecurityQues.SelectedItem.ToString(),
                        textbSecurityQuesAns.Text,
                        dateTimePicker2.ToString(),



                        out errorMessage);

                    if (isInserted)
                    {
                        // Clear fields after successful registration
                        txtbUsername.Text = "";
                        txtbPassword.Text = "";
                        txtbConfirmpass.Text = "";
                        textBxFirstName.Text = "";
                        textBxLastname.Text = "";
                        combobxSecurityQues.SelectedItem = null;
                        textbSecurityQuesAns.Text = "";
                        dateTimePicker2.ToString();

                        MessageBox.Show("Your account has been successfully created", "Registration Success", MessageBoxButtons.OK);

                        new Login().Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("An error occurred: " + errorMessage, "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An unexpected error occurred: " + ex.Message, "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


            else
            {
                MessageBox.Show("Passwords do not match. Please re-enter.", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtbPassword.Text = "";
                txtbConfirmpass.Text = "";
                txtbPassword.Focus();
            }
        }

        // Checkbox to Show/Hide Password
        private void CHbxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (CHbxShowPass.Checked)
            {
                txtbPassword.PasswordChar = '\0';
                txtbConfirmpass.PasswordChar = '\0';
            }
            else
            {
                txtbPassword.PasswordChar = '*';
                txtbConfirmpass.PasswordChar = '*';

            }


        }

        private void LbacktoLogin_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Close();
        }
         
        private void txtbPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void textbSecurityQuesAns_TextChanged(object sender, EventArgs e)
        {

        }

        private void combobxSecurityQues_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LAnswer_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtbConfirmpass_TextChanged(object sender, EventArgs e)
        {
      
    }

        private void textBxFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }
    }
    }
