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
    public partial class InteractiveCalendar : Form
    {
        public InteractiveCalendar()
        {
            InitializeComponent();
            calendar_creator(DateTime.Now.Year, DateTime.Now.Month);
        }
        private void calendar_creator(int year, int month)
        {
            //This will clear the previous controls
            Calendar.Controls.Clear();

            //This will get the first day of the month so we can create the ordering of the panels off of it
            DateTime month_Start = new DateTime(year, month, 1);

            //This will calculate the days in the current month to get number of panels needed
            int days_Month = DateTime.DaysInMonth(year, month);

            //This gets the day of the week of the first date
            int first_Day = (int)month_Start.DayOfWeek;
            //This is the panel size from testing
            int panel_Width = 156;
            int panel_Height = 100;
           
            //This will loop through the days in the month creating a panel for each
            for (int i = 1; i <= days_Month; i++) {
                //Calc the rows needed
                int col = (first_Day + i - 1) % 7;
                int row = (first_Day + i - 1) / 7;
                
                Panel day_Panel = new Panel
                {
                    Size = new Size(panel_Width - 5, panel_Height - 5),
                    Location = new Point(col * panel_Width, row * panel_Height),
                    BorderStyle = BorderStyle.FixedSingle,
                    BackColor = Color.IndianRed
                };
            Calendar.Controls.Add(day_Panel);
            
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void InteractiveCalendar_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Calendar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
