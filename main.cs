using System;
using System.Text;

struct ParReci
{
	public string rec;
	public string prevod;
}

static bool DaLiJeRec(string s)
{
  foreach(char c in s)
    if(!char.IsLetter(c)) r
}

class Program
{
	static ParReci[] UcitajReci(int n)
	{
		ParReci[] _niz = new ParReci[n];
		for (int i = 0; i < n; i++)
		{
			string[] _red;
			bool _greska = true;
			while (_greska)
			{
				_greska = false;
				_red = Console.ReadLine().Split();
				if (_red.Length == 2)
				{
					if (_red[0].Length <= 50 && _red[1].Length <= 50)
					{
						_niz[i].rec = _red[0];
						_niz[i].prevod = _red[1];
					}
					else
					{
						_greska = true;
						Console.WriteLine("Greska. Ponovite unos.");
					}
				}
				else
				{
					_greska = true;
					Console.WriteLine("Greska. Ponovite unos.");
				}
			}
		}
		return _niz;
	}
	static string Zvezdice(string s)
	{
		char[] c = new char[s.Length];
		for (int i = 0; i < s.Length; i++)
			c[i] = '*';
		return new string(c);
	}
	static string Prevedi(string recenica, ParReci[] recnik)
	{
		StringBuilder prevod = new StringBuilder(recenica);
		string[] reci = recenica.Split();
		foreach (var rec in reci)
		{
			int ind = PronadjiRec(rec, recnik);
			if (ind != -1)
			{
				prevod.Replace(rec, recnik[ind].prevod);
			}
			else
			{
				prevod.Replace(rec, Zvezdice(rec));
			}
		}
		return prevod.ToString();
	}
	static int PronadjiRec(string rec, ParReci[] recnik)
	{
		int _ind = -1;
		for (int i = 0; i < recnik.Length; i++)
		{
			if (recnik[i].rec == rec) { _ind = i; break; }
		}
		return _ind;
	}
	static void Main()
	{
		int n;
		ParReci[] recnik;
		string recenica;

		Console.Write("Unesite broj reci u recniku: ");
		while (!int.TryParse(Console.ReadLine(), out n) || n < 0 || n > 100)
			Console.Write("Greska! Ponovite.\nUnesite broj reci u recniku: ");
		Console.WriteLine("Unesite recnik: ");
		recnik = UcitajReci(n);
		Console.Write("Unesite recenicu za prevod: ");
		while ((recenica = Console.ReadLine()).Length > 100)
			Console.Write("Greska! Ponovite.\nUnesite recenicu za prevod: ");
		Console.WriteLine("Prevod rečenice je: ");
		Console.WriteLine(Prevedi(recenica, recnik));
	}
}