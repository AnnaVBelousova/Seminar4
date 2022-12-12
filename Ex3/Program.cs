// See https://aka.ms/new-console-template for more information
// Задача 29: Напишите программу, которая задаёт массив из N элементов (из диапазона [0-14] ) и выводит на экран десятичное представление числа, записанного в СС по основанию 15

int n = Convert.ToInt32(Console.ReadLine());

int[]array = new int[n];
void FillArray(int[]array)
{
    int length = array.Length;
    int index = 0;
    while (index < length)
    {
        array[index] = new Random().Next(0,14);
        Console.WriteLine(array[index]);
        index ++; 
    }
}


