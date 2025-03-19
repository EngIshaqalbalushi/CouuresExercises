using System.Security.Cryptography;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Exercises2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Array Initialization & Output
            //int[] numbers = {3,3,4,5,6};

            //for (int i = 0; i < numbers.Length; i++)
            //{

            //    Console.WriteLine(numbers[i]);
            //}
            //------------------------------------------

            //Find Maximum &Minimum in an Array

            //int[] numbers =new int[10];

            //for(int i = 0; i < numbers.Length;i++)

            //{
            //    Console.WriteLine("Enter Number");
            //    int number = int.Parse(Console.ReadLine());

            //    numbers[i] = number;
            //}
            //Array.Sort(numbers);

            //Console.WriteLine(" Number maximum" + numbers[0]);
            //Console.WriteLine(" Number maximum" + numbers[9]);

            //-----------------------------------------------------

            //Count Even &Odd Numbers


            // Console.WriteLine("Enter Array Number");
            // int arryNumber = int.Parse(Console.ReadLine());
            // int resut = 0,resut2=0;
            // int[] numbers = new int[arryNumber];

            //for(int i = 0; i < numbers.Length; i++)
            // {

            //     Console.WriteLine("Enter Number");
            //     int number = int.Parse(Console.ReadLine());

            //     if (number%2==0)
            //     {
            //          resut ++;
            //     }else
            //     {
            //         resut2 ++;
            //     }



            // }
            // Console.WriteLine("even Number" + resut);
            // Console.WriteLine("odd Number" + resut2);

            //____________________________________________________

            // Reverse an Array


            //Console.WriteLine("Enter Array Number");
            //int arryNumber = int.Parse(Console.ReadLine());

            //int[] numbers = new int[arryNumber];

            //for (int i = 0; i < numbers.Length; i++)

            //{
            //    Console.WriteLine("Enter Number");
            //    int number = int.Parse(Console.ReadLine());

            //    numbers[i] = number;
            //}
            //Array.Reverse(numbers);

            //for (int i = 0; i < numbers.Length; i++)
            //{

            //    Console.WriteLine(numbers[i]);
            //}

            //__________________________________________________

            //Search for a Number in an Array


            //Console.WriteLine("Enter Array Number");
            //int arryNumber = int.Parse(Console.ReadLine());

            //int[] numbers = new int[arryNumber];

            //for (int i = 0; i < numbers.Length; i++)

            //{
            //    Console.WriteLine("Enter Number");
            //    int number = int.Parse(Console.ReadLine());

            //    numbers[i] = number;
            //}

            //Console.WriteLine("Enter Serarch Number");
            //int searchNumber = int.Parse(Console.ReadLine());

            //if (searchNumber == numbers[searchNumber])
            //{
            //    Array.IndexOf(numbers, searchNumber);
            //    Console.WriteLine("Enter Serarch Number" + numbers[searchNumber]);

            //}
            //else
            //{
            //    Console.WriteLine("not foud  Number" );

            //}





            //________________________________________

            //Sorting an Array (Ascending Order)

            //Console.WriteLine("Enter Array Number");
            //int arryNumber = int.Parse(Console.ReadLine());

            //int[] numbers = new int[arryNumber];

            //for (int i = 0; i < numbers.Length; i++)

            //{
            //    Console.WriteLine("Enter Number");
            //    int number = int.Parse(Console.ReadLine());

            //    numbers[i] = number;
            //}
            //Array.Sort(numbers);

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(" Array Number");

            //    Console.WriteLine(numbers[i]);
            //}

            //________________________________________________________

            // Merging Two Arrays

            //Console.WriteLine("Enter Array Number");
            //int arryNumber = int.Parse(Console.ReadLine());

            //int[] numbers = new int[arryNumber];

            //for (int i = 0; i < numbers.Length; i++)

            //{
            //    Console.WriteLine("Enter Number");
            //    int number = int.Parse(Console.ReadLine());

            //    numbers[i] = number;
            //}

            //Console.WriteLine("Enter Array 2 Number");
            //int arryNumber1 = int.Parse(Console.ReadLine());

            //int[] numbers1 = new int[arryNumber1];

            //for (int i = 0; i < numbers.Length; i++)

            //{
            //    Console.WriteLine("Enter Number");
            //    int number1 = int.Parse(Console.ReadLine());

            //    numbers1[i] = number1;
            //}



            //int[] numbers2 = numbers.Union(numbers1).ToArray();


            //for (int i = 0; i < numbers2.Length; i++)
            //{
            //    Console.WriteLine(numbers2[i]);
            //}

            //----------------------------------------------------


            //  Remove Duplicates from an Array

            //Console.WriteLine("Enter Array Number");
            //int arryNumber = int.Parse(Console.ReadLine());



            //int[] numbers = new int[arryNumber];

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine("Enter Number");
            //    int number = int.Parse(Console.ReadLine());
            //    numbers[i] = number;
            //}


            //List<int> uniqueNumbers = new List<int>();
            //HashSet<int> seenNumbers = new HashSet<int>();

            //foreach (int num in numbers)
            //{
            //    if (!seenNumbers.Contains(num))
            //    {
            //        uniqueNumbers.Add(num);
            //        seenNumbers.Add(num);
            //    }
            //}

            //int[] uniqueArray = uniqueNumbers.ToArray();


            //Console.WriteLine("Array after removing duplicates:");


            //for (int i = 0; i < uniqueArray.Length; i++)
            //{
            //    Console.WriteLine(uniqueArray[i]);
            //}

            //_________________________________________

            // Second Largest Number in an Array

            //Console.WriteLine("Enter Array size");
            //int arryNumber = int.Parse(Console.ReadLine());



            //int[] numbers = new int[arryNumber];

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (arryNumber > 1)
            //    {
            //        Console.WriteLine("Enter Number");
            //        int number = int.Parse(Console.ReadLine());
            //        numbers[i] = number;
            //    }


            //}

            //Array.Sort(numbers);
            //Array.Reverse(numbers);


            //Console.WriteLine(numbers[1]);


            while (true)
            {
                Console.Clear();
                Console.WriteLine("\nChoose an Array Exercise:");
                Console.WriteLine("1. Array Initialization & Output");
                Console.WriteLine("2. Find Maximum & Minimum in an Array");
                Console.WriteLine("3. Sum & Average of an Array");
                Console.WriteLine("4. Count Even & Odd Numbers");
                Console.WriteLine("5. Reverse an Array");
                Console.WriteLine("6. Search for a Number in an Array");
                Console.WriteLine("7. Sorting an Array (Ascending Order)");
                Console.WriteLine("8. Merging Two Arrays");
                Console.WriteLine("9. Remove Duplicates from an Array");
                Console.WriteLine("10. Find Second Largest Number");
                Console.WriteLine("0. Exit");
                Console.Write("Enter your choice: ");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1: ArrayInitialization(); break;
                    case 2: FindMaxMin(); break;
                    case 3: SumAndAverage(); break;
                    case 4: CountEvenOdd(); break;
                    case 5: ReverseArray(); break;
                    case 6: SearchNumber(); break;
                    case 7: SortArray(); break;
                    case 8: MergeArrays(); break;
                    case 9: RemoveDuplicates(); break;
                    case 10: FindSecondLargest(); break;
                    case 0: return;
                    default: Console.WriteLine("Invalid choice! Try again."); break;
                }

                Console.ReadLine();
            }


        }
        static void ArrayInitialization()
        {
            Array Initialization &Output
            int[] numbers = { 3, 3, 4, 5, 6 };

            for (int i = 0; i < numbers.Length; i++)
            {

                Console.WriteLine(numbers[i]);
            }
        }

        static void FindMaxMin()
        {

            //Find Maximum &Minimum in an Array

            int[] numbers = new int[10];

            for (int i = 0; i < numbers.Length; i++)

            {
                Console.WriteLine("Enter Number");
                int number = int.Parse(Console.ReadLine());

                numbers[i] = number;
            }
            Array.Sort(numbers);

            Console.WriteLine(" Number maximum" + numbers[0]);
            Console.WriteLine(" Number maximum" + numbers[9]);
        }
        static void CountEvenOdd()
        {

            Console.WriteLine("Enter Array Number");
            int arryNumber = int.Parse(Console.ReadLine());
            int resut = 0, resut2 = 0;
            int[] numbers = new int[arryNumber];

            for (int i = 0; i < numbers.Length; i++)
            {

                Console.WriteLine("Enter Number");
                int number = int.Parse(Console.ReadLine());

                if (number % 2 == 0)
                {
                    resut++;
                }
                else
                {
                    resut2++;
                }



            }
            Console.WriteLine("even Number" + resut);
            Console.WriteLine("odd Number" + resut2);


        }
        static void ReverseArray()
        {

            Console.WriteLine("Enter Array Number");
            int arryNumber = int.Parse(Console.ReadLine());

            int[] numbers = new int[arryNumber];

            for (int i = 0; i < numbers.Length; i++)

            {
                Console.WriteLine("Enter Number");
                int number = int.Parse(Console.ReadLine());

                numbers[i] = number;
            }
            Array.Reverse(numbers);

            for (int i = 0; i < numbers.Length; i++)
            {

                Console.WriteLine(numbers[i]);
            }
        }
        static void SearchNumber()
        {
            Console.WriteLine("Enter Array Number");
            int arryNumber = int.Parse(Console.ReadLine());

            int[] numbers = new int[arryNumber];

            for (int i = 0; i < numbers.Length; i++)

            {
                Console.WriteLine("Enter Number");
                int number = int.Parse(Console.ReadLine());

                numbers[i] = number;
            }

            Console.WriteLine("Enter Serarch Number");
            int searchNumber = int.Parse(Console.ReadLine());

            if (searchNumber == numbers[searchNumber])
            {
                Array.IndexOf(numbers, searchNumber);
                Console.WriteLine("Enter Serarch Number" + numbers[searchNumber]);

            }
            else
            {
                Console.WriteLine("not foud  Number");

            }

        }
        static void SortArray()
        {

            Console.WriteLine("Enter Array Number");
            int arryNumber = int.Parse(Console.ReadLine());

            int[] numbers = new int[arryNumber];

            for (int i = 0; i < numbers.Length; i++)

            {
                Console.WriteLine("Enter Number");
                int number = int.Parse(Console.ReadLine());

                numbers[i] = number;
            }
            Array.Sort(numbers);

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(" Array Number");

                Console.WriteLine(numbers[i]);
            }
        }
        static void MergeArrays()
        {
            Console.WriteLine("Enter Array Number");
            int arryNumber = int.Parse(Console.ReadLine());

            int[] numbers = new int[arryNumber];

            for (int i = 0; i < numbers.Length; i++)

            {
                Console.WriteLine("Enter Number");
                int number = int.Parse(Console.ReadLine());

                numbers[i] = number;
            }

            Console.WriteLine("Enter Array 2 Number");
            int arryNumber1 = int.Parse(Console.ReadLine());

            int[] numbers1 = new int[arryNumber1];

            for (int i = 0; i < numbers.Length; i++)

            {
                Console.WriteLine("Enter Number");
                int number1 = int.Parse(Console.ReadLine());

                numbers1[i] = number1;
            }



            int[] numbers2 = numbers.Union(numbers1).ToArray();


            for (int i = 0; i < numbers2.Length; i++)
            {
                Console.WriteLine(numbers2[i]);
            }
        }
        static void RemoveDuplicates()
        {
            Console.WriteLine("Enter Array Number");
            int arryNumber = int.Parse(Console.ReadLine());



            int[] numbers = new int[arryNumber];

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("Enter Number");
                int number = int.Parse(Console.ReadLine());
                numbers[i] = number;
            }


            List<int> uniqueNumbers = new List<int>();
            HashSet<int> seenNumbers = new HashSet<int>();

            foreach (int num in numbers)
            {
                if (!seenNumbers.Contains(num))
                {
                    uniqueNumbers.Add(num);
                    seenNumbers.Add(num);
                }
            }

            int[] uniqueArray = uniqueNumbers.ToArray();


            Console.WriteLine("Array after removing duplicates:");


            for (int i = 0; i < uniqueArray.Length; i++)
            {
                Console.WriteLine(uniqueArray[i]);
            }

        }
        static void FindSecondLargest()
        {
            Console.WriteLine("Enter Array size");
            int arryNumber = int.Parse(Console.ReadLine());



            int[] numbers = new int[arryNumber];

            for (int i = 0; i < numbers.Length; i++)
            {
                if (arryNumber > 1)
                {
                    Console.WriteLine("Enter Number");
                    int number = int.Parse(Console.ReadLine());
                    numbers[i] = number;
                }


            }

            Array.Sort(numbers);
            Array.Reverse(numbers);


            Console.WriteLine(numbers[1]);

        }

    }
}
