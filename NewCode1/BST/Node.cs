namespace NewCode1.BST
{
    public class Node<TKey, TValue>
    {
        public Node(TKey key, TValue value)
        {
            Key = key;
            Value = value;
        }

        public TKey Key { get; }
        public TValue Value { get; }

        public Node<TKey, TValue> Left { get; set; }
        public Node<TKey, TValue> Right { get; set; }
    }
}

