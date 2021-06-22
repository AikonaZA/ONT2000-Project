using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Business_Layer
{
    public class DataAccessLayer
    {
        SqlConnection dbConn;
        SqlCommand dbCmd;
        SqlDataAdapter dbAdapter;
        private string connection;

        public DataAccessLayer()
        {
            connection = "Data Source = localhost; Initial Catalog = BayWest; Integrated Security = SSPI;";
            dbConn = new SqlConnection(connection);
            
        }

        public string Connection
        {
            get { return connection; }
            set { connection = value; }
        }

        public int AddStaff(Staff staff)
        {
            if (dbConn.State == ConnectionState.Closed)
            {
                dbConn.Open();
            }
            string sql = "sp_AddStaff '" + staff.StaffID + "','" + staff.Name + "','" + staff.DateOfBirth + "','" + staff.Address + "','" + staff.PhoneNumber + "'";
            dbCmd = new SqlCommand(sql, dbConn);
            int x = dbCmd.ExecuteNonQuery();
            return x;
        }

        public int ChangeStaff(Staff staff)
        {
            if (dbConn.State == ConnectionState.Closed)
            {
                dbConn.Open();
            }
            string sql = "sp_AddStaff '" + staff.StaffID + "','" + staff.Name + "','" + staff.DateOfBirth + "','" + staff.Address + "','" + staff.PhoneNumber + "'";
            dbCmd = new SqlCommand(sql, dbConn);
            int x = dbCmd.ExecuteNonQuery();
            return x;
        }

        public int AddCalls(Calls calls)
        {
            if (dbConn.State == ConnectionState.Closed)
            {
                dbConn.Open();
            }
            string sql = "sp_AddCalls '" + calls.CallID + "','" + calls.Status + "','" + calls.StaffID + "','" + calls.VenueID + "','" + calls.Comments + "'" ;
            dbCmd = new SqlCommand(sql, dbConn);
            int x = dbCmd.ExecuteNonQuery();
            return x;
        }

        public int ChangeCalls(Calls calls)
        {
            if (dbConn.State == ConnectionState.Closed)
            {
                dbConn.Open();
            }
            string sql = "sp_AddCalls '" + calls.CallID + "','" + calls.Status + "','" + calls.StaffID + "','" + calls.VenueID + "','" + calls.Comments + "'";
            dbCmd = new SqlCommand(sql, dbConn);
            int x = dbCmd.ExecuteNonQuery();
            return x;
        }

        public int AddShops(Venues venues)
        {
            if (dbConn.State == ConnectionState.Closed)
            {
                dbConn.Open();
            }
            string sql = ("sp_AddVenues '" + venues.ShopID + "','" + venues.ShopName + "','" + venues.ShopLocation + "'");
            dbCmd = new SqlCommand(sql, dbConn);
            int x = dbCmd.ExecuteNonQuery();
            return x;
        }

        public int ChangeShops(Venues venues)
        {
            if (dbConn.State == ConnectionState.Closed)
            {
                dbConn.Open();
            }
            string sql = ("sp_AddVenues '" + venues.ShopID + "','" + venues.ShopName + "','" + venues.ShopLocation + "'");
            dbCmd = new SqlCommand(sql, dbConn);
            int x = dbCmd.ExecuteNonQuery();
            return x;
        }

        public int AddRentals(RentalAgreements rentals)
        {
            if (dbConn.State == ConnectionState.Closed)
            {
                dbConn.Open();
            }
            string sql = ("sp_AddRentals '" + rentals.RentalAgrrementID + "','" + rentals.ShopID + "','" + rentals.RentalDate + "','" + rentals.RentDuration + "'");
            dbCmd = new SqlCommand(sql, dbConn);
            int x = dbCmd.ExecuteNonQuery();
            return x;
        }

        public int ChangeRentals(RentalAgreements rentals)
        {
            if (dbConn.State == ConnectionState.Closed)
            {
                dbConn.Open();
            }
            string sql = ("sp_AddRentals '" + rentals.RentalAgrrementID + "','" + rentals.ShopID + "','" + rentals.RentalDate + "','" + rentals.RentDuration + "'");
            dbCmd = new SqlCommand(sql, dbConn);
            int x = dbCmd.ExecuteNonQuery();
            return x;
        }

        public DataTable GetAllShops()
        {
            DataTable dtShop = new DataTable();
            string sql = "sp_AllShops";
            dbCmd = new SqlCommand(sql, dbConn);
            dbAdapter = new SqlDataAdapter(dbCmd);
            dbAdapter.Fill(dtShop);
            return dtShop;
        }

        public DataTable GetAllStaff()
        {
            DataTable dtStaff = new DataTable();
            string sql = "sp_AllStaff";
            dbCmd = new SqlCommand(sql, dbConn);
            dbAdapter = new SqlDataAdapter(dbCmd);
            dbAdapter.Fill(dtStaff);
            return dtStaff;
        }

        public DataTable GetAllCalls()
        {
            DataTable dtCalls = new DataTable();
            string sql = "sp_AllCalls";
            dbCmd = new SqlCommand(sql, dbConn);
            dbAdapter = new SqlDataAdapter(dbCmd);
            dbAdapter.Fill(dtCalls);
            return dtCalls;
        }

        public DataTable GetAllRentals()
        {
            DataTable dtRentals = new DataTable();
            string sql = "sp_AllRentals";
            dbCmd = new SqlCommand(sql, dbConn);
            dbAdapter = new SqlDataAdapter(dbCmd);
            dbAdapter.Fill(dtRentals);
            return dtRentals;
        }

        public DataTable GetAllServices()
        {
            DataTable dtService = new DataTable();
            string sql = "sp_AllServices";
            dbCmd = new SqlCommand(sql, dbConn);
            dbAdapter = new SqlDataAdapter(dbCmd);
            dbAdapter.Fill(dtService);
            return dtService;
        }
        public DataTable GetAllSchedules()
        {
            DataTable dtSchedule = new DataTable();
            string sql = "sp_AllSchedules";
            dbCmd = new SqlCommand(sql, dbConn);
            dbAdapter = new SqlDataAdapter(dbCmd);
            dbAdapter.Fill(dtSchedule);
            return dtSchedule;
        }

        public DataTable GetFacilities()
        {
            DataTable dtFacilities = new DataTable();
            string sql = "sp_Facilities";
            dbCmd = new SqlCommand(sql, dbConn);
            dbAdapter = new SqlDataAdapter(dbCmd);
            dbAdapter.Fill(dtFacilities);
            return dtFacilities;
        }

        public DataTable GetCallsNotClosed()
        {
            DataTable dtNotClosed = new DataTable();
            string sql = "sp_CallsNotClosed";
            dbCmd = new SqlCommand(sql, dbConn);
            dbAdapter = new SqlDataAdapter(dbCmd);
            dbAdapter.Fill(dtNotClosed);
            return dtNotClosed;
        }

        public DataTable GetCallsForShops()
        {
            DataTable dtCallsShop = new DataTable();
            string sql = "sp_CallsForShops";
            dbCmd = new SqlCommand(sql, dbConn);
            dbAdapter = new SqlDataAdapter(dbCmd);
            dbAdapter.Fill(dtCallsShop);
            return dtCallsShop;
        }
        public DataTable GetCallsForStaff()
        {
            DataTable dtCallsStaff = new DataTable();
            string sql = "sp_CallsForStaff";
            dbCmd = new SqlCommand(sql, dbConn);
            dbAdapter = new SqlDataAdapter(dbCmd);
            dbAdapter.Fill(dtCallsStaff);
            return dtCallsStaff;
        }
    }
}
