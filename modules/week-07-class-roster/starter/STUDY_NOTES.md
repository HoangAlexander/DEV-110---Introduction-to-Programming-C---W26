# Week 7: Class Roster Builder (Arrays) - Study Notes

**Name:** Alexander Hoang

## Arrays and `count`

**What are “parallel arrays” and how did you use them in this assignment?**
[Explain how rosterNames and rosterCredits stay lined up by index]

Answer: Parallel arrays are 2 or more arrays in which the same index correlates with one another. Ex: rosterNames[0] is "Alex", then rosterCredits[0] is Alex's credit number "3.0" Both arrays share corresponding information related to each other using the same index number.

**What is the purpose of the `count` variable?**
[Explain how it tracks how many roster slots are “in use”]

Answer: count lets you keep track of how many students are occupied in the array. Due to the limit of 3 being in an array, our roser will let us know how many vaccancies are left if not full.

**Where did you use `count` in loops and why?**
[Explain why you loop 0..count-1 instead of using the full array length]

Answer: Count -1 helps us cover all the students in the array as the count starts at the minimum value of 0 and the ending number stops at 3. To count 3 slots you would normally need to add a 3-1 to include 3.

## Printing and Sorting

**How did you print the class roster using a `foreach` loop?**
[Describe building an array of roster lines and then printing each line]

Answer: Formating the strings using BuildRosterLines creates a string[] with size count and fills it using a for loop. When combining the student name and credits together. Then in the menu, to print, I used a forreach loop to go through each line in the array and printed each line with foreach without needing indexes.

**How did you sort the roster while keeping names and credits aligned?**
[Describe copying the used roster into new arrays and using Array.Sort on parallel arrays]

Answer: Just like in the prior questions about parallel arrays, i just used the same index number to keep the information in both array's to corolate the information of each student to the given index slot. As for sorting them with Array.Sort, i just had the desired sorting method as the lead returned value within the parameter. Ex: Array.Sort(sortedNames, sortedCredits) for Names and vise versa for Credits.

## What I Learned

**Key takeaways from this week:**
[3-5 main things you learned]

1. Parallel Arrays
2. Array.Sort
3. count
4. general Arrays
5. foreach Arrays

**Which loop felt most natural to use and why?**

Answer: The initial while loop was most natural to use due to it being the first loop I learned.

## Time Spent

**Total time:** 6.5 hours

**Breakdown:**

- Planning the arrays/menu: [30 minutes]
- Input validation: [2 hours]
- Add + print roster features: [1 hours]
- Sorting feature: [30 minutes]
- Testing and debugging: [2 hours]
- Writing documentation: [30 minutes]

**Most time-consuming part:** [Which aspect took the longest and why?]

Answer: Input Validation took the longest due to testing if the credits would align with the names and to test of they were parralell to each other. Which kind of blends into testing and debugging.

## Reflection

**What would you do differently next time?**

Answer: Next time I would have to code both arrays before testing, as it was counterproductive to test the program with only 1 array coded as I needed a parralel array to function.

**How did using `for` and `foreach` improve your understanding of arrays?**

Answer: Using for helped me understood the configurations of an array such as adding students. As foreach, it helped me understand the user experience more when viewing the array without an index needed.
