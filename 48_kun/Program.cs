// C# STRING METODLARI: TA'RIF + KOD NAMUNALARI

using System;
using System.Text;

class Program
{
    static void Main()
    {
        // 🔹 1. Tekshiruvchi metodlar

        string s = "  Salom, Dunyo!  ";
        Console.WriteLine(s.Contains("Dunyo"));                // true
        Console.WriteLine(s.StartsWith("  Sa"));               // true
        Console.WriteLine(s.EndsWith("!  "));                  // true
        Console.WriteLine(s.Equals("  Salom, Dunyo!  "));     // true
        Console.WriteLine(string.IsNullOrEmpty(s));            // false
        Console.WriteLine(string.IsNullOrWhiteSpace("   "));  // true

        // 🔹 2. O‘zgartiruvchi metodlar

        Console.WriteLine(s.ToLower());         //   salom, dunyo!
        Console.WriteLine(s.ToUpper());         //   SALOM, DUNYO!
        Console.WriteLine(s.Trim());            // Salom, Dunyo!
        Console.WriteLine(s.TrimStart());       // Salom, Dunyo!
        Console.WriteLine(s.TrimEnd());         //   Salom, Dunyo!
        Console.WriteLine(s.Replace("Dunyo", "Olam")); //   Salom, Olam!
        Console.WriteLine(s.Remove(2, 5));       //   lom, Dunyo!
        Console.WriteLine(s.Insert(2, "Hello ")); //  Hello Salom, Dunyo!
        Console.WriteLine(s.PadLeft(25, '*'));  // *****  Salom, Dunyo!
        Console.WriteLine(s.PadRight(25, '-')); //   Salom, Dunyo!  -------

        // 🔹 3. Ajratuvchi va birlashtiruvchi metodlar

        string[] parts = s.Split(',');
        foreach (var part in parts)
            Console.WriteLine(part); // "  Salom" va " Dunyo!  "

        string[] words = { "Hello", "World" };
        Console.WriteLine(string.Join("-", words));     // Hello-World
        Console.WriteLine(string.Concat("A", "B", "C")); // ABC
        Console.WriteLine(string.Format("{0} + {1} = {2}", 2, 3, 5)); // 2 + 3 = 5

        // 🔹 4. Qidirish va indexlash

        Console.WriteLine(s.IndexOf("Dunyo"));    // 9 (bo'shliqlar hisoblanadi)
        Console.WriteLine(s.LastIndexOf("o"));    // oxirgi o harfining indexi
        Console.WriteLine(s.Substring(2, 5));      // "Salo"

        // 🔹 5. Maxsus metodlar

        char[] chars = s.ToCharArray();
        Console.WriteLine(chars[3]);  // 'l'

        string n = "é";  // e + accent
        string norm = n.Normalize();
        Console.WriteLine(norm);

        string a = "Apple";
        string b = "Banana";
        Console.WriteLine(a.CompareTo(b)); // -1 (Apple < Banana)

        object clone = s.Clone();
        Console.WriteLine(clone); // "  Salom, Dunyo!  "

        // 🔹 6. StringBuilder bilan bog‘liq

        StringBuilder sb = new StringBuilder("Salom");
        sb.Append(", Dunyo");
        sb.Insert(6, "Aziz ");
        sb.Replace("Dunyo", "Olam");
        sb.Remove(0, 6);
        Console.WriteLine(sb); // Aziz Olam
        sb.Clear();
        Console.WriteLine("After clear: '" + sb.ToString() + "'"); // Bo'sh
    }
}
