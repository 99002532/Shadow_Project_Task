using System;
using System.Collections;
using MyApplication;

namespace KeyGen
{
    interface IComparatorValue
    {
        public ArrayList ComparorsValue(ArrayList Dvalue, ArrayList Dresult, int switcher);
    }
    public class ComparatorValue : IComparatorValue
    {

        /// <summary>
        /// DigitComparor:
        /// this function will compare the Digits whether they are same are not.
        /// </summary>
        /// <param name="Dvalue"></param>
        /// <param name="Dresult"></param>
        /// <param name="switcher"></param>
        /// <returns></returns>
        public ArrayList ComparorsValue(ArrayList Dvalue, ArrayList Dresult, int switcher)
        {

            int DvalLength = Dvalue.Count;
            int DresultLength = Dresult.Count;
            ArrayList TempArray = new ArrayList();
            switch (switcher)
            {
                case 1:
                    for (int i = 0; i < DvalLength; i++)
                    {
                        //Console.WriteLine("loop1: " + Dvalue[i] + "  " + Dresult[DresultLength - 1]);
                        if (String.Equals(Dvalue[i].ToString(), Dresult[DresultLength - 1].ToString()))
                        //if (Dvalue[i].Equals(Dresult[DresultLength - 1]))
                        {
                            Globals.FlagOne = 1;
                            return TempArray;
                        }
                    }

                    break;
                case 2:
                    for (int i = 0; i < DvalLength; i++)
                    {
                        //Console.WriteLine("loop2: " + Dvalue[i] + "  " + Dresult[0]);
                        if (String.Equals(Dvalue[i].ToString(), Dresult[0].ToString()))
                        //if (Dvalue[i].Equals(Dresult[0]))
                        {
                            Globals.FlagTwo = 1;
                            return TempArray;
                        }
                    }


                    break;
            }
            return TempArray;
        }
    };
}
