class sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            // Sort a string
            string[] college = { "Reva", "CMR", "BMS", "New Horizon" };
            Array.Sort(college);
            foreach (string i in college)
            {
                Console.WriteLine(i);
            }
            // Sort an int
            int[] myNumbers = { 5, 1, 8, 9 };
            Array.Sort(myNumbers);
            foreach (int i in myNumbers)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
