internal class Program
{
    private static void Main()
    {
        Console.Write("Enter the value of the M: ");
        int M = int.Parse(Console.ReadLine()!);

        Console.Write("Enter the value of the N: ");
        int N = int.Parse(Console.ReadLine()!);

        int[,] matriz = new int[M, N];

        for (int i = 0; i < M; i++)
        {
            Console.Write($"Enter the values of line {i}: ");
            string[] values = Console.ReadLine()!.Split(' ');

            for (int j = 0; j < N; j++)
            {
                matriz[i, j] = int.Parse(values[j]);
            }
        }

        Console.Write("Enter the values of X: ");
        int X = int.Parse(Console.ReadLine()!);

        for (int i = 0; i < M; i++)
        {
            for (int j = 0; j < N; j++)
            {
                if (matriz[i, j] == X)
                {


                    Console.WriteLine($"Position {i},{j}:");
                    if (i > 0) Console.WriteLine($"Up: {matriz[i - 1, j]}");
                    if (j > 0) Console.WriteLine($"Left: {matriz[i, j - 1]}");
                    if (j < N - 2) Console.WriteLine($"Rigth: {matriz[i, j + 1]}");
                    if (i < M - 2) Console.WriteLine($"Down: {matriz[i + 1, j]}");


                }
            }
        }

    }
}