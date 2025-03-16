using Microsoft.VisualBasic;
using System;

namespace Exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // check for even and odd numbers
            //int number;


            //Console.WriteLine("Enter a number  ");

            //number =int.Parse (Console.ReadLine());

            //if(number/2== 0)
            //{
            //    Console.WriteLine(" The number is Even "+number);
            //}
            //else
            //{
            //    Console.WriteLine(" The number is odd " + number);

            //}
            //_______________________________________________________

            //2. Largest of Three Numbers


            //int number1, number2, number3;

            //Console.WriteLine("Enter a number one  ");
            //number1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter a number two  ");
            //number2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter a number three  ");
            //number3 = int.Parse(Console.ReadLine());

            //if ( number1>number2 && number1>number3)
            //{
            //    Console.WriteLine(" a number one is largest   " +number1);

            //}else if(number2>number1 && number2>number2)
            //{
            //    Console.WriteLine(" a number tow is largest   " + number2);

            //}
            //else
            //{
            //    Console.WriteLine(" a number three is largest   " + number3);

            //}

            //-------------------------------------------------

            // Temperature Converter

            //double Celsius;
            //double result;
            //Console.WriteLine("Enter Celsius number  ");
            //Celsius = double.Parse(Console.ReadLine());

            //result = (Celsius *9/ 5) + 32;

            //Console.WriteLine(" Temperature in Faherenheit is  "+result);
            //______________________________________________________________________


            // Simple Discount Calculator

            //double Price;
            //Console.WriteLine("Enter Celsius number  ");
            //Price = double.Parse(Console.ReadLine());

            //double resut;
            //double PriceAfterDiscount;
            //if(Price> 100)
            //{
            //    resut = (Price * 10 / 100);
            //    PriceAfterDiscount = Price - resut;
            //    Console.WriteLine("The price after discount " +PriceAfterDiscount);

            //}
            //else
            //{
            //    Console.WriteLine("The price = " + Price);

            //}

            //_____________________________________________________________


            //Grading System

            //double score;
            //Console.WriteLine("Enter Student score  ");
            //score = double.Parse(Console.ReadLine());

            //if (score>=90 && score<=100)
            //{
            //    Console.WriteLine("Student score A  ");

            //} else if (score >= 80 && score < 89)
            //{
            //    Console.WriteLine("Student score B  ");

            //}
            //else if (score >= 70 && score < 79)
            //{
            //    Console.WriteLine("Student score C  ");

            //}
            //else if (score >= 60 && score < 69)
            //{
            //    Console.WriteLine("Student score D ");

            //}
            //else if ( score < 60)
            //{
            //    Console.WriteLine("Student score F  ");

            //}
            //else 
            //{
            //    Console.WriteLine("Student score not be largest than 100   ");

            //}

            //____________________________________________________________


            //Swap Two Numbers
            //double number1, number2, number3;

            //Console.WriteLine("Enter number 1 ");
            //number1 = double.Parse(Console.ReadLine());
            //Console.WriteLine("Enter number 2  ");
            //number2 = double.Parse(Console.ReadLine());

            //number3 = number1;
            //number1 = number2;
            //number2 = number3;


            //Console.WriteLine("Enter number one "+number1);
            //Console.WriteLine("Enter number two "+number2);

            //__________________________________________________

            // Days to Weeks and Days Converter

            //double number1;
            //int week = 7;
            //double resut;
            //double remainingDay;

            //Console.WriteLine("Enter number  ");
            //number1 = double.Parse(Console.ReadLine());

            //resut = number1 / week;

            //remainingDay= number1 % week;
            //Console.WriteLine("Weeks   "+resut+"  Days "+remainingDay);

            //________________________________________________________

            //. Electricity Bill Calculator

            //double unit ,reust;

            //Console.WriteLine("Enter number of unit ");
            //unit = double.Parse(Console.ReadLine());

            //if (unit>300)
            //{

            //    Console.WriteLine(" number of unit "+unit);

            //}
            //else if(unit<300)
            //{
            //    reust = unit * 0.75;
            //    Console.WriteLine(" number of unit "+ reust);

            //}
            //else
            //{
            //    reust = unit * 0.5;

            //    Console.WriteLine(" number of unit "+reust);

            //}







            //_____________________________________

            //Simple Calculator
            //double number1, number2, resut;
            //string opration;

            //Console.WriteLine("Enter number 1 ");
            //number1 = double.Parse(Console.ReadLine());
            //Console.WriteLine("Enter number 2 ");
            //number2 = double.Parse(Console.ReadLine());

            //Console.WriteLine("Enter your operator(+, -, /, *, %)");
            //opration = (Console.ReadLine());


            //if (opration == "-")
            //{
            //    resut = number1 - number2;

            //    Console.WriteLine("resut " + resut);

            //}
            //else if (opration == "+")
            //{
            //    resut = number1 + number2;
            //    Console.WriteLine("resut " + resut);

            //}
            //else if (opration == "/")
            //{
            //    resut = number1 / number2;
            //    Console.WriteLine("resut " + resut);

            //}
            //else if (opration == "*")
            //{
            //    resut = number1 * number2;
            //    Console.WriteLine("resut " + resut);
            //}
            //else
            //{
            //    Console.WriteLine(" not fond resut");

            //}
            //____________________________________________________________
            // Simple Calculator (Switch-Case)


            //double number1, number2, resut ;
            //string opration;
            //Console.WriteLine("Enter number 1 ");
            //number1 = double.Parse(Console.ReadLine());
            //Console.WriteLine("Enter number 2 ");
            //number2 = double.Parse(Console.ReadLine());

            //Console.WriteLine("Enter your operator(+, -, /, *, %)");
            //opration = (Console.ReadLine());

            //switch (opration)
            //{
            //    case "+":
            //        resut = number1 + number2;
            //        Console.WriteLine(resut);
            //            break;
            //    case "-":
            //        resut = number1 - number2;
            //        Console.WriteLine(resut);

            //        break;
            //    case "*":
            //        resut = number1 * number2;
            //        Console.WriteLine(resut);

            //        break;
            //    case "/":
            //        resut = number1 / number2;
            //        Console.WriteLine(resut);

            //        break;
            //}

            //___________________________________________________________________

            //Basic ATM System

            //double Balance = 1000;

            //int number = 0;
            //double WithdrawMoney = 0;
            //double NewBalance = 0;

            //do
            //{
            //    Console.WriteLine("Selected Operation ");
            //    Console.WriteLine("1-Withdraw Money ");
            //    Console.WriteLine("2-Deposit Money ");
            //    Console.WriteLine("3-Ckeck Bnlance");
            //    Console.WriteLine("4-Exit ");
            //    number = int.Parse(Console.ReadLine());

            //    switch (number)
            //    {
            //        case 1:
            //            if (Balance != 0)
            //            {
            //                Console.WriteLine("Balance = "+Balance);
            //                Console.WriteLine("Add Withdraw Money  ");


            //                WithdrawMoney = double.Parse(Console.ReadLine());

            //            Console.WriteLine(" New Bnlance = " + (Balance-WithdrawMoney));
            //            }

            //            break;
            //        case 2:



            //                Console.WriteLine("Balance = " + Balance);
            //                Console.WriteLine("Add Deposit  Money  ");


            //                WithdrawMoney = double.Parse(Console.ReadLine());

            //                Console.WriteLine(" New Bnlance = " + (Balance + WithdrawMoney));



            //            break;
            //        case 3:

            //            Console.WriteLine( " Balance"+Balance);

            //            break;
            //        case 4:

            //            Console.WriteLine("GG"  );
            //            number = 4;
            //            break;
            //    }


            //} while (number == 4);

            //__________________________________________________________________________

            //Geometry Calculator

            //double area;
            //double redius;
            //double Circumference ,sdie, Perimeter;
            //int number;
            //double Height,Base;

            //do
            //{
            //    Console.WriteLine("Selecte Shape ");
            //    Console.WriteLine("1-Circle ");
            //    Console.WriteLine("2-Square");
            //    Console.WriteLine("3- Tringle");
            //    Console.WriteLine("4-Exit ");
            //    number = int.Parse(Console.ReadLine());

            //    switch (number)
            //    {
            //        case 1:
            //            Console.WriteLine(" Circle ");
            //            Console.WriteLine("Enter Radius  ");
            //            redius = double.Parse(Console.ReadLine());

            //            area = 3.14 * redius * redius;
            //            Circumference = 2 * 3.14 * redius;
            //            Console.WriteLine("Circle Area = "+area);
            //            Console.WriteLine("Circle Ciercumference = " + Circumference);

            //            break;
            //        case 2:
            //            Console.WriteLine(" Square  ");
            //            Console.WriteLine("Enter sdie  ");
            //            sdie = double.Parse(Console.ReadLine());

            //            area =Math.Pow(sdie,2) ;
            //            Perimeter = 4 * sdie;
            //            Console.WriteLine("Square Area  " +area);
            //            Console.WriteLine("Square  Perimeter  " + Perimeter);


            //            break;
            //        case 3:

            //            Console.WriteLine(" Triangle   ");
            //            Console.WriteLine("Height sdie  ");
            //            Height = double.Parse(Console.ReadLine());

            //            Console.WriteLine("Base sdie  ");
            //            Base = double.Parse(Console.ReadLine());

            //            area = 1 / 2 * (Base * Height);
            //            Console.WriteLine(" Triangle Area =   "+area);


            //            break;
            //        case 4:

            //            Console.WriteLine("GG");
            //            number = 4;
            //            break;
            //    }


            //} while (number == 4);

            //___________________________________________________

            //Factorial of a Number 


            double number ,resut;
            Console.WriteLine("Enter Factorial  number  ");
           number = double.Parse(Console.ReadLine());

            resut = number * (number + 2);
            Console.WriteLine("Enter Factorial  number  "+resut);




        }
    }
}
