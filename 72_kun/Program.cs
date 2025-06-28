using System;
using System.Collections.Generic;
using System.Linq;

// GROUPBY
// class Program
// {
//   static void Main()
//   {
//     var mevalar = new List<string> { "olma", "anor", "banan" };

//     var guruhlar = mevalar.GroupBy(meva => meva.Length);

//     foreach (var guruh in guruhlar)
//     {
//       Console.WriteLine($"Uzunligi : {guruh.Key}");
//       foreach (var meva in guruh)
//       {
//         Console.WriteLine(meva);
//       }
//     }

//   }
// }

// class Program
// {
//   static void Main()
//   {
//     var mevalar = new List<string> { "olma", "anor", "banan", "apelsin", "olcha", "o'rik" };

//     var lookup = mevalar.ToLookup(meva => meva.Length);
//     foreach (var meva in lookup[5])
//     {
//       Console.WriteLine(meva);
//     }
//   }
// }


// class Program
// {
//   static void Main()
//   {
//     var foydalanuvchilar = new List<(int Id, string Ism)>
//         {
//             (1, "Ali"),
//             (2, "Vali"),
//             (3, "Sardor")
//         };

//     var buyurtmalar = new List<(int UserId, string Mahsulot)>
//         {
//             (1, "Olma"),
//             (2, "Banan"),
//             (3, "Uzum"),
//         };

//     var natija = foydalanuvchilar.Join(
//       buyurtmalar,
//       user => user.Id,
//       order => order.UserId,
//       (user, order) => $"{user.Id}, {order.UserId}, {user.Ism}, {order.Mahsulot}"
//     );

//     foreach (var i in natija)
//     {
//       Console.WriteLine(i);
//     }
//   }
// }



// class Program
// {
//   static void Main()
//   {
//     var mevalar = new List<string> { "olma", "anor", "banan", "apelsin", "olcha", "o'rik" };

//     var lookup = mevalar.ToLookup(meva => meva.Length);
//     foreach (var meva in lookup[5])
//     {
//       Console.WriteLine(meva);
//     }
//   }
// }


// class Program
// {
//   static void Main()
//   {
//     var foydalanuvchilar = new List<(int Id, string Ism)>
//         {
//             (1, "Ali"),
//             (2, "Vali"),
//             (3, "Sardor")
//         };

//     var buyurtmalar = new List<(int UserId, string Mahsulot)>
//         {
//             (1, "Olma"),
//             (2, "Banan"),
//             (3, "Uzum"),
//         };

//     var natija = foydalanuvchilar.GroupJoin(
//       buyurtmalar,
//       user => user.Id,
//       order => order.UserId,
//       (user, order) => new
//       {
//         user.Ism,
//         Mahsulotlar = order.Select(o => o.Mahsulot)
//       }
//     );

//     foreach (var i in natija)
//     {
//       Console.WriteLine(i.Ism);
//       foreach (var j in i.Mahsulotlar)
//       {
//         Console.WriteLine($" - {j}");
//       }
//     }
//   }
// }

// class Program
// {
//   static void Main()
//   {
//     var ismlar = new[] { "Ali", "Vali", "Sami" };
//     var baholar = new[] { 5, 4, 3 };

//     var natija = ismlar.Zip(baholar, (ism, baho) => $"{ism} - {baho}");

//     foreach (var i in natija)
//     {
//       Console.WriteLine(i);
//     }
//   }
// }


// var sonlar = new[] { 1, 2, 2, 3, 3, 3, 4 };

// class Program
// {
//   static void Main()
//   {
//     var sonlar = new[] { 1, 2, 2, 3, 3, 3, 4 };

//     var natija = sonlar.Distinct();

//     foreach (var i in natija)
//     {
//       Console.WriteLine(i);
//     }
//   }
// }


// class Program
// {
//   static void Main()
//   {
//     var a = new[] { 1, 2, 3 };
//     var b = new[] { 3, 4, 5 };

//     var natija = b.Union(a);

//     foreach (var i in natija)
//     {
//       Console.WriteLine(i);
//     }
//   }
// }


// class Program
// {
//   static void Main()
//   {
//     var a = new[] { 1, 2, 3 };
//     var b = new[] { 3, 4, 5 };

//     var natija = b.Intersect(a);

//     foreach (var i in natija)
//     {
//       Console.WriteLine(i);
//     }
//   }
// }

// class Program
// {
//   static void Main()
//   {
//     var a = new[] { 1, 2, 3, 4 };
//     var b = new[] { 3, 4, 5 };

//     var natija = a.Except(b);

//     foreach (var i in natija)
//     {
//       Console.WriteLine(i);
//     }
//   }
// }

// class Program
// {
//   static void Main()
//   {
//     // var sonlar = new[] { 1, 3, 5, 7 };
//     // var sonlar = new int[] { 1};
//     // bool bor = sonlar.All(s => s % 2 == 1);
//     // Console.WriteLine(bor);
//     // Console.WriteLine(sonlar.First());

//     // var sonlar = new int[] {1, 3, 4, 6, 7};
//     // var sonlar = new int[] { };
//     // Console.WriteLine(sonlar.First());
//     var a = new[] { 99, 35, 6, 7 };
//     Console.WriteLine(a.ElementAt(3));
//     // Console.WriteLine(a.Single());
//   }
// }


// class Program
// {
//   static void Main()
//   {
//     var sonlar = new int[] {2, 3, 4, };
//     var natija = sonlar.DefaultIfEmpty(100);
//     foreach (var s in natija)
//     {
//       Console.WriteLine(s);
//     }
//   }
// }


// class Program
// {
//   static void Main()
//   {
//     // var sonlar = new[] { 1, 2, 3, 4, 5, 6 };
// var juftlar = sonlar.Where(s => s % 2 == 0);

