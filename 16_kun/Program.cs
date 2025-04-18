// ✅ 1. Massiv elementlarini chiqarish

// Vazifa: int[] tipidagi massivdagi barcha sonlarni foreach yordamida ekranga chiqaring.

// int[] sonlar = { 1, 2, 3, 4, 5, 6, 7, };
// foreach (var item in sonlar)
// {
//   Console.WriteLine(item);  
// }


// ✅ 2. String elementlarga “Salom” yozuvi qo‘shish

// Vazifa: string[] ismlar massivida har bir ismga "Salom, " ni qo‘shib, natijani chiqaring.

// string[] ismlar = { "Javohir", "Diyor", "Ilyos" };

// foreach (var item in ismlar)
// {
//   Console.WriteLine($"Salom {item}");
// }


// ✅ 3. Massivdagi juft sonlar sonini hisoblash

// Vazifa: int[] massivdan foreach orqali faqat juft sonlarni toping va ularning sonini hisoblang.

// int[] sonlar = { 1, 2, 3, 4, 5, 6 };
// int count = 0;
// foreach (var item in sonlar)
// {
//   if (item % 2 == 0)
//   {
//     count++;
//   }
// }
// Console.WriteLine($"{count} ta juft son bor");



// ✅ 4. Massivdagi maksimal qiymatni topish

// Vazifa: foreach yordamida int[] massivdagi eng katta sonni toping.

// int[] sonlar = { 100, 3, 14, 7, 120 };
// int maxValue = sonlar[0];
// foreach (var item in sonlar)
// {
//   if (maxValue < item)
//   {
//     maxValue = item;
//   }
// }

// Console.WriteLine("En katta son: " + maxValue);


// ✅ 5. String elementlarning uzunligini chiqarish

// Vazifa: foreach yordamida har bir ismning uzunligini (Length) chiqaring.

// string[] ismlar = { "Ali", "Zuhra", "Muhammad" };

// foreach (var item in ismlar)
// {
//   Console.WriteLine($"{item}: {item.Length}");
// }


// ✅ 6. Massivdagi manfiy sonlar yig‘indisini hisoblash

// Vazifa: foreach orqali manfiy sonlarni toping va ularning yig‘indisini hisoblang.

// int[] sonlar = { -3, 7, -1, 4, -6 };
// int s = 0;

// foreach (var item in sonlar)
// {
//   if (item < 0)
//   {
//     s += item;
//   }
// }

// Console.WriteLine(s);


// ✅ 7. Har bir harfni katta harfga aylantirish

// Vazifa: string[] tipidagi so‘zlar massividagi har bir so‘zni katta harfga (ToUpper) aylantirib chiqaring.

// string[] sozlar = { "salom", "dunyo", "csharp" };

// foreach (var item in sozlar)
// {
//   Console.WriteLine(item.ToUpper());
// }


// ✅ 8. 2-o‘lchamli massivdagi sonlar yig‘indisi

// Vazifa: int[,] 2-o‘lchovli massivda barcha sonlarning yig‘indisini foreach yordamida hisoblang.

// int[,] matritsa = {
//   {1, 2},
//   {3, 4},
// };
// int s = 0;
// foreach (var item in matritsa)
// {
//   s += item;
// }

// Console.WriteLine(s);


// ✅ 9. Eng uzun ismni topish

// Vazifa: foreach yordamida eng uzun string elementni toping.

// string[] ismlar = { "Ali", "Zuhra", "Muhammad", "Sardorbek" };
// var maxLength = ismlar[0];
// foreach (var item in ismlar)
// {
//   if (maxLength.Length < item.Length)
//   {
//     maxLength = item;
//   }
// }

// Console.WriteLine("Eng uzun so'z " + maxLength);


// ✅ 10. Harflar massivida unli harflarni sanash

// Vazifa: char[] massivida foreach orqali unli harflar sonini toping (a, e, i, o, u).

// char[] harflar = { 'a', 'b', 'c', 'e', 'o', 'r', 'u' };
// char[] unliHarflar = { 'a', 'e', 'u', 'i', 'o' };
// int count = 0;
// foreach (var item in harflar)
// {
//   foreach (var inner in unliHarflar)
//   {
//     if (inner == item)
//     {
//       count++;
//     }
//   }
// }

// Console.WriteLine($"{count} ta unli harf bor.");



