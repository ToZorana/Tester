using System;
using System.Text;

// Da li je uneti string reč?

class Program
{
  
static bool Rec(string s)
{
  foreach(char c in s)
    if(!char.IsLetter(c)) return false;
  return true;
}
	
	static void Main()
	{
		Console.WriteLine("Unesite jednu rec: ");
    string rec = Console.ReadLine();
    while(!DaLiJeRec(rec)) 
    {
      Console.WriteLine("Greska ");
      rec = Console.ReadLine();
    }
	}
}