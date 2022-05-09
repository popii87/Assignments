public class BinaryTree
{
	public Node root;

	public int maxDepth(Node root)
	{
		if (root == null)
			return 0;

		
		int leftDepth = maxDepth(root.left);
		int rightDepth = maxDepth(root.right);

		
		if (leftDepth > rightDepth)
			return (leftDepth + 1);
		else
			return (rightDepth + 1);
	}

	
	
}
