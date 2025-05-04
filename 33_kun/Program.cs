// 🟢 1. Add Five to Input

// Difficulty: Easy

// Problem: Sizga bir int qiymat beriladi. Uni 5 ga oshiring va natijani qaytaring.

// Function Signature:

// Func<int, int> AddFive;

// Example:
// Input: 3
// Output: 8

// class Program
// {
//   public static Func<int, int> AddFive = (x) => 5 + x;
//   static void Main()
//   {
//     Console.WriteLine(AddFive(3));
//   }
// }



// 🟢 2. Greet By Name

// Difficulty: Easy

// Problem: Berilgan ism orqali "Salom, [ism]" ko‘rinishida ekranga xabar chiqaring.

// Function Signature:

// Action<string> Greet;

// Example:
// Input: "Javohir"
// Output: Salom, Javohir

// class Program
// {
//   public static Action<string> Greet = (ism) => Console.WriteLine($"Salom, {ism}");

//   static void Main()
//   {
//     string name = "Javohir";
//     Greet(name);
//   }
// }



// 🟢 3. Is Even

// Difficulty: Easy

// Problem: Berilgan son juftmi yoki toqmi — true yoki false qaytaring.

// Function Signature:

// Predicate<int> IsEven;

// Example:
// Input: 6
// Output: true

// class Program
// {
//   public static Predicate<int> IsEven = (x) => x % 2 == 0;

//   static void Main()
//   {
//     Console.WriteLine(IsEven(4));
//   }
// }



// 🟡 4. Find Maximum of Two

// Difficulty: Medium

// Problem: Ikki son beriladi. Ulardan kattasini qaytaring.

// Function Signature:

// Func<int, int, int> MaxOfTwo;

// Example:
// Input: 4, 9
// Output: 9

// class Program
// {
//   public static Func<int, int, int> MaxOfTwo = (a, b) => a > b ? a : b;

//   static void Main()
//   {
//     Console.WriteLine(MaxOfTwo(2, 10));
//   }
// }


// 🟢 5. Square a Number

// Difficulty: Easy

// Problem: Berilgan sonning kvadratini qaytaring.

// Function Signature:

// Func<int, int> Square;

// Example:
// Input: 7
// Output: 49


// class Program
// {
//   public static Func<int, int> Square = (x) => x * x;

//   static void Main()
//   {
//     Console.WriteLine(Square(5));
//   }
// }


// 🟡 6. Print List Elements

// Difficulty: Medium

// Problem: Berilgan List<string> elementlarini ekranga chiqarish uchun Action<List<string>> yarating.

// Function Signature:

// Action<List<string>> PrintList;

// Example:
// Input: ["apple", "banana"]
// Output:

// apple  
// banana

// class Program
// {
//   public static Action<List<string>> PrintList = (list) => 
//   {
//     foreach(var i in list)
//     {
//       Console.WriteLine(i);
//     }
//   };

//   static void Main()
//   {
//     List<string> mevalar = new List<string>() {"Olma", "Anor", "Nok"};
//     PrintList(mevalar);
//   }
// }


// 🟡 7. Count Even Numbers in List

// Difficulty: Medium

// Problem: Berilgan List<int> ichidan juft sonlar sonini hisoblang.

// Function Signature:

// Func<List<int>, int> CountEven;

// Example:
// Input: [1, 2, 4, 7]
// Output: 2

// class Program
// {
//   public static Func<List<int>, int> CountEven = (list) => 
//   {
//     int count = 0;
//     foreach(var i in list)
//     {
//       if (i % 2 == 0)
//       {
//         count++;
//       } 
//     }
//     return count;
//   };

//   static void Main()
//   {
//     List<int> sonlar = new List<int>() {1, 2, 4, 7};
//     Console.WriteLine(CountEven(sonlar));
//   }
// }


// 🔴 8. Filter Positive Numbers

// Difficulty: Hard

// Problem: Berilgan sonlar ro‘yxatidan faqat musbatlarini ajratib oling.

// Function Signature:

// Func<List<int>, List<int>> FilterPositive;

// Example:
// Input: [-5, 3, 0, 8]
// Output: [3, 8]


// class Program
// {
//   public static Func<List<int>, List<int>> FilterPositive = (list) => 
//   {
//     List<int> sonlar = new List<int>();
//     foreach(var i in list)
//     {
//       if (i > 0)
//       {
//         sonlar.Add(i);
//       }
//     }
//     return sonlar;
//   };

//   static void Main()
//   {
//     List<int> inputNum = new List<int>(){-5, 3, 0, 8};
//     List<int> musbatSonlar = FilterPositive(inputNum);
//     foreach(var i in musbatSonlar)
//     {
//       Console.WriteLine(i);
//     }
//   }
// }



// 🟡 9. Reverse a String

// Difficulty: Medium

// Problem: Berilgan matnni teskari qilib qaytaring.

// Function Signature:

// Func<string, string> ReverseString;

// Example:
// Input: "hello"
// Output: "olleh"


// class Program
// {
//   public static Func<string, string> ReverseString = (matn) => 
//   {
//     string reverseMatn = "";
//     foreach(var i in matn)
//     {
//       reverseMatn = i + reverseMatn;
//     }
//     return reverseMatn;
//   };

//   static void Main()
//   {
//     Console.WriteLine(ReverseString("hello"));
//   }
// }



// 🔴 10. Custom Filter with Predicate

// Difficulty: Hard

// Problem: Sizga List<int> va Predicate<int> beriladi. Shunga asosan FilterList funksiyasini yarating — faqat Predicate shartiga mos kelganlar qaytsin.

// Function Signature:

// Func<List<int>, Predicate<int>, List<int>> FilterList;

// Example:
// Input: [1, 2, 3, 4], condition: x => x > 2
// Output: [3, 4]


// class Program
// {
//   public static Func<List<int>, Predicate<int>, List<int>> FilterList = (list, tekshirish) => 
//   {
//     List<int> kattaSonlar = new List<int>();

//     foreach(var i in list)
//     {
//       if (tekshirish(i))
//       {
//         kattaSonlar.Add(i);
//       }
//     }
//     return kattaSonlar;
//   };

//   static void Main()
//   {
//     List<int> sonlar = new List<int>(){1, 2, 3, 4};
//     Predicate<int> katta = (x) => x > 2;
//     List<int> kattaSonlar = FilterList(sonlar, katta);
//     foreach(var i in kattaSonlar)
//     {
//       Console.WriteLine(i);
//     }
//   }
// }

