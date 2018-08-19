namespace Kata
{
	public class Node
	{
		public int Data { get; private set; }
		public Node Next { get; private set; }

		public Node(int data, Node next = null)
		{
			Data = data;
			Next = next;
		}
	}

	public static class ConvertLinkedList
	{
		public static string Stringify(Node list) => (list == null) ? "null" : $"{list.Data} -> {Stringify(list.Next)}";
	}
}
