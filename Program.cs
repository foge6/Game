int[,] CreatePlay ()
{
int[,] game = new int [3,3];
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        System.Console.Write($"{game[i,j]} ");
    }
    System.Console.WriteLine();
}
return game;
}


int[,] ForPlayer1 (int[,] game)
{
    System.Console.WriteLine("Player 1, write position");
    int x = Convert.ToInt32(Console.ReadLine());
    int y = Convert.ToInt32(Console.ReadLine());
    for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {   
        if (i == x && j == y)
        System.Console.Write($"{game[x,y] = 1} ");
        else
        System.Console.Write($"{game[i,j]} ");
    }
    System.Console.WriteLine();
}
return game;
}

int[,] ForPlayer2 (int[,] game)
{
    System.Console.WriteLine("Player 2, write position");
    int x = Convert.ToInt32(Console.ReadLine());
    int y = Convert.ToInt32(Console.ReadLine());
    for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {   
        if (i == x && j == y)
        System.Console.Write($"{game[x,y] = 2} ");
        else
        System.Console.Write($"{game[i,j]} ");
    }
    System.Console.WriteLine();
}
return game;
}

int[,] ConsoleForPlay (int[,] game)
{
    for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        if( game[i,j] == 0 );
        ForPlayer2(ForPlayer1(game));
    }
}
return game;
}
int[,] massive = CreatePlay();
ConsoleForPlay(massive);

// ForPlayer2(ForPlayer1(CreatePlay()));
