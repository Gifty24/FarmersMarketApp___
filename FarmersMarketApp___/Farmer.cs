using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmersMarketApp___
{
    public class Farmer
    {
        //public properties for farmer class 
        public string Username { get; set; } //property to store user name
        public string Password { get; set; } //property to store password
        public string FirstName { get; set; } //property to store first name
        public string LastName { get; set; } //property to store last  name
        public string FarmName { get; set; } //property to store farm name
        public string RegistrationId { get; set; } //property to store registration ID

        public LinkedList<Produce> ProduceList { get; set; } = new LinkedList<Produce>(); //list of produce items, initializing it to an empty linked list

        public Farmer() //constructor to initialize the ProduceList
        {
            ProduceList = new LinkedList<Produce>(); //initialize the produce list
        }
    }
}
