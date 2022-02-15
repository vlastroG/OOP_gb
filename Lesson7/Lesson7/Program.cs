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

