
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
*/



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

