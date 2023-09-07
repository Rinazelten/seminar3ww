/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

System.Console.Write("Введите количество чисел, которые хотите  проверить");
int sizeArray = int.Parse(Console.ReadLine());


int[] userArray = GenerateArray(sizeArray);
PrintArray(userArray);
CountMoreZero(userArray);


void CountMoreZero(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= 0) result++;
    }
    System.Console.WriteLine();
    System.Console.WriteLine($"Количество положительных чисел равно: {result}");
}

void PrintArray(int[] array)
{
    foreach (int i in array)
    {
        Console.Write($"{i} ");
    }
}

int[] GenerateArray(int length)
{
    int[] result = new int[length];
    for (int i = 0; i < result.Length; i++)
    {
        System.Console.WriteLine($"Введите число {i+1}: ");
        result[i] = int.Parse(System.Console.ReadLine());
    }
    return result;
}

/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

IntersectionPoint();

void IntersectionPoint()
{
System.Console.WriteLine("Введите через Enter значения b1, k1, b2, k2");
double b1 = double.Parse(Console.ReadLine());
double k1 = double.Parse(Console.ReadLine());
double b2 = double.Parse(Console.ReadLine());
double k2 = double.Parse(Console.ReadLine());
if (k1 == k2 && b1 == b2) System.Console.WriteLine("Прямая лежит в прямой!");
else if (k1 == k2 && b1 != b2) System.Console.WriteLine("Прямые параллельны!");
else if (k1 != k2 && b1 == b2) System.Console.WriteLine("Точка пересечения в нуле");
else
{
    double resultX = (b2 - b1) / (k1 - k2);
    double resultY = k1 * resultX + b1;
    System.Console.WriteLine($"Прямые пересекутся в X: {resultX}, Y: {resultY}");
}
}