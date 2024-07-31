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
    public partial class CustomerPortalForm : Form
    {
        private LinkedList<Produce> shoppingBasket = new LinkedList<Produce>(); //shopping basket to store selected produce
        private List<Farmer> farmers; //list of farmers
        private List<Produce> predefinedProduce; //list of predefined produce

        public CustomerPortalForm(List<Farmer> farmers, List<Produce> predefinedProduce)
        {
            InitializeComponent(); //initializing the form components 
            this.farmers = farmers; //set the farmers list
            this.predefinedProduce = predefinedProduce; //set the predefined produce list 
            LoadAllProduce(); //Load all produce
            LoadBasket(); //load initial basket
        }
     
        private void LoadAllProduce() //method to load all produce
        {
            var allProduce = predefinedProduce.ToList(); //Add predefined produce farmer' produce
            allProduce.AddRange(farmers.SelectMany(f => f.ProduceList)); //add farmers produce

            dataGridViewProduce.DataSource = allProduce; //Load produce into data grid
        }
        private void lblSubtotal_Click(object sender, EventArgs e)
        {

        }

        private void CustomerPortalForm_Load(object sender, EventArgs e)
        {

        }

        private void btnAddToBasket_Click(object sender, EventArgs e)
        {
            var selectedProduce = (Produce)dataGridViewProduce.CurrentRow.DataBoundItem; //get the selected produce
            if(selectedProduce != null)
            {
                var amountToAdd = 1; //define how much quantity to add to basket
                try
                {
                    selectedProduce.DecreaseQuantity(amountToAdd); //decrease the quantity of the selected produce
                    var basketItem = new Produce
                    {
                        Name = selectedProduce.Name,
                        Category = selectedProduce.Category,
                        Price = selectedProduce.Price,
                        Quantity = amountToAdd,
                        Unit = selectedProduce.Unit,
                    };
                    shoppingBasket.AddLast(basketItem); // add the item to the shopping basket
                    LoadAllProduce(); // reload all the produce to update the quantity
                    LoadBasket();//Reload the basket to show the added item
                }
                catch(InvalidOperationException ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); //show this error if not enough quantity
                }
            }
            else
            {
                MessageBox.Show("No produce selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);// show this error if no produce is selected
            }
           
        }
        private void LoadBasket() //method to load the shopping basket
        {
            dataGridViewBasket.DataSource = null; // reset data source
            dataGridViewBasket.DataSource = shoppingBasket.ToList(); // load shopping basket into data grid
            CalculateTotals(); //Calculate subtotal and total
        }
        private void CalculateTotals()//method to calculate the subtotal and total
        {
            double subtotal = shoppingBasket.Sum(p => p.Price * p.Quantity); //calculate the subtotal
           
            lblSubtotal.Text = $"Subtotal: {subtotal:C}"; //Display the subtotal
            lblTotal.Text = $"Total: {subtotal:C}"; //display the total including any additional calculation like tax
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            //show this confirmation message
            MessageBox.Show("Order placed! Please pick up your items on Saturday 6/30 at 10:00AM at Baltimore City Farmers Market, 1 Elm St, Baltimore MD 43222.");
            shoppingBasket.Clear(); //clear the shopping basket
            LoadBasket() ; //reload the basket to show it is empty
        }

        private void btnDelete_Click(object sender, EventArgs e) //function to delete from basket
        { 
            if (dataGridViewBasket.SelectedRows.Count > 0) //check if any row is selected in the data grid
            {
                List<int> indicesToRemove= new List<int>(); //list to store indices of items to remove

                foreach (DataGridViewRow row in dataGridViewBasket.SelectedRows) //loop through each selected row in the DataGridView
                {
                        indicesToRemove.Add(row.Index);//add selected row indices to the list
                }
                indicesToRemove.Sort((a, b)=> b.CompareTo(a)); //sort the indices in descending order
                foreach(int index in indicesToRemove)
                {
                    if (index>=0 && index< shoppingBasket.Count)
                    {
                        var itemToRemove=shoppingBasket.ElementAt(index); //get the item to remove from the basket
                        var originalItem=predefinedProduce.FirstOrDefault(p=>p.Name==itemToRemove.Name)??
                            farmers.SelectMany(f=>f.ProduceList).FirstOrDefault(p=>Name==itemToRemove.Name);
                        
                        if (originalItem!=null)
                        {
                            originalItem.IncreaseQuantity(itemToRemove.Quantity); //increase the quantity of the original produce
                        }
                        shoppingBasket.Remove(itemToRemove); //remove the item from the shopping basket
                    }

                }
                LoadAllProduce() ; //reload all produce to update the quantity
                LoadBasket() ; //reload the basket to reflect the changes in the DataGridView
            }
            else
            {
                MessageBox.Show("Please select an item to remove from the basket. "); //show this message if no item is selected
            }
           
        }
    }
}
