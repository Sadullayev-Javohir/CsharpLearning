// ✅ 1. Divide Two Numbers Safely

// Description:
// Ikki sonni bo‘lish kerak. Agar bo‘linuvchi 0 bo‘lsa, DivideByZeroException chiqarilsin.

// Function Signature:

// int SafeDivide(int a, int b)

// Input: SafeDivide(10, 2)
// Output: 5

// Input: SafeDivide(10, 0)
// Output: "Cannot divide by zero!"

// Constraints: -1000 ≤ a, b ≤ 1000

// int SafeDivide(int a, int b)
// {
//   try 
//   {
//     return a / b;
//   }
//   catch(DivideByZeroException) 
//   {
//     Console.WriteLine("Sonni no'lga bo'lib bo'lmaydi");
//     return 0;
//   }
// }

// Console.WriteLine(SafeDivide(4, 3));




// ✅ 2. Parse Integer Safely

// Description:
// Foydalanuvchi matn kiritadi. Agar bu matnni int ga o‘tkaza olmasak, FormatException chiqarilsin.

// Function Signature:

// int ParseInteger(string input)

// Input: "123"
// Output: 123

// Input: "abc"
// Output: "Invalid input!"

// int ParseInteger(string input)
// {
//   try
//   {
//     return int.Parse(input);
//   }
//   catch(FormatException)
//   {
//     Console.WriteLine("Bu matnni songa aylantira olmaysiz");
//     return -1;
//   }
// }

// Console.WriteLine(ParseInteger("igi"));


// ✅ 3. Access Array Safely

// Description:
// Massivdan indeks orqali qiymat olish. Agar indeks noto‘g‘ri bo‘lsa, IndexOutOfRangeException chiqsin.

// Function Signature:

// int GetArrayValue(int[] arr, int index)

// Input: [1,2,3], 1
// Output: 2

// Input: [1,2,3], 5
// Output: "Invalid index!"

// int GetArrayValue(int[] arr, int index)
// {
//   try
//   {
//     return arr[index];
//   }
//   catch(IndexOutOfRangeException)
//   {
//     Console.WriteLine("Invalid index!");
//     return 0;
//   }
// };
// int[] arr = {1,2,3};
// Console.WriteLine(GetArrayValue(arr, 4));



// ✅ 4. Custom Age Validation

// Description:
// Yoshni qabul qilish. Agar manfiy bo‘lsa, throw orqali ArgumentOutOfRangeException otish.

// Function Signature:

// void SetAge(int age)

// Input: 25 → Output: Accepted
// Input: -5 → Output: Invalid age!

// void SetAge(int age)
// {
//   if (age < 0)
//   {
//     throw new ArgumentOutOfRangeException("Invalid message");
//   }
//   Console.WriteLine("Accepted");
// }
// SetAge(-55);



// ✅ 5. Finally Always Executes

// Description:
// finally blok har doim bajarilishini ko‘rsating.

// Function Signature:

// void DemoFinally()

// Output:

// Try block
// Finally block

// void DemoFinally()
// {
//   try
//   {
//     Console.WriteLine("Try block");
//   }
//   finally
//   {
//     Console.WriteLine("Catch block");
//   }
// }

// DemoFinally();



// ✅ 6. Nested Try-Catch

// Description:
// Ichma-ich try-catch blok ishlatish.

// Function Signature:

// void NestedTryCatch()

// Output:

// Inner catch
// Outer finally

// void NestedTryCatch()
// {
//   try
//   {
//     try
//     {
//       int x = int.Parse("abc");
//     }
//     catch
//     {
//       Console.WriteLine("Inner catch");
//     }
//   }
//   finally
//   {
//     Console.WriteLine("Outer Finally");
//   }
// }

// NestedTryCatch();



// ✅ 8. Throw in Catch Block

// Description:
// catch blokda boshqa xatolik chiqarish.

// Function Signature:

// void ThrowInsideCatch()

// Output:

// Catch block
// Unhandled: New exception!

// void ThrowInsideCatch() 
// {
//   try
//   {
//     throw new Exception("First");
//   }
//   catch
//   {
//     Console.WriteLine("Catch block");
//     throw new Exception("New exception!");
//   }
// }

// ThrowInsideCatch();


// ✅ 9. Multiple Catch Blocks

// Description:
// Turli exceptionlar uchun alohida catch bloklar.

// Function Signature:

// void MultipleCatches(string input)

// Input: "0" → Output: Divide by zero
// Input: "abc" → Output: Invalid number

// void MultipleCatches(string input) 
// {
//   try 
//   {
//     int num = int.Parse(input);
//     int result = 10 / num;
//     Console.WriteLine(result);
//   }
//   catch(FormatException)
//   {
//     Console.WriteLine("Invalid number");
//   }
//   catch(DivideByZeroException)
//   {
//     Console.WriteLine("Divide by zero");
//   }
// }
// MultipleCatches("ABC");


// ✅ 10. Throw and Rethrow

// Description:
// Xatolikni ushlab, uni yana tashlash (throw;).

// Function Signature:

// void RethrowDemo()


// void RethrowDemo()
// {
//   try
//   {
//     try 
//     {
//       throw new Exception("Inner error");
//     }
//     catch
//     {
//       Console.WriteLine("Handling and rethrowing");
//       throw;
//     }
//   }
//   catch(Exception ex)
//   {
//     Console.WriteLine("Final catch: " + ex.Message);
//   }
// }

// RethrowDemo();