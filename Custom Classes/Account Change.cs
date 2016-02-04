using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plutus.CustomClasses
{
    public class AccountChange
    {
        public int      _accountID;
        public decimal  _amount; 

        public AccountChange(   int         accountID,
                                decimal     amount)
        {
            _accountID  = accountID;
            _amount     = amount; 
        }

        private AccountChange()
        {   
            //private constructor used only for Serialization
        }   
    }       
}           
