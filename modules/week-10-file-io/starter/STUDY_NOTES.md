# Week 10: Habit Tracker (File I/O) — Study Notes

**Name:** Alexander Hoang

## File I/O — Reading

**What does `File.ReadAllLines` return, and how did you use it?**
[Think about the return type and what you did with each element]

Answer: File.ReadAllLines return all strings within the array. I used it to read all lines in Habits.csv and looped each line to output stings for the user to view as coherrent with commas to read the habit's name, status and frequency.

**Why is it important to skip blank lines when reading a CSV file?**
[What would happen if you tried to split an empty string on `','`?]

Answer:It is important to skip blank lines because it can cause an error when accessing the index. For each blank line, it would count it as a value ex: habit[1] or habit[2].

## File I/O — Writing

**What does `File.WriteAllLines` do, and what arguments does it take?**
[Describe the path argument and what goes in the string array]

Answer: File.WriteAllLines writes text to habits.csv. Specifically it takes the file path and save all parts of the string to each line of the array.

**What is `Select(...).ToArray()` doing in `SaveHabits`?**
[Break down the two steps: what does `Select` produce, and why call `ToArray()`?]

Answer: Select(...) goes through each habit and formats it into a string to match the CSV line. ToArray() is used to convert the csv line into a string which is then used by File.WriteAllLines.

## Exception Handling

**What is a `FileNotFoundException` and when does it occur?**
[Describe the scenario where C# throws this specific exception]

Answer: FileNotFoundException is an error given when C# tries to read a file that does not exist. Commonly occurring through mispelling or incorrect pathing.

**Why do we catch `FileNotFoundException` specifically instead of using `catch (Exception)`?**
[Think about what catching all exceptions can hide from you]

Answer: We catch FileNotFoundException to specify the implication of mispelling or incorrect file directory pathing. The reason why umbrellaing it under the same "catch (Exception)" is not ideal, because when the problem occurs, we would not know specifically what is causing the error and it would fall under the same debugging troubleshooting as all other errors. In short, time saver.

## What I Learned

**Key takeaways from this week:**
[List 3 main things you learned]

1. FileNotFoundException handy usage
2. FileRead and WriteAllLines to format and output strings back and forth between user input and the array
3. Integrating an array through a csv and having it work with the main program.cs

**What was the trickiest part of this assignment and how did you work through it?**

Answer: The trickiest part was testing and debugging. Instead of the program automatically accessing the csv file, the user would have to input the name and path of the csv file correctly. If you went too quickly you could actually continue the program even if you didnt load the file.

## Time Spent

**Total time:** 4 hours

**Breakdown:**

- Understanding the starter code and CSV formats: 1 hours
- Implementing LoadHabits: 30 minutes
- Implementing PrintHabits / PrintSummary: 10 minutes
- Implementing AddHabit / UpdateHabit / SaveHabits: 50 minutes
- Testing and debugging: 1 hours
- Writing study notes: 30 minutes

**Most time-consuming part:**

Answer: The most time-consuming part was testing and debugging. Not only did you have to test the code, but also the function of each program. Then the same time spent would also accumulate with debugging.
