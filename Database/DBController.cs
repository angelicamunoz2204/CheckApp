using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CheckApp.Database.DBModels;

namespace CheckApp.Database
{
    public class DBController
    {
        public static Bank getBankById(string id)
        {
            using (var db = new CheckPlus_235Context())
            {
                var bank = db.Banks.FirstOrDefault(b => b.BankId == id);
                return bank;
            }
        }
    }
}