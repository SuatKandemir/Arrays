using System;

Console.WriteLine("Please Enter The Number");
int  arraylenght = int.Parse(Console.ReadLine());
int[]  array = new int[arraylenght];

for (int i = 0; i < arraylenght; i++)
{
    Console.WriteLine("Please {0}.Number Enter :",i+1);
    array[i] = int.Parse(Console.ReadLine());
}

int total = 0;
foreach (int num in array)  
   total += num;

Console.WriteLine("Average :" + total / arraylenght);