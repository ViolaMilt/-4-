/*Домашнее задание

Задача 1. Напишите цикл, 
который принимает на вход два натуральных числа (A и B) и возводит число A в степень B.*/

void Stepen (int a,int b)
{
    Console.WriteLine (Math.Pow (a,b));
}

Console.WriteLine ( "Введите  второе число:  ");
int z = Convert.ToInt32(Console.ReadLine());

Console.WriteLine ( "Введите  второе число:  ");

int q = Convert.ToInt32(Console.ReadLine());

Console.WriteLine( "Результат:  ");

Stepen (z,q);



/* Задача 2.
Напишите программу, которая принимает на
вход число и выдаёт сумму цифр в числе.*/

Console.WriteLine ( "Введите число:  ");

string znachenie = Convert.ToString(Console.ReadLine());
int sum = 0;
int v = 0;
for ( int i=0; i< znachenie.Length ; i++)
    {
        v = int.Parse(znachenie[i].ToString());

        sum = sum + v ;
    }
    Console.WriteLine (sum);
    
/*Задача 3
 Напишите программу, которая 
задаёт массив из 8 случайных целых чисел и выводит отсортированный по модулю массив.*/

int[]array1 = new int [8];
void Sluchai(int[] array2)
{
for(int i = 0; i <array2.Length;i++)
{
    array2[i] = new Random().Next(-10,10);
    Console.WriteLine( " " + array2[i]);
}
}

async void Sortirovka ( int [] arr)
  {
      for ( int i = 0; i< arr.Length; i++)

      {
          for ( int g = i+1; g< arr.Length; g++) 
          {
             if ( Math.Abs(arr [g]) < Math.Abs(arr [i]))
             {
              int t = arr [g];
              arr[g]= arr[i];
              arr[i] = t;
              }
          }
      Console.WriteLine($"{arr[i]}");
      }
      
  } 

Sluchai(array1);
Console.WriteLine ("Отсортированный массив: ");
Sortirovka(array1);




