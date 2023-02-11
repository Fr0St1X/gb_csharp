void PrintArray(int[,] matr)
{
for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
            {
                Console.Write($"{matr[i, j]} ");
            }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
            {
                matr[i, j] = new Random().Next(1,10); // [1; 10]
            }
    }
}

int[,] matrix = new int[3, 4];
PrintArray(matrix);
FillArray(matrix);
Console.WriteLine("Рекламное место сдаётся!");
PrintArray(matrix);

//FUCKториал

double Factorial (int n)
{

    //1! = 1
    //0! = 1
    if (n == 1) return 1;
    else return n * Factorial(n-1);
}
for (int i = 1; i < 40; i++)
{
    Console.WriteLine($"{i}! = {Factorial(i)}"); // 1*2*3 = 6
}