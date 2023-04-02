// Программа принимает на вход число и выдает его квдрат.
// Считываем данные с консоли
string? inLine = Console.ReadLine();

//Делаем проверку на пустые данные
if (inLine != null)
// Парсим-преобразуем строковое значение в целочисленное
{
    int inNumber = int.Parse(inLine);

    // введём новую переменную в которую положем уже квадрат
    int outNumber = inNumber * inNumber;
    int outStrtPow = (int)Math.Pow(inNumber, 2);

    //Выводим данные в консоль

    Console.WriteLine(outNumber);

    Console.WriteLine(outStrtPow);

}





