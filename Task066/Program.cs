// Задайте значения M и N. Напишите программу, 
//которая найдёт сумму натуральных элементов в промежутке от M до N. 
//Выполнить с помощью рекурсии.
//          M = 1; N = 15 -> 120
//          M = 4; N = 8. -> 30

int SumNatureNumInInterval(int min, int max)
{
    if (min < 0)
    {
        if (max==0) return 0;
        return max + SumNatureNumInInterval(min, max-1);
    }
    else
    {
        if (max==min) return min;
        return max + SumNatureNumInInterval(min, max-1);
    }
}

Console.WriteLine("Введите минимальное значение:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение:");
int n = Convert.ToInt32(Console.ReadLine());
if (n < m)
{
    Console.WriteLine($"Вы задали некорректные значения");
}
else
{
    if(n > 0) 
    {
        int res = SumNatureNumInInterval(m, n);
        Console.WriteLine($"Сумма натуральных чисел в интервале от {m} до {n} составляет {res}");
    }
    else
    {
        Console.WriteLine($"В заданном интервале нет натуральных числел");
    }
}

