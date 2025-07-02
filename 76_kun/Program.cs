using System.IO;

// class Program
// {
//   static void Main()
//   {
//     var sonlar = new[] { 12, 3, 6, 78, 4 };
//     // var result = from x in sonlar where x > 5 select x;

//     var result = sonlar.Where(x => x > 5).ToList();

//     foreach (var item in result)
//     {
//       Console.WriteLine(item);
//     }
//   }
// }

// class Program
// {
//   static void Main()
//   {
// string filePath = "test.txt";
// File.Create(filePath).Close();

// File.WriteAllText("test.txt", "Salom Dunyo");
// string content = File.ReadAllText("test.txt");
// Console.WriteLine(content);

// File.AppendAllText("test.txt", "Hey leave me alone");
// if (File.Exists("test.txt")) File.Delete("test.txt");
// else Console.WriteLine("Fayl yo'q");

// Directory.CreateDirectory("MyFolder");
// Directory.Delete("MyFolder", true);

// string[] files = Directory.GetFiles("hey");

// foreach (var file in files)
// {
//   Console.WriteLine(file);
// }

//     string[] dirs = Directory.GetDirectories("hey");

//     foreach (var dir in dirs)
//     {
//       Console.WriteLine(dir);
//     }

//   }
// }

// class Program
// {
//   static void Main()
//   {
//     string path = @"/home/kali/Desktop/MICROSOFT/PRACTISE/CsharpLearning/76_kun/ASOSIY";

// DirectoryInfo dir = new DirectoryInfo(path);

// if (!dir.Exists)
// {
//   dir.Create();
//   Console.WriteLine("✅ Papka yaratildi");
// }
// else
// {
//   Console.WriteLine("Papka allaqachon mavjud");
// }

// Console.WriteLine("Ichidagi fayllar");
// DirectoryInfo[] files = dir.GetDirectories();
// foreach (var i in files)
// {
//   Console.WriteLine(i.CreationTime);
// }
// Console.WriteLine("🕓 Yaratilgan vaqti: " + dir.CreationTime);
// Console.WriteLine("🇳🍠  To'liq yo'li" + dir.FullName);
// Console.WriteLine($"📁 Papka nomi {dir.Name}");


//   }
// }


class Program
{
  static void MenuPrint()
  {
    Console.WriteLine("File Explorer 📂");
    Console.WriteLine("1. Fayl yaratish");
    Console.WriteLine("2. Fayl o'qish");
    Console.WriteLine("3. Fayl yozish");
    Console.WriteLine("4. Fayl o'chirish");
    Console.WriteLine("5. Chiqish");
  }

  static void InputSwitch()
  {
    Console.Write("Tanlovni kiriting: ");
    var input = Console.ReadLine();
    switch (input)
    {
      case "1":
        FileCreate();
        break;
      case "2":
        FileRead();
        break;
      case "3":
        FileWrite();
        break;
      case "4":
        FileDelete();
        break;
      case "5":
        Console.WriteLine("Tizimdan chiqildi");
        break;
    }
  }
  static void FileCreate()
  {
    Console.Write("Fayl yaratish uchun nomini kiriting: ");
    var file = Console.ReadLine();

    while (File.Exists(file))
    {
      Console.WriteLine("📕 Bu file mavjud");
      Console.Write("Boshqa nom kiriting: ");
      file = Console.ReadLine();
    }
    File.Create(file);
    Console.WriteLine("Fayl yaratildi ✅");
  }
  static void FileRead()
  {

    var matn = File.ReadAllText("hey.txt");
    Console.WriteLine(matn);

  }
  static void FileWrite()
  {
    Console.WriteLine("Faylga yozmoqchi bo'lgan matningizni kiriting: ");
    var input = Console.ReadLine();
    File.AppendAllText("hey.txt", input);
    Console.WriteLine("Yozildi");
  }
  static void FileDelete()
  {
    if (File.Exists("hey.txt"))
    {
      File.Delete("hey.txt");
    }
    else
    {
      Console.WriteLine("file yo'q");
    }
  }

  static void Main()
  {
    while (true)
    {
      MenuPrint();
      InputSwitch();
    }
  }
}
