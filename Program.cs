/* Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16


 
using System;
 class MainClass {
  public static double a(double baseNum, int exp) {
    double result = 1;
    for(int i = 0; i < exp; i++)
    {
        result *= baseNum;
    }
    return result;
  }
 
  public static void Main (string[] args) {
    double baseNum;
    int exp;
    Console.Write("Enter the base number: ");
    baseNum = Convert.ToDouble(Console.ReadLine());
    Console.Write("Enter the exponent: ");
    exp = Convert.ToInt32(Console.ReadLine());
    double result = a(baseNum, exp);
    Console.WriteLine("Answer: " + result);
  }
}


Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12


int SumOfDigit(int num)
{
    int sum = 0;
     while(num !=0)
     {
        sum += num % 10;
        num = num /10; 
      
     }

     return sum;

}
Console.Write("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());
int sum = SumOfDigit(num);
Console.WriteLine("Sum of Digits in the number is:"  + sum);



Напишите программу, которая задаёт массив из m элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]





  int[] CreateArray(int size) 
  {
    int[] array = new int[size];
    for(int i = 0; i< size; i++)
        array[i] = Convert.ToInt32(Console.ReadLine());
    return array;
  }
  
  void ShowArray( int[] array) 
  {
    for(int i = 0; i < array.Length; i++)
       Console.Write(array[i] + " ");
    Console.WriteLine();
  }
  
    Console.Write("Input a length of array: ");
    int length = Convert.ToInt32(Console.ReadLine());
    int[] newArray = CreateArray(length);
    ShowArray(newArray);
  
*/