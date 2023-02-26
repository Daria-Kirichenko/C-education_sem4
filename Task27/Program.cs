// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}
int Summary(int n)
{
    int sum = 0;
    while(n != 0)
        {
            int lastDigit = n % 10;
            sum = sum + lastDigit;
            n = n / 10;
        }
    return sum;
}
int number = ReadNumber("Введите ваше число:");
int result = Summary(number);
Console.WriteLine(result);