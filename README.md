Benjamin Shirk ST10081854
PROG7312 Part 3 POE README File

Visual Studio 2022 version coded in .NET Framework 4.8 
Windows Forms (.NET Framework)

How to open and compile project

Project will be in a github repository 

Github name - bbninja1

Project Name - bbninja1/BenjaminShirk_ST10081854_ProgPart1

Link - https://github.com/bbninja1/BenjaminShirk_ST10081854_ProgPart1.git

Once Openned the .sln file click the green play button to compile the project

OR Open File Submitted On VC learn. 

Open File "BenjaminShirk_ST10081854_POE_Final_Project"

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

Part1
------------
Window Forms
------------
Menu - This is the Main Page where the user can enter the replacing books game by clicking the button, along with a quit and help button. 

BookShelfGame - This is the Replacing Books game form. The Game consists of 10 call numbers that are randomly generated. The game requires you to order them into the correct order by using the
Up and Down button to order the books, you will need to click the callnumber book to be able to move the book up and down to order them. The cs file has an up and down method that allows the user to us the buttons for the game, refresh method, clear listbox method, 
enter/verify button that will check if the order is correct, listbox callnumberspopulation method, new game button that will reset the call numbers, and lastly a reset total score button.

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

Classes
--------

Replacing_Books Class - This class is where the creation of the lists and sorting of the lists. Method List will create the callnumbers and sortedlist is where the sorting comparrison
of the lists occur.

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

Library and Classes
-------------------

ListHandler Class with Dewey_Decimal class - This class in the library consists of the ToString class that will name the callnumbers in the correct order.

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

Extra/Gamification Features
-----

Resource File with 2 images

Gamification features added - Progress bar in the BookShelfGame that will indicate what percentage you got correctly ordered.
                            - Score/Total Score that will add up every game the user does. 
Aditional gamification feature - Timer to indicate user how long the user was on the game

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

Part 2
------------
Window Forms
------------

Addition of the Identifying_Areas_Game_Form - This is the Indentifying Area Game Form, The game will generate a question where the user must 
match the columns that will alternate between callnumbers and descriptions. The user must play the game to identify the correct callnumbers and 
descriptions and therefore memorize for the future games. 

The cs file consists of the less relevent buttons help, menu that will give you a help message and menu that will take you to the menu page.
There is the enter, reset score and next question button, the enter button will alter your score and progress bar depending on the score you get. 
The next question will generate a new question for you to play again. Reset score will bring your score to 0 again. 

This form has a CreateQuestion, SetUp Question, SetUpLeftAndRightColumn, these are methods that enable drag and drop and validate within 
the droping into the 4 list boxes. The Last relevent method is the ValidateAnswer that will check if the answer is correct and highlight
the text green for correct and red for incorrect and increase your score, This method makes use of the Validate Method in the Identifying_Areas Cass.

--------------------------------------------------------------------------------------------------------------------------------------

Classes
--------

Addition of the Identifying_Areas Class - This class is where the creation of the 2 Dictionaries, an int variable that will be used to alternate 
between the swapping of the columns to allow for matching between callnumbers and descriptions, an array that will hold the wrong answer. 

This class has 4 Methods - Generate Question which will generate a question with a possible correct answer and wrong answer and will use
the GetRandomIndex method to find the random index.

Shuffle Method will swap the lists/dictionary data to generate a different question when a new question is called.

Validation Method will check if the values match are correct.

--------------------------------------------------------------------------------------------------------------------------------------

Extra/Gamification Features
-----
Features are the same

Gamification features added - Progress bar in the Identifying Areas Game that will indicate what percentage you got correctly ordered.
                            - Score/Total Score that will add up every game the user does. 

Aditional gamification feature - Timer to indicate user how long the user was on the game

--------------------------------------------------------------------------------------------------------------------------------------

References
----------
ChatGPT was used on the Drag And drag-and-drop methods.

--------------------------------------------------------------------------------------------------------------------------------------

Part 3
------
Window Forms
------------

Addition of the FindingCallNumbers - This is the FindingCallNumbers Form, the finding call numbers game will use the dewy_decimal_dat.txt file
to get the necessary data to let the user navigate through the hierachy that has been generated and stored in the txt file. The game will be 
for the user to naviagte the hierachy correctly and learn on the way. 

The form consists of a 4 answer button that the user will use to navigate the hierachy, a description label that will show Class 1 of the hierachy and
the user will use to choose the correct button text to navigate and advance to Class 2 then of corse again to Class 3. 
Form also consists of a timer at the top that will show how long you are playin the game for and will reset once you start a new game that is also a button at the bottom.
Reset Score is also a button that will reset total and current score if you choose to. 
--------------------------------------------------------------------------------------------------------------------------------------

Classes
--------
The Finding Call Numbers class consists of methods : File Path, ReadToTree, Classes, Button Display, Shuffle Buttons, AssignButtonValues,
Validation, SetUpClass, Check Results, Add Buttons, Update Score, ResetScore, Timer, New Game.

FilePath - Method to find the file in bin Debug and store the data in a string array.

ReadToTree - Method that reads data from a file and populates a tree.

Classes - Method that generates the nodes for the classes(1-3)

Button Displays - Methods that display values on the provided buttons based on the given node class.

Shuffle Buttons - Method that shuffles the order of buttons randomly.

AssignButtonValues - Methods that assign values to buttons based on the first and second digits of the current key.

Validation - Methods to check if the first digit of the current key matches the first character of the provided text.

SetUpClass - Method to display classes (Class 2 and 3) as we go through the hierarchy.

Check Results - Methods that hold messages whether the user is correct or incorrect.

Add Buttons - Method to add answer buttons to the list of buttons.

Update Score - Method that will Update Score.

Reset Score - Method that Resets the Score and Labels.

Timer - Method that Sets Up the Timer.

New Game - Method that will generate a New Game and that will therefore re-start the form to generate a new game.

--------------------------------------------------------------------------------------------------------------------------------------

Extra/Gamification Features
-----
Features are the same plus 1 additional feature added

Gamification features added - Progress bar in the FindingCallNumbers game that will indicate what percentage you got correctly in the hierarchy.
                            - Score/Total Score that will add up every game the user does. 
                            - Added A Timer at the top to show how long the game has taken.

--------------------------------------------------------------------------------------------------------------------------------------

References
----------
ChatGPT was used for some of the comments on my code.
YouTube video was used to create the timer used on all my games

--------------------------------------------------------------------------------------------------------------------------------------
