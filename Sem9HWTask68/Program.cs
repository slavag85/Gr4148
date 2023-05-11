// Напишите программу вычисления фужнкции Акермана мс помощью рекурсии.
// Даны два неотрицательных числа m и n.

Console.Clear();

// метод запрашивает и считывает
int ReadData (string line);
{
    Console.Write (line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}
// метод вычесдения функции Аккермана
 
 int FunAkk(int m, int n);
 {
    
    if(m == 0) return (n + 1);
    
    else 
    
        if(n == 0) return FunAkk(m-1,1);
    
    
    else
        return FunAkk(m-1,FunAkk(m,n-1));

 }

int numM = ReadData ("Введите число M: ");
int numN = ReadData ("Введите число N: ");
