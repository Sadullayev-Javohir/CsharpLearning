using System;
using System.Collections.Generic;
using System.Linq;

// ✅ 1. Remove Duplicates from Integer List

// Difficulty: Easy
// Description:
// Berilgan int tipidagi ro‘yxatdan barcha takroriy elementlarni olib tashlang va faqat noyob elementlarni chiqaring.

// class Program
// {
//   public static IList<int> RemoveDuplicates(int[] nums)
//   {
//     HashSet<int> set = new HashSet<int>(nums);
//     return set.ToList();
//   }

//   static void Main()
//   {
//     int[] arr = {1,2,2,4,4,3,6,7,6};
//     IList<int> result = RemoveDuplicates(arr);
//     foreach(var i in result)
//     {
//       Console.WriteLine(i);
//     }
//   }
// }


// ✅ 2. Intersection of Two String Lists

// Difficulty: Easy
// Description:
// Berilgan ikkita string massivdagi umumiy elementlarni toping.

// Example:

// Input: ["apple", "banana", "cherry"], ["banana", "date", "cherry"]
// Output: ["banana", "cherry"]

// Constraints:

//     1 <= A.Length, B.Length <= 1000

//     1 <= string.Length <= 100

// class Program
// {
//   public static IList<string> Intersection(string[] fruits1, string[] fruits2)
//   {
//     HashSet<string> A = new HashSet<string>(fruits1);
//     A.IntersectWith(fruits2);
//     return A.ToList();
//   }

//   static void Main()
//   {
//     string[] fruits1 = {"apple", "banana", "cherry"};
//     string[] fruits2 = {"banana", "date", "cherry"};
//     IList<string> result = Intersection(fruits1, fruits2);

//     foreach(var i in result)
//     {
//       Console.WriteLine(i);
//     }
//   }
// }


// ✅ 3. Unique Words From Sentence

// Difficulty: Easy
// Description:
// Berilgan jumladan (string) faqat noyob so‘zlarni ajrating.

// Example:

// Input: "cat dog cat bird"
// Output: ["cat", "dog", "bird"]


// class Program
// {
//   public static IList<string> UniqueWords(string text)
//   {
//     string[] words = text.Split(' ');
//     HashSet<string> set = new HashSet<string>(words);
//     return set.ToList();
//   }

//   static void Main()
//   {
//     string text = "cat dog cat bird";
//     var result = UniqueWords(text);
//     foreach(var i in result)
//     {
//       Console.WriteLine(i);
//     }
//   }
// }


// ✅ 4. Sorted Scores

// Difficulty: Easy
// Description:
// Berilgan sonlar to‘plamini tartiblangan holda chiqaruvchi funksiya yozing (o‘sish tartibida).

// Example:

// Input: [40, 10, 30, 20]
// Output: [10, 20, 30, 40]

// class Program
// {
//   public static IList<int> SortedScores(int[] sonlar)
//   {
//     SortedSet<int> sortnum = new SortedSet<int>(sonlar);
//     return sortnum.ToList();
//   }

//   static void Main()
//   {
//     int[] sonlar = {1,10,4,8,3,-3,-100};
//     IList<int> natija = SortedScores(sonlar);
//     foreach(int i in natija)
//     {
//       Console.WriteLine(i);
//     }
//   }
// }


// ✅ 5. Find Min and Max in SortedSet

// Difficulty: Easy
// Description:
// Berilgan sonlar ro‘yxatidagi eng kichik va eng katta qiymatni aniqlang.

// Example:

// Input: [5, 2, 8, 3]
// Output: Min = 2, Max = 8


// class Masala
// {
//   public static void FindMinMax(int[] listNum)
//   {
//     SortedSet<int> sonlar = new SortedSet<int>(listNum);
//     int MaxNum = sonlar.Max;
//     int MinNum = sonlar.Min;
//     Console.WriteLine($"Max: {MaxNum}");
//     Console.WriteLine($"Min: {MinNum}");
//   }

//   static void Main()
//   {
//     int[] sonlar = {151, 631, 6131, 89, 901, 81, 234};
//     FindMinMax(sonlar);
//   }
// }


