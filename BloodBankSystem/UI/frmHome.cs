using BloodBankSystem.DAL;
using BloodBankSystem.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodBankSystem
{
    public partial class frameHome : Form
    {
        public frameHome()
        {
            InitializeComponent();
        }

        //create the object of donor dal
        donorDAL dal = new donorDAL();

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //open users form
            frmUsers users = new frmUsers();
            users.Show();
        }

        private void donorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //open manage donors form
            frmDonors donors = new frmDonors();
            donors.Show();
        }

        private void frameHome_Load(object sender, EventArgs e)
        {
            //load all the blood donors count when form is loaded
            //call allDonorCountMethod
            allDonorCount();

            //display all the donors
            DataTable dt = dal.Select();
            dgvDonors.DataSource = dt;
        }

        public void allDonorCount()
        {
            //get the donor count from db and set in respective label
            lblOPositiveCount.Text = dal.countDonors("O+");
            lblONegativeCount.Text = dal.countDonors("O-");
            lblAPositiveCount.Text = dal.countDonors("A+");
            lblANegativeCount.Text = dal.countDonors("A-");
            lblBPositiveCount.Text = dal.countDonors("B+");
            lblBNegativeCount.Text = dal.countDonors("B-");
            lblABPositiveCount.Text = dal.countDonors("AB+");
            lblABNegativeCount.Text = dal.countDonors("AB-");
        }

        private void frameHome_Activated(object sender, EventArgs e)
        {
            //call all donor count method
            allDonorCount();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            //get the keywords from the search text box
            string keywords = txtSearch.Text;

            //check whether the text box is empty or not
            if(keywords != null)
            {
                //filter the donors based on keywords
                DataTable dt = dal.Search(keywords);
                dgvDonors.DataSource = dt;
            }
            else
            {
                //display all the donors
                DataTable dt = dal.Select();
                dgvDonors.DataSource = dt;
            }
        }
    }
}
