void InputArray (int[] col, int min, int max) //Создание случайного массива от мин до мах
{
    for(int i=0; i<col.Length;i++)
    {
        col[i]=new Random().Next(min,max+1);
    }
}

int SumOddArrayElements(int [] col) //Сумма элементов, стоящих на нечётных позициях
{
    int sum=0;
    for(int i=1;i<col.Length;i+=2)
    {
        sum=sum+col[i];
    }
    return sum;
}

Console.Clear();
int [] arr =new int[10];
InputArray(arr,-10,10);
Console.WriteLine($"{String.Join(",",arr)}");
Console.WriteLine(SumOddArrayElements(arr));
