// See https://aka.ms/new-console-template for more information
using SingleLinkedListHomeWork1_6.Classes;

#region problem 1 Execution


SingleLinkedList singleLinkedList = new SingleLinkedList();
singleLinkedList.InsertEnd(6);
singleLinkedList.InsertEnd(10);
singleLinkedList.InsertEnd(8);
singleLinkedList.InsertEnd(15);

singleLinkedList.InsertFront(7);
singleLinkedList.InsertFront(5);
singleLinkedList.InsertFront(1);

singleLinkedList.Print();
#endregion

#region problem 2 Execution

Console.ForegroundColor = ConsoleColor.Magenta;

singleLinkedList.DeleteFront();
singleLinkedList.Print();

#endregion

#region problem 3 Execution

Console.ForegroundColor = ConsoleColor.Cyan;

Node? nodeAtSpecificPosition = singleLinkedList.GetNodeFromEndByPosition(2);
Console.WriteLine($"the data of wanted node : {nodeAtSpecificPosition.data}");
singleLinkedList.Print();

#endregion

#region problem 4 Execution

Console.ForegroundColor = ConsoleColor.Red;

SingleLinkedList firstSingleLinkedList = new SingleLinkedList();
firstSingleLinkedList.InsertFront(5);
firstSingleLinkedList.InsertEnd(10);


SingleLinkedList secondSingleLinkedList = new SingleLinkedList();
secondSingleLinkedList.InsertFront(5);
secondSingleLinkedList.InsertEnd(10);
secondSingleLinkedList.InsertEnd(8);

bool isSamelistsdata = firstSingleLinkedList.Equals(secondSingleLinkedList);
Console.WriteLine(isSamelistsdata);
#endregion


#region problem 5 Execution

BasicSingleLinkedList linkedList = new BasicSingleLinkedList();

Console.ForegroundColor = ConsoleColor.Green;
linkedList.InsertEnd(10);
linkedList.InsertEnd(15);
linkedList.InsertEnd(30);
linkedList.Print();
Node? tail =  linkedList.GetTail();
#endregion