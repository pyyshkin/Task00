Console.WriteLine("Введите два числа");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 == number2 * number2)
{
    Console.WriteLine($"{number2} является квадратом {number1}");
}
else
{
    Console.WriteLine($"{number2} не является квадратом {number1}");
}
