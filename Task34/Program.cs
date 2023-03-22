//Задача 34
void InputArray (int[] col) //Создание положительного трехзначного случайного массива
{
    for(int i=0; i<col.Length;i++)
    {
        col[i]=new Random().Next(100,1001);
    }
}

int EvenNumbersArray (int [] col) // Количество четных чисел в массиве
{
    int count = 0;
    for(int i=0; i<col.Length;i++)
    {
        if(col[i]%2==0)
        {
            count++;
        }
    }
    return count;

}

Console.Clear();
int [] arr =new int[10];
InputArray(arr);
int count=EvenNumbersArray(arr);
Console.WriteLine($"{String.Join(",",arr)}");
Console.WriteLine(count);
