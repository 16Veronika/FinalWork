using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите элементы массива через пробел: ");
        string input = Console.ReadLine();
        string[] inputArray = input.Split(' ');
        Console.WriteLine();

        for (int i = 0; i < inputArray.Length; i++)
        {
            Console.Write($"\"{inputArray[i]}\"");
        }

        string[] newArray = new string[inputArray.Length];
        int newIndex = 0;

        for (int i = 0; i < inputArray.Length; i++)
        {
            if (inputArray[i].Length <= 3)
            {
                newArray[newIndex] = inputArray[i];
                newIndex++;
            }
        }

        for (int i = 0; i < newIndex; i++)
        {
            Console.Write($"\"{newArray[i]}\"");
        }
    }
}