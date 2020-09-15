using System;


namespace NewCode1.BST
{
    public class Tree<TKey, TValue>  where TKey : IComparable<TKey>
    {
        public Node<TKey, TValue> Root { get; private set; }

        public Node<TKey, TValue> AddNode(TKey key, TValue value)
        {
            Node<TKey, TValue> parent = null;
            Node<TKey, TValue> current = Root;
            int compare = 0;
            while (current != null)
            {
                parent = current;
                compare = current.Key.CompareTo(key);
                current = compare < 0 ? current.Right : current.Left;
            }
           var newNode = new Node<TKey, TValue>(key, value);
            if (parent != null)
                if (compare < 0)
                    parent.Right = newNode;
                else
                    parent.Left = newNode;
            else
                Root = newNode;

            return current;
        
        }

        public TValue FindByKey(TKey key)
        {
            var nod = Find(key, Root);
            return nod == null  ? default(TValue):  nod.Value;
        }

        private Node<TKey, TValue> Find(TKey key, Node<TKey, TValue> parent)
        {
            if (parent != null)
            {
                int compare = 0;
                compare = parent.Key.CompareTo(key);

                if (compare == 0) return parent;
                if (compare < 0)
                    return Find(key, parent.Right);
                else
                    return Find(key, parent.Left);
            }

            return null;
        }

    }
}