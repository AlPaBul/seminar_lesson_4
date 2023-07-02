/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму 
цифр в числе.
452 -> 11
82 -> 10
9012 -> 12

*/

 int start (string msg)
 {
    Console.Write(msg);
    string messedg = Console.ReadLine();
    int result = int.Parse(messedg);    
    return result;

 }


int sumaVsexChiselnumber (int numberEnter)
{
    int result = 0;
    while (numberEnter > 0)
    {
        result += numberEnter % 10;
        numberEnter = numberEnter / 10;
    }
    return result;
}

int numberEnter = start("enter any number: ");
Console.WriteLine($"Summa all chusel v number {numberEnter} = {sumaVsexChiselnumber(numberEnter)}");

