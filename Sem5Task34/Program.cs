//Метод, генерирующий массив
int[] GenArray(int len, int minValue, int maxValue)
{
    int[] arr = new int[len];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(minValue, maxValue + 1);
    }
    return arr;
}
// Метод, выводящий на печать данные пользователю
void Print1DArr(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ",");
    }
    Console.WriteLine(arr[arr.Length - 1] + "[");
}
// метод решения задачи 34 наивный
int VariantNaive(int[] inputArray)

{
    // Переменная накопления результата
    int result = 0;
    //буферная переменная
    int i = 0;
    // пробегаем все элементы массива
    while (i < inpueArray.Length - 1)
    {
        // сверяем элемент массива
        if (inputArray[i] % 2 == 0)
        {
            // подсчитываем результат
            result++;
        }
        // увеличиваем инкремент
        i++;
    }
    // выводим результат
    return result;
}
// Сортировка методом пузырька
void BubbleSort(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        for (int j = 0; j < array.Lendth - i - 1; j++)
        {
            if (array[j] > array[j + 1])
            {
                int buf = array[j];
                array[j] = array[j + 1];
                array[j + 1] = buf;
            }
        }
}
// Сортировка методом подсчёта
void CountingSort(int[] arr, int min, int max)
{
    int max = arr.Max();
    int min = arr.Min();
    // Создаётся часстотный словарь
    int[] count = new int[max - min + 1];
    int z = 0;
    // Заполняем частотный словарь  

    for (int i = 0; i < arr.Length; i++)
    {
        count[arr[i] - min]++;
    }

    for (int i = min; i <= max; i++)
    {
        while (count[i - min]-- > 0)
        {
            arr[z] = i;
            z++;
        }
    }
}
int[] testArray = GenArray(123, 100, 900);
Print1DArr(testArray);
CountingSort(testArray);
Print1DArr(testArray);
// int result = VariantNaive(testArray);
// PrintData(result.ToString());
