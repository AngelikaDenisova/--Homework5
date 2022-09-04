//  Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76


int [] array = new int[8];
int size = array.Length;

int max =  0;
int min = 100;
int result = 0;



for(int i =0; i< size; i++)
{
    array[i] = new Random().Next(0,101);


    if ( max < array[i])
    {
      max = array[i];
    }

    if (min > array[i])
    {
        min = array[i];
    }

    result = max - min;
}
Console.WriteLine(String.Join(";", array));
Console.WriteLine("Разница между максимальным и минимальным элементов массива равна "+ result);
