//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

int[] CreateArray()
{
    int[]massiv = new int[5]; 
    for (int i = 0; i < 5; i ++)
    {
        massiv[i]=new Random().Next(100,1000); 
        Console.Write(" "+massiv[i]);
    }
    Console.Write("\n\n\t");
    return massiv;
}

int checkArray(int[]massiv)
{
    int count=0; 
    for (int i=0; i<5; i++)
    {
        if (massiv[i]%2==0)
        {
            count++;
        }   
    }
    return count;
}
Console.WriteLine(checkArray(CreateArray()));