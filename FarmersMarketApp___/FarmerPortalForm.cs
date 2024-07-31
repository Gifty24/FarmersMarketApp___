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
    public partial class FarmerPortalForm : Form
    {
        private Farmer currentFarmer; //store the current logged-in farmer
        private List<Produce> predefinedProduce; //list to store predefined produce

        public FarmerPortalForm(Farmer farmer, List<Produce> predefinedProduce) //constructor to initialize the form with the current farmer and predefined produce
        {
            InitializeComponent(); //initialize form components
            currentFarmer = farmer ?? throw new ArgumentNullException(nameof(farmer));//ensure farmer is not null
            this.predefinedProduce = predefinedProduce ?? new List<Produce>(); //initialize predefined produce list if null
            LoadProduce(); //load farmer's produce into the data grid
        }
        private void LoadProduce() //method to load all produce into the data grid
        {
            var allProduce = new List<Produce>(predefinedProduce); //create a list from predefined produce

            allProduce.AddRange(currentFarmer.ProduceList);//add farmer's produce list

            dataGridViewProduce.DataSource = allProduce; //load produce into data  grid
        }
        private void FarmerPortalForm_Load(object sender, EventArgs e)
        {

        }

        private void btnAddProduce_Click(object sender, EventArgs e)
        {
            //create a new produce item from the input fields
            Produce produce = new Produce
            {
                Name = txtProduceName.Text, //get the entered produce name by farmer
                Category = txtProduceCategory.Text, //get entered produce category by farmer
                Price = double.Parse(txtProducePrice.Text), //get the entered produce price
                Quantity = double.Parse(txtProduceQuantity.Text), //get the entered produce quantity
                Unit = txtProduceUnit.Text, //get the entered produce unit

            };
            currentFarmer.ProduceList.AddLast(produce); //add new produce to list

            ClearInputFields(); //Clear input fields after adding the produce

            LoadProduce(); //Reload the produce list 
        }
        private void ClearInputFields() //function to clear all the input fields once added to the produce list
        {
            txtProduceName.Clear(); //clear produce name input field
            txtProduceCategory.Clear(); //clear category name input field
            txtProducePrice.Clear();//clear produce price input field
            txtProduceQuantity.Clear();//clear produce quantity input field
            txtProduceUnit.Clear();//clear produce name Unit field
        }

        private void dataGridViewProduce_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblProduceCategory_Click(object sender, EventArgs e)
        {

        }
    }
}
