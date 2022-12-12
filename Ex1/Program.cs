// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
double A = Convert.ToDouble(Console.ReadLine());
double B = Convert.ToDouble(Console.ReadLine());
double count = 1;
for (int i = 1; i <= B; i++)
{
  count = count * A;
}

Console.WriteLine(count);
