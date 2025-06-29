// class Program
// {
//   static void Main()
//   {
//     var sonlar = Enumerable.Range(1, 10);
//     // int sum = sonlar.Sum();
//     // int min = sonlar.Min();
//     // int max = sonlar.Max();
//     // double average = sonlar.Average();
//     // Console.WriteLine($"O'rtacha: {average:F2}");
//     // long juftSolarSoni = sonlar.LongCount(n => n % 5 == 0);
//     // Console.WriteLine(juftSolarSoni);
//   }
// }


// class Program
// {
//   static void Main()
//   {
//     var nums = new string[] { "23", "3", "4", "2", };
//     string birlashgan = nums.Aggregate((a, b) => a + ", " + b);
//     Console.WriteLine(birlashgan);
//   }
// }


// class Program
// {
//   static void Main()
//   {
//     var sonlar = Enumerable.Range(1, 5);

//     List<int> list = sonlar.ToList();

//     list.ForEach(Console.WriteLine);
//   }
// }

// class Program
// {
//   static void Main()
//   {
//     var sonlar = Enumerable.Range(1, 5);

//     int[] massiv = sonlar.ToArray();

//     foreach (var i in massiv)
//     {
//       Console.WriteLine(i);
//     }
//   }
// }


// class Program
// {
//   static void Main()
//   {
//     var ismlar = new[] { "Ali", "Vali", "Sami" };
//     var dic = ismlar.ToDictionary(ism => ism.Length, ism => ism);

//     foreach (var kv in dic)
//     {
//       Console.WriteLine($"Uzunligi: {kv.Key}, Ism: {kv.Value}");
//     }

//   }
// }

// class Program
// {
//   static void Main()
//   {
//     var ismlar = new[] { "Ali", "Vali", "Olim" };
//     var lookup = ismlar.ToLookup(ism => ism.Length);

//     foreach (var guruh in lookup)
//     {
//       Console.WriteLine($"Uzunlik: {guruh.Key}");
//       foreach (var ism in guruh)
//       {
//         Console.WriteLine(" " + ism);
//       }
//     }
//   }
// }

// using System.Collections;

// class Program
// {
//   static void Main()
//   {
//     ArrayList ar = new() { 1, 2, 3, 4 };

//     var intlar = ar.Cast<int>();

//     foreach (var i in intlar)
//     {
//       Console.WriteLine(i);
//     }
//   }
// }


// class Program
// {
//   static void Main()
//   {
//     var sonlar = new[] { 10, 20, 30, 55, 40, 25 };
//     var kichik = sonlar.TakeWhile(n => n < 50).ToList();

//     kichik.ForEach(Console.WriteLine);
// var birinchiUchta = sonlar.Take(3).ToList();

// birinchiUchta.ForEach(Console.WriteLine);
//   }
// }


// class Program
// {
//   static void Main()
//   {
//     var sonlar = new[] { 100, 200, 300, 400 };
//     var tashlangan = sonlar.Skip(2).ToList();
//     tashlangan.ForEach(Console.WriteLine);
//   }
// }


// class Program
// {
//   static void Main()
//   {
//     var sonlar = new[] { 10,ty<string>();
// Console.WriteLine(emptylist.Count()); 20, 25, 35, 40, 15 };
//     var natija = sonlar.SkipWhile(n => n < 30).ToList();

//     natija.ForEach(Console.WriteLine);
//   }
// }

class Program
{
  static void Main()
  {
    var emptylist = Enumerable.Empty<string>();
    Console.WriteLine(emptylist.Count());

    var sonlar = Enumerable.Range(5, 10);

    foreach (var i in sonlar)
    {
      Console.WriteLine(i);
    }

    var takrorlangan = Enumerable.Repeat("Hello", 5);

    foreach (var i in takrorlangan)
    {
      Console.WriteLine(i);
    }
  }
}




class Dastur
{
  static void Main()
  {
    var a = new[] { 1, 2, 3, 4 };
    var b = new[] { 1, 2, 3, 4 };

    bool tengmi = a.SequenceEqual(b);
    Console.WriteLine($"Ikkala ro'yxat tengmi? {tengmi}");
  }
}


//     // var ismlar = new string[] { };
//     // var natija = ismlar.DefaultIfEmpty("Bo'sh");

//     // foreach (var i in ismlar)
//     // {
//     //   Console.WriteLine(i);
//     // }

//     var a = new[] { 1, 2, 3 };
//     var b = new[] { 4, 5, 6 };

//     var birlashgan = a.Concat(b).ToList();

//     birlashgan.ForEach(Console.WriteLine);
//   }
// }


// class Program
// {
//   static void Main()
//   {
//     var sonlar = Enumerable.Range(1, 10);
//     int juft = sonlar.Count(n => n % 2 == 0);
//     Console.WriteLine(juft);
//   }
// }


// class Program
// {
//   static void Main()
//   {
//     var sonlar = Enumerable.Range(1, 10);
//     var average = sonlar.Sum();
//     Console.WriteLine(average);
//   }
// }


// class Program
// {
// static void Main()
// {
//   var words = new[] { "one", "two", "three" };
// var aggregate = words.Aggregate((a, b) => a + ", " + b).ToList();
// aggregate.ForEach(Console.WriteLine);
// var sonlar = new[] { 2, 4, 5, 6 };
// var min = sonlar.Min();
// var max = sonlar.Max();
// var average = sonlar.Average();
// Console.WriteLine(average);
// Console.WriteLine(min);
// Console.WriteLine(max);
//   }
// }

// class Program
// {
//   static void Main()
//   {

//     var massiv = Enumerable.Range(1, 3).ToArray();
//     // var list = Enumerable.Range(1, 3).ToList();

//     foreach (var i in massiv)
//     {
//       Console.WriteLine(i);
//     }
//   }
// }

// class Program
// {
//   static void Main()
//   {
//     var ismlar = new[] { "Ali", "Vali", "Olim" };
//     var lookup = ismlar.ToLookup(i => i.Length);

//     foreach (var g in lookup)
//     {
//       Console.WriteLine(g.Key);
//       foreach (var i in g)
//       {
//         Console.WriteLine($"  {i}");
//       }
//     }
//   }
// }


// using System.Collections;
// class Program
// {
//   static void Main()
//   {
//     ArrayList ar = new() { 1, 2, 3 };
//     var intlar = ar.Cast<int>();
//     foreach (var i in intlar) Console.WriteLine(i);
//   }
// }


// class Program
// {
//   static void Main()
//   {
//     // var sonlar = Enumerable.Range(1, 10).Take(3);
//     // var sonlar = Enumerable.Range(1, 10).Skip(2);
//     // foreach (var s in sonlar) Console.WriteLine(s);
//     // var takror = Enumerable.Repeat("salom", 5);
//     // foreach (var i in takror) Console.WriteLine(i);

//     // var a = new[] { 1, 2, 3 };
//     // var b = new[] { 1, 2, 3 };

//     // Console.WriteLine(a.SequenceEqual(b));


//   }
// }


// class Program
// {
//   static void Main()
//   {
//   //   var empty = new int[] { };
//   //   var natija = empty.DefaultIfEmpty();

//   //   foreach (var i in natija) Console.WriteLine(i);
//   // }
// }


// class Program
// {
//   static void Main()
//   {
//     var a = new[] { 1, 2 };
//     var b = new[] { 3, 4 };
//     var natija = a.Concat(b);

//     foreach (var i in natija) Console.WriteLine(i);
//   }
// }
