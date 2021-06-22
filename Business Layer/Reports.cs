using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Business_Layer;

namespace Business_Layer
{
    public class Reports
    {

        private DataAccessLayer ds = new DataAccessLayer();

        public DataTable AllShops()
        {
            return ds.GetAllShops();
        }
        public DataTable Facilities()
        {
            return ds.GetFacilities();
        }
        public DataTable AllStaff()
        {
            return ds.GetAllStaff();
        }
        public DataTable AllCalls()
        {
            return ds.GetAllCalls();
        }
        public DataTable CallsNotClosed()
        {
            return ds.GetCallsNotClosed();
        }
        public DataTable CallsForShops()
        {
            return ds.GetCallsForShops();
        }
        public DataTable CallsForStaff()
        {
            return ds.GetCallsForStaff();
        }

    }
}
