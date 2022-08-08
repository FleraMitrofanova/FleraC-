//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
int NumToPower(int numA, int numB)
{
    int count = 1;

    for (int i=0;i < numB; i++)
    {
     count *=numA;
    }
    return count;
}

Console.Write("Введите число: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень: ");
int numB = Convert.ToInt32(Console.ReadLine());
int result = NumToPower(numA, numB);
Console.Write("Результат: "+ result);
