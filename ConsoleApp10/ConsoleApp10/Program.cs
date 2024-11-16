using System;

class SpiralMatrix
{
    static void Main()
    {
        int n = 7; // Matritsa o'lchami (7x7)
        int[,] matrix = new int[n, n]; // 2D massiv
        int currentNumber = 1; // Boshlang'ich son

        // Boshlang'ich chegaralar
        int topRow = 0;        // Yuqoridan boshlangan qator
        int bottomRow = n - 1; // Pastdan boshlangan qator
        int leftCol = 0;       // Chapdan boshlangan ustun
        int rightCol = n - 1;  // O'ngdan boshlangan ustun

        // Spiral shaklda matritsani to'ldirish
        while (currentNumber <= n * n)
        {
            // 1. Yuqoridan chapdan o'ngga
            for (int col = leftCol; col <= rightCol; col++)
                matrix[topRow, col] = currentNumber++;
            topRow++; // Yuqori chegarani bir qatorga pastga tushirish

            // 2. O'ngdan yuqoridan pastga
            for (int row = topRow; row <= bottomRow; row++)
                matrix[row, rightCol] = currentNumber++;
            rightCol--; // O'ng chegarani bir ustunga chapga surish

            // 3. Pastdan o'ngdan chapga
            for (int col = rightCol; col >= leftCol; col--)
                matrix[bottomRow, col] = currentNumber++;
            bottomRow--; // Pastki chegarani bir qator yuqoriga ko'tarish

            // 4. Chapdan pastdan yuqoriga
            for (int row = bottomRow; row >= topRow; row--)
                matrix[row, leftCol] = currentNumber++;
            leftCol++; // Chap chegarani bir ustunga o'ngga surish
        }

        // Matritsani konsolda chiqarish
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
                Console.Write(matrix[i, j].ToString("D2") + " ");
            Console.WriteLine();
        }
        Console.ReadKey();
    }
}
