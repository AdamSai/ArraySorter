# Array Sorter
This is my solution for the [array sorter exercise](https://datsoftlyngby.github.io/soft2020spring/resources/70801985-02-assignment-heap-sort.pdf).  
As the exercise stated: `The class should work both with Comparable1 objects and with the use of a
Comparator and/or Lambda`, I have chosen to make my implementation work with **lambda** expressions.

With the ArraySorter class you can create a priority queue with an already existing array, and then define the size of the queue. The queue size must be equal to or larger than the array of items you set in the constructor.  
In the `program.cs` file a random array of integers is created and sorted **ascending** and **descending**.