using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using Plutus.CustomClasses;

namespace Plutus.CustomControls
{
    class CurrencyNumericUpDown : NumericUpDown
    {
        private Currency _displayCurrency;
        private bool _started;

        public Currency DisplayCurrency
        {
            get
            {
                return _displayCurrency;
            }
            set
            {
                _displayCurrency = value;
                UpdateEditText();
            }
        }

        protected override void UpdateEditText()
        {
            switch (_displayCurrency)
            {
                case Currency.GBP:
                    this.Text = (Value.ToString("C2", System.Globalization.CultureInfo.CreateSpecificCulture("en-GB")));
                    break;
                case Currency.EUR:
                    this.Text = (Value.ToString("C2", System.Globalization.CultureInfo.CreateSpecificCulture("de-DE")));
                    break;
                case Currency.DKK:
                    this.Text = (Value.ToString("C2", System.Globalization.CultureInfo.CreateSpecificCulture("da-DK")));
                    break;
                case Currency.USD:
                    this.Text = (Value.ToString("C2", System.Globalization.CultureInfo.CreateSpecificCulture("en-US")));
                    break;
                default:
                    this.Text = Value.ToString();
                    break;
            }
        }
    }
}
