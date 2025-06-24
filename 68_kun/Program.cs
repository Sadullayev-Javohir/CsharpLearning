using System;
using System.Collections.Generic;

// class Program
// {
//   static void Main()
//   {
//     // List<string> fruits = new List<string>() { "olma", "banan", "anor" };
//     // fruits.Add("uzum");
//     // fruits.Remove("banan");
//     // fruits.ForEach(Console.WriteLine);


//     LinkedList<string> animals = new LinkedList<string>();

//     animals.AddLast("it");
//     animals.AddLast("mushuk");
//     animals.AddFirst("quyon");

//     animals.Remove("iT");

//     foreach (var i in animals)
//     {
//       Console.WriteLine(i);
//     }

//   }
// }


// class Program
// {
//   static void Main()
//   {
//     LinkedList<string> ismlar = new LinkedList<string>();

//     ismlar.AddLast("Ali");
//     ismlar.AddLast("Vali");
//     ismlar.AddFirst("Sami");


//     LinkedListNode<string> tugun = ismlar.Find("Ali");
//     ismlar.AddAfter(tugun, "Hasan");
//     foreach (var i in ismlar)
//     {
//       Console.WriteLine(i);
//     }
//   }
// }


// 🔷 1. AddFirst(value)

// Masala: Sizda bo‘sh ro‘yhat bor. Undan har doim yangi ism kelganda ro‘yhatning boshiga qo‘shing.

// class Program
// {
//   static void Main()
//   {
//     LinkedList<string> ismlar = new LinkedList<string>();

//     ismlar.AddFirst("Sami");
//     ismlar.AddFirst("Ali");
//     ismlar.AddFirst("Vali");

//     foreach (var i in ismlar)
//     {
//       Console.WriteLine(i);
//     }
//   }
// }


// 🔷 2. AddLast(value)

// Masala: Talabalar ro‘yxati oxiridan tartib bilan kiritilsin.


// class Program
// {
//   static void Main()
//   {
//     LinkedList<string> students = new LinkedList<string>();

//     students.AddLast("Sami");
//     students.AddLast("Ali");
//     students.AddLast("Vali");

//     foreach (var i in students)
//     {
//       Console.WriteLine(i);
//     }
//   }
// }


// 🔷 3. Find(value) va AddAfter(node, value)

// Masala: "Ali" ismli kishidan keyin "Hasan" ismini joylashtiring.


// class Program
// {
//   static void Main()
//   {
//     LinkedList<string> s = new LinkedList<string>();

//     s.AddLast("Sami");
//     s.AddLast("Ali");
//     s.AddLast("Vali");

//     LinkedListNode<string> tugun = s.Find("Ali");

//     if (tugun != null)
//     {
//       s.AddAfter(tugun, "Husan");
//     }

//     foreach (var i in s)
//     {
//       Console.WriteLine(i);
//     }
//   }
// }


// 🔷 4. AddBefore(node, value)

// Masala: "Vali"dan oldin "Shahboz" ni joylashtiring.

// class Program
// {
//   static void Main()
//   {
//     LinkedList<string> ismlar = new LinkedList<string>();

//     ismlar.AddLast("Vali");
//     ismlar.AddLast("Sami");

//     LinkedListNode<string> tugun = ismlar.Find("Vali");

//     if (tugun != null)
//     {
//       ismlar.AddBefore(tugun, "Shaxboz");
//     }

//     foreach (var i in ismlar)
//     {
//       Console.WriteLine(i);
//     }
//   }
// }

// 🔷 5. Remove(value)

// Masala: Ro‘yhatdan "Ali" ni olib tashlang.

// class Program
// {
//   static void Main()
//   {
//     LinkedList<string> ismlar = new LinkedList<string>();

//     ismlar.AddFirst("Ali");
//     ismlar.AddFirst("Behruz");
//     ismlar.AddLast("Vali");

//     // ismlar.Remove("Ali");
//     // ismlar.RemoveFirst();
//     // ismlar.RemoveLast();

