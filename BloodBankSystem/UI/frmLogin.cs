using BloodBankSystem.BLL;
using BloodBankSystem.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodBankSystem.UI
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        //create the object of BLL and DAL
        loginBLL l = new loginBLL();
        loginDAL dal = new loginDAL();

        //create a static string method to save the username
        public static string loggedInUser;

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //write the code to login
            //get the username and password
            l.username = textBoxUsername.Text;
            l.password = textBoxPassword.Text;

            //check the login credentials
            bool isSuccess = dal.loginCheck(l);

            //check if the login was success
            if(isSuccess == true)
            {
                //login success
                MessageBox.Show("Login successful.");

                //save the username in loggedInUser method
                loggedInUser = l.username;

                //display home form
                frameHome home = new frameHome();
                home.Show();
                this.Hide();
            }
            else
            {
                //login failed
                MessageBox.Show("Login failed.");
            }
        }
    }
}
