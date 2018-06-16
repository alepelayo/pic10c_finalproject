## Translating a VectorStringClass from C++ to C#

### Daily Log:

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




