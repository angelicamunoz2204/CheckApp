using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using CheckApp.DTO;

namespace CheckApp.FilesManage
{
    public class TxtFileManage
    {
        public static void read()
        {
            try
            {
                string header;
                string details;

                using (var sr = new StreamReader("./File_transformation_TEST/CHEQUE_ap.TXT"))
                {
                    header = sr.ReadLine();
                    details = sr.ReadLine();

                    sr.Close();
                }

                var checkHeader = createCheckHeader(header);
                var checkDetails = createCheckDetails(details);

                string headerOutput = String.Format("H~{0}~{1}~{2}~{3}~{4}~{5}~{6}",checkHeader.checkNumber, "bankName", "addr1", "addr2", checkHeader.accountId, "checkDate", checkHeader.currencyId);
                string detailsOutput = String.Format("ID~{0}~{1}~{2}~{3}~{4}{5}{6}~{7}~{8}~{9}", checkHeader.payeeName1, checkHeader.payeeName2, checkHeader.address1, checkHeader.address2, checkHeader.address3, checkHeader.address4, checkHeader.address5, checkHeader.checkAmount, checkHeader.payorId, checkHeader.amountString);

                using (var sw = new StreamWriter("./File_transformation_TEST/CHECK_AFT_DATE.TXT"))
                { 
                    sw.WriteLine(headerOutput);
                    sw.WriteLine(detailsOutput);

                    sw.Close();
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
        }

        public static HeaderDTO createCheckHeader(string headerString)
        {
            var h = new HeaderDTO();
            h.checkNumber = headerString.Substring(1, 8).Trim();
            h.bankId = headerString.Substring(9, 10).Trim();
            h.accountId = headerString.Substring(19, 15).Trim();
            h.checkDate = headerString.Substring(34, 10).Trim();
            h.payeeId = headerString.Substring(44, 10).Trim();
            h.payeeName1 = headerString.Substring(54, 35).Trim();
            h.payeeName2 = headerString.Substring(89, 35).Trim();
            h.address1 = headerString.Substring(124, 35).Trim();
            h.address2 = headerString.Substring(159, 35).Trim();
            h.address3 = headerString.Substring(194, 35).Trim();
            h.address4 = headerString.Substring(229, 35).Trim();
            h.address5 = headerString.Substring(264, 35).Trim();
            h.checkAmount = headerString.Substring(532, 14).Trim();
            h.payorId = headerString.Substring(546, 10).Trim();
            h.amountString = headerString.Substring(591, 120).Trim();
            h.templateId = headerString.Substring(711).Trim();

            var accountId = h.accountId;
            string currencyId = "";

            if(accountId == "1001395" || accountId == "1026780" )
            {
                currencyId = "EC$";
            }
            
            if(accountId == "1502764" || accountId == "2045326" )
            {
                currencyId = "$";
            }

            h.currencyId = currencyId;

            return h;
        }

        public static DetailsDTO createCheckDetails(string detailsString)
        {
            var d = new DetailsDTO();
            d.checkNumber = detailsString.Substring(1, 8).Trim();
            d.bankId = detailsString.Substring(9, 10).Trim();
            d.bankAccount = detailsString.Substring(19, 15).Trim();
            d.checkDate = detailsString.Substring(34, 10).Trim();
            d.invoiceNumber = detailsString.Substring(44, 30).Trim();
            d.invoiceDate = detailsString.Substring(74, 10).Trim();
            d.voucherNumber = detailsString.Substring(84, 16).Trim();
            d.voucherDate = detailsString.Substring(100, 10).Trim();
            d.grossAmount = detailsString.Substring(110, 14).Trim();
            d.discountAmount = detailsString.Substring(124, 14).Trim();
            d.netAmount = detailsString.Substring(138, 14).Trim();
            d.concept = detailsString.Substring(152, 30).Trim();
            d.benefitDescription = detailsString.Substring(182).Trim();

            return d;
        }
    }
}