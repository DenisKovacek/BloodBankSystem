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

            try
            {
                //write sql query to select the data from the db
                string sql = "SELECT * FROM table_donors";

                //create sql command to execute the query
                SqlCommand cmd = new SqlCommand(sql, conn);

                //create sql data adapter to hold the data temporarily
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                //open db connection
                conn.Open();

                //pass the data from adapter to data table
                adapter.Fill(dt);
            }
            catch (Exception e)
            {
                //display message if there are any errors
                MessageBox.Show(e.Message);
            }
            finally
            {
                //close db connection
                conn.Close();
            }

            return dt;
        }
        #endregion
        #region INSERT data to db
        public bool Insert(donorBLL d)
        {
            //create a boolean variable and set its default value to false
            bool isSuccess = false;

            //create SQL connection to connect db
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                //write the query to insert data into db
                string sql = "INSERT INTO table_donors (first_name, last_name, email, contact, gender, address, blood_group, added_date, image_name, added_by) VALUES (@first_name, @last_name, @email, @contact, @gender, @address, @blood_group, @added_date, @image_name, @added_by)";

                //create sql command to execute the query
                SqlCommand cmd = new SqlCommand(sql, conn);

                //pass the values to sql query
                cmd.Parameters.AddWithValue("@first_name", d.first_name);
                cmd.Parameters.AddWithValue("@last_name", d.last_name);
                cmd.Parameters.AddWithValue("@email", d.email);
                cmd.Parameters.AddWithValue("@contact", d.contact);
                cmd.Parameters.AddWithValue("@gender", d.gender);
                cmd.Parameters.AddWithValue("@address", d.address);
                cmd.Parameters.AddWithValue("@blood_group", d.blood_group);
                cmd.Parameters.AddWithValue("@added_date", d.added_date);
                cmd.Parameters.AddWithValue("@image_name", d.image_name);
                cmd.Parameters.AddWithValue("@added_by", d.added_by);

                //open db connection
                conn.Open();

                //create an integer variable to check whether the query was executed successfully or not
                int rows = cmd.ExecuteNonQuery();

                //if the query is executed successfully the value of rows will be greater than zero
                if(rows > 0)
                {
                    //query executed successfully
                    isSuccess = true;
                }
                else
                {
                    //query failed to execute
                    isSuccess = false;
                }

            }
            catch(Exception e)
            {
                //display error message if there are any errors
                MessageBox.Show(e.Message);
            }
            finally
            {
                //close the db connection
                conn.Close();
            }

            return isSuccess;
        }
        #endregion
        #region UPDATE donors in db
        public bool Update(donorBLL d)
        {
            //create a boolean value and set its default value to false
            bool isSuccess = false;
            //create sql connection to connect database
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                //create an sql query to update donors
                string sql = "UPDATE table_donors SET first_name = @first_name, last_name = @last_name, email = @email, contact = @contact, gender = @gender, address = @address, blood_group = @blood_group, image_name = @image_name, added_by = @added_by WHERE donor_id = @donor_id";

                //create sql command here
                SqlCommand cmd = new SqlCommand(sql, conn);

                //pass the value to sql query
                cmd.Parameters.AddWithValue("@first_name", d.first_name);
                cmd.Parameters.AddWithValue("@last_name", d.last_name);
                cmd.Parameters.AddWithValue("@email", d.email);
                cmd.Parameters.AddWithValue("@contact", d.contact);
                cmd.Parameters.AddWithValue("@gender", d.gender);
                cmd.Parameters.AddWithValue("@address", d.address);
                cmd.Parameters.AddWithValue("@blood_group", d.blood_group);
                cmd.Parameters.AddWithValue("@image_name", d.image_name);
                cmd.Parameters.AddWithValue("@added_by", d.added_by);
                cmd.Parameters.AddWithValue("@donor_id", d.donor_id);

                //open db connection
                conn.Open();

                //create an integer variable to check if the query was executed successfully
                int rows = cmd.ExecuteNonQuery();

                //if the query is executed successfully its value will be greater than zero
                if(rows > 0)
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

            }
            finally
            {

            }

            return isSuccess;
        }
        #endregion
        #region DELETE donors from db
        public bool Delete(donorBLL d)
        {
            //create a boolean value and set its value to false
            bool isSuccess = false;

            //create an sql connection to connect to db
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                //write sql query to delete donors from the db
                string sql = "DELETE FROM table_donors WHERE donor_id = @donor_id";

                //create sql command 
                SqlCommand cmd = new SqlCommand(sql, conn);

                //pass the value to sql query using parameters
                cmd.Parameters.AddWithValue("@donor_id", d.donor_id);

                //open db connection
                conn.Open();

                //create an integer variable to check whether the query executed successfully 
                int rows = cmd.ExecuteNonQuery();

                //if the query is executed successfully the number of rows will be greater than zero
                if(rows > 0)
                {
                    //query executed successfully
                    isSuccess = true;
                }
                else
                {
                    //query failed to execute 
                    isSuccess = false;
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {

            }

            return isSuccess;
        }
        #endregion

        #region COUNT donors for specific blood group
        public string countDonors(string blood_group)
        {
            //create sql connection to connect to db
            SqlConnection conn = new SqlConnection(myconnstrng);

            //create a string variable for donor count and set its default value to zero
            string donors = "0";

            try
            {
                //sql query to count donors for specific blood group
                string sql = "SELECT * FROM table_donors WHERE blood_group = '" + blood_group +"'";

                //create sql command to execute query
                SqlCommand cmd = new SqlCommand(sql, conn);

                //sql data adapter to get the data from tb
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                //datatable to hold the data temporarily
                DataTable dt = new DataTable();

                //pass the value from SQL data adapter to data table
                adapter.Fill(dt);

                //get the total number of donors based on blood_group
                donors = dt.Rows.Count.ToString();
            }
            catch(Exception e)
            {
                //display error message if there are any errors
                MessageBox.Show(e.Message);
            }
            finally
            {
                //close the db connection
                conn.Close();
            }
            return donors;
        }
        #endregion
        #region METHOD to search donors
        public DataTable Search(string keywords)
        {
            //sql connection to connect db
            SqlConnection conn = new SqlConnection(myconnstrng);

            //create datatable to hold the data temporarily
            DataTable dt = new DataTable();

            try
            {
                //write the code to search donors based on keywords typed in the text box
                //write sql query to search donors
                string sql = "SELECT * FROM table_donors WHERE donor_id LIKE '%" + keywords + "%' OR first_name LIKE '%" + keywords + "' OR email LIKE '%'" + keywords + "%' OR blood_group LIKE '" + keywords + "'";

                //create sql command to execute the query
                SqlCommand cmd = new SqlCommand(sql, conn);

                //sql adapter to save data from db
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                //open db connection
                conn.Open();

                //transfer data from sql data adapter to data table
                adapter.Fill(dt);
            }
            catch (Exception e)
            {
                //display error message if there are any exceptional errors
                MessageBox.Show(e.Message);
            }
            finally
            {
                //close the db connectoin
                conn.Close();
            }
            return dt;
        }
        #endregion
    }
}
