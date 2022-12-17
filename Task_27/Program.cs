// Задача 27: Напишите программу, которая принимает на
// вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


Console.Write("Здравствуйте! Введите число: ");
int number = int.Parse(Console.ReadLine()!);

if (number < 1000 & number > 99) 
{
    int sum = GetSum3Nums(number);
    Console.WriteLine();
    Console.WriteLine($"Ответ: {sum}");
    Console.WriteLine();
}

if (number < 100 & number > 9) 
{
    int sum2 = GetSum2Nums(number);
    Console.WriteLine();
    Console.WriteLine($"Ответ: {sum2}");
    Console.WriteLine();
}

if (number < 10000 & number > 999) 
{
    int sum3 = GetSum4Nums(number);
    Console.WriteLine();
    Console.WriteLine($"Ответ: {sum3}");
    Console.WriteLine();
}

if (number < 100000 & number > 9999) 
{

    Console.WriteLine();
    Console.WriteLine($"Извините, это уже перебор: {number}");
    Console.WriteLine();
}

int GetSum3Nums (int num)
{

    int num1 = 0;
    int num2 = 0;
    int num3 = 0;
    int num4 = 0;
    int sum2 = 0;

        // if (num > 99 && num < 1000)        
   
    num1 = num / 10;
    num2 = num / 100;
    num3 = num1 % 10;
    num4 = num % 10;
    sum2 = num2+ num3+ num4;
    // Console.WriteLine($"Ответ: {num1}, {num2}, {num3}, {num4}");       
    return sum2;
    
}

// int sum = GetSumNums(number);
// Console.WriteLine();
// Console.WriteLine($"Ответ: {sum}");
// Console.WriteLine();


int GetSum2Nums (int num)
{

    int num1 = 0;
    int num2 = 0;
    int sum2 = 0;
       
    num1 = num / 10;
    num2 = num % 10;
    sum2 = num1+ num2;
      //Console.WriteLine($"Ответ: {num1}, {num2}");      
    return sum2;
    
}

// int sum2 = GetSumNums1(number);
// Console.WriteLine();
// Console.WriteLine($"Ответ: {sum2}");
// Console.WriteLine();


int GetSum4Nums (int num)
{


int num1 = 0;
int num2 = 0;
int num3 = 0;
int num4 = 0;
int num5 = 0;
int num6 = 0;
int sum3 = 0;
    num1 = num / 1000;
    num2 = num / 100;
    num3 = num2 % 10;
    num4 = num / 10;
    num5 = num4 % 10;
    num6 = num % 10;
    sum3 = num1 + num3 + num5 + num6;
    return sum3;
    // Console.WriteLine($"Ответ: {num1}, {num2}, {num3}, {num4}, {num5}, {num6}");
}


