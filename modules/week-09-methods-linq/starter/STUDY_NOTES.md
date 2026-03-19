# Week 9: Score Stats (Methods + LINQ) - Study Notes

**Name:** Alexander Hoang

## Methods and Decomposition

**Why is it helpful to break a program into small methods?**
[Think about readability, testing, and debugging]

Answer: Just like the previous program, breaking a program to smaller methods help with readability. As the amount of code is broken down into sections and distributed to designated methods, the quantity of code becomes digestable to read, test, and debug as the blocks of code are smaller.

## LINQ (Stats + Method Chaining)

**Which LINQ methods did you use for basic statistics?**
[Examples: Min, Max, Average, Count with predicates]

Answer: Min() was used to find the lowest score, Max() for the highest score, Average() for the average score, and Count() was used to figure out which scores passed or failed the entered threshold.

**Which LINQ methods did you chain together for reports?**
[Examples: Where + OrderByDescending, OrderByDescending + Take]

Answer: Some examples would be Where().OrderByDescending() to sort scores visually for the user to see failing and passing scores and OrderByDescending().Take() to get the top score.

**Why is it helpful to put score logic in a class (ScoreReport) instead of keeping everything in Program?**
[Think about organization, reuse, and readability]

Answer: I believe the reasons why we would seperate the score logic into its own class rather than keeping it in a program would be simular to the reasons we seperate programs into different methods. Outside of testing and debugging, the main reason would be clarity. The main program would be focused on running the program and handling user inputs, while ScoreReport can focus on all of the score analysis logic.

## What I Learned

**Key takeaways from this week:**
[3-5 main things you learned]

1. Breaking codes into multiple methods.
2. Seperating the main program into multiple classes.
3. Logic behind a main program and sub classes.
4. LINQ usage and logic
5.

**Which concept felt easiest (methods or LINQ) and why?**

Answer: Methods felt easier because it is the second time we used them.

## Time Spent

**Total time:** 4 hours

**Breakdown:**

- Understanding the starter code: 30 minutes
- Implementing the print methods: 1 hours
- LINQ method chaining: 1 hours
- Testing and debugging: 30 minutes
- Writing documentation: 30 minutes

**Most time-consuming part:** [Which aspect took the longest and why?]

Answer: Implementing print methods as well as LINQ method chaining took the longest as it was the newest concept learning for this week so it took some time to understand the logic and impliment them.

## Reflection

**What would you improve next time?**

Answer: Next time I would most likely try to impliment a gpa version of this.

**How did methods make this program easier to work on?**

Answer:As answered in the first question, methods made the program easier to work on due to the concept of breaking a code block into smaller code blocks for readability, testing, and debugging.
