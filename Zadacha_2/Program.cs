// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму 
// натуральных элементов в промежутке от M до N. 
// Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите число M: ");
int numberM = Convert.ToInt32(Console.ReadLine());
if (numberM < 1)
{
    Console.WriteLine("Некорректный ввод!");
    return;
}

Console.Write("Введите число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());
if (numberN < 1)
{
    Console.WriteLine("Некорректный ввод!");
    return;
}


Console.WriteLine($"M = {numberM}; N = {numberN} -> {SumNatureNumbers(numberM, numberN)}");


int SumNatureNumbers(int numM, int numN)
{
    if(numM == numN)
    {
        return numM;
    } 
    else if (numN > numM)
    {
        return numM + SumNatureNumbers(numM + 1, numN);
    }
    else
    {
        return numN + SumNatureNumbers(numN + 1, numM);
    }
}