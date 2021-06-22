using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Business_Layer
{
    public class Venues
    {
        private string shopID;
        private string shopName;
        private string shopLocation;

        public string ShopID
        {
            get { return shopID; }
            set { shopID = value; }
        }
        public string ShopName
        {
            get { return shopName; }
            set { shopName = value; }
        }
        public string ShopLocation
        {
            get { return shopLocation; }
            set { shopLocation = value; }
        }

        public Venues() { }

        public Venues (string shopID, string shopName, string shopLocation)
        {
            this.shopID = shopID;
            this.shopName = shopName;
            this.shopLocation = shopLocation;
        }

        private DataAccessLayer ds = new DataAccessLayer();
        public DataTable AllShops()
        {
            return ds.GetAllShops();
        }

        public void AddVenues()
        {
            ds.AddShops(this);
        }
        public void ChangeVenues()
        {
            ds.ChangeShops(this);
        }
    }
}
