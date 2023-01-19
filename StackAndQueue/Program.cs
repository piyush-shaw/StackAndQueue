using StackAndQueue;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Data Structure - Stack And Queue");
        Console.WriteLine("Create Stack using Linked List");
        LinkedListStack stack = new LinkedListStack();
        stack.Push(70);
        stack.Push(30);
        stack.Push(56);
        stack.Display();
    }
}