//     ismlar.Clear();
//     if (ismlar.Count == 0)
//     {
//       Console.WriteLine("Bo'sh");
//     }
//     foreach (var ism in ismlar)
//     {
//       Console.WriteLine(ism);
//     }

//   }
// }


// class Program
// {
//   static void Main()
//   {
//     List<string> cities = new List<string>() { "Toshkent", "Samarqand", "Buxoro" };
//     LinkedList<string> moreCities = new LinkedList<string>();
//     moreCities.AddLast("Farg'ona");
//     moreCities.AddLast("Andijon");

//     List<string> allCities = new List<string>(cities);
//     allCities.AddRange(moreCities);

//     allCities.Sort();
//     Console.WriteLine("Barcha shaharlar tartiblangan\n");
//     allCities.ForEach(Console.WriteLine);

//     Console.WriteLine("Qaysi shaharni qidirayapsiz?");
//     string search = Console.ReadLine();

//     if (allCities.Contains(search))
//     {
//       Console.WriteLine($"{search} ro'yxatda bor");
//     }
//     else
//     {
//       Console.WriteLine($"{search} topilmadi");
//     }

//   }
// }


// class Program
// {
//   static void Main()
//   {
//     LinkedList<string> names = new LinkedList<string>();
//     names.AddFirst("Ali");
//     names.AddLast("Vali");
//     names.AddAfter(names.First, "Sami");

//     LinkedListNode<string> firstNode = names.First;
//     LinkedListNode<string> lastNode = names.Last;
//     Console.WriteLine(lastNode.Value);

//     // foreach (var i in names)
//     // {
//     //   Console.WriteLine(i);
//     // }

//   }
// }



// class Program
// {
//   static void Main()
//   {
//     Stack<string> kitoblar = new Stack<string>();

//     kitoblar.Push("Ingliz tili");
//     kitoblar.Push("Matematika");
//     kitoblar.Push("Fizika");

//     // Console.WriteLine("Olingan kitob: " + kitoblar.Pop());
//     Console.WriteLine(kitoblar.Peek());
//   }
// }


// class Program
// {
//   static void Main()
//   {
//     Queue<string> navbat = new Queue<string>();

//     navbat.Enqueue("Ali");
//     navbat.Enqueue("Vali");
//     navbat.Enqueue("Guli");

//     // Console.WriteLine("Navbatdan chiqdi: " + navbat.Dequeue());

//     Console.WriteLine(navbat.Peek());
//   }
// }


// class Program
// {
//   static void Main()
//   {
//     Queue<string> customerQueue = new Queue<string>();
//     customerQueue.Enqueue("Mijoz 1");
//     customerQueue.Enqueue("Mijoz 2");
//     customerQueue.Enqueue("Mijoz 3");

//     while (customerQueue.Count > 0)
//     {
//       string mijoz = customerQueue.Dequeue();
//       Console.WriteLine($"{mijoz} xizmat ko‘rsatildi.");
//     }

//     Console.WriteLine("Navbat tugadi.");
//   }
// }


// ✅ 1-masala: Navbatdagi mijozlarga xizmat ko‘rsatish (Queue bilan)
// 🧩 Masala sharti:

// Bankda mijozlar kelish tartibida navbatga turishadi. Sizdan talab qilinadi:

//     Mijozlar ismini Queue<string> yordamida saqlang.

//     Dastur foydalanuvchidan 5 ta mijoz ismini ketma-ket qabul qilsin.

//     Har bir mijozga ketma-ket xizmat ko‘rsating (ya’ni Dequeue()).

//     Har bir mijozga xizmat ko‘rsatishda ekranga quyidagicha chiqsin:
//     "Xizmat ko‘rsatildi: [mijoz_ismi]"

//     Oxirida esa "Navbat tugadi" degan xabar chiqsin.


