using System;
using System.Collections.Generic;

namespace Challange_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 0, 8, 4, 12, 2, 10, 6, 14, 1, 9, 5, 13, 3, 11, 7, 15 };
            //int[] lis;
            int[] len = new int[array.Length];
            int[] prev = new int[array.Length];
            int maxLength = 0;
            int lastIndex = -1;

            for (int current = 0; current < array.Length; current++)
            {
                len[current] = 1;
                prev[current] = -1;
                for (int prevIndex = 0; prevIndex < current; prevIndex++)
                {
                    if (array[prevIndex] < array[current] && len[prevIndex] >= len[current])
                    {
                        len[current] = 1 + len[prevIndex];
                        prev[current] = prevIndex; //индекс на най-добрия елемент от поредицата
                    }
                }
                //макс брой елементи
                if (len[current] > maxLength)
                {
                    maxLength = len[current];
                    lastIndex = current;
                }
            }
            int[] list = new int[maxLength];
            for (int i = 0; i < maxLength; i++)
            {
                list[i] = array[lastIndex];
                lastIndex = prev[lastIndex];
            }
            Array.Reverse(list);
            Console.WriteLine(string.Join(" ", list));

        }


    }
}
