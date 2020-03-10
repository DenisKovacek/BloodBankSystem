using BloodBankSystem.BLL;
using BloodBankSystem.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodBankSystem.UI
{
    public partial class frmUsers : Form
    {
        public frmUsers()
        {
            InitializeComponent();
        }

        //create user dal and user bll object
        userBLL u = new userBLL();
        userDAL dal = new userDAL();

        string imageName = "no-image.jpg"; 

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //get the values from the UI
            u.full_name = textBoxFullName.Text;
            u.email = textBoxEmail.Text;
            u.username = textBoxUsername.Text;
            u.password = textBoxPassword.Text;
            u.contact = textBoxContact.Text;
            u.address = textBoxAddress.Text;
            u.added_date = DateTime.Now;
            u.image_name = imageName;

            //adding the values from the UI to database
            //boolean variable to check wether the data is inserted successfully or not
            bool success = dal.Insert(u);

            //check wether the data is inserted successfully or not
            if(success == true)
            {
                //data or user added successfully
                MessageBox.Show("New user added successfully.");

                //display the user in data grid view
                DataTable dt = dal.Select();
                dgvUsers.DataSource = dt;

                //clear textboxes
                Clear();
            }
            else
            {
                //failed to add a new user
                MessageBox.Show("Failed to add new user.");
            }
        }

        //function to clear textboxes
        public void Clear()
        {
            textBoxFullName.Text = "";
            textBoxEmail.Text = "";
            textBoxUsername.Text = "";
            textBoxContact.Text = "";
            textBoxAddress.Text = "";
            textBoxPassword.Text = "";
        }

        private void dgvUsers_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //find the row index of the row clicked on user data grid view
            int rowIndex = e.RowIndex;
            textBoxUserId.Text = dgvUsers.Rows[rowIndex].Cells[0].Value.ToString();
            textBoxUsername.Text = dgvUsers.Rows[rowIndex].Cells[1].Value.ToString();
            textBoxEmail.Text = dgvUsers.Rows[rowIndex].Cells[2].Value.ToString();
            textBoxPassword.Text = dgvUsers.Rows[rowIndex].Cells[3].Value.ToString();
            textBoxFullName.Text = dgvUsers.Rows[0].Cells[4].Value.ToString();
            textBoxContact.Text = dgvUsers.Rows[0].Cells[5].Value.ToString();
            textBoxAddress.Text = dgvUsers.Rows[0].Cells[6].Value.ToString();
            imageName = dgvUsers.Rows[0].Cells[7].Value.ToString();
        }

        private void frmUsers_Load(object sender, EventArgs e)
        {
            //display users in data grid view
            DataTable dt = dal.Select();
            dgvUsers.DataSource = dt;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //get the values from the UI
            u.user_id = int.Parse(textBoxUserId.Text);
            u.full_name = textBoxFullName.Text;
            u.email = textBoxEmail.Text;
            u.username = textBoxUsername.Text;
            u.password = textBoxPassword.Text;
            u.contact = textBoxContact.Text;
            u.address = textBoxAddress.Text;
            u.added_date = DateTime.Now;
            u.image_name = imageName;

            //create a boolean variable to check if the data is updated successfully
            bool success = dal.Update(u);

            //check if the data is updated or not
            if(success == true)
            {
                //data updated successfully
                MessageBox.Show("User updated successfully.");

                //refresh data grid view
                DataTable dt = dal.Select();
                dgvUsers.DataSource = dt;

                //clear the textboxes
                Clear();
            }
        }
    }
}
