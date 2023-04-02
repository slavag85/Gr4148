// Определить являеться первое число квадратом второго
// вводим две перемнные
string? numLine1 = Console.ReadLine();
string? numLine2 = Console.ReadLine();
//сделаем проверку на пустоту не имеет нулевое значения

if ((numLine1!=null) && (numLine2!=null))

//Парсим-переводим значения из строковой в целочисленное значение
{
    int num1 = int.Parse(numLine1);
    int num2 = int.Parse(numLine2);
    if (num1 == num2 * num2)
    // Если правда что первое число квадрат второго,то делаем вывод
    {
        Console.WriteLine("первое число квадрат второго");
    }
    else
    {
        Console.WriteLine("первое число не являеться квадратом вторго");
    }

}