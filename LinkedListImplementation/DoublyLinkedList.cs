using System.Collections;

namespace LinkedListImplementation
{
    public class DoublyLinkedList<T> :IEnumerable,IEnumerator 
    {

        private Node<T>? head;
        private Node<T>? tail;

        public int Count { get; private set; }

       

        public void AddFirst(T elemet)
        {

            if (this.Count == 0)
            {
                //In case this is the first element of the list we make it the tail and the head
                Node<T> newNode= new Node<T>(elemet);
                this.head = newNode;
                this.tail = newNode;
                this.Count++;
            }
          
            else
            {
                //I create a temporary currentHead for better readibility of the code. otherwise it could be done without it.
                Node<T> currentHead = this.head;
                //Here I create a new Node that will be the new head of the list
                Node<T> newHead = new Node<T>(elemet);

                //Setting the next node for the new head
                newHead.Next = currentHead;

                //Setting the previous node for the old head
                currentHead.Previous = newHead;

                //Changing the head to the new note
                this.head = newHead;

                //Increasing the count of the list
                this.Count++;

            }



        }

        public void AddLast(T element)
        {

            //In case this is the first element of the list we make it the tail and the head
            if (this.Count == 0)
            {
                Node<T> newNode = new Node<T>(element);
                this.head = newNode;
                this.tail = newNode;
                this.Count++;
            }     
            else
            {

                //I create a temporary currentTail for better readibility of the code. otherwise it could be done without it.
                Node<T> currentTail = this.tail;
                //Here I create a new Node that will be the new tail of the list
                Node<T> newTail = new Node<T>(element);

                //Setting the next node for the new tail
                newTail.Previous = currentTail;

                //Setting the previous node for the old tail
                currentTail.Next = newTail;

                //Changing the head to the new note
                this.tail = newTail;

                //Increasing the count of the list
                this.Count++;

            }

        }

        public T RemoveFirst()
        {
            //In this if statement we check if the list is empty. If it is we throw an exception
            if (this.Count == 0)
            {
                throw new ArgumentNullException("Cannot remove an element from an empty list!");
            }
            else if (this.Count == 1) //Here we check if the list has only one element. If it this we set the head and tail to null, reduce the count and return the value of the element.
            {
                //Getting the currentHead so I can return its value after setting the head and tail to null

                Node<T> currentNode = this.head; //cannot be null as we checked in the first if

                //Seeting both head and tail to null as the List will be empty
                this.head = null;
                this.tail = null;
                //reducing the count of the list back to 0 and returning the value of the node we just removed
                Count--;
                return currentNode.Value; //cannot be null as we checked in the first if
            }
            else
            {
                //Creating this vairalbe so we can return the value

                Node<T> currentNode = this.head; //cannot be null as we checked in the first if

                //Getting the new head for readability purposes. This can be done without creating a new variable

                Node<T> newHead = this.head.Next; //Cannot be null as we have covered that case in the if statement above

                //Setting the previous value of the new head to null. Thus removing the reference to the current head in the list

                newHead.Previous = null; //"newHead"Cannot be null as well due to the same reason

                //Setting the new head and reducing the count. After which returning the value of the head we removed
                this.head = newHead;
                this.Count--;

                return currentNode.Value; //Cannot be null due to the if statements above

            }



        }


        public T RemoveLast()
        {
            //In this if statement we check if the list is empty. If it is we throw an exception
            if (this.Count == 0)
            {
                throw new ArgumentNullException("Cannot remove an element from an empty list!");
            }
            else if (this.Count == 1) //Here we check if the list has only one element. If it this we set the head and tail to null, reduce the count and return the value of the element.
            {
                //Getting the currentHead so I can return its value after setting the head and tail to null

                Node<T> currentNode = this.tail; //cannot be null as we checked in the first if

                //Seeting both head and tail to null as the List will be empty
                this.head = null;
                this.tail = null;
                //reducing the count of the list back to 0 and returning the value of the node we just removed
                Count--;
                return currentNode.Value; //cannot be null as we checked in the first if
            }
            else
            {
                //Creating this vairalbe so we can return the value

                Node<T> currentNode = this.tail; //cannot be null as we checked in the first if

                //Getting the new tail for readability purposes. This can be done without creating a new variable

                Node<T> newTail = this.tail.Previous; //Cannot be null as we have covered that case in the if statement above

                //Setting the next value of the new tail to null. Thus removing the reference to the current tail in the list

                newTail.Next = null; //"newTail"Cannot be null as well due to the same reason

                //Setting the new tail and reducing the count. After which returning the value of the tail we removed
                this.tail = newTail;
                this.Count--;

                return currentNode.Value; //Cannot be null due to the if statements above

            }
        }


        public T[] ToArray()
        {

            T[] tempArray=new T[this.Count];
            int counter = 0;

            Node<T> currentNode = this.head;

            while(currentNode != null)
            {
                tempArray[counter] = currentNode.Value;
                currentNode= currentNode.Next;
                counter++;
            }

            return tempArray;

        }

        //IEnumerator and IEnumerable implementation
        private int position = -1;
        public object Current
        {
            get
            {
                var currentObject=this.head;

                for(int i = 0; i < this.position; i++)
                {
                    currentObject = currentObject.Next;
                }

                return currentObject.Value;
            }
        }
        public IEnumerator GetEnumerator()
        {
            return (IEnumerator)this;
        }

        public bool MoveNext()
        {
            position++;
            return (position < this.Count);
        }

        public void Reset()
        {
            this.position = -1;
        }
    }
}