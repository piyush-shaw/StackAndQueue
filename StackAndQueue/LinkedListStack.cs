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

	}
}

