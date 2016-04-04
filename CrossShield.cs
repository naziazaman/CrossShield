using System;

public class CrossShield
{
	public static void Main()
    {
        int index;
        int limit = 100;
        bool flag;
        for (index = 1; index <= limit; index++)
        {
            flag = false;
            if (index % 2 == 0)
            {
                flag = true;
                Console.Write("Cross");
            }
            if (index % 7 == 0)
            {
                flag = true;
                Console.Write("Shield");
            }
            if(!flag)
            {
                Console.Write(index);
            }
            Console.WriteLine();
        }
    }
}
