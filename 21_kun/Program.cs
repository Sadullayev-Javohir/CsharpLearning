// ✅ 1. if-else — Sharti:

//     Foydalanuvchining yoshini tekshiring. Agar u 18 yoki undan katta bo‘lsa, "Siz balog‘at yoshiga yetgansiz" degan xabar chiqsin. Aks holda, "Siz hali balog‘at yoshiga yetmagansiz" chiqsin.

// int yosh = 19;

// Console.WriteLine(yosh < 0 ? "Minus yosh yo'q" : 0 < yosh && yosh >= 18 ? "Siz balog'atga yetgansiz" : "Siz yoshsiz");


// ✅ 2. for — Sharti:

//     1 dan 5 gacha bo‘lgan sonlarni ekranga chiqaradigan dastur yozing.


// for (int i = 1; i <= 5; i++)
// {
//   Console.WriteLine(i);
// }


//  3. foreach — Sharti:

//     "Olma", "Banan", "Uzum", "Anor" mevalarini ichiga olgan massivni aylantirib, har bir mevani ekranga chiqaring.


// string[] mevalar = { "Olma", "Nok", "Tarvuz" };

// foreach (string meva in mevalar)
// {
//   Console.WriteLine(meva);
// }


// ✅ 4. while — Sharti:

//     1 dan 3 gacha sonlarni while sikli yordamida ekranga chiqaradigan dastur yozing.

// int i = 1;
// int son = 5;

// while (i <= son)
// {
//   Console.WriteLine(i);
//   i++;
// }


// ✅ 5. Rekursiv funksiya — Sharti:

//     Foydalanuvchi kiritgan sonning faktorialini rekursiv funksiya orqali hisoblovchi dastur yozing.

// int Faktorial(int n)
// {
//   if (n == 0 || n == 1) return 1;
//   return n * Faktorial(n - 1);
// }

// Console.WriteLine(Faktorial(5));



