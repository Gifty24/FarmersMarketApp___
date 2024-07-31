using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Mail; //Needed for sending emails
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmersMarketApp___
{
    public partial class FarmerRegistration : Form
    {
        private List<Farmer> farmers;//list of farmers

        public FarmerRegistration(List<Farmer> farmers) //constructor to initialize the form with the farmers list
        {
            InitializeComponent();//initialize the form components
            this.farmers = farmers; //assign the passed farmers list to the form's farmers list 
        }

        private void FarmerRegistration_Load(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstName.Text; //get the entered first name from user
            string lastName = txtLastName.Text; //get the entered last name from the user
            string farmName = txtFarmName.Text; //get the entered farm name from the user
            string registrationId = txtRegistrationId.Text; //get the entered registration Id from the user
            string email = txtEmail.Text; //get the entered email

            //Generate username and one-time password
            string username = firstName + lastName;
            string password = GenerateOneTimePassword();

            Farmer newFarmer = new Farmer //creating new farmer object
            {
                FirstName = firstName, //set the first name
                LastName = lastName, //set the last name
                Username = username, //set username
                Password = password, //set the password
                FarmName = farmName, //set the farm name
                RegistrationId = registrationId //set registration Id
            };
            farmers.Add(newFarmer);//add new farmers to the list

            SendEmail(email, username, password);//send and email with the username and one-time password

            //show this confirmation message
            MessageBox.Show("Your account has been approved and activated. Your username and one time password have been sent to your email.", "Registration Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();//close this form
        }
        private string GenerateOneTimePassword()
        {
            //Generate a simple one-time password by creating a GUID (Globally Unique Identifier), converting it to a string without hyphens, and taking the first 8 characters
            return Guid.NewGuid().ToString("N").Substring(0, 8);
        }
        private void SendEmail(string email, string username, string password)
        {
            try
            {
                //create a new mail message from "no-replay@farmersapp.com" to the entered email address
                MailMessage mail = new MailMessage("no-reply@farmersapp.com", email);

                SmtpClient client = new SmtpClient //configure the SMTP client
                {
                    Port = 25, //set the port number for STMP
                    DeliveryMethod = SmtpDeliveryMethod.Network,//setting the delivery method to network
                    UseDefaultCredentials = false, //do not use default credentials
                    Host = "smtp.gweefur23@outlook.com" //set the the SMTO server address (in this case i don't have a host server so i used my personal email address)
                };

                //set the subject of the email
                mail.Subject = "Your Farmer's App Account";

                //set the body of the email
                mail.Body = $"Dear Farmer, \n\nYour account has been approved and activated. \n\nUsername: {username}\nOne-Time Password: {password}\n\nPlease login and change your password immediately.\n\nBest regards,\nFarmer's App Team";

                //Send the email
                client.Send(mail);
            }
            catch (Exception ex)
            {
                //show this error message if the email could not be sent
                MessageBox.Show("Registration successful.");
            }
        }
       

    }
}
