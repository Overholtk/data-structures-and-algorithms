# Code Challenge 5: Linked Lists

## Challenge Summary
This challenge required instantiating linked lists and then working with them in various ways, inserting values into the beginning of the list, determining if a value is included in the list, and returning a string that contained every value in the list.

## Challenge Description and Approach & Efficiency

### Insert:
The insert method takes in a value as a parameter and inserts it into the head of the array. It does so by setting a current node variable to the head, then setting the next value of that node to the same element. Then, once the element is saved as the next value, it updates the head with the value of the input.

This is a O(1) space and time operation

### Includes:
This method takes in a value then loops over the array, checking the Value property of each node. If it finds a value it changes a previously instantiated boolean from false to true, then once the while loop has finished the method returns that boolean.

This is a O(N) operation

### toString:
The toString method loops through the whole array via a while loop and then adds the current value to a pre existing string, then returns the string at the end of the method. The while loop runs by checking that the Next value has a value.
This is a O(N) operation

### Append:
Append method takes in one value to be inserted into the array as the new tail. It does this by iterating through the list until it hits a node that has a null value in the next property, then simply sets the next value to the new node with the value from the parameter.

### insertBefore:
insertBefore takes in two values as parameters, one value to anchor the new node to, and one to create the new node. The method iterates through the list and then inserts the new node before the first node that is encountered who's value matches that of the parameters.

### insertAfter:
Similar to insert before, but inserts the node after the node who's value matches the parameter.

### kthFromEnd
kthFromEnd returns the value of a specific node found by iterating backwards along the array.

### zip:
loops through two linked lists and zips them together with the format A - B - A - B - A - B by resetting the nodes.Next values

# Code Challenge 10: Stack and Queue Implementation

## Challenge Summary
Create stack and queue classes, and methods that add, remove, and return information about them. 

## Challenge Description and Approach & Efficiency
In the stack method things were fairly simple and returned values or made edits by checking to see if the first node was null and then making changes to or around that node. All these operations would be O1, because they are either returning nothing or returning a single value.

In the queue method things got a little more complex due to exceptions being thrown if the queue was empty, however the operations work mostly the same, and have the same Big O cost.

## Enqueue:
Takes in a value and adds it to the front of the stack, returns the value at the top of the stack for testability. O1 operation space, O1 time.

## Dequeue:
Iterates through the list to get the value at the bottom of the stack, then pops it from the list and returns that node. 01 operation space, O1 time.

# Code Challenge 12: FIFO Animal Shelter

## Challenge Summary
Create an animal shelter class that accepts cats and dogs, then adds new animals to the shelter and returns animals to be adopted.

## Challenge Description and Approach & Efficiency
Enqueue just calls a previous method to add the new animal object to the back of the queue. This is a O1 space and time operation because it adds one value, and returns one value.

Dequeue is more complicated. It iteratates through the array and stores the animals that do not match the chosen value, then saves the first instance of that value and reorders the queue before returning the proper animal object. This is a O1 space operation (returns one value), and an ON time operation because it has to iterate through the entire list, regardless of length.
