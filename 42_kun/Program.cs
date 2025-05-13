// 📁 Mini loyiha nomi:

// "Student Record Manager"
// 🎯 Loyiha maqsadi:

//     Foydalanuvchidan talaba ma’lumotlarini (Ism, Familiya, Yoshi, Baholari) olish

//     Ma’lumotlarni faylga yozish

//     Fayldan ma’lumotni o‘qish

//     Exception handling orqali xatoliklarni ushlash

// 🧱 Texnologiyalar:

//     C# (.NET 6 yoki .NET Core/Framework)

//     Fayl: students.txt

//     Exception turlari: FormatException, IOException, FileNotFoundException

// 📌 Loyiha funksiyalari:

//     Yangi talaba ma’lumotini qo‘shish

//     Ma’lumotlarni faylga yozish

//     Fayldan o‘qib ko‘rsatish

//     Xatoliklarni ushlash (try-catch-finally)

// using System;
// using System.IO;

// class Student
// {
//   public string FirstName;
//   public string LastName;
//   public int Age;
//   public double Grade;
// }

// class Ishla
// {
//   static string filePath = "student.txt";

//   static void Main()
//   {

//     while (true)
//     {
//       Console.WriteLine("STUDENT LISTS");
//       Console.WriteLine();
//       Console.WriteLine("Choose options: ");
//       Console.WriteLine("=============");
//       Console.WriteLine("1.Student Add");
//       Console.WriteLine("2.Students Show");
//       Console.WriteLine("3.Exit");
//       Console.WriteLine();

//       string option = Console.ReadLine();

//       if (option == "1")
//       {
//         studentAdd();
//       }
//       else if (option == "2")
//       {
//         studentsShow();
//       }
//       else if (option == "3")
//       {
//         break;
//       }
//       else
//       {
//         Console.WriteLine("Invalid option");
//       }
//     }
//   }

//   static void studentAdd()
//   {
//     Student student = new Student();
    
//     Console.WriteLine("Enter First Name");
//     student.FirstName = Console.ReadLine();

//     Console.WriteLine("Enter Last Name");
//     student.LastName = Console.ReadLine();
    
//     Console.WriteLine("Enter Age");
//     student.Age = int.Parse(Console.ReadLine());

//     Console.WriteLine("Enter Grade");
//     student.Grade = double.Parse(Console.ReadLine());

//     using(StreamWriter writer = File.AppendText(filePath))
//     {
//       writer.WriteLine($"{student.FirstName}, {student.LastName}, {student.Age}, {student.Grade}");
//     }
//   }
//   static void studentsShow(){
//     if (!File.Exists(filePath))
//     {
//       Console.WriteLine("File Not Found");
//     }
//     else 
//     {
//       string[] lines = File.ReadAllLines(filePath);
//       foreach(var line in lines)
//       {
//         string[] parts = line.Split(',');

//         if (parts.Length == 4)
//         {
//           Console.WriteLine($"{parts[0]} {parts[1]} | {parts[2]} | {parts[3]}");
//         }
//       }
//     }
//   }
// }


