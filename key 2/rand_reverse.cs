using System;
using System.Collections;

namespace KeyGen
{
    interface IRandomReverse
    {
        public ArrayList ReverseDigiter(int InputNum);
    }
    public class RandomReverse : IRandomReverse
{
    /// <summary>
    /// This function will parse the interger data into array list. the data will be in reverse manner. 
    /// </summary>
    /// <param name="InputNum"></param>
    /// <returns></returns>
    public ArrayList ReverseDigiter(int InputNum)
    {
        int i = 0, m;
        ArrayList ReverseArray = new ArrayList();
            while (InputNum > 0)
        {
            m = InputNum % 10;
            ReverseArray.Add(m);
            InputNum = InputNum / 10;
            i++;

        }
        return ReverseArray;
    }
};
}
