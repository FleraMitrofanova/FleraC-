//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int Sum(int num)
{
    int count = 0;
    //int tmp = 0;

while(num!=0)
{
    count += num%10;
    num = num/10;
    
}
return count;
    
}

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int result = Sum(num);
Console.Write("Результат: "+ result);