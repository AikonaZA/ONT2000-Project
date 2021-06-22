using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Business_Layer;

namespace ONT2000_Project
{
    public partial class FormVenuesAdd : Form
    {
        public FormVenuesAdd()
        {
            InitializeComponent();
        }
        Business_Layer.Venues venues;

        private void buttonOk_Click(object sender, EventArgs e)
        {
            venues = new Venues(textBoxShopID.Text, textBoxShopName.Text, textBoxShopLocation.Text);
            venues.AddVenues();

            FormVenues FormVen = new FormVenues();
            FormVen.Visible = true;
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            FormVenues FormVen = new FormVenues();
            FormVen.Visible = true;
            this.Close();
        }
    }
}
