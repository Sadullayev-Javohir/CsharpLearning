// ✅ 1.Juft sonlarni ajratish(Where)

// Input: int[] nums
// Output: int[] — juft sonlar

// class Program
// {
//   public static int[] juftSonlar(int[] nums)
//   {
//     return nums.Where(a => a % 2 == 0).ToArray();
//   }
//   static void Main()
//   {
//     int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
//     List<int> juft = new List<int>(juftSonlar(nums));
//     juft.ForEach(x => Console.WriteLine(x));
//   }
// }


// ✅ 2.Har bir raqamni kvadratga oshirish (Select)

// Input: int[] nums
// Output: int[] — kvadratlangan sonlar


// class Program
// {
//   public static int[] kvadratSonlar(int[] nums)
//   {
//     return nums.Select(n => n * n).ToArray();
//   }

//   static void Main()
//   {
//     int[] sonlar = { 1, 2, 3, 4, 5, 6 };
//     var kvadratlar = kvadratSonlar(sonlar);
//     foreach (var num in kvadratlar)
//     {
//       Console.WriteLine(num);
//     }
//   }
// }


// ✅ 3.Ismlardan uzunligi 4 dan katta bo‘lganlarni olish (Where)

// Input: string[] names
// Output: string[] — faqat uzun ism


// class Program
// {
//   public static string[] uzunIsmlar(string[] ismlar)
//   {
//     return ismlar.Where(ism => ism.Length > 4).ToArray();
//   }

//   static void Main()
//   {
//     string[] ismlar = { "Ali", "Vali", "Sami", "Joe", "Muhammad" };
//     var uzunIsmlarOlish = uzunIsmlar(ismlar);
//     foreach (var ism in uzunIsmlarOlish)
//     {
//       Console.WriteLine(ism);
//     }
//   }

// }

// ✅ 4. Stringlar uzunligini qaytarish (Select)

// Input: string[] words
// Output: int[] — har bir so‘z uzunligi

// class Program
// {
//   public static int[] ismlarUzunligi(string[] ismlar)
//   {
//     return ismlar.Select(ism => ism.Length).ToArray();
//   }
  
//   static void Main()
//   {
//     string[] ismlar = { "Ali", "Vali", "Sami", "Joe", "Muhammad" };
//     var ismlarInt = ismlarUzunligi(ismlar);
//     foreach(var ism in ismlarInt)
//     {
//       Console.WriteLine(ism);
//     }
//   }
// }



// ✅ 6. Listdagi birinchi 5 ga bo‘linadigan raqamni topish (FirstOrDefault)

// Input: int[] nums
// Output: int — birinchi 5 ga bo‘linadigan son yoki 0

// class Program
// {
//   public static int fiveDivided(int[] nums)
//   {
//     return nums.FirstOrDefault(n => n % 5 == 0);
//   }

//   static void Main()
//   {
//     int[] nums = {1,2,3,4,5,6,7,8,9,10};
//     var fiveDividedNum = fiveDivided(nums);
//     Console.WriteLine(fiveDividedNum);
//   }
// }


// ✅ 8. Sonlar massivida musbat sonlar nechtaligini hisoblash (Where, Count)

// Input: int[] nums
// Output: int


// class Program
// {
//   public static int MusbatCount(int[] nums)
//   {
//     return nums.Where(n => n > 0).Count();
//   }

//   static void Main()
//   {
//     int[] nums = {-2, 2, -3, 65, -5, 2, -6};
//     int count = MusbatCount(nums);
//     Console.WriteLine(count);
//   }
// }


// ✅ 9. Ismda "a" harfi borlarini olish (Where)

// Input: string[] names
// Output: string[]


// class Program
// {
//   public static string[] Acontains(string[] ismlar)
//   {
//     return ismlar.Where(ism => ism.Contains('a')).ToArray();
//   }

//   static void Main()
//   {
//     string[] ismlar = { "Ali", "Vali", "Sami", "Joe", "Muhammad" };
//     var aBorlar = Acontains(ismlar);
//     foreach(var a in aBorlar)
//     {
//       Console.WriteLine(a);
//     }
//   }
// }


// ✅ 10. Ismlar bosh harfini olish (Select)

// Input: string[] names
// Output: char[]

// class Program
// {
//   public static char[] boshHarflar(string[] ismlar)
//   {
//     return ismlar.Select(ism => ism[0]).ToArray();
//   }

//   static void Main()
//   {
//     string[] ismlar = { "Ali", "Vali", "Sami", "Joe", "Muhammad" };
//     var output = boshHarflar(ismlar);

//     foreach(var o in output)
//     {
//       Console.WriteLine(o);
//     }
//   }
// }