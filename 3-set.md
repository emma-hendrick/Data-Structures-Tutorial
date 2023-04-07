[Tutorial Home](README.md)

# Sets
## Unique Elements

A set is a data structure that is defined as a list which does not (and cannot) contain any duplicate elements. 

## Structure

Values within sets are immutable, you cannot change them. If you need to update something, you have to remove the original value, and then insert the new one. Sets are also automatically sorted, which is handy, no more array BIF's to sort a list!

Sets are incredibly useful when we need to ensure that no duplicate records can be created, like if we wanted to store a list of user ID cards.

![ID Cards](images/ids.jpg)

## Methods

| Name | Description |
| - | - |
| Add(el) | Inserts an element into the set |
| Remove(el)  | Removes an element from the set |
| Member(el) | Check if an element is contained in the set |
| Size() | Get the size of the set |

## Efficiency of Common Operations

| Operation | Time Complexity |
| - | - |
| Add | O(1) |
| Remove  | O(1) |
| Member | O(1) |
| Size | O(1) |

## Where would you use it

Sets are useful when we need to remove duplicate information, or perform common math operations such as union or intersect. It can be useful in cases such as:

* Preventing duplicates in a collection of objects
* Keeping track of records that should be unique, such as user accounts

## Example

```C#
Set<string> users = new Set<string>();

users.Add("Bob");
users.Add("Larry");
users.Add("Bob");
// ["Bob", "Larry"]

bool isSusanneRegistered = users.Member("Susanne");
// false

bool isBobRegistered = users.Member("Bob");
// true

users.Remove("Bob");
users.Add("Andy");
// ["Andy", "Larry"]
```

## Problem to Solve

Your challenge is to implement the set data structure in a program which allows us to create and maintain a mailing list. Most of the structure for the program is implemented, but you will need to implement the add, remove, and member functionality.

[The Problem](set/problem) - [Example Solution](set/example-solution)

---

[Previous Lesson: Queues](2-queue.md) - [Next Lesson: Linked Lists](4-linked-list.md)