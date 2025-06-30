using System;
using System.Linq;
using System.Diagnostics;

// class Program
// {
//   static void Main()
//   {
//     // var matnlar = new[] { "a", "b", "c", "d", "e" };
//     // matnlar.AsParallel().ForAll(x => Console.WriteLine($"Element: {x}"));

//   }
// }


// using System;
// using System.Linq;
// using System.Collections.Generic;
// using System.Threading;

// class Program
// {
//   static void Main()
//   {
//     // Ma'lumotlar ro'yxati
//     var sonlar = Enumerable.Range(1, 10).ToList();

//     try
//     {
//       // PLINQ orqali parallel ishlov berish
//       var natija = sonlar
//           .AsParallel()
//           .Select(x =>
//           {
//             // Agar qiymat 5 bo'lsa, xatolik chiqaramiz
//             if (x == 5)
//               throw new InvalidOperationException("Xatolik: 5 taqiqlangan!");

//             // Thread ID ni ham ko'rsatamiz
//             Console.WriteLine($"Qiymat: {x}, Thread: {Thread.CurrentThread.ManagedThreadId}");

//             return x;
//           })
//           .ToList(); // Parallel ishlovdan so'ng natijani yig'amiz

//       Console.WriteLine("Hamma elementlar muvaffaqiyatli ishlovdan o'tdi.");
//     }
//     catch (AggregateException ex) // PLINQ bir nechta exceptionlarni AggregateException ga o'rab beradi
//     {
//       Console.WriteLine("\n❌ Xatoliklar yuz berdi:");

//       foreach (var i in ex.InnerExceptions)
//       {
//         Console.WriteLine(i.Message);
//       }
//     }
//   }
// }


// class Program
// {
//   static void Main()
//   {
//     var sonlar = Enumerable.Range(1, 1_000_000_000).ToList();

//     var sw1 = Stopwatch.StartNew();
//     var linqnatija = sonlar.Where(x => x % 2 == 0).Select(x => x * x).ToList();

//     sw1.Stop();

//     Console.WriteLine($"Linq vaqti: {sw1.ElapsedMilliseconds} ms");

//     var sw2 = Stopwatch.StartNew();
//     var plinq = sonlar.AsParallel().Where(x => x % 2 == 0).Select(x => x * x).ToList();
//     sw2.Stop();

//     Console.WriteLine($"Plinq vaqti: {sw2.ElapsedMilliseconds}");
//   }
// }

// ✅ MASALA 1
// 🧾 Shart:

// 1 dan 1 milliongacha bo‘lgan sonlar orasidan faqat juftlarini toping. Har bir juft sonni kvadratga oshirib, yangi ro‘yxatga joylashtiring. Buni PLINQ yordamida bajaring.

// class Program
// {
//   static void Main()
//   {
//     var sonlar = Enumerable.Range(1, 1_000_000_000);

//     var juftlar = sonlar.AsParallel().Where(x => x % 2 == 0).Select(x => x * x).ToList();

//     juftlar.ForEach(Console.WriteLine);
//   }
// }


// ✅ MASALA 2
// 🧾 Shart:

// Berilgan stringlar ro‘yxatidan uzunligi 5 dan katta bo‘lgan so‘zlarni toping va ularni bosh harfga o‘tkazing. Barcha ishlarni PLINQ yordamida bajaring.

// string[] sozlar = { "banana", "apple", "grape", "watermelon", "kiwi", "cherry" };

// var natija = sozlar.AsParallel().Where(s => s.Length > 5).Select(s => s.ToUpper()).ToList();

// natija.ForEach(Console.WriteLine);

// ✅ MASALA 3
// 🧾 Shart:

// 1 dan 500 000 gacha bo‘lgan sonlar ichidan toq sonlarni toping va ularning 3-darajasini (kubini) hisoblang. So‘ng natijani ekranga chiqaring. PLINQ’dan foydalaning.

// class Program
// {
//   static void Main()
//   {
//     var sonlar = Enumerable.Range(1, 500000);

//     var toqsonlar = sonlar.AsParallel().Where(x => x % 2 == 1).Select(x => x * x * x).ToList();

//     toqsonlar.ForEach(Console.WriteLine);
//   }
// }


// ✅ MASALA 4
// 🧾 Shart:

// Berilgan matnlar to‘plamidan har bir matnni teskari qilib chiqaring (Reverse). PLINQ bilan buni parallel bajarib, yakuniy ro‘yxatni chop eting.

// class Program
// {
//   static void Main()
//   {
//     string[] matnlar = { "hello", "parallel", "programming", "csharp", "world" };

//     var teskari = matnlar.AsParallel().Select(s => new string(s.Reverse().ToArray())).ToList();

