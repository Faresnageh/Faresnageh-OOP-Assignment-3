# Task 2.1

## IReadOnlyDictionary

**What is it?**

It is like a dictionary that allows reading data only

**How is it different from Dictionary?**

Dictionary allows adding removing and changing data

IReadOnlyDictionary allows reading the data but does not allow changing it through this interface

**Why would a public method return IReadOnlyDictionary instead of Dictionary?**

To let the caller read the data without allowing them to modify it

---

## SortedDictionary

**What is it?**

It is a dictionary that keeps its items sorted by key

**How is it different from Dictionary in ordering?**

Dictionary does not keep items sorted by key

SortedDictionary keeps them sorted automatically

**How is lookup speed different?**

Dictionary lookup is usually O(1) average

SortedDictionary lookup is O(log n)

**When would you choose SortedDictionary?**

When I need the items to always stay sorted by key

---


## Task 2.2

S1 => Dictionary
Fast lookup by national ID

S2 => HashSet
Tags must be unique

S3 => List
Keeps insertion order and allows repeated grades

S4 => IReadOnlyDictionary
Caller can read the prices but cannot modify them

S5 => SortedDictionary
Keeps sessions sorted by start time

S6 => IEnumerable
Good for looping once and stopping early