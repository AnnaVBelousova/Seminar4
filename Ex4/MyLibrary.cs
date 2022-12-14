
public static class MyLibrary
// Метод создания массива
{
 public static int[] CreateArray(int count)
 {
    return new int[count];
 }

  

// Заполнение массива числами из данного отрезка



public static void Fill(int[]array)
{
    int length = array.Length;
    int index = 0;
    while (index < length)
    {
        array[index] = new Random().Next(0,15);
        
        index ++; 
    }
}

// Печать массива

   public static string Print(int[]array)
{
    return String.Join(' ', array);
} 

// Метод возведения в степень


public static int pow(int A, int B)
{

int count = 1;
for (int i = 1; i <= B; i++)
{
  count = count * A;
}
return count;
}
//Перевести число из 15-ричной системы в 10-тичную.

    public static int ToDec(int[] value)

    {
      int length = value.Length;
      int result = 0;
      for (int i = 0; i < length; i++)
      {
        result = result + value[i] * pow (15, length -1 -i);
      }
      return result;
    }
}

