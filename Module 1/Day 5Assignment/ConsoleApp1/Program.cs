// See https://aka.ms/new-console-template for more information
Console.WriteLine(int.MaxValue);

/*01 Introduction to C# and Data Types
Understanding Data Types
Test your Knowledge
1. What type would you choose for the following “numbers”?
A person’s telephone number: String
A person’s height: int
A person’s age: int
A person’s gender (Male, Female, Prefer Not To Answer): String
A person’s salary: double
A book’s ISBN: String
A book’s price: Decimal
A book’s shipping weight: double
A country’s population: double
The number of stars in the universe: double
The number of employees in each of the small or medium businesses in the
United Kingdom (up to about 50,000 employees per business): double
2.What are the difference between value type and reference type variables?: Value type contains own data, operation on one cannot affect the other, each is unique. Reference types store references to data, reference variables can refer same object
What is boxing and unboxing?: Boxing is value type --> object, unboxing is opposite
3. What is meant by the terms managed resource and unmanaged resource in .NET: umanaged resources arent controlled by garbage collector
4. Whats the purpose of Garbage Collector in .NET?: manages and allocates the release of memory automatically 
Playing with Console App
Modify your console application to display a different message. Go ahead and
intentionally add some mistakes to your program, so you can see what kinds of error
messages you get from the compiler. The more familiar you are with these messages, and
what causes them, the better you'll be at diagnosing problems in your programs that you /
didn't/ intend to add!
Using just the ReadLine and WriteLine methods and your current knowledge of variables,
you can have the user pass in quite a few bits of information. Using this approach, create a
console application that asks the user a few questions and then generates some custom
output for them. For instance, your program could generate their "hacker name" by asking
them their favorite color, their astrology sign, and their street address number. The result
might be something like "Your hacker name is RedGemini480."
Practice number sizes and ranges
1. Create a console application project named /02UnderstandingTypes/ that outputs the
number of bytes in memory that each of the following number types uses, and the
minimum and maximum values they can have: sbyte, byte, short, ushort, int, uint, long,
ulong, float, double, and decimal.
*/
Console.WriteLine(sbyte.MaxValue + " " + sbyte.MinValue);
Console.WriteLine(byte.MaxValue + " " + byte.MinValue);
Console.WriteLine(short.MaxValue + " " + short.MinValue);
Console.WriteLine(ushort.MaxValue + " " + ushort.MinValue);
Console.WriteLine(int.MaxValue + " " + int.MinValue);
Console.WriteLine(uint.MaxValue + " " + uint.MinValue);
Console.WriteLine(long.MaxValue + " " + long.MinValue);
Console.WriteLine(ulong.MaxValue + " " + ulong.MinValue);
Console.WriteLine(float.MaxValue + " " + float.MinValue);
Console.WriteLine(double.MaxValue + " " + double.MinValue);
Console.WriteLine(decimal.MaxValue + " " + decimal.MinValue);
/*
Composite Formatting to learn how to align text in a console application
2. Write program to enter an integer number of centuries and convert it to years, days, hours,
minutes, seconds, milliseconds, microseconds, nanoseconds. Use an appropriate data
type for every data conversion. Beware of overflows!
Input: 1
Output: 1 centuries = 100 years = 36524 days = 876576 hours = 52594560 minutes
= 3155673600 seconds = 3155673600000 milliseconds = 3155673600000000
microseconds = 3155673600000000000 nanoseconds
Input: 5
Output: 5 centuries = 500 years = 182621 days = 4382904 hours = 262974240
minutes = 15778454400 seconds = 15778454400000 milliseconds = 15778454400000000
microseconds = 15778454400000000000 nanoseconds
*/
int intVal;

Console.WriteLine("Enter a number of centuries: ");
String inputString = Console.ReadLine();
intVal = Convert.ToInt32(inputString);

