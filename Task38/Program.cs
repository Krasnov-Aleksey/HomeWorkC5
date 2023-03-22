void InputArrayDouble (double [] col) //Создание случайного вещественного массива
{
    for(int i=0; i<col.Length;i++)
    {
        col[i]=Math.Round(new Random().NextDouble()*10,2);
    }
}

double SumMinMax (double[] col) //Сложение мин и мах числа в массиве
{
    double min =col[0];
    double max=col[0];
    for (int i=1;i<col.Length;i++)
    {
        if (col[i]<min) 
            min=col[i];
        if (col[i]>max)
            max=col[i];
    }
    double sum=min+max;
    return sum;
}


Console.Clear();

double[] arr=new double[5];
InputArrayDouble(arr);
Console.WriteLine($"[{String.Join(" ",arr)}]");
Console.WriteLine(Math.Round(SumMinMax(arr),2));




