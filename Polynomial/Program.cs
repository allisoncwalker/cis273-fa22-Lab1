﻿namespace Polynomial;
class Program
{ 
    static void Main(string[] args)
    {
        Polynomial p1 = new Polynomial();

        p1.AddTerm(5, 4);
        p1.AddTerm(3, 2);
        p1.AddTerm(13, 6);
        p1.AddTerm(-2, 4);

        Console.WriteLine(p1);

        Polynomial p2 = new Polynomial();

        p2.AddTerm(6, 4);
        p2.AddTerm(8, 0);

        Console.WriteLine(p2);
    }
}

