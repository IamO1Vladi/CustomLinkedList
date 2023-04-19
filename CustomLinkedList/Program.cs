using LinkedListImplementation;

namespace CustomLinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DoublyLinkedList<int> test = new DoublyLinkedList<int>();

            test.AddFirst(1);
            test.AddLast(2);
            test.AddLast(3);
            test.AddLast(4);
            test.AddLast(5);

        

            foreach (var number in test)
            {
                Console.WriteLine(number);
            }

        }
    }
}