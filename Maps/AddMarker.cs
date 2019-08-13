using Maps.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maps
{
    public partial class AddMarker : Form
    {
        public AddMarker()
        {
            InitializeComponent();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Ok_Click(object sender, EventArgs e)
        {
            using (EventContext context = new EventContext())
            {
                Event marker = new Event();
                marker.Description = textBox_Description.Text;
                marker.Latitude = int.Parse(textBox_Latitude.Text);
                marker.Longitude = int.Parse(textBox_Longitude.Text);
                marker.Name = textBox_Name.Text;
                marker.Year = int.Parse(textBox_Year.Text);
                context.Events.Add(marker);
                context.SaveChanges();
                this.Close();

            }
        }
    }
}
