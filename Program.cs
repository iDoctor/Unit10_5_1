int num1 = 0, num2 = 0;
try
{
    Console.WriteLine("Введите число А:");
    num1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число B:");
    num2 = Convert.ToInt32(Console.ReadLine());

    Calculator calc = new Calculator();
    Console.WriteLine($"Сумма A + B = {calc.GetSum(num1, num2)}");
}
catch (Exception ex)
{
    Console.WriteLine($"Ошибка! {ex.Message}");
}
finally
{
    Console.WriteLine($"Текущие значения A={num1}, B={num2}");
}

class Calculator : ICalculator
{
    public int GetSum(int num1, int num2)
    {
        return num1 + num2;
    }
}

interface ICalculator
{
    int GetSum(int num1, int num2);
}