# Data Structures
Is great when you have more than 1 datum(?) to store.
All data structures mentioned below have different strengths and weaknesses, so we can use them accordingly to our benefit.

## Array
Is a collection of objects that is of same data type. 
It's fixed length - you have to declare the length at initialization. When we run out of the space we have create a longer array and we have to copy over. They also take up _contiguous_ memory space, so getting the value of the element at a known index (such as 5th element of an array) only takes one calculation/operation.

- Fixed Length
- everything is right next to each other

## List
- Lists are auto-resizing arrays
List addresses array's fixed length inconvenience(?) by auto-resizing when it runs out of space.
Addition features List introduces on top of array
- Resizing without you having to get involved
    - You don't have to declare the length of list on initialization
- Adding to the end of the list without worrying about how full the list is.
- Big O of Adding: O(1) (amortized)
    - If I have to resize because I ran out of space... then it takes O(n)
- Searching
- Removing
- Time complexity of removing from a known index and leaving it blank: O(1)
- Removing from a known index and making sure that there is no blank spot: O(n) with the worst case being the first element removed
- Sort
- Count property that will give you the number of elements currently in the list
- Capacity property - that gives you how big the actual backing array is.

## Generic Classes
`<T>` is an indicator that the particular class is a generic class.
Generic class is a class that can work with many different type of data.
For example, we can have `List<string>` `List<int>` `List<bool>` `List<List<List<int>>>` `List<Pokemon>` `List<List<PokeTrainer>>`
Generic Classes preserve the same set of behavior for multiple data types. This is a little different from overloading. This is another example of polymorphism, one of the principles of OOP.

## Algorithm analysis: Time Complexity and Big O Notation
algorithm is a finite set of computer instruction
2 types of complexity: time complexity, space complexity
- Time complexity: It measures the # of instructions that algorithm has for n elements. For array of N elements, looking at each array element would take N instructions. The most common notation to describe the time complexity of an algorithm is Big O: O(). Big O notation represents the worst case scenario. (In our naive searching of the array where we traversed the array from the front to back in search of an item, the worst case scenario was when the item was at the very end. We had to traverse all the way to the end to find the item: O(n) - linear)
- Space complexity: how much memory space does your algorithm take up when executing

Other examples of O(n) operations: 
    - Traversing through an array of n elements
    - For Loops (not-nested) 

Example of O(1) Operations:
    - Accessing an element in an array or list with its index

O(log n)
- Binary Search

O(n^2)
- Doubly Nested Loops
- Bubble sort (which is one of elementary sorts)

O(n^3)
- Triple nested loops
- Matrix multiplication

O(c^n)
- permutation algo

## foreach loop and IEnumerable
Not all data structures are designed to access items by its index. But still there are ways to loop through those collections even when we can't access its items by index. Any classes that implements the interface IEnumerable has ability to give you the enumerator (which basically gives you the next item in the list). We use the enumerator under the hood through foreach loop. Foreach loop doesn't have an index/counter it instead gives you the next item in the collection until it reaches the end of the collection
```csharp
List<int> intList = new List<int>{1, 2, 3, 4, 5};

for(int i = 0; i < intList.Count; i++)
{
    Console.WriteLine(intList[i]);
}

//Super useful when we can't access items by its index
//You can only use this loop with classes/data structures that implements the interface IEnumerable
foreach(int listItem in intList)
{
    Console.WriteList(listItem);
}
```
## Dictionary (or HashMap in Java or object in JS)
Is a collection of key value pair
```
{
    "key": value,
    "key1": value,
    "key2": value
}
```
- Keys must be unique 
- Values may be the same
- Lookup in dictionaries with its key is very fast
    - this is an ideal tool if you want to find something via key
    - Example of using dictionary is on "Return the frequency of the most frequent letter in a string"
        - "aaaaaabbecccwfff"
        - a appears 6 times, b appears 2 times, c appears 3 times, e 1 time, w 1 time, f 3 times
        - i could.. int a = 6, b = 2, c = 3, e = 1, w = 1, f = 3;
        - int a, b, c, d, e, f, g, h, i, j, k, l.... this seems inefficient
    - Store two related data types together (such as username and password)
        - instead of string username = "pw";

## HashSet
C#'s generic implementation of Set. Set is an unordered finite collection where no two elements are the same. This is great when you want to ensure you're not adding any duplicates.
    - Removing all duplicates from an array.
    - Do set operations with these (Union, isSubset, is Superset)

## Queue and Stack
Queue and Stack are related data structures. 
Queue: DMV or Bank queue or Bus line. First come, first served. The item that is added to the queue the first, is the first one to be accessed. First In, First Out(FIFO)
Stack: Stack of pancake where you grab the pancake from the top. Last in, first out. (LIFO)
- These data structures do not support accessing by index or searching.
- Add (for stack)/Enqueue(for queue) 
- Pop (for stack)/ Dequeue (for queue)
- Peek (for both) : for looking at what is next item on the list without removing
- Size: how many things are in here

## LinkedList
LinkedList is a type of data structure where the data is not necessarily stored next to each other but each node keeps a reference (aka the memory location) to its next neighbor(next node). When the node only keeps a reference to its next one, we call that a "singly linked list". When the nodes also keep references to its previous neighbor, we call it a "doubly linked list"

## Generic vs Non Generic Collections
In C#, we have two different namespaces for collections: System.Collections. System.Collections.Generic
System.Collections.Generic is where all generic collections like List<T>, HashSet<T>, Queue<T>, Stack<T> all live in.
In the case you want to store multiple data types in a collection, you can go about it in two ways. 1. use non-generic collections: Queue, Stack, ArrayList, Hashtable, SortedList. These non-generic collections box (aka turn everything into Object) data before storing. Which means if you want to access the data, unboxing is needed. 2. Use generic collections such as list, except do boxing/unboxing yourself and contain them as objects ie. List<Object>.

## and more!
[C# System.Collections.Generic](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic?view=net-6.0)
[C# System.Collections](https://docs.microsoft.com/en-us/dotnet/api/system.collections?view=net-6.0)