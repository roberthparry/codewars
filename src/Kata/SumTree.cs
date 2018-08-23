namespace Kata
{
    public class SumTreeKata
    {
		public class Node
        {
            public int Value;
            public Node Left;
            public Node Right;

            public Node(int value, Node left = null, Node right = null)
            {
                Value = value;
                Left = left;
                Right = right;
            }
        }

		public static int SumTree(Node root) => (root == null) ? 0 : root.Value + SumTree(root.Left) + SumTree(root.Right);
	}
}
