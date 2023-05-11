// Задача №39
// Напишите программу, которая перевернёт одномерный  массив
// (послений элемент будет на первом месте,а первый - на последнем и т.д.)

// Вводим метод генерации
int[] Gen1DArr(int len, int top, int but)
{
    int[] res = new int[len];
    for (int i = 0; i < len; i++)
    {
        res[i] = new Random().Next(but, top + 1);
    }
    return res;

}
// Берём метод печати.
void Print1DArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ",");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");

}
// Метод разворота массива
void SwapArray(int[] arr)
{
    int buf = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        // (arr[i], arr[arr.Length-1-i]) = (arr[arr.Length-1-i], arr[i]); - метод дла разворота массива
        buf = arr[i];
        arr[i] = arr[arr.Length - 1 - i];
        arr[arr.Length - 1 - i] = buf;
    }

}
int[] SwapNewArray(int[] arr);