// class Program
// {
//   static void Main()
//   {
//     Queue<string> customers = new Queue<string>();
//     customers.Enqueue("Ali");
//     customers.Enqueue("Sammi");
//     customers.Enqueue("Vali");
//     customers.Enqueue("Guli");
//     customers.Enqueue("Bahora");

//     while (customers.Count != 0)
//     {
//       Console.WriteLine($"Xizmat ko'rsatildi: {customers.Peek()}");
//       customers.Dequeue();
//       if (customers.Count == 0)
//       {
//         Console.WriteLine("Navbat tugadi");
//       }
//     }

//   }
// }



// ✅ 2-masala: Brauzer "Orqaga" tugmasi funksiyasi (Stack bilan)
// 🧩 Masala sharti:

//     Foydalanuvchi veb-sahifalarni ketma-ket ko‘rayapti. Har bir sahifa nomini Stack<string> da saqlang.

//     Foydalanuvchi 5 ta sahifaga kiradi (masalan: Google, YouTube, GitHub, Facebook, Twitter).

//     Har safar “Orqaga” (Back) tugmasi bosilganda, oxirgi sahifa chiqadi va foydalanuvchiga shu sahifadan chiqilgani ekranga yoziladi.

//     Stack bo‘sh bo‘lsa, "Sahifalar tugadi" deb chiqsin.

// class Program
// {

//   static void Back(Stack<string> sahifalar)
//   {
//     Console.WriteLine($"Siz {sahifalar.Pop()} sahifasidan chiqdingiz.");
//     if (sahifalar.Count == 0)
//     {
//       Console.WriteLine("Sahifalar tugadi");
//     }
//   }
//   static void Main()
//   {
//     Stack<string> sahifalar = new Stack<string>();

//     sahifalar.Push("Google");
//     sahifalar.Push("Github");
//     sahifalar.Push("YouTube");
//     sahifalar.Push("Facebook");
//     sahifalar.Push("TikTok");

//     Back(sahifalar);
//     Back(sahifalar);
//     Back(sahifalar);
//     Back(sahifalar);
//     Back(sahifalar);

//   }
// }



// class Program
// {
//   static void Main()
//   {
//     HashSet<int> raqamlar = new HashSet<int>();
//     raqamlar.Add(1);
//     raqamlar.Add(2);
//     raqamlar.Add(3);
//     // Console.WriteLine(raqamlar.Clear());
//     // raqamlar.Clear();
//     Console.WriteLine(raqamlar.Count);

//     foreach (var i in raqamlar)
//     {
//       Console.WriteLine(i);
//     }

//   }
// }


// class Program
// {
//   static void Main()
//   {
//     HashSet<string> a = new HashSet<string>() { "apple", "banana", "cherry" };
//     HashSet<string> b = new HashSet<string>() { "banana", "cherry", "date" };

//     // a.IntersectWith(b);
//     // a.UnionWith(b);
//     // a.ExceptWith(b);
//     // a.SymmetricExceptWith(b);
//     Console.WriteLine(a.SetEquals(b));

//     foreach (var i in a)
//     {
//       Console.WriteLine(i);
//     }

//   }
// }


// SortedSet<int> sonlar = new SortedSet<int> { 10, 2, 6, 9, 15 };
// // Console.WriteLine(sonlar.Min);
// // Console.WriteLine(sonlar.Max);

// // var oraliq = sonlar.GetViewBetween(4, 10);
// // var teskari = sonlar.Reverse();

// int a = 2 + 4;
// if (sonlar.TryGetValue(a, out int natija))
// {
//   Console.WriteLine(natija);
// }
// else
// {
//   Console.WriteLine("topilmadi");
// }

//   foreach (var i in sonlar)
//   {
//     Console.WriteLine(i);
//   }

class Program
{
  static void Main()
  {
    HashSet<int> sonlar = new HashSet<int>() { 15, 6, 7, 1, 9 };
    foreach (var i in sonlar)
    {
      Console.WriteLine(i);
    }
  }
}
