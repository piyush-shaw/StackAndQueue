using System;
namespace StackAndQueue
{
	public class LinkedListStack
	{
		private Node top;

		//Push the data in stack
		internal void Push(int value)
		{
			Node node = new Node(value);
			if (this.top == null)
				node.next = null;
			else
				node.next = this.top;
			this.top = node;
			Console.WriteLine("{0} pushed to stack ",value);
		}
		//display the data of stack
		public void Display()
		{
			Node temp = this.top;
			while (temp != null)
			{
				Console.WriteLine(temp.data + " ");
				temp = temp.next;
			}
		}
        //Peek method to show top element
        internal void Peek()
        {
            if (this.top == null)
            {
                Console.WriteLine("Stack is empty");
                return;
            }
            Console.WriteLine("{0} is in the top of the stack ", this.top.data);
        }
		//Pop method to delete element
		internal void Pop()
		{
			if (this.top == null)
			{
				Console.WriteLine("Stack is empty, Deletion is not possible ");
				return;
			}
			Console.WriteLine("Value popped is {0} ",this.top.data);
			this.top = this.top.next;
		}
		//Empty method to make stack empty
		internal void IsEmpty()
		{
			while (this.top != null)
			{
				Peek();
				Pop();
			}
		}
    }
}

