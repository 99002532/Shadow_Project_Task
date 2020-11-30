using System;
using System.Collections.Generic;
using System.Text;

namespace KeyGen
{
    interface IDigitsGenerate
    {
        public int RandDigits(int size);
    }
    public class DigitsGenerate : IDigitsGenerate
    {
        /// <summary>
        /// Random Digits
        /// based on the size of user input it will generate random number
        /// </summary>
        /// <param name="size"></param>
        /// <returns></returns>
        public int RandDigits(int size)
        {
            int RandVal = 0;
            var KeyGens = new KeyGenerator();
            switch (size)
            {
                case 1:
                    RandVal = KeyGens.RandomKey(1, 10);
                    break;
                case 2:
                    RandVal = KeyGens.RandomKey(10, 100);
                    break;
                case 3:
                    RandVal = KeyGens.RandomKey(100, 1000);
                    break;
                case 4:
                    RandVal = KeyGens.RandomKey(1000, 9999);
                    break;
                case 5:
                    RandVal = KeyGens.RandomKey(10000, 99999);
                    break;
                case 6:
                    RandVal = KeyGens.RandomKey(100000, 999999);
                    break;
                case 7:
                    RandVal = KeyGens.RandomKey(1000000, 9999999);
                    break;
                case 8:
                    RandVal = KeyGens.RandomKey(10000000, 99999999);
                    break;
                case 9:
                    RandVal = KeyGens.RandomKey(10000000, 999999999);
                    break;
                default:
                    Console.WriteLine("Maximum 9 size is allowed");
                    Console.ReadLine();
                    System.Environment.Exit(0);
                    break;


            }

            return RandVal;

        }
    };
}
