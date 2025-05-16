using System;
using System.Linq;


// ✅ 1.OrderBy — Raqamlarni o'sish tartibida joylashtirish
// 🔹 Problem:

// Berilgan int[] nums massivni o‘sish tartibida saralovchi metod yozing.


// class Program
// {
//   public static int[] Saralash(List<int> nums)
//   {
//     return nums.OrderBy(x => x).ToArray();
//   }

//   static void Main()
//   {
//     var nums = new List<int> { 53, 6, 23, 75, 2, 8, 34, 72 };
//     var saralanganRaqamlar = Saralash(nums);
//     foreach (var num in saralanganRaqamlar)
//     {
//       Console.WriteLine(num);
//     }
//   }
// }



// ✅ 2.GroupBy — Ismlarni birinchi harfiga qarab guruhlash
// 🔹 Problem:

// Ismlar ro‘yxatini birinchi harfi bo‘yicha guruhlab, har bir guruhni chiqaruvchi metod yozing.

// class Program
// {
//   public static IEnumerable<IGrouping<char, string>> GuruhIsmlar(string[] ismlar)
//   {
//     return ismlar.GroupBy(ism => ism[0]);
//   }

//   static void Main()
//   {
//     string[] ismlar = { "Temur", "Humoyun", "Akbar", "Po'lat" };
//     var guruhlanganIsmlar = GuruhIsmlar(ismlar);
//     foreach (var guruh in guruhlanganIsmlar)
//     {
//       Console.WriteLine($"{guruh.Key} ismlar: ");

//       foreach (var name in guruh)
//       {
//         Console.WriteLine($"  {name}");
//       }
//     }

//   }
// }


// ✅ 3.Count — 10 dan katta nechta son bor?
// 🔹 Problem:

// Berilgan int[] nums massivida 10 dan katta nechta son borligini qaytaring.

// class Program
// {
//   public static int sanash(int[] nums)
//   {
//     return nums.Count(num => num > 10);
//   }

//   static void Main()
//   {
//     int[] nums = { 5, 12, 18, 3 };
//     int sanalganlar = sanash(nums);
//     Console.WriteLine(sanalganlar);
//   }
// }


// ✅ 4.Any — Ismlar orasida "Ali" bormi?
// 🔹 Problem:

// Berilgan string[] names massivida "Ali" bor yoki yo‘qligini tekshiruvchi metod yozing.

// class Program
// {
//   public static bool aliBormi(string[] ismlar)
//   {
//     return ismlar.Any(ism => ism == "Ali");
//   }

//   static void Main()
//   {
//     Console.WriteLine(aliBormi(new string[] { "Ali", "Bek", "Sami" }));
//   }
// }



// ✅ 5.All — Barcha sonlar musbatmi?
// 🔹 Problem:

// Berilgan int[] nums massividagi barcha sonlar musbat (0 dan katta) bo‘lsa true, aks holda false qaytaring.

// class Yechim
// {
//   public static bool hammasiMusbatmi(int[] nums)
//   {
//     return nums.All(num => num > 0);
//   }

//   static void Main()
//   {
//     Console.WriteLine(hammasiMusbatmi(new int[] { 1, 3, 4, 5, 6 }));
//   }
// }



