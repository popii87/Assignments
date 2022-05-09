using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    
    public static void Main()
	{
		FirstTest();
	}

	public static void FirstTest()
	{
		var categories = new List<Branch>() {
			new Branch(0, "0", -1),
			new Branch(1, "1", 0),
			new Branch(2, "2", 1),
			new Branch(3, "3", 0),
			new Branch(4, "4", 3),
			new Branch(5, "5", 4),
			new Branch(6, "6", 3),
			new Branch(7, "7", 6),
			new Branch(8, "8", 7),
			new Branch(9, "9", 6),
			new Branch(10, "10", 3)
		};

		var tree = GenerateTreeWithRecursion<Branch, int>(categories, r => r.Id, r => r.ParentId, -1);
		PrintTree(tree.Single());
	

		Console.WriteLine();

		
	}
	
	public static IEnumerable<TreeItem<T>> GenerateTreeWithRecursion<T, K>(
		IEnumerable<T> collection,
		Func<T, K> id_selector,
		Func<T, K> parent_id_selector,
		K id_to_match)
	{
		var tree = new List<TreeItem<T>>();
		var nodesWithMatchedId = collection.Where(c => EqualityComparer<K>.Default.Equals(parent_id_selector(c), id_to_match)).ToList();
		foreach (var c in nodesWithMatchedId)
		{
			tree.Add(new TreeItem<T>
			{
				Item = c,
				Children = GenerateTreeWithRecursion(collection, id_selector, parent_id_selector, id_selector(c))
			});
		}
		return tree;
	}

	

	static void PrintTree<T>(TreeItem<T> root, int deep = 0)
	{
		
		Console.WriteLine(new String('\t', deep) + root.Item.ToString());
		
		
		foreach (var c in root.Children)
		{
			PrintTree(c, deep + 1);
			
		}
	}
	
}
