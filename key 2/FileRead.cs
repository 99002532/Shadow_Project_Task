using System;
using System.IO;
using System.Text.Json;
using System.Linq;
using System.Collections;
using MyApplication;

namespace KeyGen
{
    interface IFileRead
    {
        public UserInput ReaderInput();
        public int IfElseComparator(int size, int RandomValue);
    }
    class UserInput
    {
        public int size { get; set; }
        public ArrayList digit1_not { get; set; }
        public ArrayList digit2_not { get; set; }
    }
    class FileRead: IFileRead
    {
    public UserInput ReaderInput()
    {
        StreamReader ReaderFile;
            try
            {
                ReaderFile = new StreamReader(@"C:\Users\CTEA\Documents\input.json");
            }
            catch(Exception e)
            {
                Console.WriteLine("File Not found");
                Console.ReadLine();
                System.Environment.Exit(0);
            }

            ReaderFile = new StreamReader(@"C:\Users\CTEA\Documents\input.json");
            string str = ReaderFile.ReadToEnd();

            try
            {
                JsonSerializer.Deserialize<UserInput>(str);
            }
            catch (Exception e)
            {

                Console.WriteLine("Invalid File Input: Check Json");
                Console.ReadLine();
                System.Environment.Exit(0);
            }
            var userInputVal = JsonSerializer.Deserialize<UserInput>(str);
            return userInputVal;
    }

    public int IfElseComparator(int size, int RandomValue)
    {
        var digi_r1 = new digits_twister();

        if (Globals.FlagOne == 1)//checking if digit1 matches with generated random number 
        {
            RandomValue = digi_r1.rand_digits(size);
            Globals.FlagOne = 0;
        }
        else if (Globals.FlagTwo == 1)//checking if digit2 matches with generated random number 
        {
            RandomValue = digi_r1.rand_digits(size);
            Globals.FlagTwo = 0;
        }
        else//exiting the loop
        {
            Globals.FlagG = 1;
        }
        return RandomValue;
    }
}
}
