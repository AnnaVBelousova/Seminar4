// See https://aka.ms/new-console-template for more information
// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
int n = Convert.ToInt32(Console.ReadLine());

int counter = 0 ;
while (n!=0)
{
  int a = n % 10;
  counter = counter + a;
  n = n / 10;
}
 
 Console.WriteLine(counter);
