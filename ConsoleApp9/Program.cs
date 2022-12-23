
using ConsoleApp9;

WorkingWithStrings wws=new();
string[] strings = new string[] { "Aa", "aaa", "aaaaa", "BbBb", "Aaaa", "aaaaaaa", "a" };
string[] strings2 = new string[] {""};
var unique= wws.SearchForAUnique(strings2);
if (unique != null)
{
    foreach (string s in unique)
        Console.WriteLine(s);
}