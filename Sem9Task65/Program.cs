// 
Console.Clear();

// Метод ввода
int ReadData(string msg)
{
    Console.Write(msg);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}
//Рекурентный метод 

void FromMton(int m, int n)
{
    if (m <= n)     //точка остановки   
    {
        Console.Write(m + " ");  //печатаем 
        FromMton(m + 1, n);  // следующий вызов производим
    }
    else
    {
        return;
    }
}
int m = ReadData("Введите m: ");
int n = ReadData("Введите n: ");
FromMton(m, n);

// проверка от дурака
// if (m > n)
// {
//     int buf = m;
//     m = n;
//     n = buf;
// }
// FromMton(m, n);
// (m>n)?FromMton(n,m):Fromton(m,n);
FromMton((m>n)?n:m,(m>n)?m:n);
