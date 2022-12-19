class Class1
{
    static void Main(string[] args)
    {
        Stack s = new Stack();
        s.Push(1);
        s.Push(2);
        s.Push(3);
        s.Push(4);
        Console.WriteLine("Original Stack: ");
        foreach (int i in s)
        {
            Console.WriteLine(i);
        }
        s.Pop();
        s.Pop();
        s.Pop();
        Console.WriteLine("Stack after Pop() operation: ");
        foreach (int i in s)
        {
            Console.WriteLine(i);
        }
        Console.ReadLine();
    }
}
 