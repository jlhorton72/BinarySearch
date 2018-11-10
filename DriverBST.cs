using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Name:       James Horton
/// Date:       11/09/2018
/// Assignment: Binary Search Tree
/// </summary>


namespace BinarySearchTreeApplication
{

    class DriverBST
    {
        static void Main(string[] args)
        {
            BinaryTree thisTree = new BinaryTree();

            // *** can alter between two segments of code to check functionality **

            thisTree.AddToTree('g');
            thisTree.AddToTree('n');
            thisTree.AddToTree('w');
            thisTree.AddToTree('u');
            thisTree.AddToTree('\0');
            thisTree.AddToTree('N');
            thisTree.AddToTree('Z');
            thisTree.AddToTree('A');
            thisTree.AddToTree('P');

            //thisTree.AddToTree('A');
            //thisTree.AddToTree('a');
            //thisTree.AddToTree('B');
            //thisTree.AddToTree('b');
            //thisTree.AddToTree('\0');
            //thisTree.AddToTree('D');
            //thisTree.AddToTree('d');
            //thisTree.AddToTree('E');
            //thisTree.AddToTree('e');
            //thisTree.AddToTree('F');
            //thisTree.AddToTree('f');
            //thisTree.AddToTree('G');
            //thisTree.AddToTree('g');
            //thisTree.AddToTree('\0');
            //thisTree.AddToTree('I');
            //thisTree.AddToTree('i');
            //thisTree.AddToTree('J');
            //thisTree.AddToTree('j');

            Console.WriteLine(" The following was loaded into the tree: ");
            Console.WriteLine(" g,n,w,u,\0,N,Z,A,P ");
            //Console.WriteLine(" A,a,B,b,\0,D,d,E,e,F,f,G,g,\0,I,i,J,j");
            Console.WriteLine(" We will now print out an Inorder Traversal: ");
            thisTree.walkThru(thisTree.GetRoot());

            Console.WriteLine("");
            Console.WriteLine(" Now we will use a search to see if a particular value is in the tree.");
            Console.WriteLine(" First we will search for 'u':");
            thisTree.Search(thisTree.Root, 'u');
            Console.ReadKey();
            Console.WriteLine("");
            Console.WriteLine(" Now lets looks for something not there like 'J' :");
            thisTree.Search(thisTree.Root, 'J');

            Console.WriteLine(" This concludes the presentation!!");
            Console.ReadKey();
        } // end of main
    } // end of class
} // end of namespace
