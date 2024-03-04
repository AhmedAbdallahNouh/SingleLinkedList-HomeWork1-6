using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SingleLinkedListHomeWork1_6.Classes
{
	public class SingleLinkedList : BasicSingleLinkedList
	{
	
		public Node? Tail { get; set; }
		public int Length { get; private set; } = 0;
		public SingleLinkedList() { }
		  
		public SingleLinkedList(Node? head = null)
		{
			Head = head;
			Tail = head;
			Tail.next = null;
		}
		public SingleLinkedList(Node? head = null, Node? tail = null)
		{
			Head = head;
			Tail = tail;
		}

		
		public void InsertEnd(int value)
		{
			Node node = new Node(value);
			if (Head is null)
			{
				Head = Tail = node;
				Length++;
				return;
			}
			Tail.next = node;
			Tail = node;
			Length++;

		}
		public Node? FindByIndex(int index)
		{
			int counter = 1;
			for (Node? current = Head; current is not null; current = current.next)
			{
				if (counter++ == index)
				{
					return current;
				}
			}
			return null;
		}
		public int FindIndexByValue(int value)
		{
			int counter = 1;
			for (Node? current = Head; current is not null; current = current.next)
			{
				if (current.data == value)
				{
					return counter;
				}
				counter++;
			}
			return -1;
		}


		#region problem 1 
		//implemented insertFront
		public void InsertFront(int value)
		{
			Node node = new Node(value);
			if (node is null)
				return;

			if(Head is null)
			{ 
				Head = Tail = node; 
				Length++;
				return;
			}

			node.next = Head;
			Head = node;
			Length++;
		}
		#endregion

		#region problem 2 
		//implemented insertFront
		public void DeleteFront()
		{
			
			if (Head is null)		
				return;

			if(Head == Tail) 
			{
				Head = null;
				Length--;
				return;
			}
			Node nodeToDelete = Head;
			Head = Head.next;
			Length--;
			Node.Delete(ref nodeToDelete);
		}
		#endregion

		#region problem 3 
		//implemented Get nth from back
		public Node? GetNodeFromEndByPosition(int position)
		{
			position = Math.Abs(position);
			if (position > Length || position == 0  || Head is null ||  Length == 0)
				return null;

			int counter = 0;
			for (Node? current = Head; current is not null; current = current.next)
			{
				if(Length - counter == position)
					return current;

				counter++;
			}
			return null;
		}
		#endregion

		#region problem 4 
		//implemented Get nth from back
		public override bool Equals(object? obj)
		{
			if (obj is null) 
				return false;

			if (ReferenceEquals(this, obj)) 
				return true;

			if (obj.GetType() != GetType())
				return false;

		    var	linkedList = obj as SingleLinkedList;

			//code assumes a variable length is maintained : 
			//if (linkedList?.Length != Length)
			//	return false;

			if ( (Head is null && linkedList.Head is not null) || (Head is not null && linkedList.Head is null) ) 
				return false;

			if (Head == null && linkedList.Head == null)
				return true;

			for(Node firtsObjNode = Head! , secondObjNode = linkedList.Head ; firtsObjNode is not null || secondObjNode is not null; firtsObjNode = firtsObjNode.next! , secondObjNode = secondObjNode?.next!)
			{
				if( firtsObjNode?.data != secondObjNode?.data)
					return false;
			}
			return true;

		}

		public override int GetHashCode()
		{
			throw new NotImplementedException();
		}
		#endregion
	}
}
