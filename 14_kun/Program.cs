// ✅ Boshlang‘ich daraja
// 1. 1 dan 100 gacha bo‘lgan sonlarni chiqaruvchi dastur tuzing.

// for (int i = 1; i <= 100; i++)
// {
//   Console.WriteLine($"Son: {i}");
// }


// 2. 1 dan 50 gacha bo‘lgan juft sonlarni chiqaring.

// for (int i = 0; i <= 50; i += 2)
// {
//   if (i == 0)
//   {
//     continue;
//   }
//   Console.WriteLine(i);
// }


// 3. Foydalanuvchi kiritgan n sonigacha bo‘lgan sonlar yig‘indisini toping.

// int s = 0;
// for (int i = 0; i <= 10; i++)
// {
//   s += i;
// }

// Console.WriteLine(s);



// 4. Berilgan n sonining faktorialini hisoblang (n!).

// int n = 5;
// int factorial = 1;
// for (int i = 1; i <= n; i++)
// {
//   factorial *= i;
// }
// Console.WriteLine(factorial);


// 5. 1 dan 10 gacha bo‘lgan sonlar uchun ko‘paytirish jadvalini chiqaring.

// for (int i = 1; i <= 10; i++)
// {
//   for (int j = 1; j <= 10; j++)
//   {
//     Console.WriteLine($"{i}*{j}={i * j}");
//   } 

// }


// 🔄 O‘rta daraja
// 6. Foydalanuvchi kiritgan ikkita son orasidagi barcha sonlar yig‘indisini toping.
// Misol: a = 3, b = 7 => 3 + 4 + 5 + 6 + 7 = 25

// int a = 3, b = 7;
// int s = 0;
// for (int i = a; i <= b; i++)
// {
//   s += i;
// }
// Console.WriteLine(s);



// 7. 1 dan 100 gacha bo‘lgan faqat 3 va 5 ga bo‘linadigan sonlarni chiqaring.

// for (int i = 1; i <= 100; i++)
// {
//   if (i % 3 == 0 && i % 5 == 0)
//   {
//     Console.WriteLine(i);
//   }
// }


// 8. Berilgan n soni tub (prime) sonmi yo‘qligini aniqlang.

// int n = 13;
// int count = 0;

// for (int i = n; i <= n; i++)
// {
//   for (int j = 1; j <= n; j++)
//   {
//     if (i % j == 0)
//     {
//       Console.WriteLine($"{i}:::{j}");
//       count++;
//     }
//   }
// }

// if (count <= 2)
// {
//   Console.WriteLine("Tub son");
// }
// else
// {
//   Console.WriteLine("Tub son emas");
// }


// 🚀 Yuqori daraja
// 9. Piramida shaklida yulduzcha (*) chiqaradigan dastur yozing.


// for (int i = 1; i <= 5; i++)
// {
//   for (int j = 1; j <= i; j++)
//   {
//     // Console.Write(j);
//     Console.Write($"*");
//   } 
//   Console.WriteLine();
// }


// 10. Teskari yulduzcha piramidasini tuzing.
// for (int i = 1; i <= 10; i++)
// {
//   for (int j = i; j <= 10; j++)
//   {
//     Console.Write("*");
//   }
//   Console.WriteLine();
// }