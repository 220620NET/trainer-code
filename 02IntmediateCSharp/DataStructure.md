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

## Dictionary

## HashSet

## Queue and Stack

## LinkedList

## and more!