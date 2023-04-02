// // Напишите программу,которая будет выдовать название дня недели по заданному номеру.
// // Вводим сообщение для пользователя
// Console.WriteLine("Введите день недели");

// // Задаём строковую переменную
// String? dayLine = Console.ReadLine();

// // Делаем проверку для определения пустоту
// if (dayLine != null)
// {

//     String[] dayWeek = new string[7];
//     dayWeek[0] = "понедельник";
//     dayWeek[1] = "вторник";
//     dayWeek[2] = "среда";
//     dayWeek[3] = "четверг";
//     dayWeek[4] = "пятница";
//     dayWeek[5] = "суббота";
//     dayWeek[6] = "воскресенье";

//     // Парсим стровоую переменную в целочисленную

//     int day = int.Parse(dayLine);
//     // Выводим день недели,минус единица для правильнонго счёта
//     // сделаем проверку на правельности вводимых чисел
//     if ((0 < day) && (day < 8))
//     {
//         Console.WriteLine(dayWeek[day - 1]);
//     }
//     // Выводим сообщение пользователю
//     else Console.WriteLine("Введите другое число");

// }

// Считываем данные с консоли
string? inputLine = Console.ReadLine();
// Провериям, чтобы данные небыли пустыми
if(inputLine != null)
{
    // Парсим в целочисленное значение
    int inpuntNumber = int.Parse(inputLine);
    string outDayOfWeek = System.Globalization.CultureInfo.GetCultureInfo("ru-RU").DateTimeFormat.GetDayName((DayOfWeek)Enum.GetValues(typeof(DayOfWeek)).GetValue ());
    // Выводим результат в консоль
    Console.WriteLine(outDayOfWeek);
    
}

