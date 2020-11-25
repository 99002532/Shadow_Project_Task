using System;
using System.Collections;
using System.IO;
using System.Text.Json;
using System.Linq;
using KeyGen;

namespace MyApplication
{

    public static class Globals
    {

        public static int FlagG = 0;
        public static int FlagOne = 0;
        public static int FlagTwo = 0;
    }
    

 
    /// <summary>
    /// This proram will generate a random number with given number of size.and with given conditions.
    /// </summary>
    class MyApplication
    {

        static void Main(string[] args)
        {
            //Reading input from the file

                var FileOp = new FileRead();
                var userInputVal = FileOp.ReaderInput();
  
            var DigiCheck = new Counts_Digits();//instance of Counts_Digit
            var KeyGens = new KeyGenerator();//instance of KeyGenerator()
            var DigiTwistVal = new digits_twister();//instance of digits_twister

            Console.WriteLine("The Size is: ");
            Console.WriteLine(userInputVal.size);
            int RandomValueGen = DigiTwistVal.rand_digits(userInputVal.size);//generating random number
            //Console.WriteLine("First random: "+ RandomValueGen);

            //Reading the second line for "digit should not start with"

            Console.WriteLine("Characters shouldn't start with: ");
            foreach (var ValuePrinter in userInputVal.digit1_not)
                Console.WriteLine(ValuePrinter);
            DigiCheck.Digi_Counter(userInputVal.digit1_not);
            DigiCheck.Digi_special(userInputVal.digit1_not);

            Console.WriteLine("Characters shouldn't end with: ");
            foreach (var ValuePrinter in userInputVal.digit2_not)
                Console.WriteLine(ValuePrinter);
            DigiCheck.Digi_Counter(userInputVal.digit2_not);
            DigiCheck.Digi_special(userInputVal.digit2_not);
