using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace BTreeCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("C# Version:");
            do
            {
                Console.Write("\nEnter value of n = ");
                string str = Console.ReadLine();
                n = Int16.Parse(str);
                BTree t = new BTree();
                ArrayList l = t.constructBTree(1, n);
                Console.WriteLine("All possible distinct search binary trees are " + l.Count);
                Console.WriteLine("In order(Left < Root < Right)");



                int i = 0;
                while (i < l.Count)
                {
                    t.outputTree((BTreeNode)l[i]);
                    i++;
                    if (i != l.Count)
                        Console.Write("---");
                }
                Console.WriteLine();
                Console.Write("\nEnter 0 to exit program, otherwise enter 1 to continue: ");
                str = Console.ReadLine();
                n = Int16.Parse(str);
            } while (n != 0);
        }
    }
}
