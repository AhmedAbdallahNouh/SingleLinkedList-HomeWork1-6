using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SingleLinkedListHomeWork1_6.Classes
{
	public class BasicSingleLinkedList
	{
		public Node? Head { get; set; }


		#region problem 5 
		//Implement InsertEnd
		public virtual void InsertEnd(int value)
		{
			Node node = new Node(value);
			
			if (Head is null)
			{
				Head = node;
				Head.next = null;
				return;
			}
			for (Node current  = Head; current is not null; current = current.next)
			{
				if (current.next == null)
				{
					current.next = node;
					return;
				}
			}
		}

		//Implement Print
		public virtual void Print()
		{
			Node? current = Head;
			while (current is not null)
			{
				Console.WriteLine(current.data);
				current = current.next;
			}
		}

		//Implement GetTail
		public virtual Node? GetTail()
		{
			if (Head is null)
				return null;
			
			for (Node current = Head; current is not null; current = current.next)
			{
				if (current.next == null)
					return current;
			}
			return null;
		}
		#endregion
	}
}
