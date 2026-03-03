# Week 8: Mad Libs (Structure + Debugging) - Study Notes

**Name:** Alexander Hoang

## Program Structure

**What helper methods did you create (and what does each one do)?**
[List your methods and briefly describe each]

Answer: The helper methods I used were ChooseTemplate() for the initial menu that lets the user choose between 2 stories and returns StoryTemplate. I used CollectWords() which loops the template's prompts which would aquire the user's input and return each word as a string array. I used ReadYesNo() which confirms a true of false statement in the form of a y or n for the user. ReadIntInRange() was used to check the user's input and to keep asking until the input was withing the range of 1-2. ReadNonEmptyString() was used to keep asking the user for a valid input that was not empty or whitespace. StoryTemplate.GenerateStory() was used to check the word count to match the prompts and return it to the story. And StoryTemplate.FormatStory() was used to insert string.Format words into the template.

**Why is it helpful to move code out of `Main` and into helper methods?**
[Explain how this improves readability and reduces bugs]

Answer: The main things is readability and reduces bug potential. Readability and reducing bug potentials are all tied to the amount of code written in a method. If a method is jam packed, its equivilant of reading through a whole dictionary rather than narrowing down the program to specific key words. Round about way of saying less code to skim through visually and check.

## Data Modeling

**What is the purpose of the `StoryTemplate` class in this assignment?**
[Explain what data it stores and why]

Answer: The StoryTemplate stores options such as, titles, prompts, and placeholders such as {0,1....} which is used to tell a customized story from the user's inputs. 

**How did using a template make it easier to support two different stories?**
[Explain how the same logic can work with different prompts/text]

Answer: Because program logic remains the same, the only difference would be adding new template values for the second story. This is done so because CollectWords and GenerateStory are still used regardless of which template is chosen.

## Testing and Debugging

**Where did you set a breakpoint while debugging this program (what line or method)?**
[Be specific - example: inside GenerateStory, at the beginning of CollectWords, etc.]

Answer: The first breakpoint I used was at the begining of CollectWords to make sure the prompts were in the correct order and made sense. I also used a breakpoint inside Generate Story to confirm the words matched the appropriate array Prompts.Length before formatting.

**What did you learn from stepping through your code line by line?**
[Describe how watching execution helped you understand flow or find bugs]

Answer: Stepping through code line by line helped me follow the programs logic. As the program ran slowly, it made it easier to spot bugs and to understand user flow, not just expected outcomes.

**What bug or logic mistake did you encounter (and how did you fix it)?**
[Describe a real issue you ran into and how breakpoints/stepping helped]

Answer: One mistake I ran into was adding "a" in my CollectWords so it read "Enter a" which caused a hiccup on the user side when reading a promp such as "Enter a a Noun"

## What I Learned

**Key takeaways from this week:**
[3 main things you learned]

1. Importance of helper methods
2. Coding outside of Main
3. Using Classes to organize code

**What part of this assignment helped you understand program structure the most?**
[Breaking into methods, using public/private methods, separating concerns, etc.]

Answer: Just like the key take aways, I would say breaking down the program into smaller helper methods made the code easier to read and debug.

## Time Spent

**Total time:** 8 hours

**Breakdown:**

- Planning structure (methods/classes): [30 minutes]
- Input validation: [2 hours]
- Story templates + formatting: [2 hours]
- Testing and debugging: [3 hours]
- Writing documentation: [1 hour]

**Most time-consuming part:** [Which aspect took the longest and why?]

Answer: Testing and debugging most likely took the longest, because it was the first time in this class that I had to write a program outside of 1 class with multiple methods, prompts, and writing a story. Which meant I had to test all the values and made sure it worked as intended and made sense from the user's side as well.

## Reflection

**What would you improve if you had more time?**
[Ideas: more templates, better formatting, more validation, etc.]

Answer: I would most likely improve the quality of the prompts to ask the user more specified questions in order to get a more cohesive story.

**How did breaking your program into smaller parts help you debug?**
[Explain the connection between structure and debugging]

Answer: Looking back at it now, instead of testing everything at once, and causing a chain of debugging and fixes, breaking the code into smaller parts, made the process more digestable. I would imagine the testing and debugging would take even longer and grueling.
