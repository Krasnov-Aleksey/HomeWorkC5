void InputArray (int[] col, int min, int max) //Создание случайного массива от мин до мах
{
    for(int i=0; i<col.Length;i++)
    {
        col[i]=new Random().Next(min,max+1);
    }
}

int OddArrayCount(int [] col) //Количество нечентых значений
{
    int count=0;
    for(int i=0;i<col.Length;i++)
    {
        if (col[i]%2!=0)
        {
        Console.Write($"{col[i]} ");
        count++;
        }
    }
    return count;
}
int EvenArrayCount(int [] col) //Количество чентых значений
{
    int count=0;
    for(int i=0;i<col.Length;i++)
    {
        if (col[i]%2==0)
        {
        Console.Write($"{col[i]} ");
        count++;
        }
    }
    return count;
}


Console.Clear();
Console.Write("Введите размер массива ");
int sizeArr=Convert.ToInt32(Console.ReadLine());
int [] arr=new int [sizeArr];
InputArray(arr,1,31);
Console.WriteLine($"{String.Join(" ",arr)}");
Console.WriteLine();
int oddArray=OddArrayCount(arr);
Console.WriteLine();
int evenArray=EvenArrayCount(arr);
Console.WriteLine();
if (oddArray<evenArray)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}