Console.WriteLine(intVal + " centuries = " + (intVal*100) + " years " + (intVal * 100 * 365) + "days etc");
/*
Explore following topics
C# Keywords
Main() and command-line arguments
Types (C# Programming Guide)
Statements, Expressions, and Operators
Strings (C# Programming Guide)
Nullable Types (C# Programming Guide)
Nullable reference types
Controlling Flow and Converting Types
Test your Knowledge
1. What happens when you divide an int variable by 0?
Crash, error division by 0
2. What happens when you divide a double variable by 0?
Runs, gives infinity
3. What happens when you overflow an int variable, that is, set it to a value beyond its
range?
Flips it on opposite spectrum
4. What is the difference between x = y++; and x = ++y;?
y++ y variable is increased after, ++y y is increased before
5.What is the difference between break, continue, and return when used inside a loop
statement?
break will stop the loop, continue will continue, return counts as a break and will return whatever you want
6. What are the three parts of a for statement and which of them are required?
for(initialize; test; update)
7. What is the difference between the = and == operators?
single equals is an assignment, double equals is a comparator
8. Does the following statement compile? for ( ; true; ) ;
yes
9.What does the underscore _ represent in a switch expression?
replaces the default keyword to signify that it should match anything if reached
10. What interface must an object implement to be enumerated over by using the foreach
statement?
IEnumerator Interface
Practice loops and operators
1.FizzBuzzis a group word game for children to teach them about division. Players take turns
to count incrementally, replacing any number divisible by three with the word /fizz/, any
number divisible by five with the word /buzz/, and any number divisible by both with /
fizzbuzz/.
Create a console application in Chapter03 named Exercise03 that outputs a simulated
FizzBuzz game counting up to 100. The output should look something like the following
screenshot:
*/
int number = 100;

for(int i = 0; i < number; i++)
{
    if(i % 3 == 0 && i % 5 != 0)
    {
        Console.WriteLine("fizz");
    }
    else if(i % 5 == 0 && i % 3 != 0)
    {
        Console.WriteLine("buzz");
    }
    else if(i % 3 == 0 && i % 5 == 0)
    {
        Console.WriteLine("fizzbuzz");
    }
}
/*
What will happen if this code executes?
int max = 500;
for (byte i = 0; i < max; i++)
{
    WriteLine(i);
}
Write Line does not exist, needs Console.WriteLine
Create a console application and enter the preceding code. Run the console application
and view the output. What happens?
What code could you add (don’t change any of the preceding code) to warn us about the
problem?
Your program can create a random number between 1 and 3 with the following code:
int correctNumber = new Random().Next(3) + 1;
Write a program that generates a random number between 1 and 3 and asks the user to
guess what the number is. Tell the user if they guess low, high, or get the correct answer.
Also, tell the user if their answer is outside of the range of numbers that are valid guesses
(less than 1 or more than 3). You can convert the user's typed answer from a string to an
int using this code:
int guessedNumber = int.Parse(Console.ReadLine());
Note that the above code will crash the program if the user doesn't type an integer value.
For this exercise, assume the user will only enter valid guesses.
2. Print-a-Pyramid.Like the star pattern examples that we saw earlier, create a program that
will print the following pattern: If you find yourself getting stuck, try recreating the two
examples that we just talked about in this chapter first. They’re simpler, and you can
compare your results with the code included above.
This can actually be a pretty challenging problem, so here is a hint to get you going. I used
three total loops. One big one contains two smaller loops. The bigger loop goes from line
to line. The first of the two inner loops prints the correct number of spaces, while the
second inner loop prints out the correct number of stars.
*
***
*****
*******
*********
3. Write a program that generates a random number between 1 and 3 and asks the user to
guess what the number is. Tell the user if they guess low, high, or get the correct answer.
Also, tell the user if their answer is outside of the range of numbers that are valid guesses
(less than 1 or more than 3). You can convert the user's typed answer from a string to an
int using this code:
int guessedNumber = int.Parse(Console.ReadLine());
Note that the above code will crash the program if the user doesn't type an integer value.
For this exercise, assume the user will only enter valid guesses.
4. Write a simple program that defines a variable representing a birth date and calculates
how many days old the person with that birth date is currently.
int now = int.Parse(DateTime.Now.ToString("yyyyMMdd"));
int dob = int.Parse(dateOfBirth.ToString("yyyyMMdd"));
int age = (now - dob) / 10000;
For extra credit, output the date of their next 10,000 day (about 27 years) anniversary.
Note: once you figure out their age in days, you can calculate the days until the next
anniversary using int daysToNextAnniversary = 10000 - (days % 10000); .
5.Write a program that greets the user using the appropriate greeting for the time of day.
Use only if , not else or switch , statements to do so. Be sure to include the following
greetings:
"Good Morning"
"Good Afternoon"
"Good Evening"
"Good Night"
It 's up to you which times should serve as the starting and ending ranges for each of the
greetings.If you need a refresher on how to get the current time, see DateTime
Formatting. When testing your program, you'll probably want to use a DateTime variable
you define, rather than the current time. Once you're confident the program works
correctly, you can substitute DateTime.Now for your variable (or keep your variable and just
assign DateTime.Now as its value, which is often a better approach).
*/
Console.Write("Zzz,Good morning,Good afternoon,Good evening".Split(',')[DateTime.UtcNow.Hour % 20 / 6]);

