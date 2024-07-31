using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.AxHost;
using System.Xml.Linq;

namespace FarmersMarketApp___
{
    public class Produce
    {
        public string Name { get; set; } //property to store the name of the produce item
        public string Category { get; set; } //property to store the name of the category of the produce
        public double Price { get; set; } //property to store the price of the produce item
        public double Quantity { get; set; } //property to store the quantity of the produce item
        public string Unit { get; set; }  //property to store the Unit of the produce item 

        public void DecreaseQuantity(double amount) //method to decrease the quantity of produce
        {
            if (Quantity>=amount)
            {
               Quantity -= amount; //decrease the quantity if there is enough available 
            }
            else
            {
                throw new InvalidOperationException("Insufficient quantity available."); //throw an exception if the quantity is not enough 
            }
        }
        public void IncreaseQuantity(double amount) //method to increase the quantity of produce
        {
           Quantity += amount; //Increase the quantity 
        }
    }
}
