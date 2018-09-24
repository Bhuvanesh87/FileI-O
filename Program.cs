using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   public  class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the program number to execute");
            int i = Convert.ToInt32(Console.ReadLine());

            switch(i)
            {
                case 1:
                          FileIo1 f1 = new FileIo1();
                          f1.Program1();
                          break;
                case 2:
                          FileIo2  f2= new FileIo2();
                          f2.Program2();
                          break;
                case 3:
                          FileIo3  f3= new FileIo3();
                          f3.Program3();
                          break;
                case 4:
                          FileIo4 f4 = new FileIo4();
                          f4.Program4();
                          break;
                case 5:
                          FileIo5 f5 = new FileIo5();
                          f5.Program5();
                          break;
                case 6:
                            FileIo6 f6 = new FileIo6();
                            f6.Program6();
                            break;
                case 7:
                            FileIo7 f7 = new FileIo7();
                            f7.Program7();
                            break;
                case 8:
                            FileIo8 f8 = new FileIo8();
                            f8.Program8();
                            break;
                case 9:
                            FileIo9 f9 = new FileIo9();
                            f9.Program9();
                            break;
                case 10:
                            FileIo10 f10 = new FileIo10();
                            f10.Program10();
                            break;
                case 11:
                            FileIo11 f11 = new FileIo11();
                            f11.Program11();
                            break;
                case 12:
                            FileIo12 f12 = new FileIo12();
                            f12.Program12();
                            break;

                case 13:
                            FileIo13 f13 = new FileIo13();
                            f13.Program13();
                            break;

                case 14:
                            FileIo14 f14 = new FileIo14();
                            f14.Program14();
                            break;



            }







            /* int a, b, c;
         Console.WriteLine("Enter two numbers");
         a = Convert.ToInt32(Console.ReadLine());
         b = Convert.ToInt32(Console.ReadLine());
         if(b == 0)
         {
             Console.WriteLine("Second number should not be zero");
         }
         else
         {
             c=a/b;
             Console.WriteLine("The Quoefficent is " + c);
         }*/

            /* try
             {
                     int a, b, c;
                     Console.WriteLine("Enter two numbers");
                     a = Convert.ToInt32(Console.ReadLine());
                     b = Convert.ToInt32(Console.ReadLine());
                     c =a / b;
                     Console.WriteLine("The Quoefficent is " + c);
              }
             catch
             {
                 Console.WriteLine("The Error occured due to second number should not be zero");
             }
             finally
             {
                 Console.WriteLine("The finally block will be executed");
             }*/

            Console.Read();
        }
    }
}
