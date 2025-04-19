// 🔁 1. Faktorial topish

// Tavsif: Berilgan n soni uchun n! (faktorial) ni rekursiv funksiya bilan hisoblang.
// 📌 Misol: Faktorial(5) → 120

// int Factorial(int n )
// {
//   if (n == 0 || n == 1) return 1;
//   return n * Factorial(n - 1);
// }
// Console.WriteLine(Factorial(5));



// 🔁 2. Fibonachchi soni

// Tavsif: Fibonachchi ketma-ketligining n-elementini toping.
// 📌 Misol: Fibonacci(6) → 8

// int Fibonachchi(int n)
// {
//   if (n == 0) return 0;
//   if (n == 1) return 1;
//   return Fibonachchi(n - 1) + Fibonachchi(n - 2);
// }
// Console.WriteLine(Fibonachchi(10));


// 🔁 3. Natural sonlar yig'indisi (1 dan n gacha)

// Tavsif: 1 + 2 + 3 + ... + n ni rekursiya yordamida hisoblang.
// 📌 Misol: Sum(5) → 15

// int hisoblash(int n)
// {
//   if (n == 0) return 0;
//   return n + hisoblash(n - 1);
// }
// Console.WriteLine(hisoblash(5));


// 🔁 4. Sonni teskari tartibda chiqarish

// Tavsif: Berilgan n sonidan 1 gacha bo‘lgan sonlarni ekranga rekursiya orqali chiqaring.
// 📌 Misol: PrintReverse(5) → 5 4 3 2 1

// string PrintReverse(int n)
// {
//   if (n == 0) return "";
//   return n + "\n" + PrintReverse(n - 1);
// }
// Console.WriteLine(PrintReverse(5));



// 🔁 5. Raqamlar yig'indisi (digit sum)

// Tavsif: Sonning raqamlari yig‘indisini rekursiv tarzda hisoblang.
// 📌 Misol: DigitSum(1234) → 10

// int DigitSum(int n)
// {
//   if (n == 0) return 0;
//   return (n % 10) + DigitSum(n / 10);
// }

// Console.WriteLine(DigitSum(134));



// 🔁 6. String uzunligini topish (rekursiya bilan)

// Tavsif: Hech qanday .Length funksiyasiz, string uzunligini rekursiv hisoblang.
// 📌 Misol: GetLength("hello") → 5

// int getLength(string word)
// {
//   if (word == "") return 0;
//   return 1 + getLength(word.Substring(1));
// }

// Console.WriteLine(getLength("Javohir"));


// 🔁 7. Stringni teskari qilish

// Tavsif: Berilgan stringni rekursiv ravishda teskari qilib qaytaring.
// 📌 Misol: Reverse("salom") → "molas"

// string ReverseWord(string word)
// {
//   if (word == "") return "";
//   return ReverseWord(word.Substring(1)) + word[0];
// }

// Console.WriteLine(ReverseWord("Javohir"));


// 🔁 8. Array elementlari yig‘indisi (rekursiv)

// Tavsif: Arraydagi barcha elementlar yig‘indisini rekursiv tarzda toping.
// 📌 Misol: SumArray([1,2,3,4]) → 10

// int sumArray(int[] arr, int n)
// {
//   if (n <= 0) return 0;
//   return arr[n - 1] + sumArray(arr, n - 1);
// }

// int[] sonlar = { 0, 1, 2, };
// Console.WriteLine(sumArray(sonlar, sonlar.Length));

// ✅ 9. Ikki sonning ko‘paytmasini rekursiv hisoblash

// int kopaytirish(int a, int b)
// {
//   if (b == 0) return 0;
//   return a + (kopaytirish(a, b - 1));
// }
// Console.WriteLine(kopaytirish(3, 5));



// ✅ 10. String uzunligini rekursiya bilan aniqlash

// int UzunlikAniqlash(string word)
// {
//   if (word == "") return 0;
//   return 1 + UzunlikAniqlash(word.Substring(1));
// }

// Console.WriteLine(UzunlikAniqlash("hello"));


