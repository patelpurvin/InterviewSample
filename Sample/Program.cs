using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.ReadLine();
        }

        
    }
    
    public class Customer
    {

        private int _id;
        private string _firstname;
        private string _lastname;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string FirstName
        {
            get { return _firstname; }
            set { _firstname = value; }
        }
        public string LastName
        {
            get { return _lastname; }
            set { _lastname = value; }
        }
        public string GetFullName()
        {
            return this._firstname + " " + this._lastname;
        }
    }
}
