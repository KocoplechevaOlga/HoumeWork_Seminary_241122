// Задайте значение N. Напишите программу, 
//которая выведет все натуральные числа в промежутке от N до 1. 
//Выполнить с помощью рекурсии.
//          N = 5 -> "5, 4, 3, 2, 1"
//          N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


void NatureNumberDescres(int num)
{
    if (num == 0) return;
    Console.Write($"{num} ");
    NatureNumberDescres(num-1);
}

Console.WriteLine("Введите натуральное число:");
int n = Convert.ToInt32(Console.ReadLine());
if(n > 0) NatureNumberDescres(n);

else 
{
    Console.WriteLine("Вы ввели ненатуральное число, скорректруйте данные");
}