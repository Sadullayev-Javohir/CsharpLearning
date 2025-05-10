// ✅ Problem 1: Write a Single Line to a File

// Input: "hello.txt", "Hello World"
// Output: A file named hello.txt should contain: Hello World

// Explanation: Fayl yaratilsin va berilgan matn ichiga yozilsin.

// class Program
// {
//   public static void WriteToFile(string fileName, string content)
//   {
//     File.WriteAllText(fileName, content);
//   }
//   static void Main(string[] args)
//   {
//     WriteToFile("hello.txt", "Hello World");
//   }
// }


// ✅ Problem 2: Append a Line to an Existing File

// Input: "log.txt", "New entry"
// Output: log.txt fayl oxiriga "New entry" qo‘shiladi.

// Explanation: Eski ma’lumot saqlanib, yangi qator qo‘shiladi.

// class Program
// {
//   public static void AppendText(string fileName, string content)
//   {
//     File.AppendAllText(fileName, $"\n{content}");
//   }

//   static void Main(string[] args)
//   {
//     AppendText("log.txt", "New Entry");
//   }
// }


// ✅ Problem 3: Write Multiple Lines to a File

// Input: ["Line1", "Line2", "Line3"]
// Output: Fayl ichida har bir qator alohida saqlanadi.

// Explanation: Qatorlar massivi faylga yoziladi.


// class Program
// {
//   public static void WriteLine(string fileName, string[] lines)
//   {
//     File.WriteAllLines(fileName, lines);
//   }

//   static void Main(string[] args)
//   {
//     string[] lines = {"First", "Second", "Third"};
//     WriteLine("lines.txt", lines);
//   }
// }



// ✅ Problem 4: Save Numbers to File in CSV Format

// Input: [10, 20, 30, 40]
// Output: Faylda: 10,20,30,40

// Explanation: Raqamlar vergul bilan ajratib yozilsin.


// class Program
// {
//   public static void saveCsv(string fileName, int[] nums)
//   {
//     string numText = String.Join(", ", nums);
//     File.WriteAllText(fileName, numText);
//   }

//   static void Main(string[] args)
//   {
//     saveCsv("nums", new int[]{10, 20, 30, 40});
//   }
// }


// ✅ Problem 5: Check If File Exists Before Writing

// Input: "data.txt", "New Data"
// Output: Agar fayl yo‘q bo‘lsa, yaratilsin va matn yozilsin.

// Explanation: Fayl mavjud bo‘lmasa, WriteAllText ishlaydi.


// class Program
// {
//   public static void SaveText(string fileName, string content)
//   {
//     if (!File.Exists(fileName))
//     {
//       File.WriteAllText(fileName, content);
//     }
//   }
//   static void Main(string[] args)
//   {
//     SaveText("matn.txt", "New Data");
//   }
// }


// ✅ Problem 6: Write Using StreamWriter With using

// Input: "note.txt", "This is a note"
// Output: Faylga matn yoziladi va avtomatik yopiladi.

// Explanation: using blokida StreamWriter ishlatiladi.

// class Program
// {
//   public static void WriteWithStreamWriter(string fileName, string content)
//   {
//     using(StreamWriter writer = new StreamWriter(fileName))
//     {
//       writer.WriteLine(content);
//     }
//   }
//   static void Main(string[] args)
//   {
//     WriteWithStreamWriter("sixth.txt", "Hi, I'm developer");
//   }
// }


// ✅ Problem 7: Append Multiple Lines Using StreamWriter

// Input: ["Apple", "Banana", "Orange"]
// Output: Har biri yangi qatordan yoziladi.

// Explanation: Faylga ustma-ust yozish uchun append: true.


// class Program
// {
//   public static void AppendMultipleLines(string fileName, string[] lines) 
//   {
//     using(StreamWriter writer = new StreamWriter(fileName, true))
//     {
//       foreach(var line in lines)
//       {
//         writer.WriteLine(line);
//       }
//     }
//   }

//   static void Main(string[] args)
//   {
//     string[] lines = {"Hello", "My", "name", "is", "Javohir"};
//     AppendMultipleLines("seventh.txt", lines);
//   }
// }


// ✅ Problem 9: Create Log with Timestamps

// Input: "Started process"
// Output: log.txt faylga: 2025-05-10 14:32:12 - Started process

// Explanation: Har bir yozuvga vaqt qo‘shiladi.

// class Program
// {
//   public static void LogMessage(string fileName, string message)
//   {
//     string timeNow = DateTime.Now.ToString("yyyy-MM-DD HH:mm:ss");
//     using(StreamWriter writer = new StreamWriter(fileName))
//     {
//       writer.WriteLine($"{message} ->> {timeNow}");
//     }
//   }

//   static void Main()
//   {
//     LogMessage("nineth.txt" ,"Grand Theft Auto");
//   }
// }


// ✅ Problem 10: Clear File Content Before Writing

// Input: "overwrite.txt", "Fresh Start"
// Output: Fayldagi eski ma’lumot o‘chiriladi, yangi yoziladi.

// Explanation: FileMode.Create faylni tozalab beradi.

class Program
{
  public static void OverWriteFile(string fileName, string content)
  {
    using(FileStream fs = new FileStream(fileName, FileMode.Create))
    using(StreamWriter writer = new StreamWriter(fs))
    {
      writer.Write(content);
    }
  }

  static void Main()
  {
    OverWriteFile("tenth.txt", "Hey, what's up How are you");
  }
}