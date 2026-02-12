# Week 3: Personal Profile Card - Study Notes

**Name:** Alexander Hoang

## Understanding Variables and Data Types

**What are the four main data types you used in this assignment?**
[List string, int, double, and bool - explain what each stores and give examples from your profile card]

Answer: string: used to store words/non numberic characters such as names or yes/no.
bool: used to create true or false conditions such as checking for if the user is inputting decimals or whole numbers into the calculator.
int: an int is used to store whole numbers
double: stores a wide range of numbers, not limited to whole numbers, and can compute long decimal points without rounding like how floats do.

**Why did you use `double` for GPA instead of `int`?**
[Explain the difference and why decimal precision matters for GPA]

Answer: I used double for GPA instead of int because the user would lose accuracy on their grade if I used int as GPA goes into decimal places beyond the hundreath, not viable for int which stores whole numbers.

**How did you convert the yes/no input into a boolean?**
[Explain the comparison operation you used]

Answer: I took the yes or no value given by the user and returned it into the boolean where it will run the input through the true or false statement. For this particular program, the true or false statements were: "Are you a full time student?" which took the user's input of yes/no, and "Is the user an honor student?" which was answered indirectly by asking the students gpa and running through a true =>3.5.

## Data Modeling Decisions

**How did you organize the information into logical groups?**
[Explain why you grouped certain pieces of information together (personal, academic, etc.)]

Answer: For visual clarity. Although I really wanted to take age and height and place it in the personal group.

**Which pieces of information did you calculate rather than ask for?**
[List the derived data: birth year, years to graduation, height conversion, honor status, age in months]

Answer: birth year, years to graduation, height conversion, honor status, age in months

**Why is it better to calculate birth year from age rather than ask for both?**
[Explain data consistency and reducing redundant input]

Answer: It is better to calculate birth year from age rather than ask for both because they both give the same value which will conflict in a duplicate in a value storage for "age." In practical terms, it's basically asking a person for their age twice in real life.

## Challenges and Solutions

**Biggest challenge with this assignment:**
[What was the hardest part? Type conversion, calculations, formatting, choosing data types?]

Answer: The hardest part in this assigment would be conversions and calculations. Seldom do I find myself calculating ages in month or converting height feet and inches to inches, so it threw me off a bit.

**How you solved it:**
[Explain your approach to overcoming the challenge]

Answer: The age in months conversion wasn't too difficult, just take the age value and multiply by 12 as each year has 12 months. The more tricky conversion would be height, which was ft+inches to inches. Which I would took my own height as a test value, and divided ft by 12 as there are 12 inches in a foot and add the remainder for total inches. Then I reversed the logic into creating a formula to convert inches into inch+ft.

**Most confusing concept:**
[What was hardest to understand? Type casting, modulus for height, boolean logic, or formatting?]

Answer: modulus for height

## Type Conversion and Calculations

**How do you convert string input to a number?**
[Explain Parse methods: int.Parse(), double.Parse()]

Answer: Took the user's age input as Console.ReadLine() and take the value and convert it into a value using int.Parse()

**What calculation did you use to convert height from inches to feet and inches?**
[Explain: feet = inches / 12, remaining = inches % 12]

