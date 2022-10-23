using System.Collections.Generic;
using System.Security;

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

    }

    public static bool IsPalindrome<T>(LinkedList<T> linkedList)
    {
        var currentNode = linkedList.First;
        var back = linkedList.Last;

        while (currentNode != null)
        {
            if (currentNode.Equals(back))
            {
                currentNode = currentNode.Next;
            }
            else
            {
                return false;
            }
        }

        foreach (var node in linkedList)
        {
            Console.WriteLine(node);
        }

        return true;
    }

}