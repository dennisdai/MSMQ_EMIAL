using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] _array = { 1, 3, 5, 6, 10, 14, 16, 20, 21, 23, 28 };
            int _findValue = BinSearch(_array, 0, _array.Length, 20);
            if (_findValue == -1)
            {
                Console.WriteLine("not find");
            }
            else
            {
                Console.WriteLine("find the value at " + _findValue);
            }
            Console.ReadLine();
        }

        static int BinSearch(int[] _array, int start, int end, int key)
        {
            int left, right;
            int mid;
            left = start;
            right = end;

            while (left <= right)
            {
                mid = (left + right) / 2;

                if (key < _array[mid])
                {
                    right = mid - 1;
                }
                else if (key > _array[mid])
                {
                    left = mid + 1;
                }
                else
                    return mid;
            }
            return -1;
        }
    }
}
