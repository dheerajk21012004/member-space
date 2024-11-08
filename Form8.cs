﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace member_space
{
    public partial class Form8 : Form
    {
        public event EventHandler PaymentCompleted;
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Retrieve payment details
            string cardholder_Name = textBox2.Text;
            string cardNumber = textBox3.Text;
            string expiration_Date = textBox4.Text;
            string CVV = textBox5.Text;

            // Open confirmation form with payment details
            Form9 confirmationForm = new Form9(cardholder_Name, cardNumber, expiration_Date, CVV);
            confirmationForm.PaymentConfirmed += ConfirmationForm_PaymentConfirmed; // Event handler for confirmation
            confirmationForm.Show();
        }
        private void ConfirmationForm_PaymentConfirmed(object sender, EventArgs e)
        {
            // Raise the PaymentCompleted event to notify Form1
            PaymentCompleted?.Invoke(this, EventArgs.Empty);
            this.Close(); // Close Form2 after confirmation
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
