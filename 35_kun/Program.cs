using System;
using System.Collections.Generic;
using System.Linq;
// ✅ 1. Takrorlanuvchi sonlarni o‘chirish

// Masala:
// Sizga nums nomli butun sonlardan iborat ro‘yxat berilgan. Ushbu ro‘yxatdan takroriy elementlarni olib tashlang va yagona (takrorlanmagan) sonlar ro‘yxatini, ularning ketma-ketligini saqlagan holda qaytaring.

// Input:

// nums = [1, 2, 2, 3, 4, 3, 5]

// Output:

// [1, 2, 3, 4, 5]

// Cheklovlar:

//     1 <= nums.Length <= 1000

//     -10^4 <= nums[i] <= 10^4


// class Solution {
//   public static List<int> RepeatNumsRemove(List<int> nums) {
//     HashSet<int> seen = new HashSet<int>();
//     List<int> result = new List<int>();

//     foreach(var num in nums)
//     {
//       if(!seen.Contains(num))
//       {
//         seen.Add(num);
//         result.Add(num);
//       }
//     }
//     return result;
//   }

//   static void Main()
//   {
//     List<int> nums = new List<int>(){1, 2, 2, 3, 4, 3, 5};
//     List<int> result = RepeatNumsRemove(nums);
//     foreach(var i in result)
//     {
//       Console.WriteLine(i);
//     }
//   }
// }



// ✅ 2. Eng ko‘p uchragan elementni topish

// Masala:
// Berilgan nums ro‘yxatdagi eng ko‘p uchragan elementni toping. Agar bir nechta shunday element bo‘lsa, ularning birortasini qaytaring.

// Input:

// nums = [1, 3, 2, 3, 4, 3, 2]

// Output:

// 3

// Cheklovlar:

//     1 <= nums.Length <= 1000

// public class Solution
// {
//   public static int WideNum(int[] nums)
//   {
//     Dictionary<int, int> dict = new Dictionary<int, int>();
//     int MaxCount = 0;
//     int result = 0;
//     foreach(int num in nums)
//     {
//       if (!dict.ContainsKey(num))
//         dict[num] = 0;
//       dict[num]++;
//       if (dict[num] > MaxCount)
//       {
//         MaxCount = dict[num];
//         result = num;
//       }
//     }
//     return result;
//   }
//   static void Main()
//   {
//     int[] nums = {1,2,2,3,4,5,6};
//     int result = WideNum(nums);
//     Console.WriteLine(result);
//   }
// }



// ✅ 3. Takroriy juft sonlar sonini hisoblash

// Masala:
// nums ro‘yxatda nechta turli juft sonlar mavjudligini hisoblang (takrorlar hisobga olinmaydi).

// Input:

// nums = [2, 4, 4, 6, 1, 3, 2]

// Output:

// 3

// class Program 
// {
//   public static int JamiJuftlar(int[] nums)
//   {
//     SortedSet<int> sonlar = new SortedSet<int>(nums);
//     int count = 0;
//     foreach(var i in sonlar)
//     {
//       if (i % 2 == 0)
//       {
//         count++;
//       }
//     }
//     return count;
//   }

//   static void Main()
//   {
//     int[] nums = {2, 4, 4, 6, 1, 3, 2};
//     int result = JamiJuftlar(nums);
//     Console.WriteLine(result);
//   }
// }



// ✅ 4. Ro‘yxatni teskari tartibda chiqarish

// Masala:
// Sizga nums nomli ro‘yxat berilgan. Uni teskari tartibda qaytaring.

// Input:

// nums = [1, 2, 3, 4]

// Output:

// [4, 3, 2, 1]

// class Program
// {
//   public static List<int> ReversedNums(int[] nums)
//   {
//     List<int> reversed = new List<int>(nums);
//     reversed.Reverse();
//     return reversed;
//   }
//   static void Main()
//   {
//     List<int> sonlar = ReversedNums(new int[] {1, 2, 3, 4});
//     foreach(var i in sonlar)
//     {
//       Console.WriteLine(i);
//     }
//   }
// }



// ✅ 5. Eng kichik va eng katta sonni topish

// Masala:
// Berilgan ro‘yxatdan eng kichik va eng katta elementni topib, ro‘yxat shaklida qaytaring: [min, max]

// Input:

// nums = [5, 3, 9, 1, 6]

// Output:

// [1, 9]

// class Program
// {
//   public static List<int> MinMax(int[] nums)
//   {
//     int Min = nums[0];
//     int Max = nums[0];
//     foreach(var i in nums)
//     {
//       if (i < Min)
//       {
//         Min = i;
//       }
//       if (i > Max)
//       {
//         Max = i;
//       }
//     }
//     return new List<int>(){Min, Max};
//   }
//   static void Main()
//   {
//     int[] nums = {5, 3, 9, 1, 6};
//     List<int> result = MinMax(nums);
//     foreach(var i in result)
//     {
//       Console.WriteLine(i);
//     }
//   }
// }



