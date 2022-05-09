
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;

Console.WriteLine("Hello, World!");
Node root = newNode('A');
(root.child).Add(newNode('B'));
(root.child).Add(newNode('F'));
(root.child).Add(newNode('D'));
(root.child).Add(newNode('E'));
(root.child[0].child).Add(newNode('K'));
(root.child[0].child).Add(newNode('J'));
(root.child[2].child).Add(newNode('G'));
(root.child[3].child).Add(newNode('C'));
(root.child[3].child).Add(newNode('H'));
(root.child[3].child).Add(newNode('I'));
(root.child[0].child[0].child).Add(newNode('N'));
(root.child[0].child[0].child).Add(newNode('M'));
(root.child[3].child[2].child).Add(newNode('L'));

Console.Write(depthOfTree(root) + "\n");
// Utility function to create a new tree node
static Node newNode(int key)
{
    Node temp = new Node();
    temp.key = (char)key;
    temp.child = new List<Node>();
    return temp;
}

// Function that will return the depth
// of the tree
static int depthOfTree(Node ptr)
{
    // Base case
    if (ptr == null)
        return 0;

    // Check for all children and find
    // the maximum depth
    int maxdepth = 0;
    foreach (Node it in ptr.child)
        maxdepth = Math.Max(maxdepth,
                            depthOfTree(it));

    return maxdepth + 1;
}
