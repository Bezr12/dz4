// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// Console.WriteLine("Введите число ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите степень числа");
// int b = Convert.ToInt32(Console.ReadLine());
// int degree = a;

// for (int i = 1; i < b; i++)
// {
// degree = degree * a;
// }
// Console.WriteLine(a + " в степени " + b + " равно " + degree);



// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// int Sum (int num)
// {
//     int sum = 0;
//     while (num > 0)
//     {
//         sum += num % 10;
//         num /= 10;
//     }
//     return sum;
// }

// Console.WriteLine("Введите число: ");
// int chis = Convert.ToInt32(Console.ReadLine());
// int a = Sum(chis);
// Console.WriteLine($"Сумма цифр в числе {chis} равна {a}");

// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);

    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}   

int size = 8;
int min = 1;
int max = 20;

int[] myAray = CreateRandomArray(size, min, max);
ShowArray(myAray);


