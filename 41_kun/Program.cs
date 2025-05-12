using System;
using System.IO;
using System.Collections.Generic;


// 🔹 1. [Easy] Fayl Kengaytmasini Qaytarish

// 📌 Tavsif:
// Foydalanuvchidan to‘liq fayl yo‘li beriladi. Path.GetExtension() metodidan foydalanib, fayl kengaytmasini qaytaring.

// 🧪 Input:
// "C:\\Projects\\code\\main.cs"

// 🎯 Output:
// .cs


// class Program
// {
//   public static string PrintPath(string path)
//   {
//     return Path.GetExtension(path);
//   }

//   static void Main()
//   {
//     string path = @"/home/kali/Desktop/folder/writing.txt";
//     Console.WriteLine(PrintPath(path));
//   }
// }



// 🔹 2. [Easy] Faqat Fayl Nomi Kengaytmasiz

// 📌 Tavsif:
// To‘liq fayl yo‘li beriladi. Siz Path.GetFileNameWithoutExtension() metodidan foydalanib, kengaytmasiz faqat fayl nomini qaytaring.

// 🧪 Input:
// "D:\\Users\\admin\\resume.pdf"

// 🎯 Output:
// resume

// class Program
// {
//   public static string nameFileExt(string path)
//   {
//     return Path.GetFileNameWithoutExtension(path);
//   }

//   static void Main()
//   { 
//     string path = @"/home/kali/Desktop/folder/writing.txt";
//     Console.WriteLine(nameFileExt(path));
//   }
// }

// 🔹 3. [Medium] Papkaga Tegishli Barcha Fayllarni Chiqarish

// 📌 Tavsif:
// Sizga papka yo‘li beriladi. Ushbu papkada joylashgan barcha fayllarning nomlarini chiqaruvchi dastur yozing. Directory.GetFiles() dan foydalaning.

// 🧪 Input:
// "C:\\MyDocs\\Projects\\"

// 🎯 Output:

// [
//   "report.docx",
//   "tasklist.xlsx",
//   "main.cs"
// ]

// class Program
// {
//   public static string[] getFiles(string path)
//   {
//     return Directory.GetFiles(path);
//   }

//   static void Main()
//   {
//     string path = @"/home/kali/Desktop/folder/";

//     string[] getfiles = getFiles(path);
//     foreach(var i in getfiles)
//     {
//       Console.WriteLine(i);
//     }
//   }
// }



// 🔹 4. [Medium] Fayl Hajmini Aniqlash

// 📌 Tavsif:
// Fayl yo‘li beriladi. Siz FileInfo klassidan foydalanib, fayl hajmini baytlarda qaytaring.

// 🧪 Input:
// "C:\\data\\image.png"

// 🎯 Output (example):
// 204800

// class Program
// {
//   public static long dataSize(string path)
//   {
//     FileInfo file = new FileInfo(path);
//     return file.Length;
//   }

//   static void Main()
//   {
//     string path = @"/home/kali/Desktop/folder/writing.txt";
//     long size = dataSize(path);
//     Console.WriteLine(size);
//   }
// }


// 🔹 5. [Medium] Faylni Nusxalash (Copy)

// 📌 Tavsif:
// Sizga ikkita yo‘l beriladi: manba fayl yo‘li va nusxa olinadigan joy. FileInfo.CopyTo() metodidan foydalanib, manba faylni ko‘rsatilgan joyga nusxalovchi dastur yozing.

// class Program
// {
//   public static void copyFile(string path, string copyPath)
//   {
//     FileInfo file = new FileInfo(path);
//     file.CopyTo(copyPath);
//     Console.WriteLine("Fayl nusxalandi");
//   }

//   static void Main()
//   {
//     string path = @"/home/kali/Desktop/folder/writing.txt";
//     string copyPath = @"/home/kali/Desktop/folder/a/writing.txt";
//     copyFile(path, copyPath);
//   }
// }



// 🔹 6. [Hard] Faylni Yangi Joyga Ko‘chirish

// 📌 Tavsif:
// Faylni bir joydan boshqa joyga ko‘chiruvchi dastur tuzing. Fayl MoveTo() orqali ko‘chiriladi. Agar fayl mavjud bo‘lmasa, "Fayl topilmadi" degan xabar chiqsin.

// 🧪 Input:

// From: "C:\\Users\\file.txt"  
// To: "D:\\Archive\\file.txt"

// 🎯 Output:
// "Fayl ko‘chirildi."
// Yoki:
// "Fayl topilmadi."


// class Program
// {
//   public static void MoveFile(string path, string movePath)
//   {
//     if (File.Exists(path))
//     {
//       FileInfo file = new FileInfo(path);
//       file.MoveTo(movePath);
//       Console.WriteLine("Fayl ko'chirildi");
//     }
//     else
//     {
//       Console.WriteLine("Fayl topilmadi");
//     }
//   }

//   static void Main()
//   {
//     string path = @"/home/kali/Desktop/folder/writing.txt";
//     string movePath = @"/home/kali/Desktop/folder/b/writing.txt";
//     MoveFile(path, movePath);
//   }
// }



// 🔹 7. [Hard] Papkada Faqat .txt Fayllarni Chiqarish

// 📌 Tavsif:
// Papkadagi faqat .txt kengaytmali fayllarni aniqlang va ularning ro‘yxatini qaytaring. Directory.GetFiles() va Path.GetExtension() metodlaridan foydalaning.

// 🧪 Input:
// "C:\\Notes"

// 📂 Papkada quyidagilar mavjud:

//     list.txt

//     notes.docx

//     ideas.txt

//     summary.pdf

// 🎯 Output:

// [
//   "list.txt",
//   "ideas.txt"
// ]

// class Program
// {
//   public static string[] txtPrint(string path)
//   {
//     List<string> list = new List<string>();
//     string[] files = Directory.GetFiles(path);
//     foreach(var file in files)
//     {
//       if (Path.GetExtension(file) == ".txt")
//       {
//         list.Add(file);
//       }
//     }
//     return list.ToArray();
//   }

//   static void Main()
//   {
//     string path = @"/home/kali/Desktop/folder/";
//     string[] files = txtPrint(path);
//     foreach(var file in files)
//     {
//       Console.WriteLine(file);
//     }
//   }
// }