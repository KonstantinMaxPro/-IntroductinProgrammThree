void PrintCubeNumber(int number)
{
    int cube = 0;
    for (int i = 1; i <= number; i++)
    {
        cube = i * i * i;
        System.Console.Write(" " + cube + ",");
    }
    System.Console.Write("\b \b");
}

void PrintCubeNumberMath(int mathNumber)
{
    for (int i = 1; i <= mathNumber; i++)
    {
        double mathCube = Math.Pow(i, 3);
        System.Console.Write(" " + mathCube + ",");
    }
    System.Console.Write("\b \b");
}

int inputNumber;
Console.WriteLine("\n======================================");
System.Console.WriteLine("ВОЗВЕДЕНИЕ ПОРЯДКОВЫХ ЧИСЕЛ В КУБ");
Console.WriteLine("======================================");
Console.Write("Введите число: ");
while (!int.TryParse(Console.ReadLine(), out inputNumber))
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("ОШИБКА! ВЫ ВВЕЛИ НЕ ЦЕЛОЧИСЛЕННОЕ ЗНАЧЕНИЕ\n");
    Console.ResetColor();
    Console.Write("Введите целое число: ");
}
    Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine($"\n1) Через цикл FOR перемножая каждое число от 1 до {inputNumber} по 3 раза: ");
 Console.ResetColor();
PrintCubeNumber(inputNumber);
System.Console.WriteLine();
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine($"2) Через цикл FOR с функцией Math.Pow ({inputNumber}, {inputNumber}): ");
 Console.ResetColor();
PrintCubeNumberMath(inputNumber);
Console.WriteLine("\n======================================\n");

