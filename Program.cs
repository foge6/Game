int[,] table = new int [3,3];

for (int j = 0; j < 3; j++)
{
    for (int i = 0; i < 3; i++)
    {
        System.Console.Write($"{table[j,i]} ");
    }
    System.Console.WriteLine(" ");
}