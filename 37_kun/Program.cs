// ✅ Problem 1: Parse and Handle Invalid Input

// Title: ParseIntegerWithErrorHandling
// Problem Statement:
// Berilgan string sonni int turiga o‘tkazing. Agar noto‘g‘ri son kiritsangiz (ya’ni matn bo‘lsa), foydalanuvchiga "Invalid number format" degan xabarni chiqaring. Har qanday holatda "Execution complete" deb yozing.

// Function Signature:

// void ParseAndHandle(string input)

// Input Example:

// ParseAndHandle("123")
// ParseAndHandle("salom")

// Output Example:

// 123
// Execution complete

// Invalid number format
// Execution complete

// Constraints:

//     input string bo‘lib, harf yoki raqam bo‘lishi mumkin

// class Program
// {
//   public static void ParseAndHandle(string input)
//   {
//     try
//     {
//       int result = int.Parse(input);
//       Console.WriteLine(result);
//     }
//     catch(FormatException ex)
//     {
//       Console.WriteLine("Invalid number format: " + ex.Message);
//     }
//     finally
//     {
//       Console.WriteLine("Execution complete");
//     }
//   }
//   static void Main()
//   {
//     ParseAndHandle("abd");
//   }
// }


// ✅ Problem 2: Division Exception Handling

// Title: SafeDivision
// Problem Statement:
// Ikki sonni bo‘ling. Agar bo‘luvchi 0 bo‘lsa, "Cannot divide by zero" xabarini chiqarish kerak. Har doim "Done" deb yozing.

// Function Signature:

// void SafeDivide(int a, int b)

// Input Example:

// SafeDivide(10, 2)
// SafeDivide(5, 0)

// Output Example:

// 5
// Done

// Cannot divide by zero
// Done

// class Program
// {
//   public static void SafeDivide(int a, int b)
//   {
//     try
//     {
//       int result = a / b;
//       Console.WriteLine(result);
//     }
//     catch(DivideByZeroException ex)
//     {
//       Console.WriteLine("Cannot divide by zero: " + ex.Message);
//     }
//     finally
//     {
//       Console.WriteLine("Done");
//     }
//   }
//   static void Main()
//   {
//     SafeDivide(3, 3);
//   }
// }


// ✅ Problem 3: Custom Exception Throw

// Title: ThrowIfNegative
// Problem Statement:
// Agar foydalanuvchi manfiy son kiritsa, NegativeNumberException nomli maxsus xatolik otishingiz kerak. Aks holda sonni ikki baravarga ko‘paytirib chiqaring.

// Function Signature:

// int DoubleIfPositive(int number)

// Input Example:

// DoubleIfPositive(4)
// DoubleIfPositive(-3)

// Output Example:

// 8
// Exception: NegativeNumberException

// class Program
// {
//   public static int DoubleIfPositive(int number)
//   {
//     try
//     {
//       if (number > 0) 
//       {
//         return number * number;
//       }
//       throw new NegativeNumberException("NegativeNumberException");
//     }
//     catch(NegativeNumberException ex)
//     {
//       Console.WriteLine(ex.Message);
//       return -1;
//     }
//   }
//   static void Main()
//   {
//     Console.WriteLine(DoubleIfPositive(-25));
//   }
// }

// class NegativeNumberException : Exception
// {
//   public NegativeNumberException(string message) : base(message) {}
// }



// ✅ Problem 4: Array Index Checker

// Title: SafeArrayAccess
// Problem Statement:
// Berilgan massiv va indeks bo‘yicha qiymatni qaytaring. Agar indeks massiv chegarasidan chiqsa, "Index out of range" degan xatolik chiqaring.

// Function Signature:

// int GetElementAt(int[] arr, int index)

// Input Example:

// GetElementAt([1, 2, 3], 1)
// GetElementAt([1, 2, 3], 5)

// Output Example:

// 2
// Exception: Index out of range


