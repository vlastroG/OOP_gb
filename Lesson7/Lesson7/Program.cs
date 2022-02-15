// See https://aka.ms/new-console-template for more information
using Lesson7;
char f = 'а';
var b = (int)f;
b++;
var c = (char)b;

ACoder g = new();
string s = "Stroganov_Владимир";
string j = g.Encode(s);
Console.WriteLine(j);
Console.WriteLine(g.Decode(j));
Console.ReadLine();

Console.WriteLine();
BCoder b1 = new();
Console.WriteLine(b1.Encode(s));
Console.WriteLine(b1.Decode(b1.Encode(s)));
Console.WriteLine();
Console.ReadLine();

