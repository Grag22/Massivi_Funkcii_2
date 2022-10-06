// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.Write("Введите пятизначное число: ");
string num = Console.ReadLine();

void CheckingNumber(string num)
{
    if (num[0] == num[4] || num[1] == num[3])
        {
            Console.WriteLine($"{num} - палиндромом.");
        }
    else Console.WriteLine($"{num} - не палиндромом.");
}

if (num!.Length == 5)
{
    CheckingNumber(num);
}
else Console.WriteLine($"Число не пятизначное!");
