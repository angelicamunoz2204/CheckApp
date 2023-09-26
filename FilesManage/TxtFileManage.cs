using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using CheckApp.DTO;
using CheckApp.Database;
using CheckApp.Database.DBModels;

namespace CheckApp.FilesManage
{
    public class TxtFileManage
    {
        public static void processingTxtFile()
        {
            try
            {
                string header;
                string details;

                using (
                    var sr =
                        new StreamReader("./File_transformation_TEST/CHEQUE_ap.TXT")
                )
                {
                    header = sr.ReadLine();
                    details = sr.ReadLine();

                    sr.Close();
                }

                var checkHeader = createCheckHeader(header);
                var checkDetails = createCheckDetails(details);
                string today = DateTime.Now.ToString("ddMMyyyy");
                string outputFileName =
                    String
                        .Format("{0}{1}{2}",
                        "./File_transformation_TEST/CHECK_AFT_DATE(",
                        today,
                        ").TXT");

                string headerOutput =
                    String
                        .Format("H~{0}~{1}~{2}~{3}~{4}~{5}~{6}~{7}~{8}~{9}~{10}~{11}{12}{13}~{14}~{15}~{16}<",
                        checkHeader.checkNumber,
                        checkHeader.bankName,
                        checkHeader.bankAddress1,
                        checkHeader.bankAddress2,
                        checkHeader.accountId,
                        checkHeader.checkDate,
                        checkHeader.currencyId,
                        checkHeader.payeeName1,
                        checkHeader.payeeName2,
                        checkHeader.address1,
                        checkHeader.address2,
                        checkHeader.address3,
                        checkHeader.address4,
                        checkHeader.address5,
                        checkHeader.checkAmount,
                        checkHeader.payorId,
                        checkHeader.amountString);
                string detailsOutput =
                    String
                        .Format("D~{0}~{1}~{2}~{3}~{4}~{5}~{6}~{7}~{8}",
                        checkDetails.invoiceNumber,
                        checkDetails.invoiceDate,
                        checkDetails.voucherNumber,
                        checkDetails.voucherDate,
                        checkDetails.grossAmount,
                        checkDetails.discountAmount,
                        checkDetails.netAmount,
                        checkDetails.concept,
                        checkDetails.benefitDescription);

                using (var sw = new StreamWriter(outputFileName))
                {
                    sw.WriteLine (headerOutput);
                    sw.WriteLine (detailsOutput);

                    sw.Close();
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("The file could not be read or written:");
                Console.WriteLine(e.Message);
            }
        }

        public static HeaderDTO createCheckHeader(string headerString)
        {
            var h = new HeaderDTO();
            h.checkNumber = headerString.Substring(1, 8).Trim();
            h.bankId = headerString.Substring(9, 10).Trim();
            h.accountId = headerString.Substring(19, 15).Trim();
            h.checkDate = formatingDate(headerString.Substring(34, 10).Trim());
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

            if (accountId == "1001395" || accountId == "1026780")
            {
                currencyId = "EC$";
            }

            if (accountId == "1502764" || accountId == "2045326")
            {
                currencyId = "$";
            }

            h.currencyId = currencyId;


            Bank bank = DBController.getBankById(h.bankId);

            h.bankName = bank.BankName;
            h.bankAddress1 = bank.Address1;
            h.bankAddress2 = bank.Address2;

            return h;
        }

        public static string formatingDate(string initialDate)
        {
            string formatedDate = DateTime.ParseExact(initialDate, "MM/dd/yyyy", CultureInfo.InvariantCulture).ToString("dd/MM/yyyy");

            return formatedDate.ToString();
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
            d.voucherDate = formatingDate(detailsString.Substring(100, 10).Trim());
            d.grossAmount = formatingDecimalNumbers(detailsString.Substring(110, 14).Trim());
            d.discountAmount = formatingDecimalNumbers(detailsString.Substring(124, 14).Trim());
            d.netAmount = formatingDecimalNumbers(detailsString.Substring(138, 14).Trim());
            d.concept = detailsString.Substring(152, 30).Trim();
            d.benefitDescription = detailsString.Substring(182).Trim();

            return d;
        }

        public static string formatingDecimalNumbers(string initialNum)
        {
            double num = double.Parse(initialNum.Replace('.', ','));
            string formatedNum = String.Format("{0:N2}", num);

            return formatedNum;
        }
    }
}
