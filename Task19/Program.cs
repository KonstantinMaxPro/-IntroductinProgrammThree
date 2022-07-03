int inputNumber;
string report;
Console.WriteLine("======================================================\nПРОВЕРКА ЯВЛЯЕТСЯ ЛИ ЧИСЛО ПАЛИНДРОМОМ");
Console.ForegroundColor = ConsoleColor.Yellow; 
Console.WriteLine("Палиндром - число, буквосочетание, слово или текст, одинаково читающееся в обоих направлениях\n");
Console.ResetColor();

Console.Write("Введите целое число: ");
while (!int.TryParse(Console.ReadLine(), out inputNumber))
{
    Console.ForegroundColor = ConsoleColor.Red; 
    Console.WriteLine("ОШИБКА! ВЫ ВВЕЛИ НЕ ЦЕЛОЧИСЛЕННОЕ ЗНАЧЕНИЕ\n");
    Console.ResetColor();
    Console.Write("Введите целое число: ");
}

int Reversal(int number)
{
    int reverseNumber = 0;
    int tempNumber = number;
    while ( number > 0)
    {
        int remainder = number % 10;
        reverseNumber = reverseNumber * 10 + remainder;
        number /= 10;
    }    
return reverseNumber;
}
int invertedNumber = Reversal(inputNumber);
Console.Write("\nЧисло ");
if(invertedNumber == inputNumber)
{
    Console.ForegroundColor = ConsoleColor.Green; 
    report = "является";
}
else
{
    Console.ForegroundColor = ConsoleColor.Red; 
    report = "не является";
}
Console.Write(inputNumber);
Console.ResetColor();
Console.WriteLine($" {report} палиндромом");
Console.WriteLine("======================================================");