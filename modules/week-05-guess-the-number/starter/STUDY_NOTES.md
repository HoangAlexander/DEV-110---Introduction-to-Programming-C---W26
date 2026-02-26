# Week 5: Guess the Number - Study Notes

**Name:** Alexander Hoang

## Loop Types

**How is a `do-while` loop different from a `while` loop?**
[Explain when each loop is best used]

Answer: A do-while loop is used after execution and a while loop is used before execution. When to use a do-while loop is when you need to run the loop as a mandatory execution, otherwise a while loop is used for the alternative.

**Where did you use a `do-while` loop in this assignment and why?**
[Describe the input validation use]

Answer: I am still not farmiliar with do-while loops and thought this would be the most comfortable place to integrate it into the program. I used a do-while input when executing a playAgainInput loop as it seemed like the loop would be running in all scenarios of the program.

**Where did you use a `while` loop and why?**
[Describe the guessing loop]

Answer:I used a while loop during the secret number guess to loop the player back into guessing the number if high, low, or correct as there were multiple conditions to cover and a while loop would be the best fit.

**Where did you use a `for` loop and why?**
[Describe the rounds loop]

Answer:I used a for loop when implementing the rounds played counter, returning the rounds into the int and keeping track. I believe a for loop is best here because there was only 1 condition to fullfill which was returning the rounds value into the totalRoundsPlayed.

## Input Validation

**Why did you create a helper method for input validation?**
[Explain how it avoids repeating code for max value and rounds]

Answer: To keep the user inputs within the scope of the parameter's set so it would be covered and processed through the guessing number loop. Without the helper method, it would be extra work to write out all the different inputs the user could type out which would result in a returned output of invalid input for each scenario.

**How did you make sure the max value was between 10 and 100?**
[Explain your range check logic]

Answer: I used an if statement to return the user's input into 1, 2, or 3 in which those values returned would execute the program down the correct path for their respective if, elseif, and else statement covering a range of 1-10 for "1" 1-50 for "2" and 1-100 for "3." Although 1 is not used in each parameter, because 1 is static, I just defined the minimum value as 1.

**How did you make sure the number of rounds was between 1 and 3?**
[Explain your range check logic]

Answer: When defining each of my difficulty inputs, alongside the maximum value, I also had a parameter paired for either 1,2, or 3 rounds.

**How did you handle invalid input (non-numbers)?**
[Explain how int.TryParse works]

Answer: I used int.TryParse in my while loop when the user would need to guess the secret number. When the user inputs letters or numbers, int.TryParse will run it through a true or false for if the input is valid and will return the value outside of the method using out. If not, then the program will loop and ask the user for an input again and loop until a valid entry is provided, avoiding a crash.

## Guessing Logic

**How did you compare the guess to the secret number?**
[Explain the if/else logic for too low, too high, and correct]

Answer: I just used a simple too low and too high as referenced in the assignment as I felt it was straight foward. As for logic, I just used an if/else logic to filter the user's input compared to the secret number. (guess <,>,= secretNumber) And depending on which path is taken would output a Console.Write.Line() to the user hinting them towards the secretNumber, low, high.

**How did you count the number of guesses?**
[Explain where you incremented the counter]

Answer: I just set a variable as guessCount to 0 and when the user would enter their inputs to guess it would trigger the counter by the logic guessCount++

## Random Numbers

**How did you generate the secret number?**
[Explain Random and Next(min, max)]

Answer: I just used new Random.Next(1,maxValue + 1) to create the secret number to fit the perameter's set by the previous user decision/inputs.

**Why does `Random.Next(1, max + 1)` include the max value?**
[Explain why +1 is needed]

Answer: A +1 is needed to include the max value in Random.Next() because inside the parameters it takes the first number as where it starts and the 2nd number as where to stop; by adding a 1 it will include the max value.

## Testing and Debugging

**What inputs did you test to confirm your loops worked correctly?**
[List several test cases]

Answer: I used negative numbers, letters, decimals, and symbols.

**What bugs or errors did you encounter and fix?**
[Describe any logic or loop errors]

Answer: An error I encountered was using Random.Next() and forgetting the new in front of it, which caused an error. The longest error to solve was making sure the farewell loop executed at the correct timing, I positioned it incorrectly so it kept looping after each round.

## What I Learned

**Key takeaways from this week:**
[3-5 main things you learned]

1. While Loops
2. new Random.Next()
3. For Loops
4. Do-While Loops
5. <variable>++

**Which loop felt most natural to use and why?**

Answer: While Loops were the most naturaly because of terms of familiarity and the first loop learned.

## Time Spent

**Total time:** [8 hours]

**Breakdown:**

- Planning the loops: [1 hours]
- Input validation: [3 hours]
- Guessing logic: [1 hours]
- Testing and debugging: [2 hours]
- Writing documentation: [1 hours]

**Most time-consuming part:** [Which aspect took the longest and why?]

Answer: Input validation most likely took the longest because for the first time in this class I was writing a multipart program with multiple loops, and with each pathway I would have to test each path for each loop and multiple times to test counters.

## Reflection

**What would you do differently next time?**

Answer: Perhaps familiarize myself with for loops and do-while loops more so I could integrate them into my projects more seemlessly, rather than defaulting to while loops.

**How did using three different loop types improve your understanding of repetition?**

Answer: Using different kinds of loops improved my understanding of which repetition scenario would save lines of code when implementing the correct type of loop for the given condition.