// foreach (var s in juftlar)
// {
//   Console.WriteLine(s);
// }


// var sonlar = new[] { 1, 2, 3 };
// var kvadrat = sonlar.Select(x => x * x);

// foreach (var s in kvadrat)
// {
//   Console.WriteLine(s);
// }

// var sonlar = new[] { 3, 1, 4, 2 };
// var saralangan = sonlar.OrderByDescending(x => x);

// foreach (var s in saralangan)
// {
//   Console.WriteLine(s);
// }


// object[] aralash = { 1, "hello", 3.14, 7, "world" };
// var intSeparate = aralash.OfType<int>();

// var sonlar = new[] { 12, 3, 65, 7 };
// var a = sonlar.Select(x => x * x);
// var t = new[]
// {
//   new {Ism = "Ali", Kitoblar = new[] {"C#", "SQL"}},
//   new {Ism = "Vali", Kitoblar = new[] {"C", "JS"}},
// };

// var a = t.SelectMany(x => x.Kitoblar);

// var sonlar = new[] { 4, 5, 7, 8 };
// var a = sonlar.OrderBy(x => x);



// var sonlar = new[] { 23, 5, 76, 2, 7 };
// var a = sonlar.OrderByDescending(x => x);

// var talabalar = new[]
// {
//   new {Ism = "Ali", Fam = "Karimov"},
//   new {Ism = "Vali", Fam = "Valiyev"},
//   new {Ism = "Sami", Fam = "Yusupov"},
// };

// var a = talabalar.OrderBy(t => t.Ism).OrderBy(t => t.Fam);


// var sonlar = new[] { 4, 7, 2, -8, -6 };
// var a = sonlar.Reverse();
// var mevalar = new[] { "olma", "anor", "nok", "behi", "xurmo" };

// var a = mevalar.GroupBy(meva => meva.Length);


// foreach (var i in a)
// {
//   Console.WriteLine(i.Key);
//   foreach (var j in i)
//   {
//     Console.WriteLine($" - {j}");
//   }
// }

// var ismlar = new[] { "Ali", "Vali", "Sami", "Guli", "Bahora" };

// var lookup = ismlar.ToLookup(ism => ism.Length);

// foreach (var i in lookup)
// {
//   Console.WriteLine(i.Key);

//   foreach (var j in i)
//   {
//     Console.WriteLine($" - {j}");
//   }
// }


//     var talabalar = new[]
// {
//     new { Id = 1, Ism = "Ali", GroupId = 101 },
//     new { Id = 2, Ism = "Vali", GroupId = 102 }
// };

//     var guruhlar = new[]
//     {
//     new { Id = 101, Nom = "A guruh" },
//     new { Id = 102, Nom = "B guruh" }
// };

//     var joinmethod = talabalar.Join(
//       guruhlar,
//       talaba => talaba.GroupId,
//       guruh => guruh.Id,
//       (talaba, guruh) => new {talaba.Ism, guruh.Nom}
//     );

//     foreach (var i in joinmethod)
//     {
//       Console.WriteLine($"{i.Ism} = {i.Nom}");
//     }
//   }

//     var talabalar = new[]
// {
//     new { Ism = "Ali", GroupId = 1 },
//     new { Ism = "Vali", GroupId = 2 },
//     new { Ism = "Salim", GroupId = 1 }
// };

//     var guruhlar = new[]
//     {
//     new { Id = 1, Nom = "1-Guruh" },
//     new { Id = 2, Nom = "2-Guruh" }
// };
//     var natija = guruhlar.GroupJoin(
//       talabalar,
//       g => g.Id,
//       t => t.GroupId,
//       (g, talabalarGuruhi) => new
//       {
//         GuruhNomi = g.Nom,
//         Talabalar = talabalarGuruhi.Select(t => t.Ism),
//       }
//     );

//     foreach (var i in natija)
//     {
//       Console.WriteLine($"{i.GuruhNomi}");
//       foreach(var ism in i.Talabalar)
//       {
//         Console.WriteLine(ism);
//       }
//     }
//   }
// }

// class Program
// {
//   static void Main()
//   {
//     var harflar = new[] { "A", "B", "C" };
//     var sonlar = new[] { 1, 2 };

//     var natija = harflar.Zip(sonlar, (h, s) => h + s);

//     foreach (var i in natija)
//     {
//       Console.WriteLine(i);
//     }
//   }
// }


// class Program
// {
//   static void Main()
//   {
//     var sonlar = new[] { 2, 3, 3, 5, 7, 6, 4, 3, 2 };
//     var noyob = sonlar.Distinct();

//     foreach(var i in noyob)
//     {
//       Console.WriteLine(i);
//     }
//   }
// }


// class Program
// {
//   static void Main()
//   {
//     // var a = new[] { 1, 2, 3 };
//     // var b = new[] { 3, 4, 5 };

//     // var c = a.Union(b);
//     // var c = a.Intersect(b);

//     // var c = a.Except(b);
//     // var c = a.Any(x => x % 2 == 0);
//     // var c = a.All(x => x > 0);
//     // var c = a.Contains(2);

//     // var c = a.First();
//     // var c = a.FirstOrDefault();
//     // var c = a.Last();
//     // var c = a.LastOrDefault();
//     // var c = a.Single();
//     var a = new int[] { 2, 4 };

//     // var c = a.SingleOrDefault();
//     // var c = a.ElementAt(1);
//     // var c = a.ElementAtOrDefault(2);
//     var c = a.DefaultIfEmpty(12);
//     foreach (var i in c)
//     {
//       Console.WriteLine(i);
//     }
//     // foreach (var i in c)
//     // {
//     //   Console.WriteLine(i);
//     // }
//   }
// }
