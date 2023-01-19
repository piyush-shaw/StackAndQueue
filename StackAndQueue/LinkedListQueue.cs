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
			}
			Console.WriteLine("{0} inserted into queue ",node.data);
		}
		//creating dequeue to remove front item from queue
        internal void Dequeue()
        {
            if (this.head == null)
            {
                Console.WriteLine("Queue is empty");
            }
			Node temp = this.head;
			this.head = this.head.next;
            Console.WriteLine("{0} removed in queue ", temp.data);
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

