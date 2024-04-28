namespace Masiv1
{
    internal class Program
    {
        static void Main(string[] args)
        {
          int rows = int.Parse(Console.ReadLine());
          int cols = int.Parse(Console.ReadLine());
            int[,] matrix = new int[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix[rows,cols] = int.Parse(Console.ReadLine());
                }
            }
            for (int row = 0 ;row < row; row++)
            {
                for (int col = 0; col < col; col++)
                {
                    Console.WriteLine(matrix[row,col]+" ");
                }
            }
            Console.WriteLine();
        }
    }
}