//     teskari.ForEach(Console.WriteLine);
//   }
// }


// ✅ MASALA 5
// 🧾 Shart:

// 1 dan 1 milliongacha bo‘lgan sonlar ustida quyidagilarni bajaring:

//     Faqat 7 ga karralilarni tanlang

//     Ularga 10 qo‘shing

//     Natijalarni parallel holatda qayta ishlang

//     Birinchi 10 ta natijani chiqaring


class Dastur
{
  static void Main()
  {
    var sonlar = Enumerable.Range(1, 1_000_000);

    var sevenDivided = sonlar.AsParallel().Where(x => x % 7 == 0).Select(x => x + 10).Take(10).ToList();

    sevenDivided.ForEach(Console.WriteLine);
  }
}

// ✅ MASALA 6
// 🧾 Shart:

// 1 dan 1 milliongacha bo‘lgan sonlarning yig'indisini hisoblang. Bu ishni PLINQ yordamida bajaring.

// class Program
// {
//   static void Main()
//   {
//     var sonlar = Enumerable.Range(1, 1_000_000);
//     var sum = sonlar.AsParallel().Select(x => (long)x).Sum();
//     Console.WriteLine(sum);
//   }
// }


namespace XML
{

  using System;
  using System.Xml.Linq;

  class Program
  {
    static void Main()
    {
      XDocument doc = new XDocument(
        new XElement("Talabalar",
          new XElement("Talaba",
            new XAttribute("id", 1),
            new XElement("Ism", "Ali"),
            new XElement("Yosh", 20)
        ),
          new XElement("Talaba",
            new XAttribute("id", 2),
            new XElement("Ism", "Vali"),
            new XElement("Yosh", 23))));
      doc.Save("talabalar.xml");
      Console.WriteLine("Fayl yaratildi");
    }
  }
}



// class Program
// {
//   static void Main()
//   {
//     XDocument doc = XDocument.Load("talabalar.xml");

//     foreach (var talaba in doc.Descendants("Talaba"))
//     {
//       string id = talaba.Attribute("id").Value;
//       string name = talaba.Element("Ism").Value;
//       string yosh = talaba.Element("Yosh").Value;

//       Console.WriteLine($"{id} {name} {yosh}");
//     }
//   }
// }


// class Program
// {
//   static void Main()
//   {
//     XDocument doc = XDocument.Load("talabalar.xml");

//     XElement yangiTalaba = new XElement("Talaba",
//     new XAttribute("id", 3),
//     new XElement("Ism", "Sami"),
//     new XElement("Yosh", 25)
//     );

//     doc.Root.Add(yangiTalaba);
//     doc.Save("talabalar.xml");
//   }
// }


// class Program
// {
//   static void Main()
//   {
//     XDocument doc = XDocument.Load("talabalar.xml");
//     var talabalar = doc.Descendants("Talaba").Where(t => int.Parse(t.Element("Yosh").Value) > 21);

//     foreach (var t in talabalar)
//     {
//       Console.WriteLine(t.Element("Ism").Value);
//     }
//   }
// }


// class Program
// {
//   static void Main()
//   {
//     XDocument doc = new XDocument(
//       new XElement("Talabalar",
//         new XElement("Talaba",
//           new XAttribute("ID", 1),
//           new XElement("Ism", "Ali"),
//           new XElement("Yosh", "Vali")
//         ),
//         new XElement("Talaba",
//         new XAttribute("ID", 2),
//         new XElement("Ism", "Vali"),
//         new XElement("Yosh", 26)
//         )
//       )
//     );
//     doc.Save("hey.xml");
//   }
// }



// class Program
// {
//   static void Main()
//   {
//     XDocument doc = XDocument.Load("hey.xml");

//     foreach (var talaba in doc.Descendants("Talaba"))
//     {
//       string id = talaba.Attribute("ID").Value;
//       string name = talaba.Element("Ism").Value;
//       string age = talaba.Element("Yosh").Value;

//       Console.WriteLine($"ID: {id}, Ismi: {name}, Yoshi: {age}");
//     }
//   }
// }



// class Program
// {
//   static void Main()
//   {
//     XDocument doc = XDocument.Load("hey.xml");

//     // XElement yangiTalaba = new XElement("Talab",
//     // new XAttribute("id", 3),
//     // new XElement("Ism", "Sami"),
//     // new XElement("Yosh", 24)
//     // );

//     // doc.Root.Add(yangiTalaba);

//     var ochiriladigan = doc.Descendants("Talab").FirstOrDefault(x => (string)x.Attribute("id") == "3");
//     ochiriladigan?.Remove();

//     doc.Save("hey.xml");
//   }
// }
