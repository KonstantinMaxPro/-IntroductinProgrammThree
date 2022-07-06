int inputNumber;
string report;


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

Console.Clear();//Очищаем консоль
/*ЗАГОЛОВОК (ДЛЯ КРАСОТЫ)*/
Console.WriteLine("=======================================");
Console.WriteLine("     ПРОВЕРКА ЧИСЛА НА ПАЛИНДРОМ");//Название
Console.WriteLine("=======================================\n");
/*КОНЕЦ ЗАГОЛОВКА*/

Console.Write("Введите целое число: ");
while (!int.TryParse(Console.ReadLine(), out inputNumber))
{
    Console.ForegroundColor = ConsoleColor.Red; 
    Console.WriteLine("ОШИБКА! ВЫ ВВЕЛИ НЕ ЦЕЛОЧИСЛЕННОЕ ЗНАЧЕНИЕ\n");
    Console.ResetColor();
    Console.Write("Введите целое число: ");
}

int invertedNumber = Reversal(inputNumber);
Console.WriteLine("\n======================================================");
Console.Write("Число ");
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
