using Calendar.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calendar
{
  
    public partial class EventForm : Form
    {
          private int DEFAULT_USER = 0;
         
        public EventForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var configuration = new ConfigurationBuilder()
                .AddJsonFile("E:\\D\\Proiecte\\C#\\Calendar\\Calendar\\appsettings.json")
                .Build(); ;
            PostgreSQLContext context = new PostgreSQLContext(configuration);

            string date = UserControlDays.dayStatic + "/" + Form1.monthStatic +  "/" + Form1.yearStatic;

            var newEvent = new Event {
                id = Form1.idx,
                title = titleText.Text, 
                description = descriptionText.Text, 
                start_date = DateTime.Parse(date + " " + startDateText.Text),
                end_date = DateTime.Parse(date + " " + endDateText.Text),
                user_id = DEFAULT_USER };
            context.Events.Add(newEvent);
            context.SaveChanges();
            Form1.idx++;

            MessageBox.Show("Saved");
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void EventForm_Load_1(object sender, EventArgs e)
        {
            eventDate.Text = UserControlDays.dayStatic + "/" + Form1.monthStatic + "/" + Form1.yearStatic;
        }
    }
}
