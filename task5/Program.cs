
Console.WriteLine("Введите число N");
int number = Convert.ToInt32(Console.ReadLine());
if (number>0)
{

    int count = -number;

    while (count <= number)
    {
        Console.Write($"{count} ");
        count ++;
    }
}
else Console.WriteLine("Некоректный ввод");