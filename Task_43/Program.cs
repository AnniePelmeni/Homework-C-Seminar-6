// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


void FindPointOfIntersection(double k1, double b1, double k2, double b2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k2 * x + b2;
    Console.WriteLine($"({x}; {y})");
}

double GetInput(string text)
{
    Console.Write(text);
    return Convert.ToDouble(Console.ReadLine());
}

double k1 = GetInput("Задайте углой коэффициент первой прямой: ");
double b1 = GetInput("Задайте точку на оси ординат, через которую будет проходить первая прямая: ");
double k2 = GetInput("Задайте углой коэффициент второй прямой: ");
double b2 = GetInput("Задайте точку на оси ординат, через которую будет проходить вторая прямая: ");

Console.Write($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} -> ");
FindPointOfIntersection(k1, b1, k2, b2);