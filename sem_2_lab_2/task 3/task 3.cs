using System;
using System.Linq;
using System.Globalization;
using ForAll.task3;
using System.Xml.Linq;

class Program
{
    public static void Main(string[] args)
    {
        Vector vector1 = new Vector(-5, 0, 1, 0, 7, 1, 2, 10);
        Vector vector2 = new Vector(1, 0, 4, -10, 2, 7, 9);

        double sumElementsLessZero = (vector1 < 0) + (vector2 < 0);
        Console.WriteLine($"The sum of the negative elements of two vectors: " + sumElementsLessZero);

        double productElementsWithEvenNumbers = (vector1 % 2) * (vector2 % 2);
        Console.WriteLine("Product of elements of two vectors with even numbers: " + productElementsWithEvenNumbers);

        int sumElementsEqualZero = (vector1 == 0) + (vector2 == 0);
        Console.WriteLine("The number of elements of two vectors equal to 0: " + sumElementsEqualZero);
    }
}

