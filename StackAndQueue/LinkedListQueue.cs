using System;
namespace StackAndQueue
{
	public class LinkedListQueue
	{
		Node head = null;

		//creating enqueue to add new item
		internal void Enqueue(int data)
		{
			Node node = new Node(data);
			if (head == null)
				head = node;
			else
			{
				Node temp = head;
				while (temp.next != null)
				{
					temp = temp.next;
				}
				temp.next = node;
				node.next = head;
			}
			Console.WriteLine("{0} inserted into queue ",node.data);
		}
		//display from queue
		internal void Display()
		{
			Node temp = this.head;
			if (temp == null)
			{
				Console.WriteLine("Queue is empty");
				return;
			}
			while (temp != null)
			{
				Console.WriteLine(temp.data+ " ");
				temp = temp.next;
			}
		}
	}
}

