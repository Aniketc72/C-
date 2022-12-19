class Class2
{
    static void Main(string[] args)
    {
        int time = Convert.ToInt32(Console.ReadLine());
        string result = (time < 18) ? "Good day." : "Good evening.";
        Console.WriteLine(result);
        Console.ReadLine();
    }
}