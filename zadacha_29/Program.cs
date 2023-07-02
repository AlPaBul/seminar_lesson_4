/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и 
выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

int start (string msg)
 {
    Console.Write(msg);
    string messedg = Console.ReadLine();
    int result = int.Parse(messedg);    
    return result;

 }

int [] anyArray (int dlina, int minZnachenue, int maxZnachenue)
{
    int [] massiv = new int[dlina];
    Random random = new Random();

    for (int count = 0; count < dlina; count++)
    {
        massiv[count] = random.Next(minZnachenue, maxZnachenue + 1);
    }
    return massiv;
}

void printarray (int[] massiv)
{
    Console.WriteLine(" [");
    for (int i = 0; i < massiv.Length - 1; i++)
    {
        Console.WriteLine($"{massiv[i]}, ");
    }
    Console.WriteLine($"{massiv[massiv.Length - 1]}");
    Console.WriteLine("]");
}

int dlina = start("dlina massiva: ");
int minZnachenue = start("Start: ");
int maxZnachenue = start("End");
int [] massiv = anyArray (dlina, minZnachenue, maxZnachenue);
printarray (massiv);