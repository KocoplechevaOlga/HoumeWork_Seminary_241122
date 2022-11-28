// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.
//          m = 2, n = 3 -> A(m,n) = 9
//          m = 3, n = 2 -> A(m,n) = 29

int FuncAckerm(int m, int n)
{
    if (m == 0) return n + 1;
    if (n == 0) return FuncAckerm(m-1, 1);
    else
    {
        return FuncAckerm(m-1, FuncAckerm(m, n-1));
    }

}

Console.WriteLine("Введите первое число, больше или равное 0:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число, меньше или равное 0:");
int b = Convert.ToInt32(Console.ReadLine());

if (a >= 0 && b >= 0) 
{
   int res =  FuncAckerm(a, b);
   Console.WriteLine(res);
}
else
{
    Console.WriteLine("Условия не корректны");
}