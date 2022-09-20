double NaturalDegree(int A, int B)
{
    double result = Math.Pow(A, B);
    return result;
}

try
{
    Console.Write("Введите число A: ");
    int a = int.Parse(Console.ReadLine());
    Console.Write("Введите число B: ");
    int b = int.Parse(Console.ReadLine());
    double result = NaturalDegree(a, b);
    Console.WriteLine($"число {a} в натуральной степени {b} = {result}");
}
catch (Exception ex)
{
    Console.WriteLine($"Входное значение имеет неверный формат. Ошибка: {ex.Message}");
}
