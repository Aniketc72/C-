class Program
{
    public static void Main()
    {
        int[] array = { 2, 11, 15, 1, 7, 99, 6, 85, 4 };
        Array.Sort(array); //sorting array 
        Array.Reverse(array);
        Console.WriteLine("Third Highest Value in Array " + array[2]);
        foreach (var result in array)
        {
            Console.Write(result + " "); // Array values 
        }
    }
}