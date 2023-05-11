// Задайте значение N.Напишите программу,которая выведет все натуральные числа в промежутке от 1 до N.
// Выполнить с помощью рекурсии.

Console.Clear();
// Чтение данных из консоли
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// метод рекурсии
// void LineGenRec(int numN)  //Печатает ччисло N 
// {
//     Console.Write(numN -" ");   //точка отановки
//     if (numN>= 1) ;
//     {

//     }
    
//         else
//     {
//         LineGenRec(numN + 1); // изменения при вызове
//     }


// }
// int num = ReadData("Введите число: ");
// LineGenRec(num);

void LineGenRec(int numN)
{
    Console.Write(numN -" ");
    if(numN=>1)
    {

    }
    else
    {
LineGenRec(numN+1);
    }
}
int num = ReadData("Введите число N: ");
LineGenRec(num);
