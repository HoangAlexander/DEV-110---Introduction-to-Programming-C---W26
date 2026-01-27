# Week 2: Calculator Lite - Study Notes

Alexander Hoang

## Understanding Data Types

**What are the four data types you used in this assignment?**
[List each data type (string, bool, int, double) and explain what kind of data each one stores]

Answer:
string: used to store words/non numberic characters such as names or yes/no.
bool: used to create true or false conditions such as checking for if the user is inputting decimals or whole numbers into the calculator.
int: an int is used to store whole numbers
double: stores a wide range of numbers, not limited to whole numbers, and can compute long decimal points without rounding like how floats do.

**Why did we use `double` instead of `int` for the calculations?**
[Explain the difference between int and double, and why double is better for this calculator]

Answer: An int only stores whole numbers, so when using decimal values, you would get a more percise calculation than using int.

**How do you convert a string to a boolean?**
[Explain how you converted the user's "yes/no" input into a true/false value]

Answer: I believe this question is asking conceptually rather than just asking for the code. To answer conceptually, you would take the yes or no value given by the user and return it into the boolean where it will run the inpute through the true or false statement. Ex: Will you be using decimal percision? If the user answers yes, then the boolean will continue the coding through the if statement of yes, using double.parse for the numeric values to be stored and calculated, rather than the else option for no which will just use doubleint for whole numbers.

## Challenges and Solutions

**Biggest challenge with this assignment:**
[What was the hardest part? Understanding data types, getting user input, performing calculations, formatting output, or handling division by zero?]

Answer: The biggest challenge would have to be testing the code because results are not indicated by syntax error if you wanted decimals to not be rounded, doing the standard debugging practice of expected results of inputs going in and out.

**How you solved it:**
[Explain what you did to overcome the challenge - reviewed documentation, asked for help, tested different approaches, etc.]

Answer: I kind of answered this question in the previous answer, but to elaborate further, the biggest change I did was change int.parse was to add (double) before it to have results for remainder and average, which can have decimal results from whole numbers. Also for results showing in decimals, it was much easier to just add double to remainder and average, which I ended up adding to the rest of the calculations to cover both conditions for the decimal percision scenario.  

**Most confusing concept:**
[What was hardest to understand? Parsing input, modulus operator, percentage formula, conditional formatting, or something else?]

Answer: I think the most confusing concepts for me would be tracking the number inputs and the results to match the intended outcome because you had to not only make sure the input values matched the correct data type going in such as a whole number or a decimal, but the outcome also matching the intended user expectation such as showing decimal value or percentages.

## Understanding Arithmetic Operations

**What is the difference between the modulus operator (%) and division (/)?**
[Explain what each operator does and give an example]

Answer:
% : returns the remainder value of a quotient (ex: 5%2 = 1)
/ : returns the quotient value (ex: 5/2 = 2 without the remainder)
**How do you calculate the average of two numbers?**
[Write the formula in your own words]

Answer: (num1+num2) / 2

**What is the formula for percentage difference?**
[Explain the formula you used: ((num1 - num2) / num1) * 100]

Answer: Im not really sure sure what to explain, so im just going to go into detail what each step means. The formula is taking the first user input value and subtracting the second user input value to give us the difference, which is then divided by the first number as the base value of 100% (ex: 100/100 = 1), then multiplying the results by 100 to give us the value in percentage form.

## Input and Output

**How do you read user input in C#?**
[Explain what Console.ReadLine() does and what type of data it returns]

Answer: Console.ReadLine() returns the user's input as a string, and from the string you can assign it to a variable.

**How do you convert string input to a number?**
[Explain the Parse methods you used, like double.Parse()]

Answer: I used double.Parse() to convert the user's input string into numbers. What this does is takes the string and Parse() goes ahead and checks if it can convert it into numberic text to place into the double tag.

**What is string interpolation and how did you use it?**
[Explain the $ symbol and curly braces {} in Console.WriteLine()]

Answer: String interpolation makes it so you can add code within your string outputs such as Console.WriteLine(). The $ sign allows edits withing the string field and the {} braces indicate where the code is to be inserted.

## Conditional Logic

**How do you format numbers with 2 decimal places vs whole numbers?**
[Explain the :F2 and :F0 format specifiers]

Answer: :F2 makes it so the value displays to the 2nd decimal place, while :F0 makes it so it only shows a whole number.

**Why is it important to check for division by zero?**
[Explain what happens if you try to divide by zero and how you handled it]

Answer: If you try to divide by 0, it will crash the program because in math you can't divide by 0 because it is undefined. To handle this I went ahead and made an "if" statement making sure (numx != 0)  the numberic value of num 1 and 2 does not equal 0 or else error message displays.

**How did you use the boolean variable to control formatting?**
[Explain how you used if/else to format output differently based on user preference]

Answer: What I specifically used the boolean variable for is to take the user's input to figure out which path in the code the program should take. In my case it was to determine if they were using percise decimals, if yes or no, would use double.Parse versus (double)Int.Parse.

## What I Learned

**Key takeaways from this week:**
[What are the 3-5 most important things you learned?]

1. double versus int
2. how to handle dividing by 0 to avoid crashing
3. debugging and testing properly for input, output, and intended outcome of a numberic program


**Which data type concept was most useful?**
[Explain which data type (string, bool, int, or double) you found most interesting and why]

Answer: double seems like the most importanct concept I learned because it just covers every single scenario of numeric input, output, and results.

**How does conditional formatting improve user experience?**
[Why is it helpful to let users choose decimal precision?]

Answer: It is helpful to let user's choose decimal precision because in certain scenarioes the user may want an intended format that requires decimals to be shown in the results. And in other scenarios sometimes the user just wants whole numbers to be displayed as the results. It all comes down with meeting customer demands.

## Testing and Debugging

**What test cases did you use to verify your program works?**
[List the different inputs you tested - positive numbers, negative numbers, decimals, zero, etc.]

Answer: I used positive numbers, negative numbers, decimals, zeros.
The one thing I'm on the fence about is using invalid inputs for the boolean yes or no. I used "o" which was caught by no being part of the else. I know we are not at the else if part yet so I decided to keep the coding simple.

**What bugs or errors did you encounter and fix?**
[Describe any errors you got and how you fixed them]

Answer: A bug I did encounter several times was the terminal locking up. I would keep restarting VSCode until eventually VSCode would not launch any more even on restart. I ended up looking online, and ended up uninstalling VSCode and reinstalling the latest version on their site, which solved the problem. No more locks and crashes.

There's also one error I received which was the Index being outside the bounds of the array. Im not really sure what I'm looking for because I used double for all my values.

## Time Spent

**Total time:** [6 hours and 50 minutes]

**Breakdown:**

-   Understanding data types: [1 hours]
-   Reading and parsing user input: [20 minutes]
-   Implementing arithmetic operations: [10 minutes]
-   Adding conditional formatting: [1 hours]
-   Handling division by zero: [20 minutes]
-   Testing and debugging: [2 hours]
-   Writing documentation: [2 hours]

**Most time-consuming part:** [Which aspect took the longest and why?]

Answer: Testing and debugging took awhile, because there was no syntax error to tell you the results not being displayed in the 2nd decimal place, or percentage, so you would have to manually scope and make sure the calculations and the displayed results were as intended.

As for the Writing the documentation process, I felt like week 2's set of study notes were much lengthier than week 1's.

## Reflection

**What would you do differently next time?**
[What would you change in your approach or code?]

Answer: I believe what I would do differently next time is do a brain storm and highlight the areas that would need special attention such as displaying correct results to display decimal points rather than just jump into coding and meeting the conditions as I go. This way it will save a bit of time of going back and adjusting code which will be difficult the more code you write.

**How does this assignment prepare you for more complex programs?**
[Why are these skills important for future programming tasks?]

Answer: This program really got me comfortable with variables, not only inputing them, but to display the intended output/results. I can see this being useful for future programing task as concepts such as variables are considered the basic building blocks of coding.  
