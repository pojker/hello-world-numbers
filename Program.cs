
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
*/


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