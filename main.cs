using System;
using System.Text;



class Program
{
  
static bool DaLiJeRec(string s)
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