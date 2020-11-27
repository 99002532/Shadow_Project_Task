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
    

    // Console -- Local / 1 instance 


 
    /// <summary>
    /// This program will generate a random number with given number of size.and with given conditions.
    /// </summary>
    class MyApplication
    {

        static void Main(string[] args)
        {
            //Reading input from the file

                FileRead FileOp = new FileRead();
                UserInput UserInputValue = FileOp.ReaderInput();
  
            CountsDigits DigiCheck = new CountsDigits();//instance of Counts_Digit
            KeyGenerator KeyGens = new KeyGenerator();//instance of KeyGenerator()
            DigitsGenerate DigiTwistVal = new DigitsGenerate();//instance of DigitsGenerate

            Console.WriteLine("The Size is: ");
            Console.WriteLine(UserInputValue.size);
            int RandomValueGen = DigiTwistVal.RandDigits(UserInputValue.size);//generating random number
            //Console.WriteLine("First random: "+ RandomValueGen);

            //Reading the second line for "digit should not start with"

            Console.WriteLine("Characters shouldn't start with: ");
            foreach (Object ValuePrinter in UserInputValue.StartDigits)
                Console.WriteLine(ValuePrinter);
            DigiCheck.DigiOneDigit(UserInputValue.StartDigits);
            DigiCheck.DigitsCounter(UserInputValue.StartDigits);
            DigiCheck.DigitsSpecialChecker(UserInputValue.StartDigits);

            Console.WriteLine("Characters shouldn't end with: ");
            foreach (object ValuePrinter in UserInputValue.EndDigits)
                Console.WriteLine(ValuePrinter);
            DigiCheck.DigiOneDigit(UserInputValue.EndDigits);
            DigiCheck.DigitsCounter(UserInputValue.EndDigits);
            DigiCheck.DigitsSpecialChecker(UserInputValue.EndDigits);

            while (Globals.FlagG == 0)
            {

                var DigiReverVal = new RandomReverse();
                ArrayList ArrayReverse = new ArrayList();
                ArrayReverse = DigiReverVal.ReverseDigiter(RandomValueGen);
                // Console.WriteLine("size" + ArrayReverse.Count);

                ComparatorValue CompareOp = new ComparatorValue();
                ComparatorValue CompareOp1 = new ComparatorValue();

                CompareOp.ComparorsValue(UserInputValue.StartDigits, ArrayReverse, 1);//comparing digit 1 with the generated random number.
                CompareOp1.ComparorsValue(UserInputValue.EndDigits, ArrayReverse, 2);//comparing digit 2 with the generated random number.

                RandomValueGen = FileOp.IfElseComparator(UserInputValue.size,RandomValueGen);

            }
            Console.WriteLine("Finished Key generation: " + RandomValueGen);//Printig the final genrated random number.
            Console.ReadLine();
        }
    };

}

