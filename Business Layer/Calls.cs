using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Business_Layer
{
    public class Calls
    {
        private string callID;
        private string status;
        private string staffID;
        private string venueID;
        private string comments;

        private DataAccessLayer ds = new DataAccessLayer();
        public string CallID
        {
            get { return callID; }
            set { callID = value; }
        }
        public string Status
        {
            get { return status; }
            set { status = value; }
        }
        public string StaffID
        {
            get { return staffID; }
            set { staffID = value; }
        }
        public string VenueID
        {
            get { return venueID; }
            set { venueID = value; }
        }
        public string Comments
        {
            get { return comments; }
            set { comments = value; }
        }

        public Calls() { }

        public Calls(string callID, string status, string staffID, string venueID, string comments)
        {
            this.callID = callID;
            this.status = status;
            this.staffID = staffID;
            this.venueID = venueID;
            this.comments = comments;
        }

        public void AddCalls()
        {
            ds.AddCalls(this);
        }
        public void ChangeCalls()
        {
            ds.ChangeCalls(this);
        }

        public DataTable AllCalls()
        {
            return ds.GetAllCalls();
        }
    }
}
