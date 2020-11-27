using System;
using System.Collections;
using System.Linq;

namespace KeyGen
{
    interface ICountsDigits
    {
        public void DigitsCounter(ArrayList Digits);
    }
    public class CountsDigits : ICountsDigits
    {
        /// <summary>
        /// DigitConter:
        /// this function will count the Digits.if it is more than 3 Digits program will show an error message and exit.
        /// </summary>
        /// <param name="Digits"></param>
        public void DigitsCounter(ArrayList Digits)
        {
            if (Digits.Count > 3)
            {
                Console.WriteLine("Maximum three Digits are accepted");
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
        public void DigitsSpecialChecker(ArrayList Digits)
        {
            String DigitsString;
            try
            {
                DigitsString = Digits[0].ToString();
            }
            catch(Exception e)
            {
                return;
            }
           DigitsString = Digits.ToString();
            char[] DigitsCharArray = DigitsString.ToCharArray();


            for (int i = 0; i < Digits.Count; i++)
            {
                DigitsString = Digits[i].ToString();
                DigitsCharArray = DigitsString.ToCharArray();
                //Console.WriteLine("Characters: " + DigitsCharArray[i]);
                if (Char.IsLetter(DigitsCharArray[0]))
                {
                    Console.WriteLine("No Characters allowed in input");
                    Console.ReadLine();
                    System.Environment.Exit(0);
                }

            }

        }
    }
}
