// Задача 68: Напишите программу вычисления функции Аккермана 
// с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


Console.Write("Введите число m: ");
int numberM = Convert.ToInt32(Console.ReadLine());
if(numberM < 0)
{
    Console.Write("Некорректный ввод!");
    return;
}

Console.Write("Введите число n: ");
int numberN = Convert.ToInt32(Console.ReadLine());
if(numberN < 0)
{
    Console.Write("Некорректный ввод!");
    return;
}

Console.WriteLine($"m = {numberM}, n = {numberN} -> A(m,n) = {FuncAkkerman(numberM, numberN)}");

int FuncAkkerman(int numN, int numM)
{
    if (numN == 0)
    {
        return numM + 1;
    }
    else if (numM == 0)
    {
        return FuncAkkerman(numN - 1, 1);
    }
    else
    {
        return FuncAkkerman(numN - 1, FuncAkkerman(numN, numM - 1));
    }
}