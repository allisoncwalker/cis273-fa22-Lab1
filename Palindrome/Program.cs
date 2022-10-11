namespace Palindrome;
public class Program
{
    static void Main(string[] args)
    {
        LinkedList<string> linkedList = new LinkedList<string>();

        linkedList.AddLast("xbx");
        linkedList.AddLast("pka");
        linkedList.AddLast("pka");
        linkedList.AddLast("xbx");

        var reverse = linkedList.Reverse();
        var currentNode = linkedList.First;
        var currentNodeReverse = reverse.First();

        //while (currentNode != null)
        //{

        //    currentNode = currentNode.Next;
        //}

        foreach(var node in linkedList)
        {
            Console.WriteLine(node);
        }
        Console.WriteLine( reverse.Equals( linkedList ));
    }
}

public static bool IsPalindrome<T>(LinkedList<T> linkedList)
{
    // Are the first and last items the same?

    // if so, move towards the middle.
    return true;
}

