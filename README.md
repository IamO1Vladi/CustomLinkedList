# Custom LinkedList

In this project, I have created another custom data structure, which has similar functionalities as the C# doubly linked list. This custom doubly linked list will have the following functionalities: 
•	void AddFirst(int element) – adds an element at the beginning of the collection
•	void AddLast(int element) – adds an element at the end of the collection
•	int RemoveFirst() – removes the element at the beginning of the collection
•	int RemoveLast() – removes the element at the end of the collection
•	ForEach() – implemented with IEnumerator and IEmurable
•	int[] ToArray() – returns the collection as an array


#Details about the Structure:
The doubly linked list is a structure that resembles a list but has different functionalities. 
Each element in it "knows" about the previous one, if it is such, and the next one, again, if there is such. 
This is possible because the doubly linked list has nodes and each node has two reference properties pointing to other nodes and a value property, which contains some kind of data. 
By definition, the doubly linked list has a head (list start) and a tail (list end). The typical operations over a doubly linked list add/remove an element at both of the endings and traverse. 
If you are interested, you can find more detailed information here: https://en.wikipedia.org/wiki/Doubly_linked_list. 


#How to use:

1. You can create the list the way you create a normal List<> in C#. Example -> CustomLinkedList<T> example = new CustomLinkedList<T>(); 
2. After which you can use the created list with the methods mentioned above. 
3. If you copy the library project remeber to add a reference to it in your main project.
4. You can rename the class for the customlinkedlist to however you want. I have left mine like this as I plan to add new methods.


#Note:

Will be adding new features to the list in the future