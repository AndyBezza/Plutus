using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

using Plutus.CustomClasses;
using System.Windows.Forms; 

namespace Plutus.DAL
{
    public class DataAccessManager
    {
        private string driveLetter;

        private const string xMLFolderLocation = "Plutus\\Plutus\\XML\\";

        private const string accountsFileName = "Accounts.xml";
        public List<Account> accounts = new List<Account>();

        private const string purchasesFileName = "Purchases.xml";
        public List<Purchase> purchases = new List<Purchase>(); 

        public DataAccessManager()
        {
            driveLetter = Path.GetPathRoot(System.Reflection.Assembly.GetEntryAssembly().Location);

            LoadXML(); 
        }

        private void LoadXML()
        {
            LoadAccounts();
            LoadPurchases();
        }

        public void LoadAccounts()
        {
            accounts = DeSerializeObject<List<Account>>(driveLetter + xMLFolderLocation + accountsFileName); 
        }

        public void LoadPurchases()
        {
            purchases = DeSerializeObject<List<Purchase>>(driveLetter + xMLFolderLocation + purchasesFileName); 
        }

        public void SaveAccounts()
        {
            SerializeObject<List<Account>>(accounts, (driveLetter + xMLFolderLocation + accountsFileName));
        }

        public void SavePurchases()
        {
            SerializeObject<List<Purchase>>(purchases, (driveLetter + xMLFolderLocation + purchasesFileName));
        }

        public void SerializeObject<T>(T serializableObject, string fileName)
        {
            if (serializableObject == null) { return; }

            try
            {
                XmlDocument xmlDocument = new XmlDocument();
                XmlSerializer serializer = new XmlSerializer(serializableObject.GetType());
                using (MemoryStream stream = new MemoryStream())
                {
                    serializer.Serialize(stream, serializableObject);
                    stream.Position = 0;
                    xmlDocument.Load(stream);
                    xmlDocument.Save(fileName);
                    stream.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Plutus Error"); 
            }
        }

        public T DeSerializeObject<T>(string fileName)
        {
            if (string.IsNullOrEmpty(fileName)) { return default(T); }

            T objectOut = default(T);

            try
            {
                string attributeXml = string.Empty;

                XmlDocument xmlDocument = new XmlDocument();
                xmlDocument.Load(fileName);
                string xmlString = xmlDocument.OuterXml;

                using (StringReader read = new StringReader(xmlString))
                {
                    Type outType = typeof(T);

                    XmlSerializer serializer = new XmlSerializer(outType);
                    using (XmlReader reader = new XmlTextReader(read))
                    {
                        objectOut = (T)serializer.Deserialize(reader);
                        reader.Close();
                    }

                    read.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Plutus Error"); 
            }

            return objectOut;
        }

        internal void CreateNewAccount()
        {
            accounts.Add(new Account(accounts.Count, 0M, 0M, "New Account...", "New Account Description", true, Currency.GBP)); 
        }

        internal int CreateNewPurchase(decimal originalPrice, Currency originalCurrency, decimal effectivePrice, Currency effectiveCurrency, string quickDescription, string additionalInformation, bool spreadOverMonth, List<AccountChange> accountChanges)
        {
            purchases.Add(new Purchase(purchases.Count(), originalPrice, originalCurrency, effectivePrice, effectiveCurrency, quickDescription, additionalInformation, spreadOverMonth, accountChanges));
            SavePurchases();
            return purchases.Count - 1; 
        }

        internal Account FindAccountByName(string accountName)
        {
            foreach (Account acc in accounts)
            {
                if (acc._name.CompareTo(accountName) == 0)
                {
                    return acc;
                }
            }
            return null;
        }

        internal List<Account> FindAccountsByCurrency(Currency currency, bool includeSuspendedAccounts)
        {
            List<Account> returnList = new List<Account>(); 

            foreach (Account acc in accounts)
            {
                if ((acc._currency == currency) && (acc._isActive || includeSuspendedAccounts))
                {
                    returnList.Add(acc); 
                }
            }

            return returnList;
        }

        public List<Account> ActiveAccounts 
        { 
            get
            {
                List<Account> returnList = new List<Account>();
                foreach(Account acc in accounts)
                {
                    if (acc._isActive)
                    {
                        returnList.Add(acc);
                    }
                }
                return returnList;
            }
        }
    }
}