// ✅ 6. Ikkita ro‘yxatning umumiy elementlarini topish

// Masala:
// Sizga list1 va list2 ro‘yxatlari berilgan. Har ikkala ro‘yxatda mavjud bo‘lgan elementlarni (takrorlarsiz) ro‘yxat shaklida qaytaring.

// Input:

// list1 = [1, 2, 3, 4], list2 = [3, 4, 5, 6]

// Output:

// [3, 4]

// public class Solution
// {
//   public static List<int> CommonNums(List<int> nums1, List<int> nums2)
//   {
//     HashSet<int> sonlar1 = new HashSet<int>(nums1);
//     HashSet<int> result = new HashSet<int>();

//     foreach(var i in nums2)
//     {
//       if (sonlar1.Contains(i)) result.Add(i);
//     }
//     return new List<int>(result);
//   }

//   static void Main()
//   {
//     List<int> list1 = new List<int> {1, 2, 3, 4};
//     List<int> list2 = new List<int> {3, 4, 5, 6};
//     List<int> result = CommonNums(list1, list2);
//     foreach(var i in result)
//     {
//       Console.WriteLine(i);
//     }
//   }
// }


// ✅ 7. Har bir sonning ro‘yxatdagi tartib raqamini chiqarish

// Masala:
// Berilgan nums ro‘yxatidagi har bir son uchun, u ro‘yxatda nechinchi marta uchrayotganini chiqaring.

// Input:

// nums = [1, 2, 1, 2, 1]

// Output:

// [1, 1, 2, 2, 3]

// class Program
// {
//   public static List<int> GetOccurance(int[] nums)
//   {
//     Dictionary<int, int> count = new Dictionary<int, int>();
//     List<int> result = new List<int>();

//     foreach(var num in nums)
//     {
//       if (!count.ContainsKey(num)) count[num] = 0;
//       count[num]++;
//       result.Add(count[num]);
//     }
//     return result;
//   }

//   static void Main()
//   {
//     int[] nums = {1, 2, 1, 2, 1};
//     List<int> result = GetOccurance(nums);
//     Console.WriteLine(String.Join(", ", result));
//   }
// }


// ✅ 8. Sonlarni ko‘paytirish jadvalini yaratish

// Masala:
// Sizga n butun soni beriladi. 1 dan n gacha bo‘lgan sonlar uchun ko‘paytirish jadvali ro‘yxatini tuzing.

// Input:

// n = 3

// Output:

// ["1x1=1", "1x2=2", "1x3=3", "2x1=2", ..., "3x3=9"]

// class Program
// {
//   public static List<string> MultiplicationTable(int n)
//   {
//     List<string> table = new List<string>();
//     for (int i = 1; i <= n; i++)
//     {
//       for (int j = 1; j <= n; j++)
//       {
//         table.Add($"\n{i} x {j} = {i * j}");
//       }
//     }
//     return table;
//   }
//   static void Main()
//   {
//     var result = MultiplicationTable(5);
//     Console.WriteLine(String.Join(", ", result));
//   }
// }



// ✅ 9. Harflarning chastotasini hisoblash

// Masala:
// Berilgan satrdagi har bir harf necha marta uchraganini hisoblang va lug‘at shaklida qaytaring.

// Input:

// s = "hello"

// Output:

// { 'h': 1, 'e': 1, 'l': 2, 'o': 1 }

// class Solution
// {
//   public static Dictionary<char, int> Frequency(string text)
//   {
//     Dictionary<char, int> dict = new Dictionary<char, int>();
//     foreach(var i in text)
//     {
//       if (!dict.ContainsKey(i)) dict[i] = 0;
//       dict[i]++;
//     }
//     return dict;
//   }

//   static void Main()
//   {
//     string text = "Welcome to Candy Shop";
//     Dictionary<char, int> result = Frequency(text);
//     foreach(var i in result)
//     {
//       Console.WriteLine($"{i.Key} : {i.Value}");
//     }
//   }
// }


// ✅ 10. Ro‘yxatni faqat musbat sonlar bilan tozalash

// Masala:
// Berilgan ro‘yxatdan barcha manfiy sonlarni olib tashlab, faqat musbat sonlar ro‘yxatini qaytaring.

// Input:

// nums = [-2, 3, -1, 4, 0]

// Output:

// [3, 4]

// class Solution
// {
//   public static List<int> ManfiyDelete(int[] nums)
//   {
//     List<int> result = new List<int>();
//     foreach(var i in nums)
//     {
//       if (i > 0)
//       {
//         result.Add(i);
//       }
//     }
//     return result;
//   }

//   static void Main()
//   {
//     int[] nums = {-2, 3, -1, 4, 0};
//     List<int> result = ManfiyDelete(nums);
//     Console.WriteLine(String.Join(", ", result));
//   }
// }