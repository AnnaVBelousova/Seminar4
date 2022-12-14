using static MyLibrary;
public class lesson5

{
    public static void Task28()
    {
        int[]array = CreateArray(2);
        Fill(array);
       
        int num = ToDec(array);
        Console.WriteLine( $"{Print(array)} = {num}");
    }
}
