// Задача №46
//  Задайте двухмерный массив размером m*n, заполненный случайными целыми числами.

int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;

}

// Метод, генерации 2-х мерного массива
int[,] Gen2DArray(int countRow, int countColumn, int minValue, int maxValue)
{
    int[,] arr = new int[countRow, countColumn];
    for (int i = 0; i < arr.Length; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            arr[i,j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return arr;
}
// Массив для печати
void Priny2DArray(int[,] arr)
{
    for (int i = 0;i < arr.GetLength(0); i++)  //GetLength - позволяет подсчитать сколько строк
    {
        for (int j = 0; j <arr.GetLength(0); j++)
        {
            Console.WriteLine(arr[i,j]+" ");
        }

    }
}

int row = ReadData("Введите колличество строк: ");
int col = ReadData("Введите колличество столбцов: ");
int[,] arr2D = Gen2DArray(row,col,10,99);
Priny2DArray(arr2D);