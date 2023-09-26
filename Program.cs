using System;
using CheckApp.Database;
using CheckApp.FilesManage;

namespace CheckApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = DBController.getBankById("CCB");
            Console.WriteLine(a);
            TxtFileManage.read();

        }
    }
}
