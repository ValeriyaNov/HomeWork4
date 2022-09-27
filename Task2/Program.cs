// Задача 27: Напишите метод, который принимает на вход число 
//и выдаёт сумму цифр в числе.
using static System.Console;
Clear();
WriteLine("Введите число ");
int N=Convert.ToInt32(ReadLine());
int n=GetSumNum(N);
WriteLine($"Сумма цифр числа {N} равна {n}");

int GetSumNum(int number)
{   
    int result=0;
for (int i=number; i>0; i=i/10)
{
    result=result+i%10;
}
    return result;
}