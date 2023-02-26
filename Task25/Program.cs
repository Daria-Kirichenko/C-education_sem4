//  Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int Production(int a)
{
    int numberB = ReadNumber("Введите число В:");
    int prod = 1;
    for(int n = 1; n <= numberB; n++)
    {
        prod = prod * a;
    }
    return prod;
}

int numberA = ReadNumber("Введите число А:");
// int numberB = ReadNumber("Введите число В:");
int result = Production(numberA);
Console.WriteLine(result);