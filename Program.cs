class continue1
{
    static void Main(string[] args)
    {
        int a = 10;
        /* do loop execution */
        do
        {
            if (a == 15)
            {
                /* skip the iteration */
                a = a + 1;
                continue;
            }
            Console.WriteLine("value of a: {0}", a);
            a++;
        }
        while (a < 20);
        Console.ReadLine();
    }
}