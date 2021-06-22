using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Business_Layer
{
    public class Staff
    {
        private string staffID;
        private string name;
        private string dateOfBirth;
        private string address;
        private string phoneNumber;

        private DataAccessLayer ds = new DataAccessLayer();
        public string StaffID
        {
            get { return staffID; }
            set { staffID = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string DateOfBirth
        {
            get { return dateOfBirth; }
            set { dateOfBirth = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }

        public Staff() { }

        public Staff(string staffID, string name, string dateOfBirth, string address, string phoneNumber)
        {
            this.staffID = staffID;
            this.name = name;
            this.dateOfBirth = dateOfBirth;
            this.address = address;
            this.phoneNumber = phoneNumber;
        }

        public void AddStaff()
        {
            ds.AddStaff(this);
        }

        public void ChangeStaff()
        {
            ds.ChangeStaff(this);
        }
            

        public DataTable AllStaff()
        {
            return ds.GetAllStaff();
        }
    }
}
