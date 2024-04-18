using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("How many numbers would you like to enter?");
        int amount = int.Parse(Console.ReadLine());
        int[] collection = new int[amount];
        Random r = new Random();
        int[] numbers = { r.Next(1, 10), r.Next(1, 10), r.Next(1, 10), r.Next(1, 10), r.Next(1, 10), r.Next(1, 10) };
        var numberSubset = numbers[1..4];
        Console.WriteLine($"Total of the numbers array={Add(numbers)}");
        Console.WriteLine($"Total of the subset array={Add(numberSubset)}");
        Console.WriteLine($"Total of 10,20,30,40,50 = {Add(10, 20, 30, 40, 50)}");
        Console.WriteLine($"Total of 10,20,30,40,50 = {Mult(10, 20, 30, 40, 50)}");
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine();
        }
    }
    static int Add(params int[] numbers)
    {
        int total = 0;
        foreach (int number in numbers)
        {
            total += number;
        }
        return total;
    }
    static int Mult(params int[] numbers)
    {
        int total = 1;
        foreach (int number in numbers)
        {
            total *= number;
        }
        return total;
    }
}