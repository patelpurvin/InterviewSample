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

        private string _firstname;
        private string _lastname;
        private string _middlename;

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
        public string MiddleName
        {
            get { return _middlename; }
            set { _middlename = value; }
        }
        public string GetFullName()
        {
            return this._firstname + " " + this._lastname;
        }
    }
}
