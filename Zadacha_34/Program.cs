﻿// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int [] array = new int[8];
int size = array.Length;
int count = 0;


for(int i =0; i< size; i++)
{
    array[i] = new Random().Next(0,1000);

    if(array[i]%2 == 0)
    {
        count +=  1; 
    }
}

Console.WriteLine(String.Join(";", array));
Console.WriteLine("Количество четных чисел в массиве : " + count);