using System;

class Program
{
    static void Main()
    {
        // 1.
        Random rand = new Random();
        int[] array = new int[10];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = rand.Next(-10, 11);
        }
        Console.WriteLine("Array: " + string.Join(", ", array));
        Console.Write("Elements with even indexes: ");
        for (int i = 0; i < array.Length; i += 2)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();

        // 2.
        int sum = 0;
        foreach (int num in array)
        {
            sum += num;
        }
        Console.WriteLine("Sum of elements: " + sum + " (integer)");

        // 3.
        int[,] multiplicationTable = new int[9, 9];
        for (int i = 0; i < 9; i++)
        {
            for (int j = 0; j < 9; j++)
            {
                multiplicationTable[i, j] = (i + 1) * (j + 1);
                Console.Write(multiplicationTable[i, j].ToString().PadLeft(3) + " ");
            }
            Console.WriteLine();
        }

        // 4.
        int[,] matrix = new int[5, 5];
        int min = int.MaxValue, max = int.MinValue;
        int minRow = 0, minCol = 0, maxRow = 0, maxCol = 0;

        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                matrix[i, j] = rand.Next(-50, 51);
                Console.Write(matrix[i, j].ToString().PadLeft(4) + " ");

                if (matrix[i, j] < min) { min = matrix[i, j]; minRow = i; minCol = j; }
                if (matrix[i, j] > max) { max = matrix[i, j]; maxRow = i; maxCol = j; }
            }
            Console.WriteLine();
        }
        Console.WriteLine($"Maximum element: {max} (coordinates: {maxRow}, {maxCol})");
        Console.WriteLine($"Minimum element: {min} (coordinates: {minRow}, {minCol})");

        // 5.
        Console.Write("Enter number of days: ");
        int days = int.Parse(Console.ReadLine());
        DaysOfWeek resultDay = (DaysOfWeek)(days % 7);
        Console.WriteLine("Through " + days + " there will be days: " + resultDay);
    }

    enum DaysOfWeek { Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday }
}
