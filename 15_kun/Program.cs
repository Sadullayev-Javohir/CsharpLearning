// ✅ 1. Masala: 1 dan 5 gacha sonlarni chiqaruvchi dastur yozing.
// 🎯 Maqsad: while sikli yordamida oddiy sanashni o‘rganish.

// int i = 1;

// while (i <= 10)
// {
//   Console.WriteLine(i);
//   i++;
// } 


// ✅ 2. Masala: Agar shart noto‘g‘ri bo‘lsa ham, kodni kamida bir marta bajaring.
// 🎯 Maqsad: do-while siklining kamida bir marta bajarilishini tushunish.

// int i = 5;

// do
// {
//   Console.WriteLine(i);
//   i++;
// }
// while (i > 6);


// ✅ 3. Masala: 1 dan 10 gacha faqat juft sonlarni chiqaruvchi dastur yozing.
// 🎯 Maqsad: if va while kombinatsiyasida shartli tekshiruv qilish.?

// int n = 1;

// while (n <= 10)
// {
//   if (n % 2 == 0)
//   {
//     Console.WriteLine(n);
//   }
//   n++;
// }



// ✅ 4. Masala: Foydalanuvchi "exit" yozmaguncha, matn kiritishni so‘raydigan dastur tuzing.
// 🎯 Maqsad: do-while bilan foydalanuvchidan qayta-qayta ma'lumot olishni o‘rganish.

// string matn = "";

// do
// {
//   Console.WriteLine("'Exit' ni yozing");
//   matn = Convert.ToString(Console.ReadLine());
// } while (matn != "Exit");



// ✅ 5. Masala: Berilgan n sonining faktorialini hisoblang. (n = 5 bo‘lsa → 5! = 120)
// 🎯 Maqsad: Ko‘paytirish asosida while siklida matematik hisoblashni tushunish.

// int n = 5;
// int i = 1;
// int factorial = 1;

// while (i <= n)
// {
//   factorial *= i;
//   Console.WriteLine(i);
//   i++;
// }

// Console.WriteLine(factorial);



// ✅ 6. Masala: 1 dan n gacha sonlar yig‘indisini hisoblang. (n = 5 → 1+2+3+4+5 = 15)
// 🎯 Maqsad: do-while siklida qo‘shish operatsiyasini amalda qo‘llash.


// int i = 1;
// int n = 5;
// int add = 0;

// do
// {
//   add += i;
//   i++;
// }
// while (i <= n);
// Console.WriteLine(add);



// ✅ 7. Masala: Raqamda nechta raqam borligini aniqlang. (Masalan, 12345 → 5 ta raqam)
// 🎯 Maqsad: Sonni bo‘lish orqali siklda ishlashni tushunish.

// int n = 12345678;
// int count = 0;

// while (n  != 0)
// {
//   n /= 10;
//   count++;
// }
// Console.WriteLine("Count: " + count);



// ✅ 8. Masala: Berilgan son tub (prime) sonmi yoki yo‘qligini tekshiring.
// 🎯 Maqsad: while yordamida matematik tekshiruv va break dan foydalanish.

// int n = 13;
// int i = 2;
// bool Tubmi = true;

// while (i <= n / 2)
// {
//   if (n % i == 0)
//   {
//     Tubmi = false;
//     break;
//   }
//   i++;
// }

// Console.WriteLine(Tubmi ? "Tub son" : "Tub son emas");

// ✅ 9. Masala: 5 dan 1 gacha sonlarni teskari chiqaruvchi dastur tuzing.
// 🎯 Maqsad: do-while yordamida kamayib boruvchi siklni yozish.

// int i = 1;
// int n = 5;

// do
// {
//   Console.WriteLine(n);
//   n--;
// }
// while (n >= i);



// ✅ 10. Masala: Berilgan son palindrome ekanligini tekshiring. (Masalan, 121 → ha)
// 🎯 Maqsad: Sonni teskari o‘girib, original bilan taqqoslashni o‘rganish.

// int num = 1121;
// int original = num;
// int reverse = 0;

// while (num != 0)
// {
//   int digit = num % 10;
//   reverse = reverse * 10 + digit;
//   num /= 10;
// }

// Console.WriteLine((reverse == original) ? $"Palindrom son: {original}" : $"Palindorm son emas: {original}");