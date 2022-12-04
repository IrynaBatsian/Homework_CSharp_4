// Напишите программу, которая принимает на вход число и выдает сумму цифр в числе

Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int m = 0;
int result = 0;
while (n != 0)
{
  m = n % 10;
  n = n / 10;
  result = result + m;
}
Console.WriteLine(result);