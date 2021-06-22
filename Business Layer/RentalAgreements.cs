using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Business_Layer
{
    public class RentalAgreements
    {
        private string rentalAgreementID;
        private string shopID;
        private string rentalDate;
        private string rentDuration;
        
        private DataAccessLayer ds = new DataAccessLayer();
        
        public string RentalAgrrementID
        {
            get { return rentalAgreementID;}
            set { rentalAgreementID = value; }
        }
        public string ShopID
        {
            get { return shopID; }
            set { shopID = value; }
        }
        public string RentalDate
        {
            get { return rentalDate; }
            set { rentalDate = value; }
        }
        public string RentDuration
        {
            get { return rentDuration; }
            set { rentDuration = value; }
        }
        public RentalAgreements() { }
        public RentalAgreements(string rentalAgreementID, string shopID, string rentalDate, string rentDuration)
        {
            this.rentalAgreementID = rentalAgreementID;
            this.shopID = shopID;
            this.rentalDate = rentalDate;
            this.rentDuration = rentDuration;
        }

        public DataTable AllRentals()
        {
            return ds.GetAllRentals();
        }

        public void AddRentals()
        {
            ds.AddRentals(this);
        }
        public void ChangeRentals()
        {
            ds.ChangeRentals(this);
        }
        
    }
}
