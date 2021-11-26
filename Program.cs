using System;

namespace Bubblesort
{
    class Program
    {
        static void Main(string[] args)
        {    
             System.Console.WriteLine($"Array before sort");
            int[] numbers = {21,55,44,11,66};
                //System.Console.WriteLine("----------------");
                System.Console.WriteLine(string.Join(',' , numbers));
            for (int i =0; i < numbers.Length -1; i++){
                for (int j =0; j <  numbers.Length -1-i;j++){
                    if (numbers[j] > numbers[j+1]){
                        int temp = numbers[j];
                        numbers[j] = numbers[j+1];
                        numbers[j+1] = temp;
                    }
                }
            }
             System.Console.WriteLine("Sorted array:");
                    System.Console.WriteLine(string.Join(',',numbers));
        }
    }
}
