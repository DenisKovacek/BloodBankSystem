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
            textBoxUserId.Text = "";
            //display the image
            //get the image path
            string paths = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
            //path do destination folder
            string imagePath = paths + "//images//no-image.jpg";
            //display in picture box
            pictureBox1.Image = new Bitmap(imagePath);
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
            imageName = dgvUsers.Rows[0].Cells[8].Value.ToString();

            //display the image
            //get the image path
            string paths = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));

            if (imageName != "no-image.jpg")
            {
                //path do destination folder
                string imagePath = paths + "//images//" + imageName;
                //display in picture box
                pictureBox1.Image = new Bitmap(imagePath);
            }
            else
            {
                //path do destination folder
                string imagePath = paths + "//images//no-image.jpg";
                //display in picture box
                pictureBox1.Image = new Bitmap(imagePath);
            }
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //get the user id from text box to delete the user
            u.user_id = int.Parse(textBoxUserId.Text);

            //create the boolean value to check if the user has been deleted or not
            bool success = dal.Delete(u);

            //check if the user has been deleted or not
            if(success == true)
            {
                //user deleted successfully
                MessageBox.Show("User deleted successfully.");

                //refresh data grid view
                DataTable dt = dal.Select();
                dgvUsers.DataSource = dt;

                //clear the textboxes
                Clear();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //call the user function
            Clear();
        }

        private void btnSelectImage_Click(object sender, EventArgs e)
        {
            //code to upload an image of the user
            //open dialogbox to select the image
            OpenFileDialog open = new OpenFileDialog();

            //filter the file type so it only allows image file types
            open.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.PNG; *.gif;) || *.jpg; *.jpeg; *.png; *.PNG; *.gif";

            //check if the file is selected or not
            if(open.ShowDialog() == DialogResult.OK)
            {
                //check if the file exists or not
                if (open.CheckFileExists)
                {
                    //display the selected file on picture box
                    pictureBox1.Image = new Bitmap(open.FileName);

                    //rename the image we selected
                    //get the image extension
                    string ext = Path.GetExtension(open.FileName);

                    //generate random integer
                    Random random = new Random();
                    int RandInt = random.Next(0, 1000);

                    //rename the image
                    imageName = "Blood_Bank" + RandInt + ext;

                    //get the path of selected image 
                    string sourcePath = open.FileName;

                    //get the destination path
                    string paths = Application.StartupPath.Substring(0, Application.StartupPath.Length - 10);
                    //path to destination folder
                    string destinationPath = paths + "//images//" + imageName;

                    //copy image to the destination folder
                    File.Copy(sourcePath, destinationPath);

                    //display message
                    MessageBox.Show("Image successfully uploaded.");
                }
            }
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            //write the code to get the users based on keywords
            //get the keywords from the textbox
            String keywords = textBoxSearch.Text;

            //check whether the textbox is empty or not
            if(keywords != null)
            {
                //textbox is not empty, display data on dgv based on keywords
                DataTable dt = dal.Search(keywords);
                dgvUsers.DataSource = dt;
            }
            else
            {
                //textbox is empty and display all the user on dgv
                DataTable dt = dal.Select();
                dgvUsers.DataSource = dt;
            }
        }
    }
}
