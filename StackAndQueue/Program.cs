using StackAndQueue;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Data Structure - Stack And Queue");
        Console.WriteLine("\n1.Create Stack \n2.Peek And Pop");
        LinkedListStack stack = new LinkedListStack();
        int option = Convert.ToInt32(Console.ReadLine());
        switch (option)
        {
            case 1:
                Console.WriteLine("Create a Stack using Linked List");
                stack.Push(70);
                stack.Push(30);
                stack.Push(56);
                stack.Display();
                break;
            case 2:
                Console.WriteLine("Peek and Pop from Stack");
                stack.Push(70);
                stack.Push(30);
                stack.Push(56);
                stack.Display();
                stack.Peek();
                stack.Pop();
                stack.IsEmpty();
                stack.Display();
                break;
        }
        
    }
}