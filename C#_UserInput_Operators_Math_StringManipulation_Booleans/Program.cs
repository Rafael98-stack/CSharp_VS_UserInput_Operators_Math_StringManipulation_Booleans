// See https://aka.ms/new-console-template for more information

/* USER INPUT */

// Console.ReadLine() to get user input.

//Console.WriteLine("What's your Name?");
//
//string myName = Console.ReadLine();
//
//Console.WriteLine("My Name is: " + myName);
//
//Console.WriteLine("What's your Age?");
//
//// int myAge = Console.ReadLine(); Cannot implicitly convert type 'string' to 'int'.
//
//int myAge = Convert.ToInt32(Console.ReadLine()); // Using one of the Convert.To methods
//
//Console.WriteLine("My Age is: " + myAge);

///////////////////////////////////////////////////////////////////////////////////////////////////////////////

/* OPERATORS */

// ARITHMETIC & ASSIGNMENT OPERATORS

// ARITHMETIC OPERATORS
// Operators are used to perform operations on variables and values.

/* 
 +	Addition	Adds together two values	x + y	

 -	Subtraction	Subtracts one value from another	x - y	

 *	Multiplication	Multiplies two values	x * y	
 	
 /	Division	Divides one value by another	x / y	

 %	Modulus 	Returns the division remainder	x % y	

 ++	Increment	Increases the value of a variable by 1	x++	

 --	Decrement	Decreases the value of a variable by 1	x--
 */

int myInt = 10;
int myInt2 = 10;
int myInt3 = 10;
int result = myInt + myInt2 + myInt3; // ADDITION 

Console.WriteLine("My Result ADDITION: " + result); // ADDITION 

result = myInt - myInt2; // SUBTRACTION

Console.WriteLine("My Result SUBTRACTION: " + result); 

result = myInt * myInt2; // MULTIPLICATION

Console.WriteLine("My Result MULTIPLICATION: " + result); 

result = myInt / myInt2; // DIVISION

Console.WriteLine("My Result DIVISION: " + result); 

result = myInt % myInt2; // MODULUS

Console.WriteLine("My Result MODULUS: " + result); 

result = myInt++; // INCREMENT

Console.WriteLine("My Result INCREMENT: " + result++); // INCREMENT

result = myInt--; // DECREMENT

Console.WriteLine("My Result DECREMENT: " + result--); // DECREMENT

// ASSIGMENT OPERATORS
// Assignment operators are used to assign values to variables.

myInt = 20;

myInt += myInt2; // +=

Console.WriteLine(myInt);

myInt -= myInt2; // -=

Console.WriteLine(myInt);

myInt /= myInt2; // /=

Console.WriteLine(myInt);

myInt *= myInt2; // *=

Console.WriteLine(myInt);

///////////////////////////////////////////////////////////////////////////////////////////////////////////////

// COMPARISON OPERATORS 
// Comparison operators are used to compare two values (or variables)

/* 
 ==	Equal to	x == y	

!=	Not equal	x != y	

>	Greater than	x > y	

<	Less than	x < y	

>=	Greater than or equal to	x >= y	

<=	Less than or equal to	x <= y
 */

Console.WriteLine((myInt > myInt2) + " " + "My Int: " + myInt + " My Int2: " + (myInt2));  // MAGGIORE DI, GREATER THAN ">" 

bool trueOrFalse = myInt <= myInt2; // MINORE O UGUALE DI, LESS THAN OR EQUAL TO "<="

Console.WriteLine(trueOrFalse);

Console.WriteLine(myInt != myInt2); // DIVERSO DA, NOT EQUAL "!="

///////////////////////////////////////////////////////////////////////////////////////////////////////////////

// LOGICAL OPERATORS 
// Logical operators are used to determine the logic between variables or values

/* 
 && 	Logical and	Returns True if both statements are true	
|| 	Logical or	Returns True if one of the statements is true	
!	Logical not	Reverse the result, returns False if the result is true	
 */

Console.WriteLine(myInt == 20 && myInt2 == 10); // AND "&&".  (TRUE && TRUE) TRUE

Console.WriteLine(myInt == 20 || myInt2 == 20); // OR "||".  (TRUE || FALSE) TRUE

Console.WriteLine(!(myInt == 20 && myInt2 == 10)); // NOT "!". (TRUE && TRUE) FALSE

///////////////////////////////////////////////////////////////////////////////////////////////////////////////

/* MATH */

// Allows to perform mathematical tasks on numbers

Console.WriteLine(Math.Max(myInt,myInt2)); // The Math.Max(x,y) method can be used to find the highest value of x and y 
 
Console.WriteLine(Math.Min(myInt, myInt2)); // The Math.Min(x,y) method can be used to find the lowest value of of x and y

int myInt5 = 25;

Console.WriteLine(Math.Sqrt(myInt5)); // The Math.Sqrt(x) method returns the square root of x

myInt5 = -25;

Console.WriteLine(Math.Abs(myInt5)); // The Math.Abs(x) method returns the absolute (positive) value of x

double myDouble6 = 99.99;

Console.WriteLine(Math.Round(myDouble6)); // Math.Round() rounds a number to the nearest whole number

///////////////////////////////////////////////////////////////////////////////////////////////////////////////

/* STRING MANIPULATION */

// Strings are used for storing text. A string variable contains a collection of characters surrounded by double quotes.

String myString = "BlaBla";



Console.WriteLine(myString + " " + myString.Length); // The length of a string can be found with the Length property

Console.WriteLine(myString.ToUpper() + " " + myString.ToLower());  // Returns a copy of the string converted to uppercase or lowercase

String myString2 = "WowWow";
String myConcatString = myString + " " + myString2; // The + operator can be used between strings to combine them. This is called concatenation

Console.WriteLine(myConcatString);

String myConcatString2 = string.Concat(myString, myString2); // String.Concat() method to concatenate two strings

Console.WriteLine(myConcatString2);

///////////////////////////////////////////////////////////////////////////////////////////////////////////////

// STRING INTERPOLATION 
// Another option of string concatenation, is string interpolation, which substitutes values of variables into placeholders in a string

string myStringInterpol = $"I say {myString} and then say {myString2}"; // "$" for Interpolation and "{}" with the variable inside to use it

Console.WriteLine(myStringInterpol + " " + $"then i say again {myString}");

///////////////////////////////////////////////////////////////////////////////////////////////////////////////

// ACCESS STRINGS
// Access the characters in a string by referring to its index number inside square brackets []

myString = "Marco";

// variable[x]
Console.WriteLine(myString[0] + " " + myString[1] + " " + myString[2] + " " + myString[3] + " " + myString[4]); // String indexes start with 0: [0] is the first character. [1] is the second character, etc

// Index.Of();
Console.WriteLine(myString.IndexOf("M")); // Find the index position of a specific character in a string, by using the IndexOf() method

// Substring(x)
Console.WriteLine(myString.Substring(3)); // Extracts the characters from a string, starting from the specified character position/index, and returns a new string. This method is often used together with IndexOf() to get the specific character position
