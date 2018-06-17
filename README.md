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

Resources used for complete this project: 
1. Chan, James. _Learn C# in one day and Learn It Well_. 2017. Print.
2. Stack Overflow Links:
	- *How to read char from the console*: https://stackoverflow.com/questions/19860677/how-to-read-char-from-the-console
	- *Generating random, unique values C#*: https://stackoverflow.com/questions/14473321/generating-random-unique-values-c-sharp
	- *Using a Switch statement with Enum C#*: https://stackoverflow.com/questions/17760689/using-a-switch-statement-with-enum-c-sharp
	
3. Outside Links: 
	- *C# Switch Enum* from Dot Net Perls:https://www.dotnetperls.com/switch-enum
	- *enum(C# Reference)* from Microsoft :https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/enum


### Notes to self:

- June 4th:
	- Found out the difference between bin and obj folders as stated below:
		> The compilers create obj directories as a temporary files.
		> bin will contain a folder for each of your solution configuration 
		> (debug is the default) which contains the build outputs for your project.
			- source: https://stackoverflow.com/questions/1085637/two-folders-bin-and-obj-does-anyone-know-why
	
	- Unlike C++, C# does not have a designated output/input command (cout/cin)

- June 15th:
	- Instead of couting variables using "<<", C# uses Console.WriteLine:
```C++
		int var = 10;
		C++: cout << var;
```C#
		C#: Console.WriteLine("{0}", var);

		Output for both is still just "10"
	- Lists/Arrays: 
		- Still treated similarly to C++, but instead of making a separate function to print all the elements out, we can simply use the following:
```C#		
			foreach(int i in ArrayOrListName)
				Console.Write(i); //or Console.WriteLine(i) to have each element in a different line




