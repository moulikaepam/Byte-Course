using System;

public class Program
{
    public static void Main(string[] args)
    {
        int n = 4; 
        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= n - i; j++) 
            {
                Console.Write(" ");
            }
            for (int k = 1; k <= i; k++) 
            {
                Console.Write("#");
            }
            Console.WriteLine(); 
        }
    }
}
