/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и 
возводит число A в натуральную степень B.
 3, 5 -> 243 (3⁵) 
 2, 4 -> 16
 */

 int vozvedenie_priglashenie (string msg)
 {
    Console.Write(msg);
    string messedg = Console.ReadLine();
    int result = int.Parse(messedg);    
    return result;

 }

int vozvedenieMathPow (int numberA, int numberB)
{
    int vozvedenieMathPow = 1;
    for (int count = 0; count < numberB; count++)
    {
        vozvedenieMathPow *= numberA; 
    }

    return vozvedenieMathPow;
}

bool numberBproverka (int numberB)
{
    if (numberB < 0)
    {
        Console.WriteLine("our number dont <= 0");
        return false;
    }
    return true;
}

int numberA = vozvedenie_priglashenie("enter number A: ");
int numberB = vozvedenie_priglashenie("enter number B: ");
if (numberBproverka(numberB))
{
    Console.WriteLine($" number {numberA} v stepene {numberB} = {vozvedenieMathPow(numberA, numberB)}");
}

 
