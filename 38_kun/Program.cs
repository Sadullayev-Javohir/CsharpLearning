using System;
using System.IO;

// 1. Masala: Fayldan barcha satrlarni o‘qish

// Problem:
// Berilgan fayldan barcha satrlarni o‘qing va ularni birlashtirib bitta satrga qaytaring.

// Input:

//     Fayl file.txt berilgan bo‘lib, uning ichida bir nechta satr mavjud.

// Output:

//     String: fayldagi barcha satrlarning birlashtirilgan natijasi.

// Example:

//     Input (file.txt):

// Hello, world!
// This is a test.
// C# file reading.

// Output: "Hello, world! This is a test. C# file reading."

// class Program
// {
//   public static string ReadFile(string path)
//   {
//     string[] result = File.ReadAllLines(path);
//     return String.Join(" ", result);
//   }

//   static void Main()
//   {
//     string result = ReadFile("file.txt");
//     Console.WriteLine(result);
//   }
// }


// 2. Masala: Fayldan barcha satrlarni massivga o‘qish

// Problem:
// Berilgan fayldan barcha satrlarni o‘qing va har bir satrni massivga saqlang.

// Input:

//     Fayl file.txt berilgan bo‘lib, uning ichida bir nechta satr mavjud.

// Output:

//     String[]: fayldagi har bir satr massiv elementiga aylanadi.

// Example:

//     Input (file.txt):

// Apple
// Banana
// Cherry

// Output: ["Apple", "Banana", "Cherry"]

// class Program
// {
//   public static string[] ReadFile(string FilePath)
//   {
//     return File.ReadAllLines(FilePath);
//   }

//   static void Main()
//   {
//     string[] result = ReadFile("file.txt");
//     foreach(var i in result)
//     {
//       Console.WriteLine(i);
//     }
//   }
// }



// 3. Masala: Fayldan satrni oqim tarzida o‘qish

// Problem:
// Berilgan fayldan har bir satrni oqim tarzida o‘qing va konsolga chiqarish.

// Input:

//     Fayl file.txt berilgan bo‘lib, uning ichida bir nechta satr mavjud.

// Output:

//     Fayldagi har bir satrni konsolga chiqarish.

// Example:

//     Input (file.txt):

// Line 1
// Line 2
// Line 3

// Output:

// Line 1
// Line 2
// Line 3


// class Program
// {
//   public static void FileRead(string Path)
//   {
//     foreach(string i in File.ReadLines(Path))
//     {
//       Console.WriteLine(i);
//     }
//   }
//   static void Main()
//   {
//     FileRead("file.txt");
//   }
// }


// 4. Masala: Fayldan satrni aniqlangan uzunlikda o‘qish

// Problem:
// Berilgan fayldan 5 ta belgi uzunlikdagi satrni o‘qing va qaytaring.

// Input:

//     Fayl file.txt berilgan bo‘lib, uning ichida bir nechta satr mavjud.

// Output:

//     String[]: fayldan o‘qilgan har bir satr 5 ta belgi uzunlikda bo‘ladi.

// Example:

//     Input (file.txt):

// Hello
// World
// This
// Is
// Test

// Output: ["Hello", "World", "This", "Is", "Test"]


// class Program
// {
//   public static string[] ReadFile(string Path)
//   {
//     string[] lines = File.ReadAllLines(Path);

//     for (int i = 0; i < lines.Length; i++)
//     {
//       if (lines[i].Length > 5)
//       {
//         lines[i] = lines[i].Substring(0, 5);
//       }
//     }
//     return lines;
//   }

//   static void Main()
//   {
//     string[] result = ReadFile("file.txt");
//     foreach(var i in result)
//     {
//       Console.WriteLine(i);
//     }
//   }
// }

// class Program
// {
//   public static int CountLines(string path) 
//   {
//     return File.ReadAllLines(path).Length;
//   }

//   static void Main()
//   {
//     int result = CountLines("file.txt");
//     Console.WriteLine(result);
//   }
// }

// 7. Masala: Fayldan faqat maxsus belgilarga ega satrlarni o‘qish

// Problem:
// Berilgan fayldan faqat raqamli belgilarga ega satrlarni o‘qing va ularni qaytaring.

// Input:

//     Fayl file.txt berilgan bo‘lib, uning ichida bir nechta satr mavjud.

// Output:

//     String[]: faqat raqamli satrlar.

// Example:

//     Input (file.txt):

// 12345
// Hello
// 67890
// World

// Output: ["12345", "67890"]

// class Program
// {
//   public static string[] ReadNumber(string path)
//   {
//     return File.ReadAllLines(path).Where(line => line.All(char.IsDigit)).ToArray();
//   }

//   static void Main()
//   {
//     string[] result = ReadNumber("file.txt");
//     foreach(var i in result)
//     {
//       Console.WriteLine(i);
//     }
//   }
// }


// 8. Masala: Fayldagi so‘zlarni sanash

// Problem:
// Berilgan fayldan barcha so‘zlarni o‘qing va umumiy so‘zlar sonini hisoblang.

// Input:

//     Fayl file.txt berilgan bo‘lib, uning ichida bir nechta satr mavjud.

// Output:

//     Integer: fayldagi jami so‘zlar soni.

// Example:

//     Input (file.txt):

//     Hello world
//     This is a test

//     Output: 5


// class Program
// {
//   public static int Count(string path)
//   {
//     return File.ReadAllText(path).Split(new[] {' ', '\n', '\r'}, StringSplitOptions.RemoveEmptyEntries).Length;
//   }
//   static void Main()
//   {
//     Console.WriteLine(Count("file.txt"));
//   }
// }



// 9. Masala: Fayldan so‘zlarni o‘qish va sortlash

// Problem:
// Berilgan fayldan barcha so‘zlarni o‘qing, ular bo‘yicha tartiblashtiring va qaytaring.

// Input:

//     Fayl file.txt berilgan bo‘lib, uning ichida bir nechta so‘zlar mavjud.

// Output:

//     String[]: so‘zlar tartiblangan holda qaytariladi.

// Example:

//     Input (file.txt):

// banana
// apple
// cherry

// Output: ["apple", "banana", "cherry"]

  // class Program
  // {
  //   public static SortedSet<string> SortTexts(string filePath)
  //   {
  //     string[] texts = File.ReadAllLines(filePath);
  //     SortedSet<string> result = new SortedSet<string>(texts);
  //     return result;
  //   }

  //   static void Main()
  //   {
  //     var result = SortTexts("file.txt");
  //     foreach(var i in result)
  //     {
  //       Console.WriteLine(i);
  //     }
  //   }
  // }



//   10. Masala: Fayldan faqat maxsus so‘zlarni o‘qish

// Problem:
// Berilgan fayldan faqat maxsus so‘zlarni o‘qing, bu so‘zlar faqat harflardan iborat bo‘lishi kerak.

// Input:

//     Fayl file.txt berilgan bo‘lib, uning ichida bir nechta so‘zlar mavjud.

// Output:

//     String[]: faqat harflardan iborat bo‘lgan so‘zlar.

// Example:

//     Input (file.txt):

// apple 123
// orange!
// hello
// world 456

// Output: ["apple", "orange", "hello"]

// class Program
// {
//   public static string[] PrintLetters(string path)
//   {
//     return File.ReadAllText(path).Split(new[] {' ', '\n', '\t', '\r'}).Where(word => word.All(char.IsLetter)).ToArray();
//   }
//   static void Main()
//   {
//     string[] result = PrintLetters("file.txt");
//     Console.WriteLine(String.Join(", ", result));
//   }
// }