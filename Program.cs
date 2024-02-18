
/*
int a = 18;
int b = 6;
int c = a + b;
Console.WriteLine(c);

 Output = 24


int a = 18;
int b = 6;
int c = a - b;
Console.WriteLine(c);

 Output = 24


int a = 18;
int b = 6;
int c = a * b;
Console.WriteLine(c);

Output = 108


int a = 18;
int b = 6;
int c = a / b;
Console.WriteLine(c);

Output = 3



//Order of operations
int a = 5;
int b = 4;
int c = 2;
int d = a + b * c;
Console.WriteLine(d);

//Output = 13


//Forcing different order of operations
int a = 5;
int b = 4;
int c = 2;
int d = (a + b) * c;
Console.WriteLine(d);

//Output = 18



int a = 5;
int b = 4;
int c = 2;
int d = (a + b) - 6 * c + (12 * 4) / 3 + 12;
Console.WriteLine(d);

//Output = 25


int a = 7;
int b = 4;
int c = 3;
int d = (a + b) / c;
Console.WriteLine(d);

//Output = 3 (3,66666)





int a = 7;
int b = 4;
int c = 3;
int d = (a + b) / c;
int e = (a + b) % c;
Console.WriteLine($"quotient: {d}");
Console.WriteLine($"remainder: {e}");

//quotient: 3
//remainder: 2




int max = int.MaxValue;
int min = int.MinValue;
Console.WriteLine($"The range of integers is {min} to {max}");

int what = max + 3;
Console.WriteLine($"An example of overflow: {what}");

//Output: The range of integers is -2147483648 to 2147483647
//An example of overflow: -2147483646




//double type
int a = 5;
int b = 4;
int c = 2;
int d = (a + b) / c;
Console.WriteLine(d);

//Output = 4 (in reality 4,5)

double a = 5;
double b = 4;
double c = 2;
double d = (a + b) / c;
Console.WriteLine(d);

//Output = 4,5


double a = 19;
double b = 23;
double c = 8;
double d = (a + b) / c;
Console.WriteLine(d);

//Output = 5,25


double max = double.MaxValue;
double min = double.MinValue;
Console.WriteLine($"The range of double is {min} to {max}");

//Output: The range of double is -1.79769313486232E+308 to 1.79769313486232E+308


double third = 1.0 / 3.0;
Console.WriteLine(third);

//Output = 0.333333333333333





//Decimal types

decimal min = decimal.MinValue;
decimal max = decimal.MaxValue;
Console.WriteLine($"The range of the decimal type is {min} to {max}");

//Output: The range of the decimal type is -79228162514264337593543950335 to 79228162514264337593543950335


//greater precision is with the decimal type:

double a = 1.0;
double b = 3.0;
Console.WriteLine(a / b);

decimal c = 1.0M;
decimal d = 3.0M;
Console.WriteLine(c / d);

//Output:
 0.333333333333333
 0.3333333333333333333333333333




// CHALLENGE FROM Work with decimal types:
write code that calculates the area of a circle whose radius is 2.50 centimeters.
Remember that the area of a circle is the radius squared multiplied by PI.
One hint: .NET contains a constant for PI, Math.PI that you can use for that value.
Math.PI, like all constants declared in the System.Math namespace, is a double value.
For that reason, you should use double instead of decimal values for this challenge.

You should get an answer between 19 and 20.

double radius = 2.50;
double pi = Math.PI;
Console.WriteLine(pi * (radius * radius));

//Output: 19.6349540849362

*/