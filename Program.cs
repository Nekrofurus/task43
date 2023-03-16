// Нап3шите программу, котора найдет точку пересечения двух прямых, заданных уравнениями y = k1*x + b1, y = k2*x + b2, 
// значения b1, k1, b2, k2 задаются пользователем
// b1 = 2, k1 = 5, b2 = 4 k2 = 9 ->(-0.5;-0,5)
const int k = 0;
const int b = 1;
const int x = 0;
const int y = 1;
double[] InputLine(int number)
{
    Console.WriteLine($"Для уравнения y = k{number}*x + b{number}");
    double[] inputLine = new double[2];
    inputLine[k] = UserInput($"Введите k{number} = ");
    inputLine[b] = UserInput($"Введите b{number} = ");
    return inputLine;
}
double UserInput(string massage)
{
    Console.Write(massage);
    string value = Console.ReadLine();
    double result = Convert.ToDouble(value);
    return result;
}


bool ValidateLines(double[] inputLine1, double[] inputLine2)
{
    if (inputLine1[k] == inputLine2[k])
    {
        if (inputLine1[b] == inputLine2[b])
        {
            Console.WriteLine("Прямые совпадают");
            return false;
        }
        else
        {
            Console.WriteLine("Прямые параллельны");
            return false;
        }
    }
    return true;
}

double[] LineIntersectionPoint(double[] inputLine1, double[] inputLine2)
{
    double[] linIsPoint = new double[2];
    linIsPoint[x] = Math.Round((inputLine2[b] - inputLine1[b]) / (inputLine1[k] - inputLine2[k]), 2);
    linIsPoint[y] = Math.Round(inputLine1[k] * linIsPoint[x] + inputLine1[b], 2);
    return linIsPoint;
}
void PrinteEquationLine(double[] inputLine)
{
    if (inputLine[k] == 0 && inputLine[b] == 0)
    {
        Console.Write("y = 0");
    }
    else if (inputLine[k] != 0 && inputLine[b] < 0)
    {
        Console.Write($"y = {inputLine[k]}x - {inputLine[b] * -1}");
    }
    else if (inputLine[k] != 0 && inputLine[b] > 0)
    {
        Console.Write($"y = {inputLine[k]}x + {inputLine[b]}");
    }
    else if (inputLine[k] != 0 && inputLine[b] == 0)
    {
        Console.Write($"y = {inputLine[k]}x");
    }
    else if (inputLine[k] == 0 && inputLine[b] != 0)
    {
        Console.Write($"y = {inputLine[b]}");
    }
}


void PrintArray(double[] array)
{
    Console.Write(" координаты пересечения: {");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length - 1]}");
    Console.Write("}");
}
double[] inputLine1 = InputLine(1);
double[] inputLine2 = InputLine(2);
double[] lineIntersectionPoint = LineIntersectionPoint(inputLine1, inputLine2);
Console.Write($"Для уравнений: ");
PrinteEquationLine(inputLine1);
Console.Write($" и ");
PrinteEquationLine(inputLine2);
if (ValidateLines(inputLine1, inputLine2))
{
    PrintArray(lineIntersectionPoint);
}
