// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

double[] getCoordinates(double numK1, double numB1, double numK2, double numB2)
{
    double[] result = new double[2];
    result[0] = (numB2 - numB1) / (numK1 - numK2);
    result[1] = numK1 * result[0] + numB1;
    return result;
}


Console.WriteLine("Введите коэффициент k1");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите коэффициент b1");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите коэффициент k2");
double k2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите коэффициент b2");
double b2 = Convert.ToInt32(Console.ReadLine());

if (k1 == k2)
{
    if (b1 == b2) Console.WriteLine("Прямые совпадают");
    else Console.WriteLine("Прямые параллельны");
}
else
{
    Console.WriteLine($"Точка пересечения прямых ({String.Join(";", getCoordinates(k1, b1, k2, b2))})");
}