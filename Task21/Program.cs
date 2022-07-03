int inputFirstNumberX;
int inputFirstNumberY;
int inputFirstNumberZ;
int inputSecondNumberX;
int inputSecondNumberY;
int inputSecondNumberZ;
Console.WriteLine("\n======================================");
System.Console.WriteLine("РАССТОЯНИЕ МЕЖДУ ДВУМЯ ТОЧКАМИ В 3D ПРОСТРАНСТВЕ");
Console.WriteLine("======================================");
Console.Write("Введите координаты первой точки по X оси: ");
while (!int.TryParse(Console.ReadLine(), out inputFirstNumberX))
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("ОШИБКА! ВЫ ВВЕЛИ НЕ ЦЕЛОЧИСЛЕННОЕ ЗНАЧЕНИЕ\n");
    Console.ResetColor();
    Console.Write("Введите координаты первой точки по X оси: ");
}
Console.Write("Введите координаты первой точки по Y оси: ");
while (!int.TryParse(Console.ReadLine(), out inputFirstNumberY))
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("ОШИБКА! ВЫ ВВЕЛИ НЕ ЦЕЛОЧИСЛЕННОЕ ЗНАЧЕНИЕ\n");
    Console.ResetColor();
    Console.Write("Введите координаты первой точки по Y оси: ");
}
Console.Write("Введите координаты первой точки по Z оси: ");
while (!int.TryParse(Console.ReadLine(), out inputFirstNumberZ))
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("ОШИБКА! ВЫ ВВЕЛИ НЕ ЦЕЛОЧИСЛЕННОЕ ЗНАЧЕНИЕ\n");
    Console.ResetColor();
    Console.Write("Введите координаты первой точки по Z оси: ");
}
Console.Write("Введите координаты второй точки по X оси: ");
while (!int.TryParse(Console.ReadLine(), out inputSecondNumberX))
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("ОШИБКА! ВЫ ВВЕЛИ НЕ ЦЕЛОЧИСЛЕННОЕ ЗНАЧЕНИЕ\n");
    Console.ResetColor();
    Console.Write("Введите координаты второй точки по X оси: ");
}
Console.Write("Введите координаты второй точки по Y оси: ");
while (!int.TryParse(Console.ReadLine(), out inputSecondNumberY))
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("ОШИБКА! ВЫ ВВЕЛИ НЕ ЦЕЛОЧИСЛЕННОЕ ЗНАЧЕНИЕ\n");
    Console.ResetColor();
    Console.Write("Введите координаты второй точки по Y оси: ");
}
Console.Write("Введите координаты второй точки по Z оси: ");
while (!int.TryParse(Console.ReadLine(), out inputSecondNumberZ))
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("ОШИБКА! ВЫ ВВЕЛИ НЕ ЦЕЛОЧИСЛЕННОЕ ЗНАЧЕНИЕ\n");
    Console.ResetColor();
    Console.Write("Введите координаты второй точки по Z оси: ");
}

double Hypotenuse(int firstX, int firstY, int firstZ, int secondX, int secondY, int secondZ)
{
    double deltaX = firstX - secondX;
    double deltaY = firstY - secondY;
    double deltaZ = firstZ - secondZ;
    double result = Math.Sqrt(deltaX * deltaX + deltaY * deltaY + deltaZ * deltaZ);
    return Math.Round(result, 2);
}

double hypotenuse = Hypotenuse(inputFirstNumberX, inputFirstNumberY, inputFirstNumberZ,
                               inputSecondNumberX, inputSecondNumberY, inputSecondNumberZ);
System.Console.WriteLine($"\nРасстояние между двумя точками: {hypotenuse}");
Console.WriteLine("======================================\n");
