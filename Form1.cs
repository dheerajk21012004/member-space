﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace member_space
{
    public partial class Form1 : Form

    {
        private string connectionString = "Server=localhost;Database=;together culture; Uid=Dheeraj kodwani;Pwd=;";

        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }
        // Event handler for Form Load
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        // Method to load data from the database
        private void LoadData()
        {
            try
            {
                // Create a MySQL connection using the connection string
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    // Open the connection to the database
                    conn.Open();

                    // SQL query to select data from the eventactivity  table
                    string query = "SELECT EventActivityId, Address, Eventdate, Duration FROM eventacitivity";

                    // Set up a data adapter and fill a DataTable with the query result
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Bind the DataTable to the DataGridView
                    dataGridView1.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }

        private void togethercultureTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void aboutButton_Click(object sender, EventArgs e)
        {
            string textToDisplay = "We are gathering a membership community" +
                " united in their desire to help create a more equitable and ecological " +
                "creative economy. We provide facilities, creative leadership and entrepreneurial " +
                "skills development, momentum, structure, and resources for people to come together " +
                "and make change happen.From 15 - 20 August 2023, we installed a Cabinet of Curiosities at the Fitzwilliam Museum. Inside, visitors " +
                "could explore and discover portraits co-created through the summer, and watch the Together Culture Manifesto" +
                " film made in partnership with Anglia Ruskin University and director Pablo Tranchell.";
           

            Form3 form3 = new Form3(textToDisplay);
            form3.Show();
        }

        private void blogButton_Click(object sender, EventArgs e)
        {
            string textToDisplay = "Together Culture is growing a community of outrageously curious," +
                " open-minded and creative members who care for each other and want to build a more " +
                "inclusive and ecological Cambridge. Today, we’re introducing you to Lele, an illustrator " +
                "and designer. You can find out more about her work here. I’m an illustrator and designer, so " +
                "I work on books, magazines, advertising campaigns, games, and all sorts of products.\r\n\r\nI" +
                " dip in and out when I'm at Together Culture. There’s always someone that you can meet and I " +
                "really enjoy attending the workshops, Helping Each Other Forums, and if I can contribute something " +
                "it’s always interesting and exciting to be a part of.  \r\n\r\nTwo years ago I did an illustration " +
                "for a course I was on - it was part of an assignment to imagine a world in which creatives are happy." 
                ;
            Form4 form4 = new Form4(textToDisplay); form4.Show();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void whatsonButton_Click(object sender, EventArgs e)
        {
            string textToDisplay = "Abbey in Action was developed by Together Culture and Abbey People, " +
                "and we will be working in collaboration with CCVS. We'll be recruiting 10 leaders who" +
                " live in Abbey and have the ambition of making positive change in their community, aspire" +
                " to develop their own voices as local changemakers, and who will work as a team to develop " +
                "a programme to help more of their neighbours to do the same. The leaders will work across" +
                " the next six months to contribute their expertise in a series of workshops that culminates " +
                "in the delivery of an event that the cohort develops.";
            Form5 form5 = new Form5(textToDisplay);
            form5.Show();
        }

        private void shopButton_Click(object sender, EventArgs e)
        {
            string textToDisplay = "1.The Future We Choose: 'Everyone should read this book' MATT HAIG - £17.99";
            string textToDisplay1 = "2.The Sum of Us: What Racism Costs Everyone and How We Can Prosper Together - £17.99";
            string textToDisplay2 = "3.The Mindful Kitchen: Vegetarian Cooking to Relate to Nature - £17.99";
            string textToDisplay3 = "4.#futuregen: Lessons from a Small Country - £17.99";
            string textToDisplay4 = "5.Invisible Work: The Hidden Ingredient of True Creativity, Purpose and Power - £17.99";

            Form6 form6 = new Form6(textToDisplay,textToDisplay1,textToDisplay2,textToDisplay3,textToDisplay4);
            

            form6.Show();
            


        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            // Display a message box to confirm logout
            MessageBox.Show("You have been logged out of the system.", "Logout", MessageBoxButtons.OK, MessageBoxIcon.Information);
            FrontPage mainpage = new FrontPage();
            mainpage.Show();
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }
    }
}
