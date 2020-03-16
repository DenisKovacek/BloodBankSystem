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
   public class userDAL
    {
        //creating static string for connection with db
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        #region SELECT data from database
        public DataTable Select()
        {
            //create an object to connect db
            SqlConnection conn = new SqlConnection(myconnstrng);

            //create a datatable to hold the data from db
            DataTable dt = new DataTable();

            try
            {
                //write sql query to get data from db
                String sql = "SELECT * FROM table_users";

                //create sql command to execute query
                SqlCommand cmd = new SqlCommand(sql, conn);

                //create sql data adapter to hold data from db temporarily
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                //open db connection
                conn.Open();

                //transfer data from sqldata adapter to datatable
                adapter.Fill(dt);
            }
            catch(Exception e)
            {
                //display error message if there is any exceptional errors
                MessageBox.Show(e.Message);
            }
            finally
            {
                //close db conn
                conn.Close();
            }

            return dt;
        }
        #endregion

        #region Insert data into Database for User Module
        public bool Insert(userBLL u)
        {
            //create a boolean variable and set its default value to false
            bool isSuccess = false;

            //create an object of sqlconnection to connect db
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                //create a string variable to store the insert query
                String sql = "INSERT INTO table_users(username, email, password, full_name, contact, address, added_date, image_name) VALUES (@username, @email, @password, @full_name, @contact, @address, @added_date, @image_name)";

                //create sql command to pass the value in our query
                SqlCommand cmd = new SqlCommand(sql, conn);

                //create the parameter to pass get the value from UI and pass it on sql query above
                cmd.Parameters.AddWithValue("@username", u.username);
                cmd.Parameters.AddWithValue("@email", u.email);
                cmd.Parameters.AddWithValue("@password", u.password);
                cmd.Parameters.AddWithValue("@full_name", u.full_name);
                cmd.Parameters.AddWithValue("@contact", u.contact);
                cmd.Parameters.AddWithValue("@address", u.address);
                cmd.Parameters.AddWithValue("@added_date", u.added_date);
                cmd.Parameters.AddWithValue("@image_name", u.image_name);

                //open db connection
                conn.Open();

                //create an integer variable to hold the value after the query is executed
                int rows = cmd.ExecuteNonQuery();

                //the value of rows will be greater than 0 if the query is executed successfully
                //else it will be 0

                if (rows > 0)
                {
                    //query executed successfully
                    isSuccess = true;
                }
                else
                {
                    //failed to execute the query
                    isSuccess = false;
                }
            }
            catch (Exception e)
            {
                //display error message if there is any exceptional error
                MessageBox.Show(e.Message);
            }
            finally
            {
                //close db connection
                conn.Close();
            }

            return isSuccess;
        }
        #endregion

        #region UPDATE data in database (User Module)
        public bool Update(userBLL u)
        {
            //create a boolean variable and set its default value to false
            bool isSuccess = false;

            //create an object for database connection
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                //create a string variable to hold the sql query
                string sql = "UPDATE table_users SET username = @username, email = @email, password = @password, full_name = @full_name, contact = @contact, address = @address, added_date = @added_date, image_name = @image_name WHERE user_id = @user_id";

                //create sql command to execute query and also pass the values to sql query
                SqlCommand cmd = new SqlCommand();

                //now pass the values to sql query
                cmd.Parameters.AddWithValue("@username", u.username);
                cmd.Parameters.AddWithValue("@email", u.email);
                cmd.Parameters.AddWithValue("@password", u.password);
                cmd.Parameters.AddWithValue("@full_name", u.full_name);
                cmd.Parameters.AddWithValue("@contact", u.contact);
                cmd.Parameters.AddWithValue("@address", u.address);
                cmd.Parameters.AddWithValue("@added_date", u.added_date);
                cmd.Parameters.AddWithValue("@image_name", u.image_name);
                cmd.Parameters.AddWithValue("@user_id", u.user_id);

                //open db connection
                conn.Open();

                //create an integer variable to hold the value after the query is executed
                int rows = cmd.ExecuteNonQuery();

                //if the query is executed successfully the value of rows will be greater than 0 else its 0
                if (rows > 0)
                {
                    //query executed successfully
                    isSuccess = true;
                }
                else
                {
                    //failed to execute the query
                    isSuccess = false;
                }
            }
            catch(Exception e)
            {
                //display error message if there is any exceptional error
                MessageBox.Show(e.Message);
            }
            finally
            {
                //close db connection
                conn.Close();
            }

            return isSuccess;


        }

        #endregion


        #region DELETE data from database (User module)

        public bool Delete(userBLL u)
        {
            //create a boolean value and set its default value to false
            bool isSuccess = false;

            //create an object for sql connection
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                //create a string variable to hold the sql query to delete data 
                string sql = "DELETE FROM table_users WHERE user_id = @user_id";

                //create a sql command to execute the query
                SqlCommand cmd = new SqlCommand(sql, conn);

                //pass the value through parameters
                cmd.Parameters.AddWithValue("@user_id", u.user_id);

                //open the db connection
                conn.Open();

                //create an integer variable to hold the value after query is executed
                int rows = cmd.ExecuteNonQuery();

                //if the query is executed successfully then the value of rows is greater than 0 else its 0
                if (rows > 0)
                {
                    //query executed successfully
                    isSuccess = true;
                }
                else
                {
                    //failed to execute the query
                    isSuccess = false;
                }
            }
            catch (Exception e)
            {
                //display a message if there are any exceptional errors
                MessageBox.Show(e.Message);
            }
            finally
            {
                //close the connection
                conn.Close();
            }

            return isSuccess;
        }

        #endregion
    }
}

//just a random comment
