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
    public partial class FormRentalAgreementAdd : Form
    {
        public FormRentalAgreementAdd()
        {
            InitializeComponent();
        }
        Business_Layer.RentalAgreements rental;
        Business_Layer.Venues shop;

        private void FormRentalAgreementAdd_Load(object sender, EventArgs e)
        {
            shop = new Venues();

            comboBoxShopID.DataSource = shop.AllShops();
            comboBoxShopID.DisplayMember = "ShopName";
            comboBoxShopID.ValueMember = "ShopID";
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            rental = new RentalAgreements(textBoxRentID.Text, comboBoxShopID.SelectedIndex.ToString(), textBoxRentDate.Text, textBoxRentDuration.Text);
            rental.AddRentals();

            FormRentalAgreement FrmRnt = new FormRentalAgreement();
            FrmRnt.Visible = true;
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            FormRentalAgreement FrmRnt = new FormRentalAgreement();
            FrmRnt.Visible = true;
            this.Close();
        }
    }
}
