// ✅ 1. void metodi: salom berish

// Tavsif: Foydalanuvchining ismini parametr sifatida olib, unga salom beradigan metod yozing.
// Natija: Salom, Javohir!

// void SalomBerish(string ism) {
//   Console.WriteLine($"Salom {ism}");
// }
// SalomBerish("Javohir");


// ✅ 2. return metodi: kvadrat hisoblash

// Tavsif: Berilgan sonning kvadratini hisoblab, natijani qaytaruvchi metod yozing.

// int Kvadrat(int num)
// {
//   num *= num;
//   return num;
// }

// Console.WriteLine(Kvadrat(4));


// ✅ 3. Ikki sonni solishtirish (int return)

// Tavsif: Ikki son qabul qiladigan va katta sonni qaytaradigan metod yozing.
// Natija: Max(5, 8) → 8

// int KattaSon(int a, int b) {
//   return (a > b) ? a : b;
// }

// Console.WriteLine(KattaSon(2, 4));



// ✅ 4. bool metod: son musbatmi?

// Tavsif: Son musbat yoki manfiyligini aniqlovchi metod yozing.
// Natija: IsPositive(-3) → false

// bool IsPositive(int num)
// {
//   return (num > 0) ? true : false;
// }

// Console.WriteLine(IsPositive(3));



// ✅ 5. params bilan yig‘indi hisoblash

// Tavsif: Istalgancha sonlarni parametr sifatida qabul qilib, ularning yig‘indisini qaytaradigan metod yozing.
// Natija: Sum(1,2,3,4) → 10

// int varArgs(params int[] sonlar)
// {
//   int sum = 0;
//   foreach (var item in sonlar)
//   {
//     sum += item;
//   }
//   return sum;
// }

// Console.WriteLine(varArgs(1, 2, 3, 4, 5, 6));


// ✅ 7. ref bilan qiymatni kvadratga ko‘paytirish

// Tavsif: ref yordamida uzatilgan sonni kvadratga oshiradigan metod yozing.


// int Kvadrat(ref int son)
// {
//   son *= son;
//   return son;
// }

// int son = 5;
// Kvadrat(ref son);
// Console.WriteLine(son);



// ✅ 8. out bilan hisob-kitob

// Tavsif: Ikki sonning ayirmasi, ko‘paytmasi va bo‘linmasini out parametrlar orqali qaytaradigan metod yozing.

// void Hisobla(int a, int b, out int ayirma, out int kopaytma, out double bolinma)
// {
//   ayirma = a - b;
//   kopaytma = a * b;
//   bolinma = (double)a / b;
// }

// int son1 = 5;
// int son2 = 2;
// int ayirma, kopaytma;
// double bolinma;

// Hisobla(son1, son2, out ayirma, out kopaytma, out bolinma);
// Console.WriteLine(ayirma);
// Console.WriteLine(bolinma);
// Console.WriteLine(kopaytma);  



// ✅ 9. Rekursiv metod: faktorial hisoblash

// Tavsif: Berilgan sonning faktorialini rekursiya orqali hisoblang.
// Natija: Faktorial(5) → 120

// int recursive(int n)
// {
//   if (n == 1) return 1;
//   return n * (recursive(n - 1));
// }

// Console.WriteLine(recursive(5));


// bool isPalindrom(string soz)
// {
//   string reverse = "";
//   for (int i = 0; i < soz.Length; i++)
//   {
//     reverse = soz[i] + reverse;
//   }
//   return (soz == reverse) ? true : false;
// }

// Console.WriteLine(isPalindrom("alla"));


