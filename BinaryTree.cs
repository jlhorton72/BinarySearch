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
    /// <summary>
    /// this defines our binary search tree
    /// </summary>
    class BinaryTree
    {
        /// <summary>
        /// defines the two elements needed to 
        /// navigate and establish the tree
        /// </summary>
        #region ---Public Class Fields ---
        public TreeNodes Root;
        public TreeNodes current;   
        #endregion -- publics --

        /// <summary>
        ///  no arg constructor that initializes myRoot
        /// </summary>
        public BinaryTree()
        {
            Root = null;
            current = null;
        } // end of no arg constructor

        /// <summary>
        /// returns the value of the actual tree root
        /// </summary>
        /// <returns></returns>
        public TreeNodes GetRoot()
        {
            return Root;
        } // end of GetRoot 

        #region --- Methods ---

        /// <summary>
        /// adds a new node to the tree
        /// or establishes its root
        /// </summary>
        /// <param name="addTo"></param>
        public void AddToTree(char addTo)
        {
            TreeNodes nextNode = new TreeNodes();       // create new node instance
            nextNode.letter = addTo;                    // sets node to new value
            if (Root == null)             // if null value becomes master root
                Root = nextNode;          // if not, the else kicks in to being finding where to hang node
            else
            {
                TreeNodes current = Root;
                TreeNodes parent;
                while (true)
                {
                    parent = current;               // this starts at root first time thru
                    if (addTo < current.letter)     // checks left side   
                    {
                        current = current.left;
                        if(current == null)         // looking for null
                        {
                            parent.left = nextNode;
                            return;
                        } // end of if
                    } // end of if
                    else
                    {                               // this check right sides
                        current = current.right;
                        if (current == null)        // looking for a null 
                        {
                            parent.right = nextNode;
                            return;
                        } // end of if
                    } // end of else

                } // end of while
            } // end of else

        } // end of AddToTree

        /// <summary>
        /// this will recursively call to do a walk 
        /// thru of the tree
        /// </summary>
        /// <param name="Root"></param>
        public void walkThru(TreeNodes myRoot)
        {
            if (myRoot != null)
            {
                walkThru(myRoot.left);                // recursive call to find the null
                Console.Write(myRoot.letter + ", ");  // prints the node value
                walkThru(myRoot.right);               // recursive call to find the null
            } // end of if
        } // end of walkThru

        /// <summary>
        /// this will search the tree for a value
        /// Call is recursive until it search entire tree or
        /// finds the value
        /// </summary>
        /// <param name="subRoot"></param>
        /// <param name="findMe"></param>
        /// <returns></returns>
        public bool Search(TreeNodes subRoot, char findMe)
        {     
            if (subRoot == null)
            {
                Console.WriteLine(" End of tree reached!");
                return false;
            } // end of if root null
            else if (subRoot.letter.Equals(findMe))
            {
                Console.WriteLine(" This character is in the tree!!");
                return false;
            } // end of if
            else if (findMe < subRoot.letter)
            {
                Console.WriteLine("   This character is NOT in this subtree!");
                return Search(subRoot.left, findMe);
            } // end of esle if 
            else if (findMe > subRoot.letter)
            {
                Console.WriteLine("This character is NOT in this subtree!");
                return Search(subRoot.right, findMe);
            } // end of else if

            return true;
        } // end of Search

        #endregion -- Methods --

    } // end of class BinaryTree
} // end of namespace