Answer: In the program I used the inches of height provided by the user (which I don't know if anyone knows on top of their head) divided the inches by 12 because there are 12 inches in a foot, the used 2 variables to display ft from the quotent and inches through the remainder (heightInches / 12) for ft, (heightInches % 12) for inches remaining.

**How did you determine if someone is an honor student?**
[Explain the boolean comparison: gpa >= 3.5]

Answer: To determine if the user was an honor system, I used the boolean to determine a true or false statement being if their input gpa is greater or equal to 3.5 then they were an honor student, if not then they were not.

## Output Formatting

**How did you format the GPA to show exactly 2 decimal places?**
[Explain the :F2 format specifier]

Answer:This was a bit tricky, because the initial user value must be stored as a double to encompass all decimal values of their GPA. Then displaying the results I used :F2 to show the hundread decimal but does not change the original value of their GPA.

**How did you display different text based on whether someone is full-time or part-time?**
[Explain the conditional/ternary operator you used]

Answer: I didn't really use conditional operators in this program due to them being simular to booleans. I wanted to get more familiar with ternary operators because I have not used them before, and I was fond of the short lines of code that would essentially mimic a boolean. For if a person was full or part time, I would take their yes or no stringvariable and store it as a boolean, then create the ternary to output the correct string based on yes or no.

**What techniques did you use to make the output look organized?**
[Discuss alignment, spacing, section headers, borders]

Answer: Alignment, spacing, section headers, borders

## Real-World Data Modeling

**What other calculated fields could you add to a profile?**
[Think of other derived data: BMI from height/weight, time to birthday, etc.]

Answer: Percise dates for accurate outputs, such as a month day and year for birthday, or month day and year for expected graduation to incorperate days until graduation or days until birthdate.

**Why is choosing the right data type important in real applications?**
[Explain memory, precision, and type safety]

Answer: I didn't realize it in week2's assignment, but although doubles are convenient and can do everything an int does, it takes more memory and adds up. The rule of thumb is if the output or input requires the percision of a double, then use it, if not then use an int.

**How does this profile card relate to real-world applications?**
[Think about social media profiles, job applications, student records systems]

Answer: Any kind of data storage software, or application.

## What I Learned

**Key takeaways from this week:**
[What are the 3-5 most important things you learned about variables and data modeling?]

1.Booleans to Ternary
2.Ternary
3.Double input into an int.Parse() output
4.
5.

**Which data type was most challenging to work with and why?**
[Reflect on your experience with string, int, double, or bool]

Answer: bool, due to me challenging myself in figuring out how to make ternaries work.

**How does understanding data types help you write better programs?**
[Explain the benefits of type safety and appropriate data representation]

Answer: bool, and conditionals are important to understand due to them tying up loose ends preventing your program from crashing.

## Testing and Debugging

**What test cases did you use to verify your calculations?**
[List different inputs you tested - edge cases, typical values, etc.]

Answer: I used different ages which caused an error that I could not fix without changing the program to ask for more percise inputs from the user, such as age 14,15,24,25,34,35 would have a range of months that would be inaccurate in determining the user's birth year.

**What bugs or errors did you encounter and fix?**
[Describe any type conversion errors, calculation mistakes, or formatting issues]

Answer:An error I encountered was an inaccuracy in birth year prediction as mentioned above. Was not able to fix that.

**How did you validate that your data types were correct?**
[Explain how you checked that GPA, heights, ages worked correctly]

Answer: How I checked if GPA, heights, ages worked correctly was I broke down the input, output, and intended outcome. Then I compared the program to my manual calculations.

## Time Spent

**Total time:** [6 hours]

**Breakdown:**

-   Understanding data types and planning variables: [2 hours]
-   Collecting user input with correct types: [20 minutes]
-   Implementing calculations: [20 minutes]
-   Formatting output: [20 minutes]
-   Testing and debugging: [1 hours]
-   Writing documentation: [2 hours]

**Most time-consuming part:** [Which aspect took the longest and why?]

Answer: The longest aspect would most likely be Writing the documentation. I think the reason why would be trying to convert your program into bites of information to answer the quesitons.

## Reflection

**What would you do differently if you started over?**
[Consider variable names, calculation order, organization, etc.]

Answer: One thing I would do differently would be to make the output look more like a profile card. Most likely more borders around the perimeter to form a square.

**How does proper data modeling make programs easier to maintain?**
[Think about readability, consistency, and reducing errors]

Answer: It lets you identify pain points before you code, so you dont experience them as you code which would take longer to code if you have to back track. Basically readability, consistency, reducin errors, and efficency.

**What real-world system would you like to model next?**
[Shopping cart, game character, recipe calculator, etc.]

Answer: A game character would be really fun.
