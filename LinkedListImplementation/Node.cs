using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListImplementation
{
    public class Node<T>
    {

        //We use this constructor to set the value for a node when we use the methods for AddFirst and AddLast
        public Node(T value)
        {
            this.Value = value;
        }

        //We use the value property to get the and set the value of a node
        public T Value { get; set; }

        //The "Next" property refers to the next node in the list. This can be empty so we declare it as nullable.
        public Node<T>? Next { get; set; }

        //The "Previous" property refers to the previous node in the list. This can be empty so we declare it as nullable.
        public Node<T>? Previous { get; set; }

        

    }
}
