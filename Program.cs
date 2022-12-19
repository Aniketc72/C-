class Reverse
{
    static void Main(string[] args)
    {
        String myStr, rev;
        rev = "";
        myStr = Console.ReadLine();
        Console.WriteLine("String is {0}", myStr);
        // find string length
        int len;
        len = myStr.Length - 1;
        while (len >= 0)
        {
            rev = rev + myStr[len];
            len--;
        }
        Console.WriteLine("Reversed String is {0}", rev);
        Console.ReadLine();
    }
}
