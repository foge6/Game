int[,] CreateMassiveForPlay ()
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
void Gameplay (int[,] game)
{
    for (int i = 0; i < 4; i++)
{
    if(FindWinner(ForPlayer2(ForPlayer1(game)))==1 || FindWinner(ForPlayer2(ForPlayer1(game)))==2)
    {
        break;
    }
    
}
System.Console.WriteLine("If no one won - Draw!");
}
int FindWinner (int [,] array)
{
int ret = 0;
if 
(
(array[0,0] == 1 &&
array[0,1] == 1 &&
array[0,2] == 1) ||
(array[1,0] == 1 &&
array[1,1] == 1 &&
array[1,2] == 1) ||
(array[2,0] == 1 &&
array[2,1] == 1 &&
array[2,2] == 1) ||
(array[0,0] == 1 &&
array[1,1] == 1 &&
array[2,2] == 1) ||
(array[0,2] == 1 &&
array[1,1] == 1 &&
array[2,0] == 1)
)
{
    System.Console.WriteLine("Player 1 - Winner");
    ret = 1;
}
else if (
(array[0,0] == 2 &&
array[0,1] == 2 &&
array[0,2] == 2) ||
(array[1,0] == 2 &&
array[1,1] == 2 &&
array[1,2] == 2) ||
(array[2,0] == 2 &&
array[2,1] == 2 &&
array[2,2] == 2) ||
(array[0,0] == 2 &&
array[1,1] == 2 &&
array[2,2] == 2) ||
(array[0,2] == 2 &&
array[1,1] == 2 &&
array[2,0] == 2)
)
{
    System.Console.WriteLine("Player 2 -Winner");
    ret = 2;
}    
return ret;
}
int[,] massive = CreateMassiveForPlay();
Gameplay(massive);