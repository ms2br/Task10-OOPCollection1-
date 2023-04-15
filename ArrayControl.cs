using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10_OOPCollection1_
{
    internal class ArrayControl
    {
        public List<string> myArray = new List<string>();

        public void Add(string setValue)
        {
            if (!myArray.Contains(setValue))
            {
                myArray.Add(setValue);
            }
            else;
        }


        public void ValueDelete(string deletValue)
        {
            if (myArray.Contains(deletValue))
            {
                #region Controlsuz Deyer Artimi Olarsa
                //while (myArray.Contains(deletValue))
                //{
                //    myArray.Remove(deletValue);
                //}
                #endregion

                myArray.Remove(deletValue);
            }
            else
            {
                Console.WriteLine("Deyer Tapilmadi");
            }
        }

        public void UpdateMetot(string lastValue,string newValue)
        {
            if (myArray.Contains(lastValue))
            {
                myArray[myArray.IndexOf(lastValue)] = newValue;
            }
            else;
        }
    }
}
