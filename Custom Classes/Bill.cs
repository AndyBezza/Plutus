using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plutus.CustomClasses
{
    public class Bill
    {
        public int      _iD;

        public DateTime _creationDateTime;
        public bool     _isActive;

        public decimal  _estimatedAmount;
        public int      _dateInMonth;
        public String   _name;
        public String   _description;
        public Currency _currency;

        public Bill(int         id,
                    decimal     estimatedAmount,
                    int         dateInMonth,
                    String      name,
                    String      description,
                    Currency    currency)
        {
            _iD                 = id;

            _creationDateTime   = DateTime.Now;
            _isActive           = true;

            _estimatedAmount    = estimatedAmount;
            _dateInMonth        = dateInMonth;
            _name               = name;
            _description        = description;
            _currency           = currency;
        }
                    

        private Bill()
        {   
            //private constructor used only for Serialization
        }   
    }       
}           
