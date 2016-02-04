using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plutus.CustomClasses
{
    public class Account
    {
        public int      _iD;

        public DateTime _creationDateTime;
        public bool     _isActive;
            
        public decimal  _startingBalance;
        public decimal  _creditLimit;
        public String   _name;
        public String   _description;
        public bool     _isCash;
        public Currency _currency;

        public Account(int         iD,
                       decimal     startingBalance,
                       decimal     creditLimit,
                       String      name,
                       String      description,
                       bool        isCash,
                       Currency    currency)
        {
            _iD                 = iD;

            _isActive           = true;
            _creationDateTime   = DateTime.Now;

            _startingBalance    = startingBalance;
            _creditLimit        = creditLimit; 
            _name               = name;
            _description        = description;
            _isCash             = isCash;
            _currency           = currency;
        }

        private Account()
        {   
            //private constructor used only for Serialization
        }   
    }       
}           
