// User write N number. Transfer it to 2 system.

// void Transfer (int number)
// {
//     string result = String.Empty;
//     while (number !=0)
//     {
//         result = number % 2 + result;
//         number = number / 2;
//     }
//     System.Console.WriteLine(result);
// }


// void Find (int numb)
// {
//     string stroke = String.Empty;
//     while (numb >0  )
//     {
//         stroke = numb %2 + stroke;
//         numb = numb/2;
//     }
// }


// 45%2 = 1
// 45/2 = 22
// 22%2 = 0
// 22/2 = 11
// ...

int[] TryToMassive ( int number)
{
    int size = 0;
    int findSize = number;
    while ( findSize > 0)
    {
        findSize = findSize /2;
        size++;
    }
    System.Console.WriteLine(size);
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[size - i - 1] = number %2;
        number = number /2;
    }
    return array;
}
void PrintArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");
    }
}
PrintArray(TryToMassive(45));