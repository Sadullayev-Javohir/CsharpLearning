using System;
using System.Text.RegularExpressions;

class Program
{
  static void Main()
  {
    // Console.WriteLine(Regex.IsMatch("abc123def", @"\d{3}"));
    // Console.WriteLine(Regex.IsMatch("@#5@!()", @"\w*"));
    // Console.WriteLine(Regex.IsMatch("ab_-a", @"^\W$"));
    // Console.WriteLine(Regex.IsMatch("color", @"colou?r"));
    // Console.WriteLine(Regex.IsMatch("colour", @"colou?r"));
    // Console.WriteLine(Regex.IsMatch("gray", @"gr[ae]y"));
    // Console.WriteLine(Regex.IsMatch("grey", @"gr[a?e]y"));
    Console.WriteLine(Regex.IsMatch("#", @"[^abc]"));

  }
}
