
using System;
using System.Collections.Generic;
using System.Linq;

namespace BankAccountData
{
    class BankAccountData
    {
        enum Banks { Райфайзенбанк=1, ДСК, Юробанк, СИБАНК, ПроКредит, Тексим, ОбщинскаБанка };

        static void Main()
        {
            //A bank account has a holder name(first name, middle name and last name), available amount of money (balance), bank name, IBAN,
            //3 credit card numbers associated with the account.Declare the variables needed to keep the information for a single bank account 
            //using the appropriate data types and descriptive names.
            var holderName = new Dictionary<string,string>();

            holderName.Add("firstName", "Amanda");
            holderName.Add("lastNmae", "Jones");
            holderName.Add("middleName", "Middle");
            long creditCardNumber1 = 4234234452423L;
            string IBAN = "BG80 BNBG 9661 1020 3456 78";
            decimal balance = 324234.45M;
            byte bankName = (byte)Banks.Тексим;         
           
            holderName.ToList().ForEach(x => Console.WriteLine("{0} : {1}", x.Key,x.Value));       
        }
    }
}
