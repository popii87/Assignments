public class Branch
{
	public int Id;
	public int ParentId;
	public string Name;
	public Branch(int id, string name, int parentId)
	{
		Id = id;
		Name = name;
		ParentId = parentId;
	}
	public override string ToString()
	{
		return Name;
	}
}
