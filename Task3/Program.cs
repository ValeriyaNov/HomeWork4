// Задача 29: Напишите метод, который формирует массив 
//из 8 случайных элементов и выводит их на экран.
using static System.Console;
Clear();
int s=8;
int[]array=GetArrray(s);
PrintArray(array);

int [] GetArrray(int size)
{
    int[] result=new int[size];
    for (int i=0; i<size; i++)
    {
        result[i]=new Random().Next(0,589);
        }
        return result;
}

void PrintArray(int[]array1)
{
    Write("[");
    for (int j=0; j<array1.Length-1; j++)
    {
        Write($"{array1[j]}, ");
    }
    Write($"{array1[array1.Length-1]}]");
}