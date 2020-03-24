using BloodBankSystem.BLL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodBankSystem.DAL
{
    class loginDAL
    {
        //create static string to connect db
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        public bool loginCheck(loginBLL l)
        {
            //create a boolean variable and set its default value to false
            bool isSuccess = false;

            //connecting db
            SqlConnection conn = new SqlConnection();

            try
            {
                //sql query to check login based on username and password
                string sql = "SELECT * FROM table_users WHERE username = @username AND password = @password";

                //create sql command to pass the value to sql query
                SqlCommand cmd = new SqlCommand(sql, conn);

                //pass the value to sql query using parameters
                cmd.Parameters.AddWithValue("@username", l.username);
                cmd.Parameters.AddWithValue("@password", l.password);

                //sql data adapter to get the data from db
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                //data table to hold the data from db temporarily
                DataTable dt = new DataTable();

                //fill the data from adapter to dt
                adapter.Fill(dt);

                //check if user exists
                if(dt.Rows.Count > 0)
                {
                    //user exists and login successfull
                    isSuccess = true;
                }
                else
                {
                    //login failed
                    isSuccess = false;
                }
            }
            catch(Exception e)
            {
                //display error if there are any exception errors
                MessageBox.Show(e.Message);
            }
            finally
            {
                //close db connection
                conn.Close();
            }

            return isSuccess;
        }
    }
}
