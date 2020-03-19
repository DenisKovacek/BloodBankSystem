using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBankSystem.DAL
{
    class donorDAL
    {
        //create a connection string to connect db
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;
        #region SELECT to display data from db
        public DataTable Select()
        {
            //create object of data table to call the data from db and return it
            DataTable dt = new DataTable();

            //create object of sql connection to connect to the db
            SqlConnection conn = new SqlConnection(myconnstrng);

            return dt;
        }
        #endregion
    }
}
