public class MatrixOperations
{
    public static void SwapMinMax(int[,] matrix)
    {
        int min = matrix[0, 0];
        int max = matrix[0, 0];
        int minRow = 0;
        int minColumn = 0;
        int maxRow = 0;
        int maxColumn = 0;

        int rowCount = matrix.GetLength(0);
        int columnCount = matrix.GetLength(1);
        for (int i = 0; i < rowCount; i++)
        {
            for (int j = 0; j < columnCount; j++)
            {
                if (matrix[i, j] < min)
                {
                    min = matrix[i, j];
                    minRow = i;
                    minColumn = j;
                }
                if (matrix[i, j] > max)
                {
                    max = matrix[i, j];
                    maxRow = i;
                    maxColumn = j;
                }
            }
        }
        int temp = matrix[minRow, minColumn];
        matrix[minRow, minColumn] = matrix[maxRow, maxColumn];
        matrix[maxRow, maxColumn] = temp;
    }
    public static void Main()
    {
        int n = 6;
        int m = 5;

        int[,] matrix = new int[n, m];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write("Введите элемент [{0}, {1}]: ", i, j);
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }
        Console.WriteLine("Исходная матрица:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
        SwapMinMax(matrix);
        Console.WriteLine("Матрица после замены минимального и максимального элементов:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}