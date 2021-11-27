using System;

namespace Armstrong
{
    class Program
    {
        static void Main(string[] args)
        {
        System.Console.Write("Enter your input: ");
        int number = Convert.ToInt32(Console.ReadLine());
        int num = number;
        int AfterCubeValue = 0;
        while(number > 0){
            int remainder = number % 10;
            number /= 10;
            AfterCubeValue = AfterCubeValue + remainder*remainder*remainder;

        }
         if(num == AfterCubeValue) {
        System.Console.WriteLine($"{num} is an armstrong number. ");
         }
         else{
             System.Console.WriteLine($"{num} is not an armstrong number.");
         }
        }
    }
}
