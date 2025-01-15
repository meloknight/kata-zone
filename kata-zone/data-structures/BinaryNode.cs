using kata_zone.data_structures;



int a = 12;
BinaryTree<int> BT = new BinaryTree<int>( a );
BT.AddLeft( BT._head, 33 );
BT.AddRight( BT._head, 19 );
Console.WriteLine( BT._head.value );
Console.WriteLine( BT._head.left.value );
Console.WriteLine( BT._head.right.value );

namespace kata_zone.data_structures
{
    public class BinaryNode<T>
    {
        public T value { get; set; }
        public BinaryNode<T>? left { get; set; }
        public BinaryNode<T>? right { get; set; }
    }

    public class BinaryTree<T>
    {
        public BinaryNode<T> _head;
        public BinaryTree( T headVal )
        {
            BinaryNode<T> head = new BinaryNode<T>();
            head.value = headVal;
            _head = head;
        }

        public void AddLeft( BinaryNode<T> curr, T value )
        {
            BinaryNode<T> tempLeft = new BinaryNode<T>();
            tempLeft.value = value;
            curr.left = tempLeft;
        }
        public void AddRight( BinaryNode<T> curr, T value )
        {
            BinaryNode<T> tempRight = new BinaryNode<T>();
            tempRight.value = value;
            curr.right = tempRight;
        }
    }

}



