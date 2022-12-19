class break1
{
    static void Main(string[] args)
    {
        int a = Convert.ToInt32(Console.ReadLine());
        /* while loop execution */
        while (a < 20)
        {
            Console.WriteLine("value of a: {0}", a);
            a++;
            if (a > 15)
            {
                /* terminate the loop using break statement */
                break;
            }
        }
        Console.ReadLine();
    }
}