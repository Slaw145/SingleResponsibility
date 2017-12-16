using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Client
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ZipCode { get; set; }
        private double _myWallet;
        public double MyWallet { get => _myWallet; set => _myWallet = value; }


        public Client(string firstname, string lastname, string zipcode, double myWallet)
        {
            FirstName = firstname;
            LastName = lastname;
            ZipCode = zipcode;
            _myWallet = myWallet;
        }
    }
}
