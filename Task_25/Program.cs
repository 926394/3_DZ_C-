// Задача 25: Напишите цикл, который принимает на вход
// два числа (A и B) и возводит число A в натуральную
// степень B. 
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите степень числа: ");
int b = int.Parse(Console.ReadLine()!);

double GetSumNums (int num1, int num2)
{
    double sum = Math.Pow(num1, num2);
    return sum; 
}
    
double sum = GetSumNums(num, b);
Console.WriteLine();
Console.WriteLine($"Ответ: {sum}");
Console.WriteLine();


