﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plutus.CustomClasses
{
    public class Purchase
    {
        private int                     _iD;

        private DateTime                _dateTime;
                               
        private decimal                 _originalPrice;
        private decimal                 _effectivePrice;
        private string                  _quickDescription;
        private string                  _additionalInformation;
        private bool                    _spreadOverMonth;
        private List<AccountChange>     _accountChanges; 
        
        public Purchase(int                 iD,
                        decimal             originalPrice,
                        decimal             effectivePrice,
                        string              quickDescription,
                        string              additionalInformation,
                        bool                spreadOverMonth, 
                        List<AccountChange> accountChanges)
        {
            _iD                     = iD;

            _dateTime               = DateTime.Now; 

            _originalPrice          = originalPrice;
            _effectivePrice         = effectivePrice;
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