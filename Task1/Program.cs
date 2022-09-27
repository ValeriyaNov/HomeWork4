//Задача 25: Напишите метод, который принимает на вход 
//два числа (A и B) и возводит число A в натуральную 
//степень B с использованием цикла.

using static System.Console;
Clear();
WriteLine("Введите число ");
int N=Convert.ToInt32(ReadLine());
WriteLine("Введите степень, в которую необходимо возвести число");
int d=Convert.ToInt32(ReadLine());
int n=GetDegree(N, d);
WriteLine($"Число {N} в степени {d} равно {n}");


int GetDegree(int number, int degree)
{
    int result=1;
     for (int i=0; i<degree; i++)
     {
        result=result*number;
     }
     return result;
}