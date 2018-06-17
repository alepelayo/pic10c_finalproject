## C# Version of *Siete-y-Medio*

I decided to recreate the first assignment in C#. Although it is not a perfect replica, it still does
allow the user to play a dealer for money they are betting per round until either the player or the 
dealer run out of money completely.

Since I have been wanting to learn C# for the past year, I figured the best way to teach myself
was to go based off the one coding language I am already comfortable with. With that, I decided to
look into C++ projects I have already done in the past (either Pic 10B or Pic 10C) and recreate the
same project but in C#. Because the point of this project for me personally was to learn the basics
of C#, I decided to simply choose the first assignment done for Pic 10C, more specifically, the 
*Siete y Medio* card game. 

The directions of the game can be found more in depth here: 
http://pic.ucla.edu/~rsalazar/pic10c/assignments/hw1/index.html

And the repository for the C++ version of the game can be found here: 
https://github.com/alepelayo/pic10c_hw1.0.git

### Resources used for complete this project: 
1. Chan, James. _Learn C# in one day and Learn It Well_. 2017. Print.
2. Stack Overflow Links:
	- *How to read char from the console*: https://stackoverflow.com/questions/19860677/how-to-read-char-from-the-console
	- *Generating random, unique values C#*: https://stackoverflow.com/questions/14473321/generating-random-unique-values-c-sharp
	- *Using a Switch statement with Enum C#*: https://stackoverflow.com/questions/17760689/using-a-switch-statement-with-enum-c-sharp
	
3. Outside Links: 
	- *C# Switch Enum* from Dot Net Perls: https://www.dotnetperls.com/switch-enum
	- *enum(C# Reference)* from Microsoft: https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/enum

### Feeling a Little Short

Although the C# project is a working *Siete y Medio* game, it is still not a replica to it's C++ version.
I believe a big part of that was the lack of classes used in C# compared to that of the C++ version. Since
the original C++ version contained a Hand, Player, and Card class, it was much easier to break down the 
coding process and what exactly each class did. For the C# version on the other hand, only one Card class 
was used since C# does not always allow for other classes to be "friends" with earlier classes. Due to this
set back, I only used one Card class which holds all the cards in spanish alone.  

If given more time, I would definitely create and use a Hand class which would contain List<Card> , possibly
making it easier to display all the cards in one method (similar to a function in C++). I would also look more
into the possibily of making a .txt file with C# similarly to the C++ version. 

### Class Take-a-ways:

Although my project did not easily connect with class topics, I quickly learned the multiple things C# lacks
compared to C++: 
- C# does not use pointers unless used in an unsafe context, therefore does 
not use smart_pointers either.
 
	- As Microsoft states: 

	> "To maintain type safety and security, C# does not support pointer arithmetic, by default.
	> However, by using the unsafe keyword, you can define an unsafe context in which pointers can be used."

- Instead of outputting to the console using `cout <<` , C# uses `Console.WriteLine()` which automatically 
include `<< endl;` (or goes on the next bottom line) or `Console.Write()` if one wishes to stay in the same
line. 

- Although C# has access to for, while, and do-while loops similarly to C++, C# also has a foreach loop which
easily print all the elements of an array or list:
```
	 foreach(int i in ArrayOrListName)
		Console.Write(i);
```
- A big part of C# is the use of stl containers such as Lists. Although I did not use any for this specific
assignment, my experimental branch has an example of both an array and a list and how they are used in C#.

### Extra Comments About the Project Overall:

A huge part of this project was just playing with the language in general before actually starting the project
itself. If one wishes to see my experimentation with the language before coding the *Siete y Medio* game, 
it is all under the experimental branch while the coding for the actual card game is under master and attempt1 branches.


### Notes to self:

- Found out the difference between bin and obj folders as stated below:
	> The compilers create obj directories as a temporary files.
	> bin will contain a folder for each of your solution configuration 
	> (debug is the default) which contains the build outputs for your project.
		- source: https://stackoverflow.com/questions/1085637/two-folders-bin-and-obj-does-anyone-know-why
	
	- Unlike C++, C# does not have a designated output/input command (cout/cin)
