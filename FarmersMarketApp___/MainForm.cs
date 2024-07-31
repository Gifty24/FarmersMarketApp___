using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmersMarketApp___
{
    public partial class MainForm : Form
    {
        private List<Farmer> farmers = new List<Farmer>(); //List to store farmers
        private Farmer currentFarmer; //currently logged-in farmer
        private List<Produce> predefinedProduce = new List<Produce>(); //list to store predefined produce, will represent other farmers who have already uploaded their products 

        public MainForm()
        {
            InitializeComponent(); //Initialize form components
            InitializePredefineProduce(); //Initialize predefined produce list
            InitializeFamers(); //Initialize predefined farmers
        }
        //method to initialize predefined produce
        private void InitializePredefineProduce() //predefined produce list that will also load in the customer portal
        {
            predefinedProduce.Add(new Produce { Name = "Chocolate Chip Cookies", Category = "Baked Goods", Price = 14, Quantity = 12, Unit = "" });
            predefinedProduce.Add(new Produce { Name = "Sourdough Bread", Category = "Baked Goods", Price = 5, Quantity = 1, Unit = "Loaf" });
            predefinedProduce.Add(new Produce { Name = "Whole wheat bread", Category = "Baked Goods", Price = 5.50, Quantity = 1, Unit = "Loaf" });
            predefinedProduce.Add(new Produce { Name = "Cheddar Cheese", Category = "Dairy", Price = 6.99, Quantity = 1, Unit = "lb" });
            predefinedProduce.Add(new Produce { Name = "Eggs", Category = "Dairy", Price = 4.50, Quantity = 1, Unit = "dozen" });
            predefinedProduce.Add(new Produce { Name = "Parsley", Category = "Herbs and Spices", Price = 1.50, Quantity = 6, Unit = "oz" });
            predefinedProduce.Add(new Produce { Name = "Cilantro", Category = "Herbs and Spices", Price = 1.50, Quantity = 5, Unit = "oz" });
            predefinedProduce.Add(new Produce { Name = "baby lettuce", Category = "Produce", Price = 6, Quantity = 6, Unit = "oz" });
            predefinedProduce.Add(new Produce { Name = "Banana Peppers", Category = "Produce", Price = .50, Quantity = 1, Unit = "each" });
            predefinedProduce.Add(new Produce { Name = "French Green Beans", Category = "Produce", Price = 4, Quantity = 1, Unit = "a bag" });
            predefinedProduce.Add(new Produce { Name = "Cabbage", Category = "Produce", Price = .80, Quantity = 1, Unit = "lb" });
            predefinedProduce.Add(new Produce { Name = "Garlic", Category = "Produce", Price = 1, Quantity = 5, Unit = "oz" });
            predefinedProduce.Add(new Produce { Name = "Onion", Category = "Produce", Price = 1.75, Quantity = 1, Unit = " each" });
            predefinedProduce.Add(new Produce { Name = "Ginger", Category = "Produce", Price = 1.50, Quantity = 1, Unit = "lb bag" });
            predefinedProduce.Add(new Produce { Name = "Green Peppers", Category = "Produce", Price = .50, Quantity = 1, Unit = "each" });
            predefinedProduce.Add(new Produce { Name = "Okra", Category = "Produce", Price = 1, Quantity = 8, Unit = "oz" });
            predefinedProduce.Add(new Produce { Name = "Shiitake Mushrooms", Category = "Produce", Price = 4, Quantity = 100, Unit = "" });
            predefinedProduce.Add(new Produce { Name = "BlueBerries", Category = "Produce", Price = 3.99, Quantity = 1, Unit = "lb" });
            predefinedProduce.Add(new Produce { Name = "Apples", Category = "Produce", Price = 3, Quantity = 1, Unit = "lb bag" });
            predefinedProduce.Add(new Produce { Name = "Peaches", Category = "Produce", Price = 2.99, Quantity = 1, Unit = "bag" });
            predefinedProduce.Add(new Produce { Name = "Mango", Category = "Produce", Price = 5, Quantity = 1, Unit = "each" });

        }
        private void InitializeFamers() //method to initialize predefined farmers
        {
            farmers.Add(new Farmer
            {
                FirstName = "Mary",
                LastName = "Green",
                Username = "MaryGreen",
                Password = "password123",
                FarmName = "Green Farm",
                RegistrationId = "12345"
            });
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnFarmerLogin_Click(object sender, EventArgs e)
        {
            FarmerLoginForm loginForm = new FarmerLoginForm(farmers, predefinedProduce); //open login form
            if (loginForm.ShowDialog() == DialogResult.OK)  //Check if login is successful
            {
                currentFarmer = loginForm.LoggedInFarmer; //set current farmer

                if (currentFarmer !=null)
                {
                    FarmerPortalForm farmerPortalForm = new FarmerPortalForm(currentFarmer, predefinedProduce); //open farmer portal

                    farmerPortalForm.Show();
                }
                else
                {
                    MessageBox.Show("Login failed. No farmer logged in."); //show login failed message
                }

               
            }
        }

        private void btnFarmerRegistration_Click(object sender, EventArgs e)
        {
            FarmerRegistration registrationForm = new FarmerRegistration(farmers); //open the farmer registration form
            if (registrationForm.ShowDialog() == DialogResult.OK) //check if the registration is successful
            {
                FarmerLoginForm loginForm = new FarmerLoginForm(farmers, predefinedProduce); //open login form

                loginForm.ShowDialog();
            }
        }

        private void btnCustomerPortal_Click(object sender, EventArgs e)
        {
            CustomerPortalForm customerPortal = new CustomerPortalForm(farmers, predefinedProduce); //open customer portal
            customerPortal.Show();
        }

        private void btnFarmerPortal_Click(object sender, EventArgs e)
        {

        }
    }
}