// class Program
// {
//   public static int GetElementAt(int[] arr, int index)
//   {
//     try
//     {
//       int result = arr[index];
//       return result;
//     }
//     catch(IndexOutOfRangeException ex)
//     {
//       Console.WriteLine("Xatolik, Index out of range", ex.Message);
//       return -1;
//     }
//     finally
//     {
//       Console.WriteLine("Finish");
//     }
//   }

//   static void Main()
//   {
//     int[] nums = {1,2,3,4};
//     Console.WriteLine(GetElementAt(nums, 2));
//   }
// }



// ✅ Problem 5: Re-throw Exception

// Title: ReThrowTest
// Problem Statement:
// try blokida xatolik yuz beradi. Siz uni catch ichida ushlab, qayta otishingiz kerak. Main metodda uni qayta ushlab, xabar chiqaring.

// Function Signature:

// void Test()

// Input Example:

// Test()

// Output Example:

// Exception caught in main: Simulated error


// class Program
// {
//   public static void Test()
//   {
//     try
//     {
//       throw new Exception("Simulated error");
//     }
//     catch(Exception)
//     {
//       throw;
//     }
//   }

//   static void Main()
//   {
//     try
//     {
//       Test();
//     }
//     catch(Exception ex)
//     {
//       Console.WriteLine("Exception caught in main: " + ex.Message);
//     }
//   }
// }


// ✅ Problem 6: Finally Logger

// Title: LoggingWithFinally
// Problem Statement:
// Massivdagi elementlar ustida operatsiya bajariladi. Har bir blok bajarilgach finally orqali "Log: Processed" chiqaring.

// Function Signature:

// void ProcessElement(int[] arr, int index)

// Input Example:

// ProcessElement([1, 2], 1)
// ProcessElement([1, 2], 5)

// Output Example:

// 2
// Log: Processed

// Exception: Index was outside the bounds
// Log: Processed

// class Program
// {
//   public static void ProcessElement(int[] arr, int index)
//   {
//     try
//     {
//       int result = arr[index];
//       Console.WriteLine(result);
//     }
//     catch(IndexOutOfRangeException ex)
//     {
//       Console.WriteLine("Xatolik indeksdan chiqib ketdi. " + ex.Message);
//     }
//     finally
//     {
//       Console.WriteLine("Log: Procceed");
//     }
//   }

//   static void Main()
//   {
//     int[] nums = {1,2,3,4};
//     ProcessElement(nums, 2);
//   }
// }



// ✅ Problem 7: Nested Try-Catch

// Title: NestedTryDemo
// Problem Statement:
// Ichki try blokda FormatException yuz beradi. Siz uni tashqi catch orqali maxsus CustomException ga o‘rab ko‘rsating.

// Function Signature:

// void NestedTryCatch(string input)

// Output Example:

// Exception: Caught CustomException: Input invalid


// class MyException : Exception
// {
//   public MyException(string message) : base(message) {}
// }

// class Program
// {
//   public static void NestedTryCatch(string input)
//   {
//     try
//     {
//       try
//       {
//         int number = int.Parse(input);
//       }
//       catch(FormatException)
//       {
//         throw;
//       }
//     }
//     catch(FormatException)
//     {
//       throw new MyException("Caught CustomException: Input invalid");
//     }
//   }

//   static void Main()
//   {
//     try
//     {
//       NestedTryCatch("abc");
//     }
//     catch(MyException ex)
//     {
//       Console.WriteLine("Exception: " + ex.Message);
//     }
//   }
// }


// ✅ Problem 8: Check Null Safety

// Title: NullSafetyChecker
// Problem Statement:
// Agar matn null bo‘lsa, "Input is null" chiqaring, aks holda uning uzunligini qaytaring.

// Function Signature:

// int GetLength(string input)

// Input Example:

// GetLength("hello")
// GetLength(null)

// Output Example:

// 5
// Input is null

// class Program
// {
//   public static int GetLength(string input)
//   {
//     try
//     {
//       return input.Length;
//     }
//     catch(NullReferenceException ex)
//     {
//       Console.WriteLine("Xatolik, Input is null " + ex.Message);
//       return 0;
//     }
//   }

//   static void Main()
//   {
//     Console.WriteLine(GetLength(null));
//   }
  
// }


