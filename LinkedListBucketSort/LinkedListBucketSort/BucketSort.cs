using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListBucketSort
{
    class BucketSort
    {
        public int[] Sort(int[] array)
        {
            LinkedList<LinkedList<int>> buckets = new LinkedList<LinkedList<int>>();
            LinkedList<int> zeros = new LinkedList<int>();
            LinkedList<int> ones = new LinkedList<int>();
            LinkedList<int> twos = new LinkedList<int>();
            LinkedList<int> threes = new LinkedList<int>();
            LinkedList<int> fours = new LinkedList<int>();
            LinkedList<int> fives = new LinkedList<int>();
            LinkedList<int> sixes = new LinkedList<int>();
            LinkedList<int> sevens = new LinkedList<int>();
            LinkedList<int> eights = new LinkedList<int>();
            LinkedList<int> nines = new LinkedList<int>();
            buckets.AddLast(zeros);
            buckets.AddLast(ones);
            buckets.AddLast(twos);
            buckets.AddLast(threes);
            buckets.AddLast(fours);
            buckets.AddLast(fives);
            buckets.AddLast(sixes);
            buckets.AddLast(sevens);
            buckets.AddLast(eights);
            buckets.AddLast(nines);

            
            
            for (int i = 1; i <= 100; i*=10)
            {
                for (int e = 0; e < array.Length; e++)
                {
                    if ((array[e] / i % 10) == 0)
                    {
                        zeros.AddLast(array[e]);
                    }
                    else if ((array[e] / i % 10) == 1)
                    {
                        ones.AddLast(array[e]);
                    }
                    else if ((array[e] / i % 10) == 2)
                    {
                        twos.AddLast(array[e]);
                    }
                    else if ((array[e] / i % 10) == 3)
                    {
                        threes.AddLast(array[e]);
                    }
                    else if ((array[e] / i % 10) == 4)
                    {
                        fours.AddLast(array[e]);
                    }
                    else if ((array[e] / i % 10) == 5)
                    {
                        fives.AddLast(array[e]);
                    }
                    else if ((array[e] / i % 10) == 6)
                    {
                        sixes.AddLast(array[e]);
                    }
                    else if ((array[e] / i % 10) == 7)
                    {
                        sevens.AddLast(array[e]);
                    }
                    else if ((array[e] / i % 10) == 8)
                    {
                        eights.AddLast(array[e]);
                    }
                    else if ((array[e] / i % 10) == 9)
                    {
                        nines.AddLast(array[e]);
                    }

                }
                
                int[] newArray = new int[array.Length];
                int t = 0;
                foreach (var list in buckets)
                {
                    foreach (var num in list)
                    {
                        newArray[t] = num;
                        t += 1;
                    }
                }
                array = newArray;

                zeros.Clear();
                ones.Clear();
                twos.Clear();
                threes.Clear();
                fours.Clear();
                fives.Clear();
                sixes.Clear();
                sevens.Clear();
                eights.Clear();
                nines.Clear();

            }
            return array;
        }

        static void Main()
        {
            Random random = new Random();

            int[] array = new int[10];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(0, 999);
            }

            Console.Write("These are the unsorted random numbers: ");
            foreach (int i in array)
            {
                Console.Write(i + " ");
            }

            Console.Write("\n\nThese are the random numbers after being sorted: ");
            BucketSort arraySort = new BucketSort();
            int[] newArray = arraySort.Sort(array);

            foreach (int i in newArray)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("\n");

        }
    }
}
