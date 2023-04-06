using System;
using System.Linq;
using System.Globalization;
using ForAll.task3;
using System.Xml.Linq;

class Program
{
    /*Test case:
     * Case 1:
         * Input:
            Vector vector1 = new Vector(-5, 0, 1, 0, 7, 1, 2, 10);
            Vector vector2 = new Vector(1, 0, 4, -10, 2, 7, 9);
           Output:
            The sum of the negative elements of two vectors: -15
            Product of elements of two vectors with even numbers: -5040
            The number of elements of two vectors equal to 0: 3

        Case 2:
            Input:
                Vector vector1 = new Vector(0, 0, 1, 0, 7, 1, 2, 10);
                Vector vector2 = new Vector(1, 0, 4, -10, 2, 7, 9);
            Output:
                The sum of the negative elements of two vectors: -10
                Product of elements of two vectors with even numbers: 0
                The number of elements of two vectors equal to 0: 4
    */

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