// ✅ 6. Range Query on SortedSet

// Difficulty: Medium
// Description:
// Berilgan sonlar ro‘yxatidan 5 dan 15 gacha bo‘lgan sonlarni qaytaring.
// Example:

// Input: [3, 5, 7, 10, 16], Range: [5, 15]
// Output: [5, 7, 10]


// class Program
// {
//   public static List<int> BetweenNums(int[] nums)
//   {
//     SortedSet<int> sonlar = new SortedSet<int>(nums);
//     SortedSet<int> range = sonlar.GetViewBetween(5, 15);
//     return range.ToList();
//   }

//   static void Main()
//   {
//     int[] sonlar = {3, 5, 7, 10, 16};
//     List<int> result = BetweenNums(sonlar);
//     foreach(int i in result)
//     {
//       Console.WriteLine(i);
//     }
//   }
// }


// ✅ 7. Check Username Exists

// Difficulty: Easy
// Description:
// Foydalanuvchi nomi mavjudmi, yo‘qmi — shuni aniqlang.

// Example:

// Input: usernames = ["Ali", "Vali", "Sami"], search = "Vali"
// Output: true

// class Program
// {
//   public static bool FindUser(string[] users)
//   {
//     HashSet<string> setUsers = new HashSet<string>(users);
//     bool isFindUser = setUsers.Contains("Vali");
//     return isFindUser;
//   }

//   static void Main()
//   {
//     string[] usernames = {"Ali", "Vali", "Sami"};
//     bool search = FindUser(usernames);
//     Console.WriteLine(search);
//   }
// }


// ✅ 8. Descending SortedSet Output

// Difficulty: Easy
// Description:
// Berilgan sonlarni kamayish tartibida chiqaruvchi dastur yozing.

// Example:

// Input: [10, 40, 20]
// Output: [40, 20, 10]

// class Program 
// {
//   public static List<int> ReverseFun(int[] sonlar)
//   {
//     SortedSet<int> sortNum = new SortedSet<int>(sonlar);
//     return sortNum.Reverse().ToList();
//   }

//   static void Main()
//   {
//     int[] numbers = {10, 40, 20};
//     List<int> reversed = ReverseFun(numbers);
//     foreach(int i in reversed)
//     {
//       Console.WriteLine(i);
//     }
//   }
// }


// ✅ 9. Symmetric Difference Between Sets

// Difficulty: Medium
// Description:
// Ikkita to‘plam orasidagi faqat bittasida mavjud elementlarni qaytaring.

// Example:

// Input: [1,2,3], [3,4,5]
// Output: [1,2,4,5]


// class Program 
// {
//   public static List<int> SymmetricDifference(int[] sonlar1, int[] sonlar2)
//   {
//     HashSet<int> hashNum = new HashSet<int>(sonlar1);
//     hashNum.SymmetricExceptWith(sonlar2);
//     return hashNum.ToList();
//   }

//   static void Main()
//   {
//     int[] sonlar1 = {1,2,3};
//     int[] sonlar2 = {3,4,5};
//     List<int> result = SymmetricDifference(sonlar1, sonlar2);
//     foreach(int i in result)
//     {
//       Console.WriteLine(i);
//     }
//   }
// }


// ✅ 10. Try to Get Element from SortedSet

// Difficulty: Medium
// Description:
// Agar berilgan element SortedSetda mavjud bo‘lsa, uni qaytaring, aks holda "Not found" deb qaytaring.

// Example:

// Input: set = ["A", "B", "C"], search = "B"
// Output: "Found: B"

// class Program
// {
//   public static string TryFind(string[] harflar, string search)
//   {
//     SortedSet<string> set = new SortedSet<string>(harflar);
//     return set.TryGetValue(search, out string found) ? $"Topildi: {found}" : "Topilmadi";
//   }

//   static void Main()
//   {
//     string[] harflar = {"A", "B", "C"};
//     string search = "B";
//     Console.WriteLine(TryFind(harflar, search));
//   }
// }


