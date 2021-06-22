using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Business_Layer
{
    public class Services
    {
        private string serviceID;
        private string serviceType;
        private string scheduleID;
        private string scheduleDescription;
        private string scheduleDate;
        private string shopID;

        public string ServiceID
        {
            get { return serviceID; }
            set { serviceID = value; }
        }
        public string ServiceType
        {
            get { return serviceType; }
            set { serviceType = value; }
        }
        public string ScheduleID
        {
            get { return scheduleID; }
            set { scheduleID = value; }
        }
        public string ScheduleDescription
        {
            get { return scheduleDescription; }
            set { scheduleDescription = value; }
        }
        public string ScheduleDate
        {
            get { return scheduleDate; }
            set { scheduleDate = value; }
        }
        public string ShopID
        {
            get { return shopID; }
            set { shopID = value; }
        }

        public Services() { }

        public Services(string serviceID, string serviceType, string scheduleID, string scheduleDescription, string scheduleDate, string shopID)
        {
            this.serviceID = serviceID;
            this.serviceType = serviceType;
            this.scheduleID = scheduleID;
            this.scheduleDescription = scheduleDescription;
            this.scheduleDate = scheduleDate;
            this.shopID = shopID;
        }
        private DataAccessLayer ds = new DataAccessLayer();

        public DataTable AllServices()
        {
            return ds.GetAllServices();
        }
        public DataTable AllSchedules()
        {
            return ds.GetAllSchedules();
        }
    }
}
