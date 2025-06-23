// using System;
// using System.Collections;


// class Program
// {
//   static void Main()
//   {
//     ArrayList arrlist = new ArrayList();
//     arrlist.Add(199);
//     arrlist.Add("salom");
//     arrlist.Add(3.14);
//     arrlist.Add(true);
//     arrlist.AddRange(new int[] { 2, 5, 7 });
//     arrlist.Insert(1, "hey");
//     arrlist.InsertRange(2, new string[] { "A", "B" });
//     arrlist.Remove("A");
//     arrlist.RemoveAt(0);
//     arrlist.RemoveRange(0, 2);

//     // arrlist.Sort();
//     arrlist.Reverse();
//     Console.WriteLine("Arraylist elementlari: ");
//     arrlist.TrimToSize();
//     foreach (var item in arrlist)
//     {
//       Console.WriteLine(item);
//     }
//     // Console.WriteLine(arrlist.Contains(3.14));
//     // Console.WriteLine(arrlist.IndexOf(3.14));


//   }
// }



// using System;
// using System.Collections;

// class Program
// {
//   static void Main()
//   {
//     Hashtable ht = new Hashtable();

//     ht["ism"] = "Javohir";
//     ht["yosh"] = 23;
//     ht["status"] = true;

//     ht.Add("kasb", "Dasturchi");

//     ht.Remove("yosh");
//     Console.WriteLine("Hashtable elementlari: ");
//     // Console.WriteLine(ht.ContainsKey("ism"));

//     // foreach (var key in ht.Values)
//     // {
//     //   Console.WriteLine(key);
//     // }

//     Hashtable nusxa = (Hashtable)ht.Clone();
//     nusxa.Clear();
//     // foreach (DictionaryEntry element in ht)
//     // {
//     //   Console.WriteLine($"Kalit: {element.Key}, Qiymat: {element.Value}");
//     // }
//   }
// }


// using System;
// using System.Collections.Generic;

// class Program
// {
//   static void Main()
//   {
//     List<string> ismlar = new List<string>();
//     ismlar.Add("Javohir");
//     ismlar.Add("Ali");
//     ismlar.Add("Laylo");
//     ismlar.AddRange(new string[] { "Sammi", "Yamal" });
//     ismlar.Clear();
//     Console.WriteLine("List elementlari :");
//     foreach (string ism in ismlar)
//     {
//       Console.WriteLine(ism);
//     }
//   }
// }


// using System;
// using System.Collections.Generic;

// class Program
// {
//   static void Main()
//   {
//     Dictionary<int, string> talabalar = new Dictionary<int, string>();

//     talabalar.Add(1, "Javohir");
//     talabalar.Add(2, "Ali");
//     talabalar.Add(3, "Laylo");

//     Console.WriteLine("Dictionary elementlari: ");

//     foreach (var juftlik in talabalar)
//     {
//       Console.WriteLine($"Id: {juftlik.Key}, Ism: {juftlik.Value}");
//     }
//     Console.WriteLine(talabalar[2]);

//   }
// }


// class Program
// {
//   static Dictionary<string, string> kontaktlar = new Dictionary<string, string>();

//   static void Main()
//   {
//     while (true)
//     {
//       Console.WriteLine("Kontaktlar");
//       Console.WriteLine("1. Qo'shish");
//       Console.WriteLine("2. Barcha kontaktlar");
//       Console.WriteLine("3. Qidirish");
//       Console.WriteLine("4. O'chirish");
//       Console.WriteLine("5. Chiqish");

//       string tanlov = Console.ReadLine();

//       switch (tanlov)
//       {
//         case "1":
//           Add();
//           break;
//         case "2":
//           View();
//           break;
//         case "3":
//           Search();
//           break;
//         case "4":
//           Delete();
//           break;
//         case "5":
//           Console.WriteLine("Siz chiqdingiz");
//           return;
//         default:
//           Console.WriteLine("Noto'g'ri tanlov");
//           break;
//       }
//     }
//   }

//   static void Add()
//   {
//     Console.Write("Ism kiriting: ");

//     string name = Console.ReadLine();
//     if (kontaktlar.ContainsKey(name))
//     {
//       Console.WriteLine("Bu ism bor");
//     }

//     Console.Write("Telefon raqam kiriting: ");
//     string phone = Console.ReadLine();

//     kontaktlar.Add(name, phone);
//   }

//   static void View()
//   {
//     if (kontaktlar.Count == 0)
//     {
//       Console.WriteLine("Kontaktlar hali bo'sh");
//     }
//     Console.WriteLine("Barcha kontaktlar");
//     foreach (var kontakt in kontaktlar)
//     {
//       Console.WriteLine($"{kontakt.Key} => {kontakt.Value}");
//     }
//   }

//   static void Search()
//   {
//     Console.WriteLine("Ism kiriting: ");
//     string name = Console.ReadLine();

//     if (kontaktlar.TryGetValue(name, out string phone))
//     {
//       Console.WriteLine($"{name} => {phone}");
//     }
//     else
//     {
//       Console.WriteLine("Ism Topilmadi");
//     }
//   }

//   static void Delete()
//   {
//     Console.WriteLine("O'chirmoqchi bo'lgan ismni kiriting: ");
//     string name = Console.ReadLine();
//     if (kontaktlar.Remove(name))
//     {
//       Console.WriteLine("Kontakt o'chirildi");
//     }
//     else
//     {
//       Console.WriteLine("Kontakt mavjud emas");
//     }
//   }
// }
