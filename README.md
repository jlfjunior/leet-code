# LeetCode

## Arrays

An **array** is a data structure that represents a collection of elements of the same data type stored in
contiguous memory locations, allowing constant-time access by index.

---

### Common Operations

- **Traversal:** Accessing each element in the array sequentially.
- **Insertion:** Adding a new element at a specific position (may require shifting elements).
- **Deletion:** Removing an element from a specific position (may require shifting elements).
- **Search:** Finding the index of a specific element (linear or binary search, depending on the context).
- **Access by Index:** Retrieving an element directly using its index.
- **Update by Index:** Modifying an element directly using its index.

---

### Solved Problems

| #  | Problem               | Difficulty | Solution                                                             | Pattern                 | Link |
|----|-----------------------|------------|----------------------------------------------------------------------|-------------------------|------|
| 1  | Two Sum               | Easy       | [`TwoSum.cs`](./LeetCode/Arrays/TwoSum.cs)                           | Hash Table, Brute Force | https://leetcode.com/problems/two-sum/ |
| 14 | Longest Common Prefix | Easy       | [`LongestCommonPrefix.cs`](./LeetCode/Arrays/LongestCommonPrefix.cs) | Vertical Scanning       | https://leetcode.com/problems/longest-common-prefix/ |
| 26 | Remove Duplicates     | Easy       | [`RemoveDuplicates.cs`](./LeetCode/Arrays/RemoveDuplicates.cs)       | Two Pointer             | https://leetcode.com/problems/remove-duplicates-from-sorted-array/ |
| 27 | Remove Element        | Easy       | [`RemoveElement.cs`](./LeetCode/Arrays/RemoveElement.cs)          | Two Pointer             | https://leetcode.com/problems/remove-element/ |

## Techniques

### Two Pointers
The Two-Pointers technique is a strategy that uses two indices (pointers) to traverse a data structure—such as an array, list, or string—in a coordinated way.