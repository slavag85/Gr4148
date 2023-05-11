// Задача №9
// Напишите прогрмму, которая выводит случайное число из отрезка[10,99] 
// и показывает наибольшую цифру числа.
System.Random numSintezator =new System.Random();

// Вариант
int rndNum = numSintezator.Next(10,100);
Console.WriteLine(rndNum);


