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
    /// defines the TreeNode
    /// </summary>
    class TreeNodes
    { 
        public char letter { get; set; }
        public TreeNodes left { get; set; }
        public TreeNodes right { get; set; }

        /// <summary>
        /// defines the individual node
        /// </summary>
        class Node
        {
            public char value;
            public Node left;
            public Node right;
        } // end of class Node


        /// <summary>
        /// this class defines the Tree and how to add to the tree
        /// </summary>
        class Tree
        {
            /// <summary>
            /// this method will insert the new node 
            /// in the correct place thru recursive calls
            /// </summary>
            /// <param name="subRoot"></param>
            /// <param name="val"></param>
            /// <returns></returns>
            public Node insert (Node subRoot, char val)
            {
                if (subRoot == null)       // verifies root for original val
                {
                    subRoot = new Node();
                    subRoot.value = val;
                } // end of if
                else if (val < subRoot.value)  // checks left side and recurses
                {
                    subRoot.left = insert(subRoot.left, val);
                } // end of else if         // else checks right risde and recurses
                else
                {
                    subRoot.right = insert(subRoot.right, val);
                } // end of else

                return subRoot;             // returns the node
            } // end of insert

            /// <summary>
            /// this method should walk thru the tree
            /// by using recursive call
            /// </summary>
            /// <param name="subroot"></param>
            public void walkThru(Node subroot)
            {
                if (subroot == null)            // null means empty and it ends
                {
                    return;
                } // end of if

                walkThru(subroot.left);         // checks left side and recalls
                walkThru(subroot.right);        // checks right side and recalls

            } // end of walkThru

        } // end of class Tree

    } // end of class TreeNodes
} // end of namspace
