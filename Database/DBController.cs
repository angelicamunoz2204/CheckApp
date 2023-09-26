using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CheckApp.Database.DBModels;

namespace CheckApp.Database
{
    public class DBController
    {
        public static List<string> getAllBanks()
        {
            var a = new List<string>();
            using (var db = new CheckPlus_235Context())
            {
                a = (from bank in db.Banks
                select bank.BankName).ToList();

            }
            return a;
        }

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