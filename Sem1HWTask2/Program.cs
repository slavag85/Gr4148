// Напишите программу,которая принимает на вход два числа и выдаёт какое число больше  
// Пример: а = 5, b = 7->max = 7; a = 2,b =10 -> max = 10.
// Вводим два числа:
String? numLine1 = Console.ReadLine();
String? numLine2 = Console.ReadLine();
// делаем проверку на пустое значение(нулевое).
if ((numLine1 != null) && (numLine2 != null)) 
{


    // Переводим строковое значение в целочисленное(парсим).
    int num1 = int.Parse(numLine1);
    int num2 = int.Parse(numLine2);
    if (num1 < num2) 
    {
        Console.WriteLine(num2);
    }
}
