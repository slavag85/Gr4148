// Программа принимает трёхзначное число и на выходе выводит последнее число
// Выводим запрос на ввод числа
Console.Write("Введите трёхзначное число:  ");
// Считываем данные с консоли
string? numLine = Console.ReadLine();
// Делаем проверку на вводимое нулевое значение
if(numLine != null)
// Парсим в целочисленное значение
{
    // char[] charArr = numLine.ToCharArray();
    // Console.WriteLine(charArr[charArr.Line-1]);
    int num = int.Parse(numLine);
    int res = num % 10;
    // Выводим сообщение 
    Console.Write("Последняя цифра введёного числа: ");
    Console.Write(res);
}
