/*
int a = 2;
int b = 3;
int c = 4;

double result = (double)(a + b + c) / 3;

Console.WriteLine(result);
*/

/*
int a = 2;
int b = 3;
int c = 4;

int result = a + b + c;
int result1 = a * b * c;

Console.WriteLine($"{result}, {result1}");
*/

Console.WriteLine("Ввыдите сумму: ");
double num = Convert.ToDouble(Console.ReadLine());

double ero = num * 62.6297;
double usd = num * 60.3116;
double kzt = num * 13.1186;
double cny = num * 85.3691;

Console.WriteLine($"{num} евро = {ero} руб");
Console.WriteLine($"{num} долл = {usd} руб");
Console.WriteLine($"{num} тенге = {kzt} руб");
Console.WriteLine($"{num} юаней = {cny} руб");
