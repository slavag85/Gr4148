// Задайте значение N.Написать Программу ,которая выдаёт все натуральные числа в промежутке от N до 1.
// Выполнить при пощи рекурсии

// Чтение данных из консоли
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

void LineGenRec(int numN)
{
    Console.Write(numN + " ");
    if (numN <= 1)
    {

    }
    else
    {
        LineGenRec(numN - 1);
    }
}
int num = ReadData("Введите число N: ");
LineGenRec(num);
