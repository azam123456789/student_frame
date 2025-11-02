using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WindowsFormsApp1
{
    public partial class FrmRegistration : Form
    {
        public FrmRegistration()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void FrmRegistration_Load(object sender, EventArgs e)
        {

            combCuntry.Items.Add("Yemen");
            combCuntry.Items.Add("Egypt");
            combCuntry.Items.Add("Oman");
            combCuntry.Items.Add("Qatar");
            combCuntry.Items.Add("palestine");
            combCuntry.Items.Add("Syria");

        }

        private void combCuntry_SelectedIndexChanged(object sender, EventArgs e)
        {



        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string name = texName.Text;

            string email = textEmail.Text;
            string pass = textPassword.Text;
            string gender = rdoMale.Checked?"Male": rdoFemal.Checked ?"Female":"Other";
            string brithdate = dtpBrithdate.Value.ToShortDateString();
            string country =combCuntry.SelectedItem?.ToString() ?? "Not Selected";
            string color = IblSelectedColor.Text.Replace("Selected Color:","");

            ibIResult.Text = $"Name: {name}\n Eemail:{email}\n Gender:{gender}\n Brithdate:{brithdate} \n" +
                $"Country:{country} \n Favorte Color:{color}";

            
            //colorDialog1 = new ColorDialog();

            ColorDialog corol= new ColorDialog();

            if (corol.ShowDialog() == DialogResult.OK)

            {
                IblSelectedColor.Text = $"Selected Color :{corol.Color.Name}";



            }
            // Validate Name 
            if (string.IsNullOrWhiteSpace(textEmail.Text))
            {
                MessageBox.Show("Name is required!", "Validation Error",
        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textEmail.Focus();
                return;
            }
            // Validate Email 

            if (!Regex.IsMatch(textEmail.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Enter a valid email address!", "Validation Error",
        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textEmail.Focus();
                return;
            }


            if (textPassword.Text.Length < 6)
            {
                MessageBox.Show("Password must be at least 6 characters!",
"Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textPassword.Focus();
                return;
            }

            if (!rdoMale.Checked && !rdoFemal.Checked && !rdoOther.Checked)
            {
                MessageBox.Show("Please select a gender!", "Validation Error",
        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (combCuntry.SelectedItem == null)
            {
                MessageBox.Show("Please select a country!", "Validation Error",
        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                combCuntry.Focus();
                return;
            }

            if (IblSelectedColor.Text == "No Color Selected")
            {
                MessageBox.Show("Please select your favorite color!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); 
                return;
            }

            string name1 = texName.Text;

            string emails = textEmail.Text;
            string passw = textPassword.Text;
            string genders = rdoMale.Checked ? "Male" : rdoFemal.Checked ? "Female" : "Other";
            string brithdates = dtpBrithdate.Value.ToShortDateString();
            string countrys= combCuntry.SelectedItem?.ToString() ?? "Not Selected";
            string colors = IblSelectedColor.Text.Replace("Selected Color:", "");

            ibIResult.Text = $"Name: {name1}\n Eemail:{emails}\n Gender:{genders}\n Brithdate:{brithdates} \n" +
                $"Country:{countrys} \n Favorte Color:{colors}";


        }

        private void colorDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {



            texName.Text = "";
            textEmail.Text = "";
            textPassword.Text = "";

            rdoMale.Checked = false;


            rdoFemal.Checked = false;
            rdoOther.Checked = false;

            combCuntry.SelectedIndex = -1;

            dtpBrithdate.Value = DateTime.Now;

            IblSelectedColor.Text = "No Color Selected";
            ibIResult.Text = "";

            // Clear student picture 
            picStudent.Image = null;

            texName.Focus();


        }


       




        private void btnUpload_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                picStudent.Image = Image.FromFile(openFileDialog.FileName);
            }


        }
       

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(texName.Text) ||
        string.IsNullOrWhiteSpace(textEmail.Text))
            {
             MessageBox.Show("Please fill in at least Name and Email before  saving!", "Validation Error", MessageBoxButtons.OK, 
        MessageBoxIcon.Warning);
                return;
            }

          
            string data = $"{texName.Text}\n" +         
                          $"{textEmail.Text}\n" +        
                          $"{textPassword.Text}\n" +     
                          $"{(rdoMale.Checked ? "Male" : rdoFemal.Checked ? "Female" : "Other")}\n" +
                          $"{dtpBrithdate.Value.ToShortDateString()}\n" + 
                          $"{combCuntry.SelectedItem?.ToString()}\n" + 
                          $"{IblSelectedColor.Text.Replace("Selected Color:", "")}\n" + 
                  $"{(picStudent.Image != null ? "student_picture.jpg" :"NoImage")}\n";

            
            File.WriteAllText("Students_data.txt", data);

           

            if (picStudent.Image != null)
            {
                picStudent.Image.Save("aaaaa.jpg");
            }

            MessageBox.Show("Data saved successfully!", "Success",
        MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
       


        private void btnLoad_Click(object sender, EventArgs e)
        {

            if (!File.Exists("Students_data.txt"))
            {
                MessageBox.Show("No saved data found!", "Error",
        MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string[] lines = File.ReadAllLines("Students_data.txt");

            if (lines.Length < 8)
            {
                MessageBox.Show("Saved data is incomplete or corrupted!", "Error",
        MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            texName.Text = lines[0];
            textEmail.Text = lines[1];
            textPassword.Text = lines[2];

            if (lines[3] == "Male") rdoMale.Checked = true;
            else if (lines[3] == "Female") rdoFemal.Checked = true;
            else rdoOther.Checked = true;

            dtpBrithdate.Value = DateTime.Parse(lines[4]);
            combCuntry.SelectedItem = lines[5];
            IblSelectedColor.Text = "Selected Color: " + lines[6];

            if (File.Exists("student_picture.jpg") && lines[7] == "student_picture.jpg")
            {
                picStudent.Image = Image.FromFile("student_picture.jpg");
            }
            else
            {
                picStudent.Image = null;
            }

            MessageBox.Show("Data loaded successfully!", "Success",
        MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

      

    }
}
