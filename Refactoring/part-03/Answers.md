# Part 03 — answers

---

## BlockedUsers

- Time complexity before: O(n^2)
- Time (ms) before: 33 ms
- What did you change?
I changed the blocked IDs collection from List<int> to HashSet<int> to make Contains faster

- Time complexity after: O(n)
- Time (ms) after: 0 ms

---

## Students

- What was the problem?
The method created 1,000,000 students even when only the first 3 were needed

- What did you change?
I changed the method to return IEnumerable<Student> and used yield return to create students only when they are needed