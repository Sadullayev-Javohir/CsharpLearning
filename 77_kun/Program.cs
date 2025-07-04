using System;
using System.IO;

// File.Create("example.txt").Close();


// File.WriteAllText("example.txt", "Assalomu alaykum, bu fayl ichidagi matn");


// class FileExplorer
// {
//   static void Main()
//   {
//     Console.WriteLine("📂 Fayl Explorer dasturiga xush kelibsiz!");

//     while (true)
//     {
//       Console.WriteLine("\nQuyidagilardan birini tanlang:");
//       Console.WriteLine("1 - Fayllarni ko'rish");
//       Console.WriteLine("2 - Yangi fayl yaratish");
//       Console.WriteLine("3 - Faylga yozish");
//       Console.WriteLine("4 - Fayldan o'qish");
//       Console.WriteLine("5 - Faylni o'chirish");
//       Console.WriteLine("6 - Fayl nusxasini olish (Copy)");
//       Console.WriteLine("7 - Fayl nomini o'zgartirish (Rename/Move)");
//       Console.WriteLine("8 - Fayl haqida ma'lumot (Size, Date)");
//       Console.WriteLine("9 - Fayl/papka mavjudligini tekshirish");
//       Console.WriteLine("0 - Chiqish");
//       Console.Write("Tanlov: ");
//       string tanlov = Console.ReadLine();

//       switch (tanlov)
//       {
//         case "1":
//           Console.WriteLine("Papka yo'lini kiriting: ");
//           string folder = Console.ReadLine();

//           if (Directory.Exists(folder))
//           {
//             string[] fayllar = Directory.GetFiles(folder);
//             Console.WriteLine("\nFayllar: ");

//             foreach (string f in fayllar)
//             {
//               Console.WriteLine(Path.GetFileName(f));
//             }
//           }
//           else
//           {
//             Console.WriteLine("❌ Papka topilmadi");
//           }
//           break;


//         case "2":
//           Console.WriteLine("Yangi fayl nomini kiriting: ");
//           string yangiFayl = Console.ReadLine();
//           File.Create(yangiFayl).Close();
//           Console.WriteLine("☑️ Fayl yaratildi");
//           break;

//         case "3":
//           Console.Write("Fayl nomi: ");
//           string faylYozish = Console.ReadLine();
//           Console.Write("Yoziladigan matn: ");
//           string matn = Console.ReadLine();
//           File.WriteAllText(faylYozish, matn);
//           Console.WriteLine("☑️ Matn yozildi");
//           break;

//         case "4":
//           Console.Write("Fayl nomi: ");
//           string faylOqish = Console.ReadLine();
//           if (File.Exists(faylOqish))
//           {
//             string natija = File.ReadAllText(faylOqish);
//             Console.WriteLine("Fayl mazmuni: \n" + natija);
//           }
//           else
//           {
//             Console.WriteLine("❌ Fayl topilmadi");
//           }
//           break;


//         case "5":
//           Console.Write("O'chiriladigan fayl nomi: ");
//           string delFayl = Console.ReadLine();
//           if (File.Exists(delFayl))
//           {
//             File.Delete(delFayl);
//             Console.WriteLine("☑️ Fayl o'chirildi");
//           }
//           else
//           {
//             Console.WriteLine("❌ Fayl topilmadi");
//           }
//           break;
//         case "6":
//           Console.Write("Manba fayl nomi: ");
//           string manba = Console.ReadLine();
//           Console.Write("Nusxa fayl nomi: ");
//           string nusxa = Console.ReadLine();
//           if (File.Exists(manba))
//           {
//             File.Copy(manba, nusxa, true);
//             Console.WriteLine("✅ Fayl nusxalandi");
//           }
//           else
//           {
//             Console.WriteLine("Manba fayl topilmadi");
//           }

//           break;

//         case "7":
//           Console.Write("Eski fayl nomi: ");
//           string eskiNomi = Console.ReadLine();
//           Console.Write("Yangi fayl nomi: ");
//           string yangiNomi = Console.ReadLine();
//           if (File.Exists(eskiNomi))
//           {
//             File.Move(eskiNomi, yangiNomi);
//             Console.WriteLine("✅ Fayl nomi o'zgartirildi.");
//           }
//           else
//           {
//             Console.WriteLine("❌ Fayl topilmadi");
//           }
//           break;

//         case "8":
//           Console.Write("Fayl nomi: ");
//           string infoFayl = Console.ReadLine();
//           if (File.Exists(infoFayl))
//           {
//             FileInfo info = new FileInfo(infoFayl);
//             Console.WriteLine($"📁 Fayl: {info.Name}");
//             Console.WriteLine($"📏 Hajmi: {info.Length} bayt");
//             Console.WriteLine($"📅 Oxirgi o'zgarish: {info.LastWriteTime}");
//           }
//           else
//           {
//             Console.WriteLine("❌ Fayl topilmadi");
//           }
//           break;

//         case "9":
//           Console.WriteLine("Yo'lni kiriting: ");
//           string yol = Console.ReadLine();
//           if (File.Exists(yol))
//           {
//             Console.WriteLine("Bu fayl mavjud");
//           }
//           else if (Directory.Exists(yol))
//           {
//             Console.WriteLine("Bu papka mavjud");
//           }
//           else
//           {
//             Console.WriteLine("❌ Fayl yoki papka topilmadi");
//           }
//           break;
//         case "0":
//           Console.WriteLine("Chiqilmoqda...");
//           return;
//         default:
//           Console.WriteLine("❌ Noto'g'ri tanlov");
//           break;
//       }
//     }
//   }
// }
