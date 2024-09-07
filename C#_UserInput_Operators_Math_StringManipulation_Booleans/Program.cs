// See https://aka.ms/new-console-template for more information

/* USER INPUT */

// Console.ReadLine() to get user input.

Console.WriteLine("What's your Name?");

string myName = Console.ReadLine();

Console.WriteLine("My Name is: " + myName);

Console.WriteLine("What's your Age?");

// int myAge = Console.ReadLine(); Cannot implicitly convert type 'string' to 'int'.

int myAge = Convert.ToInt32(Console.ReadLine()); // Using one of the Convert.To methods

Console.WriteLine("My Age is: " + myAge);

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