/*
6.Write a program that prints the result of counting up to 24 using four different increments.
First, count by 1s, then by 2s, by 3s, and finally by 4s.
Use nested for loops with your outer loop counting from 1 to 4. You inner loop should
count from 0 to 24, but increase the value of its /loop control variable/ by the value of the /
loop control variable/ from the outer loop. This means the incrementing in the /
afterthought/ expression will be based on a variable.
Your output should look something like this:
0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24
0,2,4,6,8,10,12,14,16,18,20,22,24
0,3,6,9,12,15,18,21,24
0,4,8,12,16,20,24
Explore following topics
C# operators
Bitwise and shift operators
Statement keywords
Casting and type conversions
Fundamentals of garbage collection
$ - string interpolation
Formatting types in .NET
Iteration statements
Selection statements*/


/*02 Arrays and Strings
Test your Knowledge
1. When to use String vs. StringBuilder in C# ?
String is immutable, use stringbuilder if you want to change original string
2. What is the base class for all arrays in C#?
Array Class
3.How do you sort an array in C#?
using Array. Sort() method, sorting algorithms and using LINQ query
4.What property of an array object can be used to get the total number of elements in
an array?
length()
5. Can you store multiple data types in System.Array?
no
6. What’s the difference between the System.Array.CopyTo() and System.Array.Clone()?
clone will clone original array, same length. copty to adds to a preexisting array
Practice Arrays
1. Copying an Array
Write code to create a copy of an array. First, start by creating an initial array. (You can use
whatever type of data you want.) Let’s start with 10 items. Declare an array variable and
assign it a new array with 10 items in it.Use the things we’ve discussed to put some values
in the array.
*/
int[] array1 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
/*
Now create a second array variable. Give it a new array with the same length as the first.
Instead of using a number for this length, use the Lengthproperty to get the size of the
original array.
*/
int[] array2 = new int[array1.Length];
for (int i = 0; i < array1.Length; i++)
{
    array2[i] = array1[i];
    Console.WriteLine(array1[i] + " " + array2[i]);
}
/*
Use a loop to read values from the original array and place them in the new array.Also
print out the contents of both arrays, to be sure everything copied correctly.
2.Write a simple program that lets the user manage a list of elements.It can be a grocery list,
"to do" list, etc.Refer to Looping Based on a Logical Expression if necessary to see how to
implement an infinite loop. Each time through the loop, ask the user to perform an
operation, and then show the current contents of their list. The operations available should
be Add, Remove, and Clear. The syntax should be as follows:
+some item
- some item
--
Your program should read in the user's input and determine if it begins with a “+” or “-“ or
if it is simply “—“ . In the first two cases, your program should add or remove the string
given ("some item" in the example). If the user enters just “—“ then the program should
clear the current list. Your program can start each iteration through its loop with the
following instruction:
Console.WriteLine("Enter command (+ item, - item, or -- to clear)):");
3.Write a method that calculates all prime numbers in given range and returns them as array
of integers
*/
static int[] FindPrimesInRange(int startNum,int endNum)
{
    int arrLength = 0;
    int[] primes = new int[arrLength];
    for (int i = startNum; i < endNum; i++)
    {
        if(i <= 1 || i % 2 == 0)
        {
            arrLength++;
            primes = new int[arrLength];
            for (int k = 0; k < primes.Length; k++)
            {
                primes[k] = i;
            }
        }
    }
    
    return primes;
}

