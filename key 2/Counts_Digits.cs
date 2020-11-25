using System;
using System.Collections;
using System.Linq;

namespace KeyGen
{
    interface ICounts_Digits
    {
        public void Digi_Counter(ArrayList digis);
    }
    class Counts_Digits : ICounts_Digits
    {
        /// <summary>
        /// DigitConter:
        /// this function will count the digits.if it is more than 3 digits program will show an error message and exit.
        /// </summary>
        /// <param name="digis"></param>
        public void Digi_Counter(ArrayList digis)
        {
            if (digis.Count > 3)
            {
                Console.WriteLine("Maximum three digits are accepted");
                Console.ReadLine();
                System.Environment.Exit(0);
            }
        }
        public void DigiOneDigit(ArrayList DigisCheck)
        {
            foreach (var ValuePrinter in DigisCheck)
            {
                string ValueStr = ValuePrinter.ToString();
                int ValueInt = (int)ValueStr.Count();

                if (ValueInt>1)
                {
                    Console.WriteLine("Double Digits not allowed");
                    Console.ReadLine();
                    System.Environment.Exit(0);
                }
             }
        }
        public void Digi_special(ArrayList digits)
        {
            String digi_str;
            try
            {
                digi_str = digits[0].ToString();
            }
            catch(Exception e)
            {
                return;
            }
           digi_str = digits.ToString();
            char[] digi_char = digi_str.ToCharArray();


            for (int i = 0; i < digits.Count; i++)
            {
                digi_str = digits[i].ToString();
                digi_char = digi_str.ToCharArray();
                //Console.WriteLine("Characters: " + digi_char[i]);
                if (Char.IsLetter(digi_char[0]))
                {
                    Console.WriteLine("No Characters allowed in input");
                    Console.ReadLine();
                    System.Environment.Exit(0);
                }

            }

        }
    }
}
