// // 1. switch-case misoli (Boshlang‘ich)

// // Shart: Foydalanuvchidan hafta kunini (1-7) kiritishini so‘rang. Kiritilgan raqamga mos kun nomini chop eting.

// int day = 3;

// switch (day)
// {
//   case 1:
//     Console.WriteLine("Dushanba");
//     break;
//   case 2:
//     Console.WriteLine("Seshanba");
//     break;
//   case 3:
//     Console.WriteLine("Chorshanba");
//     break;
//   case 4:
//     Console.WriteLine("Payshanba");
//     break;
//   case 5:
//     Console.WriteLine("Juma");
//     break;
//   case 6:
//     Console.WriteLine("Shanba");
//     break;
//   case 7:
//     Console.WriteLine("Yakshanba");
//     break;
// }


// 2. Bir nechta qiymatlarni bitta caseda qo‘shish

// Shart: Foydalanuvchidan oy raqamini (1-12) so‘rang va ushbu oy qaysi faslga tegishli ekanligini aniqlang (Qish, Bahor, Yoz, Kuz).


// byte oyRaqami = 2;

// switch (oyRaqami)
// {
//   case 12:
//   case 1:
//   case 2:
//     Console.WriteLine("Qish");
//     break;
//   case 3:
//   case 4:
//   case 5:
//     Console.WriteLine("Bahor");
//     break;
//   case 6:
//   case 7:
//   case 8:
//     Console.WriteLine("Yoz");
//     break;
//   case 9:
//   case 10:
//   case 11:
//     Console.WriteLine("Kuz");
//     break;
// }


// 3. default holatidan foydalanish

// Shart: Foydalanuvchidan son kiritishni so‘rang va u sonni tahlil qilib, "Bir", "Ikki" yoki "Boshqa son" deb chiqarilsin.

// byte son = 3;

// switch (son)
// {
//   case 1:
//     Console.WriteLine("Bir");
//     break;
//   case 2:
//     Console.WriteLine("Ikki");
//     break;
//   default:
//     Console.WriteLine("Boshqa son");
//     break;
// }


// 4. goto case bilan case'lar o‘rtasida o'tish

// Shart: Foydalanuvchidan raqam kiritilsin. 1 yoki 2 kiritilgan bo‘lsa, o‘sha raqamni chop eting va keyin boshqa bir raqamni chop eting (masalan, 1 kiritilsa 2'ga o'tish).

// byte num = 1;
// bool check = false;

// switch (num)
// {
//   case 1:
//     Console.WriteLine("Bir");
//     if (!check)
//     {
//       // check = true;
//       goto case 2;
//     }
//     break;
//   case 2:
//     Console.WriteLine("Ikki");
//     if (!check)
//     {
//       // check = true;
//       goto case 1;
//     }
//     break;
// }


// 5. switch va when bilan shart qo‘shish

// Shart: Foydalanuvchidan son kiritilsa, sonning musbat yoki manfiy ekanligini aniqlang.

// int num = 0;

// switch (num)
// {
//   case int n when (n > 0):
//     Console.WriteLine("Musbat");
//     break;
//   case int n when (n < 0):
//     Console.WriteLine("Manfiy");
//     break;
//   default:
//     Console.WriteLine("Nol");
//     break;
// }



// 6. Pattern Matching bilan switch misoli

// Shart: Foydalanuvchidan turli turdagi obyektlar (int, string) kiritilsa, ularni tekshiring va tegishli xabarni chiqarish.

// object obj = 2;

// switch (obj)
// {
//   case int i:
//     Console.WriteLine("Bu int");
//     break;
//   case string i:
//     Console.WriteLine("Bu string");
//     break;
//   case bool i:
//     Console.WriteLine("Bu Bool");
//     break;
// }


// 7. switch expression (C# 8.0+)

// Shart: Foydalanuvchidan oy raqamini (1-12) so‘rang va qaysi faslga tegishli ekanligini aniqlang.

// byte day = 2;

// string result = day switch
// {
//   1 => "Qish",
//   2 => "Qish",
//   3 => "Bahor",
//   4 => "Bahor",
//   5 => "Bahor",
//   6 => "Yoz",
//   7 => "Yoz",
//   8 => "Yoz",
//   9 => "Kuz",
//   10 => "Kuz",
//   11 => "Kuz",
//   _ => "Topilmadi",
// };

// Console.WriteLine(result);


// 9. Nested switch-case (Ichma-ich)

// Shart: Foydalanuvchidan ikki son kiritilsin va ular asosida turli natijalarni chop eting.

// byte a = 1, b = 1;

// switch (a)
// {
//   case 1:
//     switch (b)
//     {
//       case 1:
//         Console.WriteLine("a = 1, b = 1");
//         break;
//       case 2:
//         Console.WriteLine("a = 1, b = 2");
//         break;
//     }
//     break;
// }



// 10. switch orqali matrisa baholari (Murakkab misol)

// Shart: Foydalanuvchidan baholarni kiritilsin va bahoga mos grade chiqarilsin (A, B, C, D, F).

// byte grade = 59;

// switch (grade)
// {
//   case byte g when (g >= 90):
//     Console.WriteLine("Your grade is A");
//     break;
//   case byte g when (g >= 80 && g < 90):
//     Console.WriteLine("Your grade is B");
//     break;
//   case byte g when (g >= 70 && g < 80):
//     Console.WriteLine("Your grade is C");
//     break;
//   case byte g when (g >= 60 && g < 70):
//     Console.WriteLine("Your grade is D");
//     break;
//   default:
//     Console.WriteLine("Your grade is F");
//     break;
// }


