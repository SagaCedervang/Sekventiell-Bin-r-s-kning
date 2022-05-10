using System;

namespace Sekventiell_Binär_sökning
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int[] numbers = { 3, 5, 6, 7, 2 };
            int position = SekventiellSök(numbers, 7);
            Console.WriteLine(position);

            int[] lista = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            int index = BinärSök(lista, 12);
            Console.WriteLine(index);
        }

        static int SekventiellSök(int[] data, int värde)
        {
            int index = -1;

            if (data == null)
                return index;

            for (int i = 0; i < data.Length; i++) 
            {
                if(data[i] == värde)
                {
                    if(data[i] == värde)
                    {
                        index = i;
                        return index;
                    }
                }
            }
            return index;
        }

        static int BinärSök(int[] data, int värde)
        {
            if (data == null)
                return -1;

            int start = 0;
            int stop = data.Length - 1;

            while (start <= stop)
            {
                int mitt = (start + stop) / 2;
                if (data[mitt] < värde)
                    start = mitt + 1;
                else if (data[mitt] > värde)
                    stop = mitt - 1;
                else
                    return mitt;
                
            }
            return -1;
        }



    }
}
