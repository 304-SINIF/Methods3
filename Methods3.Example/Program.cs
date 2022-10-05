using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods3.Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int x = 10;
            //TheChanger(x);
            //Console.WriteLine(x);

            //int[] array = new int[5];
            //TheArrayChanger(array);
            //Console.WriteLine(array.Length);

            //int[] array = { 11, 25, 38, 7, 0, 87, -1 };
            //TheArraySorter(array);

            //int x = 10;
            //TheRealChanger(ref x);
            //Console.WriteLine(x);

            //string s = Console.ReadLine();
            //bool isValid = TryParse(s, out int number);
            //Console.WriteLine(isValid);
            //Console.WriteLine(number);

            SorterAndPrinter(true);

            Console.ReadKey();
        }
        static void TheArraySorter(int[] array)
        {
            Array.Sort(array);
        }
        static void TheChanger(int x)
        {
            x = 5;
        }
        static void TheArrayChanger(int[] array)
        {
            array = new int[10];
        }
        static void TheRealChanger(ref int x)
        {
            x = 5;
        }
        static bool TryParse(string input, out int number)
        {
            number = 0;
            bool isConvertable = false;
            try
            {
                number = Convert.ToInt32(input);
                isConvertable = true;
            }
            catch
            {
                isConvertable = false;
            }

            return isConvertable;
        }
        static void SorterAndPrinter(bool b, params int[] arr)
        {
            Array.Sort(arr);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + ", ");
            }
        }
    }
}
