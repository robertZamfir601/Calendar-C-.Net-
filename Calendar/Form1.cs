using Calendar.Data;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Calendar
{
    public partial class Form1 : Form
    {
        int month, year;

        public static int monthStatic, yearStatic;
        public static int idx = 3;

        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            month = now.Month;
            year = now.Year;

            displayDays();
        }

        private void displayDays()
        {
            Console.WriteLine(month);
            String monthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            MonthYearText.Text = monthName + " - " + year;

            monthStatic = month;
            yearStatic = year;

            DateTime startOfTheMonth = new DateTime(year, month, 1);
            int nrOfDays = DateTime.DaysInMonth(year, month);

            int dayOfTheWeek = Convert.ToInt32(startOfTheMonth.DayOfWeek.ToString("d"));
            if (dayOfTheWeek == 0)
                dayOfTheWeek = 7;

            for(int i = 1; i < dayOfTheWeek; i++)
            {
                UserControlBlank ucbBlank = new UserControlBlank();
                dayContainer.Controls.Add(ucbBlank);
            }

            for (int i = 1; i <= nrOfDays; i++)
            {
                UserControlDays ucDays = new UserControlDays();
                ucDays.days(i);
                dayContainer.Controls.Add(ucDays);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dayContainer.Controls.Clear();

            month--;
            if (month == 0)
            {
                year--;
                month = 12;
            }

            displayDays();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {
                    }

        private void dayContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            dayContainer.Controls.Clear();

            month++;
            if(month == 13)
            {
                year++;
                month = 1;
            }

            displayDays();
        }
    }
}
