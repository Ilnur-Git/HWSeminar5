// Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

int length = 5;
double[] CreateArray()
{
    double[] massiv = new double[length];
    for (int i = 0; i < length; i++)
    {
        
        massiv[i] = Math.Round(new Random().NextDouble()+ new Random().Next(1, 10),2);
        Console.Write(" " + massiv[i]);
    }
    Console.Write("\n\n\t");
    return massiv;
}
double checkArray(double[] massiv)
{
    double max = massiv[0];
    double min = massiv[0];
    for (int i = 0; i < length; i++)
    {
        if (massiv[i] > max)
        {
            max=massiv[i];
        }
        else if (massiv[i] < min)
        {
            min=massiv[i];
        }

    }
    return max-min;
}

Console.Write("Разница между max и min равна " + Math.Round(checkArray(CreateArray()),2));