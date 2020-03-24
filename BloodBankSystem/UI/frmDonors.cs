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
    public partial class frmDonors : Form
    {
        public frmDonors()
        {
            InitializeComponent();
        }
        //create object of donorBLL and donorDAL
        donorBLL d = new donorBLL();
        donorDAL dal = new donorDAL();

        //global variable for image
        string imageName = "no-image.jpg";

        private void frmDonors_Load(object sender, EventArgs e)
        {
            //display donors in data grid view
            DataTable dt = dal.Select();
            dgvDonors.DataSource = dt;

            //clear the pictureBox
            //first get the image path
            string path = Application.StartupPath.Substring(0, (Application.StartupPath.Length) - 10);

            string imagepath = path + "//no-image.jpg";

            //display image in picturebox
            pictureBox1.Image = new Bitmap(imagepath);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //code to add a new donor
            //get the data from manage donors form
            d.first_name = textBoxFirstName.Text;
            d.last_name = textBoxLastName.Text;
            d.email = textBoxEmail.Text;
            d.gender = comboBoxGender.Text;
            d.blood_group = comboBoxBloodGroup.Text;
            d.contact = textBoxContact.Text;
            d.address = textBoxAddress.Text;
            d.added_date = DateTime.Now;
            d.added_by = 1; //get the id of logged in user
            d.image_name = imageName;

            //inserting data into db
            //create a boolean variable to insert data into db and check whether the data inserted successfully or not
            bool isSuccess = dal.Insert(d);

            //if the data is inserted successfully then the values of isSuccess will be true
            if(isSuccess == true)
            {
                //data inserted successfully
                MessageBox.Show("New donor added successfully!");

                //refresh data grid view 
                DataTable dt = dal.Select();
                dgvDonors.DataSource = dt;

                //clear all the text boxes
                Clear();
            }
            else
            {
                //failed to insert the data
                MessageBox.Show("Failed to add new donor.");
            }
        }

        //create a method to clear all the textboxes
        public void Clear()
        {
            //clear all the textboxes
            textBoxFirstName.Text = "";
            textBoxLastName.Text = "";
            textBoxEmail.Text = "";
            textBoxDonorId.Text = "";
            comboBoxGender.Text = "";
            comboBoxBloodGroup.Text = "";
            textBoxContact.Text = "";
            textBoxContact.Text = "";
            textBoxAddress.Text = "";

            //clear the pictureBox
            //first get the image path
            string path = Application.StartupPath.Substring(0, (Application.StartupPath.Length)-10);

            string imagepath = path + "//no-image.jpg";

            //display image in picturebox
            pictureBox1.Image = new Bitmap(imagepath);
        }

        private void dgvDonors_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //select data from data grid view and display in our form
            //find the row selected
            int RowIndex = e.RowIndex;

            textBoxDonorId.Text = dgvDonors.Rows[RowIndex].Cells[0].Value.ToString();
            textBoxFirstName.Text = dgvDonors.Rows[RowIndex].Cells[1].Value.ToString();
            textBoxLastName.Text = dgvDonors.Rows[RowIndex].Cells[2].Value.ToString();
            textBoxEmail.Text = dgvDonors.Rows[RowIndex].Cells[3].Value.ToString();
            textBoxContact.Text = dgvDonors.Rows[RowIndex].Cells[4].Value.ToString();
            comboBoxGender.Text = dgvDonors.Rows[RowIndex].Cells[5].Value.ToString();
            textBoxAddress.Text = dgvDonors.Rows[RowIndex].Cells[6].Value.ToString();
            comboBoxBloodGroup.Text = dgvDonors.Rows[RowIndex].Cells[7].Value.ToString();
            
            imageName = dgvDonors.Rows[RowIndex].Cells[9].Value.ToString();
            //display the image of selected donor
            string paths = Application.StartupPath.Substring(0, (Application.StartupPath.Length)-10);
            string imagePath = paths + "//images//" + imageName;
            //display the image of the user selected
            pictureBox1.Image = new Bitmap(imagePath);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //add the functionality to update donors
            //get the values from form
            d.donor_id = int.Parse(textBoxDonorId.Text);
            d.first_name = textBoxFirstName.Text;
            d.last_name = textBoxLastName.Text;
            d.email = textBoxEmail.Text;
            d.gender = comboBoxGender.Text;
            d.blood_group = comboBoxBloodGroup.Text;
            d.contact = textBoxContact.Text;
            d.address = textBoxAddress.Text;
            d.added_by = 1; //get the id to logged in user
            d.image_name = imageName;

            //create a boolean variable to check whether the data updated successfully 
            bool isSuccess = dal.Update(d);

            //if the data updated successfully then the value of isSuccess will be true
            if(isSuccess == true)
            {
                //donor updated
                MessageBox.Show("Donor updated successfully!");
                Clear();

                //refresh data grid view
                DataTable dt = dal.Select();
                dgvDonors.DataSource = dt;
            }
            else
            {
                //failed to update
                MessageBox.Show("Failed to update.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //get the value from form
            d.donor_id = int.Parse(textBoxDonorId.Text);

            //create a boolean variable to check whether the donor deleted or not
            bool isSuccess = dal.Delete(d);

            if(isSuccess == true)
            {
                //donor deleted successfully
                MessageBox.Show("Donor deleted successfully!");

                Clear();

                //refresh data grid view
                DataTable dt = dal.Select();
                dgvDonors.DataSource = dt;
            }
            else
            {
                //failed to delete
                MessageBox.Show("Failed to delete donor.");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //clear the textboxes
            Clear();
        }

        private void btnSelectImage_Click(object sender, EventArgs e)
        {
            //code to select image and upload it
            //open the dialog box to select the image
            OpenFileDialog open = new OpenFileDialog();

            //filter the file type
            open.Filter = "Image files only.";

            //check if the image is selected
            if (open.ShowDialog() == DialogResult.OK)
            {
                //check if the file exists
                if (open.CheckFileExists)
                {
                    //display the selected image in picture box
                    pictureBox1.Image = new Bitmap(open.FileName);

                    //rename the selected image
                    //get the extension of selected image
                    string ext = Path.GetExtension(open.FileName);

                    string name = Path.GetFileNameWithoutExtension(open.FileName);

                    //generate eandom but globally unique identifier
                    Guid g = new Guid();
                    g = Guid.NewGuid();

                    //rename the image
                    imageName = "Blood_bank_"+name+g+ext;

                    //get the source path
                    string sourcePath = open.FileName;

                    //get the destination path
                    string paths = Application.StartupPath.Substring(0, Application.StartupPath.Length - 10);
                    //path to destination
                    string destinationPath = paths + "//images//" + imageName;

                    //upload the image to destination folder
                    File.Copy(sourcePath, destinationPath);

                    //display message after successfull upload
                    MessageBox.Show("Picture uploaded.");
                }
            }
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            //add the functionality to search bar

            //get the keywords typed in the search text box
            string keywords = textBoxSearch.Text;

            //check if the search bar is empty or not
            if(keywords != null)
            {
                //display the information of donors based on keywords
                DataTable dt = dal.Search(keywords);
                dgvDonors.DataSource = dt;
            }
            else
            {
                //display the information of donors based on keywords
                DataTable dt = dal.Select();
                dgvDonors.DataSource = dt;
            }
        }
    }
}