/*
4.Write a program to read an array of n integers (space separated on a single line) and an
integer k, rotate the array right k times and sum the obtained arrays after each rotation as
shown below.
After r rotations the element at position I goes to position (I + r) % n.
The sum[] array can be calculated by two nested loops: for r = 1... k; for I = 0... n - 1.
Input Output Comments
3 2 4 - 1 3 2 5 6 rotated1[] = -1 3 2 4
2 rotated2[] = 4 - 1 3 2
sum[] = 3 2 5 6
1 2 3 4 5 12 10 8 6 9 rotated1[] = 5 1 2 3 4
3 rotated2[] = 4 5 1 2 3
rotated3[] = 3 4 5 1 2
sum[] = 12 10 8 6 9
5.Write a program that finds the longest sequence of equal elements in an array of integers.
If several longest sequences exist, print the leftmost one.
Input Output
2 1 1 2 3 3 2 2 2 1 2 2 2
1 1 1 2 3 1 3 3 1 1 1
4 4 4 4 4 4 4 4
0 1 1 5 2 2 6 3 3 1 1
7.Write a program that finds the most frequent number in a given sequence of numbers.In
case of multiple numbers with the same maximal frequency, print the leftmost of them
Input Output
4 1 1 4 2 3 4 4 1 2 4 9 3 The number 4 is the most frequent(occurs 5 times)
7 7 7 0 2 2 2 0 10 10 10 The numbers 2, 7 and 10 have the same maximal
frequence(each occurs 3 times).The leftmost of them is 7.
Practice Strings
1.Write a program that reads a string from the console, reverses its letters and prints the
result back at the console.
Write in two ways
Convert the string to char array, reverse it, then convert it to string again
Print the letters of the string in back direction(from the last to the first) in a for-loop
Input Output
sample elpmas
24tvcoi92 29iocvt42
2.Write a program that reverses the words in a given sentence without changing the
punctuation and spaces
Use the following separators between the words: . , : ; = ( ) & [ ] " ' \ / ! ? (space).
All other characters are considered part of words, e.g.C++, a + b, and a77 are
considered valid words.
The sentences always start by word and end by separator.
C# is not C++, and PHP is not Delphi!
Delphi not is PHP, and C++ not is C#!
The quick brown fox jumps over the lazy dog / Yes! Really!!! /.
Really Yes dog lazy the over jumps fox brown / quick! The!!! /.
3.Write a program that extracts from a given text all palindromes, e.g. “ABBA”, “lamal”, “exe”
and prints them on the console on a single line, separated by comma and space.Print all
unique palindromes(no duplicates), sorted
Hi, exe ? ABBA! Hog fully a string: ExE.Bob
a, ABBA, exe, ExE
4.Write a program that parses an URL given in the following format:
[protocol]://[server]/[resource]
The parsing extracts its parts: protocol, server and resource.
The [server] part is mandatory.
The[protocol] and [resource] parts are optional.
https://www.apple.com/iphone
[protocol] = "https"
[server] = "www.apple.com"
[resource] = "iphone"
ftp://www.example.com/employee
[protocol] = "ftp"
[server] = "www.example.com"
[resource] = "employee"
https://google.com
[protocol] = "https"
[server] = "google.com"
[resource] = ""
www.apple.com
[protocol] = ""
[server] = "www.apple.com"
[resource] = ""
Explore the following Topics
Strings
Arrays
Using the StringBuilder*/
