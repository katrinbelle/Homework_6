/* Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */

int GetValue(string messeng)
{
    Console.Write(messeng);
    int result = 0;
    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out result)) break;
        else Console.WriteLine("Введите только число-> ");
    }

    return result;
}

void IntersectionOfTwoLines(int numberK1, int numberb1, int numberK2, int numberb2)
{
    if (numberK1 == numberK2 ) Console.WriteLine($"прямые  y={numberK1}*x +{numberb1} и y={numberK2}*x +{numberb2}  паралельны и не пересекаются");
    else if (numberb1 == numberb2 && numberK1 == numberK2) Console.WriteLine($"прямые  y={numberK1}*x +{numberb1} и y={numberK2}*x +{numberb2}  совпадают");
    else
    {
        float numberK = numberK1 - numberK2;
        float x = (numberb2 - numberb1) / (numberK);
        double y = numberK1 * x + numberb1;
        Console.Write($"Точка пересечиния  прямой y={numberK1}*x +{numberb1} и y={numberK2}*x +{numberb2} равна ({x},{y})");
    }
}

IntersectionOfTwoLines(GetValue("Введите координату по первой точке х-> "), GetValue("Введите координату по первой точке у-> ")
, GetValue("Введите координату по второй точке х-> "), GetValue("Введите координату по второй точке у-> "));
