using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmersMarketApp___
{
    public partial class FarmerLoginForm : Form
    {
        private List<Farmer> farmers; //list to store farmers
        private List<Produce> predefinedProduce; //list to store predefined produce

        public Farmer LoggedInFarmer { get; private set; }// property to store the logged in farmer

        public FarmerLoginForm(List<Farmer> farmers,List<Produce>predefinedProduce) 
        {
            InitializeComponent(); //initialize the form
            this.farmers = farmers; //assign the passed farmers list to the form's farmers list 
            this.predefinedProduce=predefinedProduce; //assign the passed predefined produce lis to the form's predefined produce list
        }

        private void lblPassword_Click(object sender, EventArgs e)
        {

        }

        private void FarmerLoginForm_Load(object sender, EventArgs e)
        {
         
            
        }
        //Method to validate farmer credentials
        private Farmer ValidateFarmerCredentials(string username, string password, out Farmer loggedInFarmer)
        {
            loggedInFarmer = null;
            foreach (var farmer in farmers) //loop through each farmer in the farmers list to validate credentials 
            {
                if (farmer.FarmName == "Mary" && farmer.LastName == "Green" && password == "password123") //check if username and password matched the predefined farmer
                {
                    return farmer; //return the farmer if credentials are valid
                }
            }
            return null; //return null if no farmer matches the credentails
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;//get username from text box
            string password = txtPassword.Text;//get password gett password from text box

            //hardcore validation for MaryGreen-the protype farmer
            if (username=="MaryGreen" && password == "password123")

            {
                //find the farmer with the hardcoded credentials
                LoggedInFarmer = farmers.FirstOrDefault(f => f.FirstName == "Mary" && f.LastName == "Green");

               if(LoggedInFarmer != null)//check if the farmer was found 
                {
                   DialogResult = DialogResult.OK; //set the dialog result to Ok
                    Close(); //close the login form
                }
               else
                {
                    MessageBox.Show("Farmer not found."); //show error message if farmer is not found
                }
                
            }
            else
            {
                MessageBox.Show("Invalid login details"); //show error message if login details ae invalid
            }
        }
    }
    
}
