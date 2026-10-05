# Generics Answers

---

## Step 2

**What is the same between the two stores?**

Both stores use a List and have the same methods

Add  
GetById  
GetAll  
Remove

**What is different?**

StudentStore works with Student objects

CourseStore works with Course objects

---

## Step 3

**Compiler error**

'T' does not contain a definition for 'Id' and no accessible extension method 'Id' accepting a first argument of type 'T' could be found (are you missing a using directive or an assembly reference?)

**Why does the compiler reject it?**

Because T can be any type and the compiler does not know that T has an Id property

The same error appears in GetById and Remove because both methods use Id