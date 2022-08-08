int[] AddElemenToArray(int[] array, int size)
{
for (int i=0;i<size;i++)
{
    int number = Convert.ToInt32(Console.ReadLine());
    array[i]=number;
}

return array;
} 
int size=8;
Console.WriteLine("Программа запущена");
int[] array = new int[size];
Console.WriteLine("Массив состоит из элементов: " + "[{0}]", string.Join(", ", AddElemenToArray(array,size)));