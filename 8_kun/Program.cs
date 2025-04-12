// 🟢 1. Masala: Foydalanuvchining ismini so‘rab, salomlashuvchi dastur tuzing.
// Shart: Foydalanuvchidan ismini olish va unga "Salom, ism!" shaklida salomlashish.

// Console.WriteLine("Ismingiz nima: ");
// string ism = Console.ReadLine();  
// Console.WriteLine("Salom " + ism + "!");



// 🟢 2. Masala: Foydalanuvchining yoshidan foydalanib, tug‘ilgan yilini hisoblang.

// Console.WriteLine("Yoshingizni kiriting: ");
// int yosh = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Hozirgi yilni kiriting: ");
// int yil = Convert.ToInt32(Console.ReadLine());

// int tugilganYil = yil - yosh;

// Console.WriteLine("Tug'ilgan yili " + tugilganYil);



// 🟢 3. Masala: Ikkita sonni olib, ularning yig‘indisini hisoblang.
// Shart: Foydalanuvchidan ikki son olib, ularning yig‘indisini konsolga chiqarish.

// Console.WriteLine("Birinchi raqamni kiriting: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Ikkinchi raqamni kiriting: ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// int result = num1 + num2;
// Console.WriteLine("Natijasi: " + result);



// 🟡 4. Masala: Konsol matnining rangini o‘zgartirib chiqarish.
// Shart: Matnni rangli holatda konsolga chiqarish (masalan: ko‘k rangda).

// Console.ForegroundColor = ConsoleColor.Blue;
// Console.WriteLine("Bu ko'k rang");


// 🟡 5. Masala: Konsol fonini o‘zgartirib, tozalab chiqish.
// Shart: Fon rangini kulrang qilib o‘zgartiring va yangi fon bilan konsolni tozalang.

// using System.Drawing;

// Console.BackgroundColor = ConsoleColor.Gray;
// Console.ForegroundColor = ConsoleColor.DarkRed;

// Console.WriteLine("Background: Grey, Color: Red");
// Console.ResetColor();
// Console.WriteLine("Default Color");

// 🟡 6. Masala: Foydalanuvchiga oddiy menyu ko‘rsatib, tanlovni aniqlang.

// Shart: Foydalanuvchiga 2 ta tanlovdan birini taklif qiling va javobga qarab xabar chiqaring.

// Console.WriteLine("1. Yig'indi");
// Console.WriteLine("2. Ayirma");
// Console.WriteLine("Tanlovingiz: ");
// int son = Convert.ToInt32(Console.ReadLine());
// if (son == 1)
// {
//   Console.WriteLine("Siz yig'indini tanladingiz");
// }
// else if (son == 2)
// {
//   Console.WriteLine("Siz ayirmani tanladingiz");
// }
// else
// {
//   Console.WriteLine("So'rov bo'yicha ma'lumot topilmadi");
// }




// 🟡 7. Masala: Yuklanayotgan jarayonni progress bar shaklida animatsiya qiling.
// Shart: Konsolda 0% dan 100% gacha yuklanayotgan progress bar ni hosil qiling.

// for (int i = 0; i <= 20; i++)
// {
//   Console.Write("\rYuklanmoqda: [{0}{1}] {2}%", new string('#', i), new string(' ', 20 - i), i * 5);
//   System.Threading.Thread.Sleep(100);
// }
// Console.WriteLine("\nYuklash tugallandi");


// 🔴 8. Masala: Foydalanuvchi bosgan tugmani aniqlang va ko‘rsating.
// Shart: Foydalanuvchi biror tugma bossin, siz esa uni nomini chiqarib bering.

// Console.WriteLine("Iltimos biror tugmani bosing: ");
// ConsoleKeyInfo key = Console.ReadKey();
// Console.WriteLine("\nSiz bosgan tugma: " + key.Key);


// 🔴 9. Masala: Matnni konsol ekranining markaziga yozing.
// Shart: Matnni konsol oynasining markazida chiqaring.

// string text = "Xush kelibsiz";
// int x = (Console.WindowWidth - text.Length) / 2;
// int y = (Console.WindowHeight) / 2;
// Console.SetCursorPosition(x, y);
// Console.WriteLine(text);



// 🔴 10. Masala: Oddiy login tizimi yarating.
// Shart: Login (username + parol) so‘ralsin. To‘g‘ri kirilsa, "Xush kelibsiz", aks holda "Xato!" yozilsin.

// Console.WriteLine("**LOGIN SYSTEM**");
// string usernameValue = "javohir";
// string passwordValue = "1234";

// Console.WriteLine("Username enter: ");
// string username = Console.ReadLine();
// Console.WriteLine("Password enter: ");
// string password = Console.ReadLine();

// if (usernameValue == username && passwordValue == password)
// {
//   Console.WriteLine("Welcome to System");
// }
// else if (usernameValue != username && passwordValue == password)
// {
//   Console.WriteLine("Username is uncorrect");
// }
// else if (usernameValue == username && passwordValue != password)
// {
//   Console.WriteLine("Password is uncorrect");
// }
// else
// {
//   Console.WriteLine("Username and Password are uncorrect");
// }