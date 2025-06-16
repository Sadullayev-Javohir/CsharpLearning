// using System;
// using System.Collections.Generic;

// // Abstrakt class
// public abstract class LibraryItem
// {
//   public string Title { get; set; }
//   public bool IsBorrowed { get; set; } = false;

//   public abstract void Display();
// }

// // Book class
// public class Book : LibraryItem
// {
//   public string Author { get; set; }

//   public override void Display()
//   {
//     Console.WriteLine($"Kitob: {Title}, Muallif: {Author}, Status: {(IsBorrowed ? "Band" : "Mavjud")}");
//   }
// }

// // Library class
// public class Library
// {
//   private List<LibraryItem> items = new List<LibraryItem>();

//   public void AddItem(LibraryItem item)
//   {
//     items.Add(item);
//     Console.WriteLine("Kitob qo'shildi.");
//   }

//   public void ShowAll()
//   {
//     foreach (var item in items)
//     {
//       item.Display();
//     }
//   }

//   public void BorrowBook(string title)
//   {
//     foreach (var item in items)
//     {
//       if (item.Title.ToLower() == title.ToLower() && !item.IsBorrowed)
//       {
//         item.IsBorrowed = true;
//         Console.WriteLine($"Siz '{item.Title}' kitobini oldingiz.");
//         return;
//       }
//     }
//     Console.WriteLine("Kitob topilmadi yoki allaqachon olingan.");
//   }

//   public void ReturnBook(string title)
//   {
//     foreach (var item in items)
//     {
//       if (item.Title.ToLower() == title.ToLower() && item.IsBorrowed)
//       {
//         item.IsBorrowed = false;
//         Console.WriteLine($"Siz '{item.Title}' kitobini qaytardingiz.");
//         return;
//       }
//     }
//     Console.WriteLine("Qaytarish uchun bunday kitob topilmadi.");
//   }
// }


// public class Program
// {
//   public static void Main()
//   {
//     Library lib = new Library();

//     // Dastlabki kitoblar
//     lib.AddItem(new Book { Title = "C# Dasturlash", Author = "Sadullayev Javohir" });
//     lib.AddItem(new Book { Title = "OOP Asoslari", Author = "A.Aziz" });

//     Console.WriteLine("\n📚 Kitoblar ro'yxati:");
//     lib.ShowAll();

//     Console.WriteLine("\n🔎 Kitob olish:");
//     lib.BorrowBook("OOP Asoslari");

//     Console.WriteLine("\n📚 Yangilangan ro'yxat:");
//     lib.ShowAll();

//     Console.WriteLine("\n📥 Kitobni qaytarish:");
//     lib.ReturnBook("OOP Asoslari");

//     Console.WriteLine("\n📚 Yakuniy ro'yxat:");
//     lib.ShowAll();
//   }
// }

// class Program
// {
//   static void Main()
//   {
//     try
//     {
//       int a = 10;
//       int b = 0;
//       int c = a / b;

//       Console.WriteLine(c);
//     }
//     catch (DivideByZeroException ex)
//     {
//       Console.WriteLine("Sonni nolga bo'lib bo'lmaydi");
//       Console.WriteLine(ex.Message);
//     }
//     finally
//     {
//       Console.WriteLine("Tugadi");
//     }
//   }
// }

// class Program
// {
//   static void Main()
//   {
//     try
//     {
//       Console.WriteLine("Yoshingizni kiriting: ");
//       string input = Console.ReadLine();
//       int yosh = int.Parse(input);
//     }
//     catch (FormatException ex)
//     {
//       Console.WriteLine("Noto'g'ri format");
//     }
//     finally
//     {
//       Console.WriteLine("The End");
//     }
//   }
// }


// class Program
// {
//   static void Main()
//   {
//     try
//     {
//       string matn = null;
//       Console.WriteLine(matn.Length);
//     }
//     catch (Exception ex)
//     {
//       Console.WriteLine("Obyekt null holatda ishlatilmoqda");
//     }
//     finally
//     {
//       Console.WriteLine("The End");
//     }
//   }
// }

