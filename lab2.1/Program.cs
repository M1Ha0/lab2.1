try
{
    Console.WriteLine("Введите x");
    double x = double.Parse(Console.ReadLine());
    Console.WriteLine("Введите y");
    double y = double.Parse(Console.ReadLine());
    if (y <= 1 && y >= Math.Abs(x))
    {
        Console.WriteLine("Точка (x, y) находится внутри области.");
    }
    else
    {
        Console.WriteLine("Точка (x, y) находится вне области.");
    }
}
catch
{
    Console.WriteLine("Введите корректные данные");
}