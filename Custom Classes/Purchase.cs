using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plutus.CustomClasses
{
    public class Purchase
    {
        public int                  _iD;

        public DateTime             _dateTime;

        public decimal              _originalPrice;
        public Currency             _originalCurrency;
        public decimal              _effectivePrice;
        public Currency             _effectiveCurrency;
        public String               _quickDescription;
        public String               _additionalInformation;
        public bool                 _spreadOverMonth;
        public List<AccountChange>  _accountChanges; 
        
        public Purchase(int                 iD,
                        decimal             originalPrice,
                        Currency            originalCurrency,
                        decimal             effectivePrice,
                        Currency            effectiveCurrency,
                        String              quickDescription,
                        String              additionalInformation,
                        bool                spreadOverMonth, 
                        List<AccountChange> accountChanges)
        {
            _iD                     = iD;

            _dateTime               = DateTime.Now; 

            _originalPrice          = originalPrice;
            _originalCurrency       = originalCurrency;
            _effectivePrice         = effectivePrice;
            _effectiveCurrency      = effectiveCurrency;
            _quickDescription       = quickDescription;
            _additionalInformation  = additionalInformation;
            _spreadOverMonth        = spreadOverMonth;
            _accountChanges         = accountChanges;
        }

        private Purchase()
        {
            //private constructor used only for Serialization
        }
    }
}
