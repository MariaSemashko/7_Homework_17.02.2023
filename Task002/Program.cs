/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/
int GetNumber(string message)
{
    int result = 0;

    while(true)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result) && result > 0)
        {
            break;
        }
        else
        {
            Console.WriteLine("Вы ввели не корректное число. Повторите ввод");
        }
    }

    return result;
}

int[,] InitMatrix(int m, int n)
{
    int[,] array = new int[m, n];
    
    Random rnd = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = rnd.Next(1,10);
        }
    }

    return array;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]} ");
        }

        Console.WriteLine();
    }
}

void FindElement(int[,] matrix, int row, int col)
{
    if (row <= matrix.GetLength(0) && col <= matrix.GetLength(1))
    {
        Console.WriteLine($"Значение элемента на позиции ({row}, {col}) равно {matrix[row-1, col-1]}");  
    }
   
    else Console.WriteLine("Такой позиции элемента не существует");

}


int[,] matrix = InitMatrix(3, 4);
PrintMatrix(matrix);
int row = GetNumber("Введите номер строки искомомго элемента: ");
int col = GetNumber("Введите номер столбца искомого элемента: ");
FindElement(matrix, row, col);