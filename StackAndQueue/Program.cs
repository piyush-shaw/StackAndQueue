using StackAndQueue;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Data Structure - Stack And Queue");
        Console.WriteLine("\n1.Create Stack \n2.Peek And Pop \n3.Create Queue \n4.Dequeue");
        LinkedListStack stack = new LinkedListStack();
        LinkedListQueue queue = new LinkedListQueue();
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
            case 3:
                Console.WriteLine("Create a Queue using Linked List");
                queue.Enqueue(56);
                queue.Enqueue(30);
                queue.Enqueue(70);
                queue.Display();
                break;
            case 4:
                Console.WriteLine("Dequeue from begining of queue");
                queue.Enqueue(56);
                queue.Enqueue(30);
                queue.Enqueue(70);
                queue.Dequeue();
                queue.Dequeue();
                queue.Display();
                break;
            default:
                Console.WriteLine("Please enter the correct option");
                break;
        }
    }
}