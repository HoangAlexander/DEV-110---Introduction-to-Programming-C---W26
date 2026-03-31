# Week 6: Text Menu App - Study Notes

**Name:** Alexander Hoang

## Loop Types

**How is a `do-while` loop different from a `while` loop?**
[Explain when each loop is best used]

Answer: A do-while loop is used after execution and a while loop is used before execution. When to use a do-while loop is when you need to run the loop as a mandatory execution, otherwise a while loop is used for the alternative.

**Where did you use a `do-while` loop in this assignment and why?**
[Describe how you validated the menu choice and numeric inputs]

Answer: The only instances of using the do-while loop was implementing a Ternary to validate if the input for was a true or false to an appropriate input value of being !ok, which would return as false to break the loop and continue the program.

**Where did you use a `while` loop and why?**
[Describe the menu loop and why it repeats]

Answer: I used a while to loop the program is the user does not input option 6 therefore the program keeps looping after each menu option that is not the exit option (6).

**Where did you use a `for` loop and why?**
[If you didn’t use a for loop, explain why it wasn’t needed]

Answer: Did not get to use a for loop because there was not an instance where a modifiable index was needed. Instead used int.Choice for the menu option as a returned variable for the program to execute the correct path.

## Input Validation

**Why did you create a helper method for input validation?**
[Explain how it avoids repeating code for multiple prompts]

Answer: To keep the user inputs within the scope of the parameter's set so it would be covered and processed. Without the helper method, it would be extra work to write out all the different inputs the user could type out which would result in a returned output of invalid input for each scenario.

**How did you validate the menu choice (1–6)?**
[Explain your range check logic and do-while loop]

Answer: Using the do-while loop was implementing a Ternary to validate if the input for was a true or false to an appropriate input value of being !ok, which would return as false to break the loop and continue the program.

**How did you handle invalid input (non-numbers)?**
[Explain how int.TryParse and double.TryParse work]

Answer: I used int.TryParse in my while loop when the user would need to input the width value for their banner. Implementing a Ternary, the input given would be validated as true or false throught he given parameters of the int.TryParse. That way the program can execute properly without error.

## String Operations

**Which string methods did you use across the different menu options?**
[List key methods like Trim, ToUpper, ToLower, Replace, Split, Join, Contains, PadLeft, PadRight, and formatting techniques]

Answer: I used Trim, ToUpper, ToLower, Split, Join, Contains, PadLeft, PadRight, and formatting techniques.

**Which four string methods did you demonstrate in Option 6 (String Analysis)?**
[Explain Equals with StringComparison, Substring, EndsWith, and IndexOf]

Answer: equals with string comparison, substring, endswith and IndexOf.

**What's the difference between string concatenation and interpolation?**
[Explain when you used each approach and which you prefer]

Answer: I prefer string interpolation to concatenation due to the amounts of "," and "+" in between the string Write.ConsoleLine which makes it hard to read compared to interpolation which removes the , and +.

## What I Learned

**Key takeaways from this week:**
[3-5 main things you learned]

1. Trim
2. Split
3. Join
4. PadLeft
5. PadRight

**Which loop felt most natural to use and why?**

Answer: While loops still seem more natural to do as it is the first loop I learned.

## Time Spent

**Total time:** 9 hours

**Breakdown:**

- Planning the loops: [1 hours]
- Input validation: [2 hours]
- String formatting: [1 hours]
- Testing and debugging: [3 hours]
- Writing documentation: [1 hours]

**Most time-consuming part:** [Which aspect took the longest and why?]

Answer: Testing and debugging, due to the size of the program and the different options that needed testing. (1-6)

## Reflection

**What would you do differently next time?**

Answer: I would probably try to use a for each loop for the menu option because it is static. Also I would like to practice more with foreach loops.

**How did using three different loop types improve your understanding of repetition?**

Answer: Using different loops really helped me get use to branching my options instead of defaulting to one. As of correlating it with repetition, I really grown to understand there isnt a loop that fits all, and each loop can meet each type of repetition such as a validation loop.
