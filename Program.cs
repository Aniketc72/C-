class Class3
{
    static void Main(string[] args)
    {
        string[] cars = new string[4];
        for (int i = 0; i < cars.Length; i++)
        {
            Console.Write("\tElement[" + i + "]: ");
            cars[i] = Console.ReadLine();
        }
        for (int i = 0; i < cars.Length; i++)
        {
            Console.WriteLine(cars[i]);
        }
        Console.ReadLine();
    }
}