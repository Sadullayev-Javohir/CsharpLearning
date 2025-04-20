// 1. ref misoli: Qiymatni metodda o‘zgartirish
// Shart:

// Bir nechta hisoblashlarni amalga oshiradigan metodga uzatilgan o‘zgaruvchini metod ichida o‘zgartirish kerak. Bunda metod qiymatni manzil orqali o‘zgartiradi.

// int a = 10;
// Multiply(ref a);
// Add(ref a);
// Subtract(ref a);
// Console.WriteLine(a);

// void Multiply(ref int num) => num *= 2;
// void Add(ref int num) => num += 10;
// void Subtract(ref int num) => num -= 10;


// 2. out misoli: Foydalanuvchi kiritgan qiymatni tekshirish
// Shart:

// Foydalanuvchi tomonidan kiritilgan qiymatni tekshirish kerak. Agar kiritilgan qiymat raqam bo‘lsa, uni qaytarish, aks holda xato xabarini chiqarish.


// bool TryParseInteger(string str, out int value) => int.TryParse(str, out value);

// string input = "42";
// if (TryParseInteger(input, out int result))
// {
//   Console.WriteLine("Prased Successfully " + result);
// }
// else
// {
//   Console.WriteLine("Invalid Input");
// }


// 3. params misoli: Ko‘p matnlarni birlashtirish
// Shart:

// Bir nechta matnlarni birlashtirish kerak, bunda metodga noma'lum miqdorda matnlar uzatiladi.


// string result = ConcatenateStrings("Hello", "World", "from", "C#");
// Console.WriteLine(result);


// string ConcatenateStrings(params string[] words) => string.Join(" ", words);



// 4. ref misoli: Array elementlarini o‘zgartirish
// Shart:

// Arraydagi elementlarni metodda o‘zgartirish kerak. Arrayni metodga manzil orqali uzatish orqali uni o‘zgartirish amalga oshiriladi.



// void ModifyArray(ref int[] array)
// {
//   for (int i = 0; i < array.Length; i++)
//   {
//     array[i] *= 10;
//   }
// }

// int[] arr = { 1, 2, 3, 4, };
// ModifyArray(ref arr);
// Console.WriteLine(string.Join(" ", arr));


// 5. out misoli: Bir nechta natijalarni qaytarish
// Shart:

// Metod bir nechta qiymatni qaytarishi kerak. out yordamida metoddan bir nechta natijalar olinadi.


// if (GetDimensions(out int witdth, out int height))
// {
//   Console.WriteLine($"Width: {witdth}, Height: {height}");
// }

// bool GetDimensions(out int width, out int height) {
//   width = 100;
//   height = 50;
//   return true;
// }


// 6. params misoli: Qo‘shish funksiyasi
// Shart:

// Bir nechta sonlarni qo‘shish kerak. params yordamida noma'lum miqdordagi sonlar uzatiladi.


// int AddNumbers(params int[] numbers)
// {
//   int sum = 0;
//   foreach (var num in numbers)
//   {
//     sum += num;
//   }
//   return sum;
// }

// int[] arry = { 1, 2, 3, 4, 5 };
// int sum = AddNumbers(arry);
// Console.WriteLine($"Sum: {sum}");



// 7. ref va out birgalikda ishlatish
// Shart:

// Bir metodda qiymatni manzil orqali o‘zgartirish va yangi qiymatni qaytarish kerak.


// void Calculate(ref int a, out int b)
// {
//   a += 10;
//   b = 25;
// }

// int x = 5;
// int y;
// Calculate(ref x, out y);
// Console.WriteLine($"x: {x}, y: {y}");


