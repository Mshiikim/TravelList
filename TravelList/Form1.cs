using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelList.Models;

namespace TravelList
{
    public partial class Form1 : Form
    {
        TravelContext ttx = new TravelContext();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LstTravel.Items.Clear();
            var locations = ttx.Locations;
            int i = 0;
            foreach(Locations location in locations)
            {
                LstTravel.Items.Add(location.LocationId.ToString());
                LstTravel.Items[i].SubItems.Add(location.Destination);
                LstTravel.Items[i].SubItems.Add(location.Country);
                LstTravel.Items[i].SubItems.Add(location.Transportation);
                LstTravel.Items[i].SubItems.Add(location.Boarding);
                i++;
            }
        }
    }
}
