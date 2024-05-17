using System;

class NotATriangleException : Exception
{
    public NotATriangleException(string message) : base(message)
    {
    }
}

class Program
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Введите стороны треугольника:");
            double side1 = Convert.ToDouble(Console.ReadLine());
            double side2 = Convert.ToDouble(Console.ReadLine());
            double side3 = Convert.ToDouble(Console.ReadLine());

            if (!IsTriangle(side1, side2, side3))
            {
                throw new NotATriangleException("Это не треугольник");
            }

            double perimeter = side1 + side2 + side3;
            Console.WriteLine($"Периметр треугольника: {perimeter}");
        }
        catch (NotATriangleException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Произошла ошибка: {ex.Message}");
        }
        finally
        {
            Console.WriteLine("Работа закончена.");
        }
    }

    static bool IsTriangle(double a, double b, double c)
    {
        return a + b > c && a + c > b && b + c > a;
    }
}