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

namespace Calendar
{
    public partial class UserControlDays : UserControl
    {
        public static string dayStatic;
        public UserControlDays()
        {
            InitializeComponent();
        }

        public void days(int numDay)
        {
            lbDays.Text = numDay + " ";
        }

        private void UserControlDays_Click(object sender, EventArgs e)
        {
            dayStatic = lbDays.Text.Trim();
            timer1.Start();
            EventForm eventForm = new EventForm();
            eventForm.Show();
        }

        private void lbDays_Click(object sender, EventArgs e)
        {
            dayStatic = lbDays.Text.Trim();
            EventForm eventForm = new EventForm();
            eventForm.Show();
        }

        private void displayevent()
        {
            var configuration = new ConfigurationBuilder()
               .AddJsonFile("E:\\D\\Proiecte\\C#\\Calendar\\Calendar\\appsettings.json")
               .Build(); ;
            PostgreSQLContext context = new PostgreSQLContext(configuration);

            string date = lbDays.Text.Trim() + "/" + Form1.monthStatic + "/" + Form1.yearStatic;
            

            var events = context.Events.Where(e => e.start_date.Day == DateTime.Parse(date).Day && 
                                    e.start_date.Month == DateTime.Parse(date).Month &&
                                    e.start_date.Year == DateTime.Parse(date).Year).ToList();
            Console.WriteLine("\t\t any: " + events.Any());
            foreach(var e in events)
            {
                eventLabel.Text = e.title;
            }


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            displayevent();
        }

        private void eventLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
