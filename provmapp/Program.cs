using System;

namespace provmapp
{
    class Program
    {
        static void Main(string[] args)
        {
         SayHi("Max",1);
         SayHi("Peter",4);
         SayHi("John",10);
         int cubed=cube(3);
         Console.WriteLine(cubed);   
        }
        static void SayHi(string name, int age)
        {
         Console.WriteLine("hello " + name+ " you are "+ age);
        }
        static int cube(int num)
        {
          int result = num*num*num;
          return result;
        }
    }
}