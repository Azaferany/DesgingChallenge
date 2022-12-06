
using System.Text.Json;

Console.WriteLine("Hello, World!");
LinkedList<string> linkedList = new LinkedList<string>(new []{"1","2","3","4","5","6","7","8","9","10"});
var resultLinkedList = DeleteNthNodeFromEnd(linkedList.First,4);

Console.WriteLine(JsonSerializer.Serialize(resultLinkedList));

LinkedList<string> DeleteNthNodeFromEnd(LinkedListNode<string> linkedListNode, int n)
{
    if (n < 1)
        return linkedListNode.List;
    var endNodeFinder = linkedListNode;
    var nthNodeFromTheEndFinder = linkedListNode;
    for (int i = 0; i < n; i++)
    {
        if (endNodeFinder != null)
            endNodeFinder = endNodeFinder.Next;
        else
            throw new Exception("nth node from end not exist");
    }
    while (endNodeFinder != null) {
        endNodeFinder = endNodeFinder.Next;
        nthNodeFromTheEndFinder = nthNodeFromTheEndFinder.Next;
    }

    nthNodeFromTheEndFinder.List.Remove(nthNodeFromTheEndFinder);
    return linkedListNode.List;
}

