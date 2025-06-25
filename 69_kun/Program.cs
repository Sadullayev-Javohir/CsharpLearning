// public class Box<T>
// {
//   public T Value { get; set; }
// }

// class Program
// {
//   static void Main()
//   {
//     Box<int> son = new Box<int> { Value = 123 };
//     Box<string> matn = new Box<string> { Value = "Hello" };

//     Console.WriteLine(son.Value);
//     Console.WriteLine(matn.Value);
//   }
// }



// class Program
// {
//   static void Main()
//   {
//     List<string> names = new List<string> { "Ali", "Vali", "Anvar", "Said" };

//     // var aNames1 = (from name in names where name.StartsWith("A") select name).ToList();
//     var aNames1 = names.Where(name => name.StartsWith("A")).ToList();
//     aNames1.ForEach(Console.WriteLine);
//   }
// }

// class Person
// {
//   public string Name { get; set; }
//   public int Age { get; set; }
// }

// class Program
// {
//   static void Main()
//   {
//     List<Person> people = new List<Person>
//     {
//       new Person {Name = "Vali", Age = 26},
//       new Person {Name = "Ali", Age = 25},
//       new Person {Name = "Sammi", Age = 22}
//     };

//     var result = from p in people where p.Age > 25 orderby p.Name select p.Name;

//     foreach (var i in result)
//     {
//       Console.WriteLine(i);
//     }
//   }

// }


// List<string> names = new List<string>() { "ali", "vali", "sami" };
// var uppernames = names.Select(n => n.ToUpper()).ToList();
// uppernames.ForEach(Console.WriteLine);


// 📌 Misol 1: Yoshi 18 dan katta bo‘lgan insonlarni chiqarish

// Shart: List<Person> ichida odamlar bor. Faqatgina yoshi 18 dan katta bo‘lganlarni chiqaring.


// class People
// {
//   public int Age { get; set; }
// }

// class Program
// {
//   static void Main()
//   {
//     List<People> pe = new List<People>()
//     {
//       new People {Age = 16},
//       new People {Age = 26},
//       new People {Age = 6},
//       new People {Age = 14},
//       new People {Age = 23},
//       new People {Age = 17},
//     };

//     var kattaYosh = pe.Where(p => p.Age > 18).ToList();

//     foreach (var i in kattaYosh)
//     {
//       Console.WriteLine(i.Age);
//     }
//   }
// }


// 📌 Misol 2: List<int> ichidan juft sonlarni ajratish

// Shart: Listdagi juft sonlarni ajrating va ularni o‘sish tartibida chiqaring.

// List<int> sonlar = new List<int>() { 25, 7, 234, 17, 34, 6, 1, -5, -45 };

// var juftSonlar = sonlar.Where(son => son % 2 == 0).ToList();

// juftSonlar.ForEach(Console.WriteLine);


// ✅ 2. Dictionary<TKey, TValue> bilan LINQ
// 📌 Misol 3: Bahosi 80 dan yuqori bo‘lgan o‘quvchilar

// Shart: Dictionary<string, int> ko‘rinishida o‘quvchilar va ularning baholari berilgan. Bahosi 80 dan yuqori bo‘lganlarni toping.


// Dictionary<string, int> students = new Dictionary<string, int>
// {
//   {"Ali", 84},
//   {"Vali", 78},
//   {"Sami", 80},
// };

// var kamayishTartibi = students.OrderByDescending(s => s.Value);

// foreach (var i in kamayishTartibi)
// {
//   Console.WriteLine(i);
// }

// var yuqoriBal = students.Where(s => s.Value >= 80);

// foreach (var s in yuqoriBal)
// {
//   Console.WriteLine(s);
// }



// 📌 Misol 5: Array ichidagi satr uzunligi 5 dan uzun bo‘lgan so‘zlarni ajratish

// Shart: string[] massivdan uzunligi 5 dan katta bo‘lgan so‘zlarni ajrating.

// string[] words = { "hey", "look", "lemone", "apple", "appreciate" };

// var LongWords = words.Where(word => word.Length > 5).ToList();

// LongWords.ForEach(Console.WriteLine);


// 📌 Misol 6: Array ichidan eng katta 3 sonni tanlab olish

// Shart: Raqamlar array berilgan. Eng katta 3 tasini chiqarish kerak.


// int[] nums = { 25, 67, 3, 6, 34, 86, 32 };

// var takeThree = nums.OrderByDescending(num => num).Take(3).ToList();

// takeThree.ForEach(Console.WriteLine);


// using System.Collections;

// class Program
// {
//   static void Main()
//   {
//     ArrayList elementlar = new ArrayList();
//     elementlar.Add(1);
//     elementlar.Add("Salom");
//     elementlar.Add(2);
//     elementlar.Add(2.3);

//     var faqatInt = elementlar.OfType<int>();

//     foreach (var i in faqatInt)
//     {
//       Console.WriteLine(i);
//     }
//   }
// }


// List<int> sonlar = new List<int>() { 1, 2, 3, 4, 5 };
// var kvadrat = sonlar.Select(son => son * son).ToList();

// kvadrat.ForEach(Console.WriteLine);

// public class Talaba
// {
//   public string Ism { get; set; }
//   public List<string> Fanlar { get; set; }
// }

// class Program
// {
//   static void Main()
//   {
//     var talabaList = new List<Talaba>
//     {
//       new Talaba { Ism = "Ali", Fanlar = new List<string>{ "Math", "English" } },
//       new Talaba { Ism = "Vali", Fanlar = new List<string>{ "Biology", "Chemistry" } }
//     };

//     var barchafanlar = talabaList.SelectMany(t => t.Fanlar).ToList();

//     barchafanlar.ForEach(Console.WriteLine);
//   }
// }


// List<int> sonlar = new List<int>() { 3, 6, 7, 23, 6, 2 };

// var increase = sonlar.OrderByDescending(son => son).ToList();

// increase.ForEach(Console.WriteLine);



// class Program
// {
//   static void Main()
//   {
//     var odamlar = new List<Odam>
//     {
//       new Odam { Ism = "Ali", Yoshi = 25 },
//       new Odam { Ism = "Vali", Yoshi = 25 },
//       new Odam { Ism = "Ali", Yoshi = 20 }
//     };

//     var saralangan = odamlar.OrderBy(x => x.Ism).ThenBy(x => x.Yoshi).ToList();

//     foreach (var i in saralangan)
//     {
//       Console.WriteLine($"{i.Ism} {i.Yoshi}");
//     }
//   }
// }

// public class Odam
// {
//   public string Ism { get; set; }
//   public int Yoshi { get; set; }
// }
