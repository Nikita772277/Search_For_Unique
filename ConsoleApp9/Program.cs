
using ConsoleApp9;

WorkingWithStrings wws=new();
string[] strings = new string[] { "BbBb", "aaa", "aaaaa", "aA", "Aaaa", "aaaaaaa", "a" };
string[] strings2 = new string[] {""};
var unique= wws.SearchForAUnique(strings);
if (unique != null)
{
    foreach (string s in unique)
        Console.WriteLine(s);
}