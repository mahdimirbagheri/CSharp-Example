using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_1_
{
    class Program
    {
        static void Main(string[] args)
        {
            // My Varible Names
            String Name, Strlinear, StrBi;
            int i = 0, Score, IntFind, Command, Max = 0, Min = 0, Count = 0, Linear, Binery;

            // Make Varibale for Name and Score
            int[] IntScore = new int[4];
            string[] StrName = new string[4];

            // Get Name and Score From User
            while (i < IntScore.Length)
            {
                Console.Write("Enter Name ({0}) : ", i + 1);
                Name = Console.ReadLine();

                Console.Write("Enter Score ({0}) : ", i + 1);
                Score = Convert.ToInt16(Console.ReadLine());

                if (i == 0)
                {
                    StrName[i] = Name;
                    IntScore[i] = Score;
                    i++;
                }

                else
                {
                    IntFind = Array.IndexOf(StrName, Name);
                    if (IntFind == -1)
                    {
                        StrName[i] = Name;
                        IntScore[i] = Score;
                        i++;
                    }
                }

            }
            Console.Clear();
            Console.WriteLine("╔════════════════════════════╦══════════════════════════════╗");
            Console.WriteLine("║ Name                       ║ Score                        ║");
            Console.WriteLine("╚════════════════════════════╩══════════════════════════════╝");
            for (int j = 0; j < IntScore.Length; j++)
            {
                Console.WriteLine("╔════════════════════════════╦══════════════════════════════╗");
                Console.WriteLine("║ {0,-10}                 ║ {1,-10}                   ║", StrName[j], IntScore[j]);
                Console.WriteLine("╚════════════════════════════╩══════════════════════════════╝");
            }
            Console.WriteLine("╔════════════════════════════╦══════════════════════════════╗");
            Console.WriteLine("║ Max (1)                    ║ Min (2)                      ║");
            Console.WriteLine("╚════════════════════════════╩══════════════════════════════╝");
            Console.WriteLine("╔════════════════════════════╦══════════════════════════════╗");
            Console.WriteLine("║ Linear Search (3)          ║ Binery Search (4)            ║");
            Console.WriteLine("╚════════════════════════════╩══════════════════════════════╝");
            Console.WriteLine("╔═══════════════════════════════════════════════════════════╗");
            Console.WriteLine("║ Exit (6)                                                  ║");
            Console.WriteLine("╚═══════════════════════════════════════════════════════════╝");
            Console.Write("Enter Number menu : ");
            Command = Convert.ToInt16(Console.ReadLine());
            switch (Command)
            {
                case 1:
                    Console.Clear();
                    for (int j = 0; j < IntScore.Length; j++)
                    {
                        if (j == 0)
                        {
                            Max = IntScore[j];
                        }
                        else
                        {
                            if (Max < IntScore[j])
                            {
                                Max = IntScore[j];
                                Count = j;
                            }
                        }
                    }
                    Console.WriteLine("╔════════════════════════════╦══════════════════════════════╗");
                    Console.WriteLine("║ {0,-10}                 ║ {1,-10}                   ║", StrName[Count], Max);
                    Console.WriteLine("╚════════════════════════════╩══════════════════════════════╝");
                    break;

                case 2:
                    Console.Clear();
                    for (int j = 0; j < IntScore.Length; j++)
                    {
                        if (j == 0)
                        {
                            Min = IntScore[j];
                        }
                        else
                        {
                            if (Min > IntScore[j])
                            {
                                Min = IntScore[j];
                                Count = j;
                            }
                        }
                    }
                    Console.WriteLine("╔════════════════════════════╦══════════════════════════════╗");
                    Console.WriteLine("║ {0,-10}                 ║ {1,-10}                   ║", StrName[Count], Min);
                    Console.WriteLine("╚════════════════════════════╩══════════════════════════════╝");
                    break;





                case 3:
                    Console.Clear();
                    Console.Write("Enter your Name : ");
                    Strlinear = (Console.ReadLine());
                    Linear = Array.LastIndexOf(StrName, Strlinear);
                    Console.WriteLine("╔════════════════════════════╦══════════════════════════════╗");
                    Console.WriteLine("║ {0,-10}                 ║ {1,-10}                   ║", StrName[Linear], IntScore[Linear]);
                    Console.WriteLine("╚════════════════════════════╩══════════════════════════════╝");
                    break;


                    //Binery Search


                    /*

                    using System;
                        namespace BinarySearchExample
                            {
                                class Program
                                {
                                    static void Main(string[] args)
                                    {
                                        int[] arr = { 2, 3, 4, 10, 40 };
                                        int x = 10;

                                        int result = BinarySearch(arr, 0, arr.Length - 1, x);

                                        if (result == -1)
                                            Console.WriteLine("Element is not present in array");
                                        else
                                            Console.WriteLine("Element is present at index " + result);
                                    }

                                    static int BinarySearch(int[] arr, int low, int high, int x)
                                    {
                                        if (high >= low)
                                        {
                                            int mid = low + (high - low) / 2; // Prevent integer overflow

                                            // If found at mid, then return mid
                                            if (arr[mid] == x)
                                                return mid;

                                            // Search the left half
                                            if (arr[mid] > x)
                                                return BinarySearch(arr, low, mid - 1, x);

                                            // Search the right half
                                            return BinarySearch(arr, mid + 1, high, x);
                                        }

                                        // Not found
                                        return -1;
                                    }
                                }
                            }

                            */

                case 4:
                    Console.Clear();
                    Console.Write("Enter your Name : ");
                    StrBi = (Console.ReadLine());
                    Binery = Array.BinarySearch(StrName, StrBi);
                    Console.WriteLine("╔════════════════════════════╦══════════════════════════════╗");
                    Console.WriteLine("║ {0,-10}                 ║ {1,-10}                   ║", StrName[Binery], IntScore[Binery]);
                    Console.WriteLine("╚════════════════════════════╩══════════════════════════════╝");
                    break;


                    // Liner Search


                    /*

                    using System;
                        namespace LinearSearchExample
                            {
                                class Program
                                {
                                    static void Main(string[] args)
                                    {
                                        int[] arr = { 2, 3, 4, 10, 40 };
                                        int x = 10;

                                        int result = LinearSearch(arr, x);

                                        if (result == -1)
                                            Console.WriteLine("Element is not present in array");
                                        else
                                            Console.WriteLine("Element is present at index " + result);
                                    }

                                    static int LinearSearch(int[] arr, int x)
                                    {
                                        int n = arr.Length;

                                        for (int i = 0; i < n; i++)
                                        {
                                            if (arr[i] == x)
                                                return i;
                                        }

                                        // If not found
                                        return -1;
                                    }
                                }
                            }
                            */


                default:
                    Environment.Exit(6);
                    break;
            }
            Console.ReadKey();
        }
    }
}
