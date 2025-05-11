// 🗂 Loyiha nomi: "Task Manager (Oddiy To-do List)"
// 🎯 Maqsad:

// Foydalanuvchi yangi vazifalarni kiritadi, ular faylga saqlanadi. Keyin bu vazifalarni ko‘rish yoki fayldan o‘chirish mumkin.
// 📁 Fayl: tasks.txt

// Bu faylda vazifalar saqlanadi. Har bir qator – bitta vazifa.
// 🧩 Asosiy funksiyalar:

//     ✅ Yangi vazifa qo‘shish (AddTask)

//     📖 Barcha vazifalarni ko‘rish (ViewTasks)

//     ❌ Faylni tozalash (ClearTasks)

// 🧪 Natija:

// 1. Add task
// 2. View tasks
// 3. Clear all tasks
// 4. Exit




// using System;
// using System.IO;

// class TaskManager
// {
//   static string filePath = "task.txt";

//   static void Main()
//   {
//     while (true)
//     {
//       Console.WriteLine("--> Task Manager <--");
//       Console.WriteLine();

//       Console.WriteLine("Tanlang (1-4)");
//       Console.WriteLine();
//       Console.WriteLine("1. Add task");
//       Console.WriteLine("2. View tasks");
//       Console.WriteLine("3. Clear all tasks");
//       Console.WriteLine("4. Exit");

//       string choices = Console.ReadLine();
    
//       switch(choices)
//       {
//         case "1":
//           addTask();
//           break;
//         case "2":
//           viewTasks();
//           break;
//         case "3":
//           clearTasks();
//           break;
//         case "4":
//           Console.WriteLine("Chiqilmoqda");
//           return;
//         default:
//           Console.WriteLine("Xato raqam kiritdingiz: ");
//           break;
//       }
//     }
//   }

//   static void addTask()
//   {
//     Console.WriteLine("Vazifani kiriting: ");
//     string task = Console.ReadLine();

//     using (StreamWriter writer = new StreamWriter(filePath, append: true))
//     {
//       writer.WriteLine(task);
//     }
//     Console.WriteLine("Vazifa qo'shildi");
//   }

//   static void viewTasks(){
//     if (File.Exists(filePath))
//     {
//       string[] tasks = File.ReadAllLines(filePath);
//       if (tasks.Length == 0)
//       {
//         Console.WriteLine("Hech qanday task mavjud emas");
//       }
//       foreach(var task in tasks)
//       {
//         Console.WriteLine($"+++++{task}+++++");
//       }
//     }
//     else 
//     {
//       Console.WriteLine("Fayl mavjud emas");
//     }
//   }
//   static void clearTasks() {
//     File.WriteAllText(filePath, "");
//     Console.WriteLine("Barcha ma'lumotlar o'chirildi");
//   }

// }











// 📚 Loyiha nomi: "Student Grades Logger"
// 🎯 Maqsad:

// Foydalanuvchi talabalar ismi va baholarini kiritadi. Bu ma'lumotlar faylga saqlanadi. So‘ng foydalanuvchi barcha talabalar ro‘yxatini va o‘rtacha bahoni ko‘ra oladi.
// 📁 Fayl: grades.txt

// Fayl formati quyidagicha bo‘ladi:

// Ali, 85
// Vali, 90
// Anvar, 78

// 🧩 Asosiy funksiyalar:

//     🎓 Talaba qo‘shish (AddStudent)

//     📄 Ro‘yxatni ko‘rish (ViewStudents)

//     📊 O‘rtacha bahoni chiqarish (AverageGrade)

//     ❌ Barcha yozuvlarni o‘chirish (ClearData)

class StudentGrade
{
  static string filePath = "students.txt";

  static void Main()
  {
    while (true)
    {
      Console.WriteLine();
      Console.WriteLine("STUDENT GRADE");
      Console.WriteLine();

      Console.WriteLine("1. Talaba qo'shish");
      Console.WriteLine("2. Ro'yxatni ko'rish");
      Console.WriteLine("3. O'rtacha bahoni chiqarish");
      Console.WriteLine("4. Barcha yozuvlarni o'chirish");
      Console.WriteLine("5. Chiqish");

      Console.WriteLine("Tanlang(1-4)");

      string choice = Console.ReadLine();

      switch(choice)
      {
        case "1":
          AddStudent();
          break;
        case "2":
          ViewStudents();
          break;
        case "3":
          AverageGrade();
          break;
        case "4":
          ClearData();
          break;
        case "5":
          Console.WriteLine("Chiqilmoqda...");
          return;
        default:
          Console.WriteLine("Xato raqam kiritildi");
          break;
      }
    }
  }

  static void AddStudent() {
    Console.WriteLine("Talabani ismini kiriting: ");
    string name = Console.ReadLine();

    Console.WriteLine("Talabani bahosini kiriting: ");
    string grade = Console.ReadLine();

    using(StreamWriter writer = new StreamWriter(filePath, append: true))
    {
      writer.WriteLine($"{name} - {grade}");
    }

    Console.WriteLine("Ma'lumotlar qo'shildi");
    Console.WriteLine();
  }
  static void ViewStudents() {
    if (File.Exists(filePath))
    {
      string[] lines = File.ReadAllLines(filePath);

      if (lines.Length == 0)
      {
        Console.WriteLine("Faylda hozircha hech narsa yo'q");
      }
      foreach(var line in lines)
      {
        Console.WriteLine($"--{line}--");
      }
    }
    else 
    {
      Console.WriteLine("Fayl mavjud emas");
    }
  }
  static void AverageGrade() 
  {
    int count = 0;
    int total = 0;
    string[] lines = File.ReadAllLines(filePath);

    foreach(string line in lines)
    {
      string[] parts = line.Split('-');
      if(parts.Length == 2 && int.TryParse(parts[1].Trim(), out int grade))
      {
        total += grade;
        count++;
      }
    }
    if(count == 0)
    {
      Console.WriteLine("Hozircha baholar yo'q");
    }
    else
    {
      double average = (double)total / count;
      Console.WriteLine($"O'rtacha baho: {average:F2}");
    }
  }
  static void ClearData() {
    File.WriteAllText(filePath, "");
    Console.WriteLine("Barcha ma'lumotlar o'chirildi");
  }

}