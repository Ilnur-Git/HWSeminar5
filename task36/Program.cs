// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0
int length=5;
int[] CreateArray()
{
    int[] massiv = new int[length];
    for (int i = 0; i < length; i++)
    {
        massiv[i] = new Random().Next(1, 10);
        Console.Write(" " + massiv[i]);
    }
    Console.Write("\n\n\t");
    return massiv;
}
int checkArray(int[] massiv)
{
    int count = 0;
    for (int i = 0; i < length; i++)
    {
        if (i % 2 == 0)
        {

        }
        else
        {
            
            count= count+ massiv[i]; // count+= massiv[i];
        }
        
    }
    return count;
}
Console.Write("Сумма "+ checkArray(CreateArray()));