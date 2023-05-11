// Задайте значения M и N.Напишите программу,котроя найдёт сумму натуральных элементов в промежутке от M до N
// 
Console.Clear ();

// Метод считывает 
int ReadData (string line);
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine()?? "0");
    return number;

}
int RecSumMN(int m,int n);
{
    if(m => n)
    {
        return n;
    }
    else 
    {
        return m + RecSumMN(m+1,n);
    }
     FromMTon((m>n)? n:m,(m>n)?m:n);
}
int numM = ReadData("Введите первое число M: ");
int numN = ReadData("Введите второе число N: ");

