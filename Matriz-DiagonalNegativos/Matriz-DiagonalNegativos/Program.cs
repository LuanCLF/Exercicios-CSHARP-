internal class Program
{
    private static void Main()
    {
        Console.Write("Enthe the value of  the array: ");
        int N = int.Parse(Console.ReadLine()!);
        int[,] matriz = new int[N, N];
        string mainDiagonal = "";
        int negativeNumbers = 0;


        for (int i = 0; i < N; i++)
        {
            Console.Write($"Coloque os valores para a linha {i}: ");
            string[] values = Console.ReadLine()!.Split(" ");
            for (int j = 0; j < N; j++)
            {
                int value = int.Parse(values[j]);
                matriz[i, j] = value;

                if (i == j) mainDiagonal += $"{value} ";

                if (value < 0) negativeNumbers++;
            }

        }

        Console.WriteLine("Main diagonal: ");
        Console.WriteLine(mainDiagonal);
        Console.WriteLine($"Negative numbers = {negativeNumbers}");
    }
}