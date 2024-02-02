using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Improved_search
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ImprovedSearch search = new ImprovedSearch(new int[] { 10, 20, 30, 40, 50 });

            int position = search.FindTransposition(30);

            Console.WriteLine("New array: " + string.Join(" ", search.Array));
            Console.WriteLine("Return: " + position);
        }
    }

    public class ImprovedSearch
    {
        public int[] Array { get; private set; }

        public ImprovedSearch(int[] array)
        {
            Array = array;
        }

        public int FindTransposition(int value)
        {
            for (int i = 0; i < Array.Length; i++)
            {
                if (Array[i] == value)
                {
                    if (i > 0)
                    {
                        int temp = Array[i - 1];
                        Array[i - 1] = Array[i];
                        Array[i] = temp;
                        return i - 1;
                    }
                    else
                    {
                        return i;
                    }
                }
            }
            return -1;
        }


    }
}