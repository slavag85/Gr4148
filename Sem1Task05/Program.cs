//Программу которая на вход принимает одно число(N),а на выходе показывает все целые числа от -N до N
// Запрашиваем ввод числа
Console.Write("Введите число: ");
// Вводим переменную
string? number = Console.ReadLine();
// Проверяем на пустоту
if(number != null)
// Парсим в целочисленное значение
{
    int endNum = int.Parse(number);
    int startNum = endNum * -1;
    string res = string.Empty;
// Записываем цикл
while (startNum<=endNum)

{
res = res + startNum + " ";
startNum = startNum + 1;
// startNum ++;

}
Console.WriteLine(res);
} 
