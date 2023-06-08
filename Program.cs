using System;

namespace Misal
{
    internal class ConsoleTab
    {
        static void Main(string[] args)
        {
            #region ArrayMax
            int[,] massiv = new int[3, 2] { { -1, 20 }, { 31, 4 }, { -544, 61 } };
            int max = massiv[0, 0];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    if (massiv[i, j] > max)
                    {
                        max = massiv[i, j];
                    }
                }
            }
            Console.WriteLine($"Maks is {max}");
            #endregion

            #region IndeksTapmaq

            Console.Write("Enter the number that you search: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[] { 4, 5, 6, 90, -43, 2 };
            IndexFind find = new IndexFind();
            find.Find(arr, n);

            #endregion

            #region Sort
            int[] Massiv = new int[] { 45, -32, 12, 3, 56 };
            int[] SortedMassiv = new int[Massiv.Length];

            SortArray sort = new SortArray();
            sort.Sort(Massiv,SortedMassiv);
            #endregion
        }
    }
    public class IndexFind
        {
            public void Find(int[] arr, int n)
            {
                bool exists = false;
                int result = Array.IndexOf(arr, n);

                foreach (var i in arr)
                {
                    if (i == n)
                    {
                        exists = true;
                        break;
                    }
                }

                if (exists)
                {
                    Console.WriteLine($"Axtarilanin indeksi: {result}");
                }
                else
                {
                    Console.WriteLine($"{n} ededi yoxdur!");
                }
            }
        }
    
    public class SortArray {
        public void Sort(int[] Massiv, int[] SortedMassiv)
        {
            
            for (int i = 0; i < Massiv.Length; i++)
            {
                for (int j = i+1; j < Massiv.Length; j++)
                {
                    if (Massiv[j] < Massiv[i])
                    {
                        int temp = Massiv[j];
                        Massiv[j] = Massiv[i];
                        Massiv[i] = temp;
                    }
                }
                SortedMassiv[i] = Massiv[i];
          
            }

            foreach (var item in SortedMassiv)
            {
                Console.Write(item + " ");
            }
        }
    }
}



