// Задача 29: Напишите программу, которая задаёт массив
// из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// Console.Write("Введите длину массива: ");
// int length = int.Parse(Console.ReadLine()!);

int[] array = new int [8];  //[length];

void GetMassivNum(int[] coll) 
{
    for(int index = 0; index < coll.Length; index ++)
    {
        Console.Write($" Введите {index } элемент массива ");
        coll[index] = int.Parse(Console.ReadLine()!);
    }
}

void TheFinishNum(int[] coll)
{
    for(int index = 0; index < coll.Length; index ++)
    {
        Console.Write($"{coll[index]} ");   
    }
}

GetMassivNum(array); 
Console.WriteLine(); 
TheFinishNum(array);
Console.WriteLine();
