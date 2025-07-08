using System;
using System.IO;
using System.Text;
// class Program
// {
//   static void Main()
//   {
//     // var ms = new MemoryStream();
//     var ms = new MemoryStream();
//     Console.WriteLine("CanRead: " + ms.CanRead);
//     Console.WriteLine("CanWrite: " + ms.CanWrite);
//     Console.WriteLine("CanSeek: " + ms.CanSeek);
//     ms.WriteByte(1);
//     Console.WriteLine("Length: " + ms.Length);
//   }
// }


// class Program
// {
//   static void Main()
//   {
// byte[] data = Encoding.UTF8.GetBytes("Salom");

// var ms = new MemoryStream(data);

// byte[] buffer = new byte[5];

// int bytesRead = ms.Read(buffer, 0, buffer.Length);

// Console.WriteLine("O'qilgan " + Encoding.UTF8.GetString(buffer, 0, bytesRead));

// byte[] data = Encoding.UTF8.GetBytes("A");
// var ms = new MemoryStream(data);

// int b = ms.ReadByte();
// Console.WriteLine("O'qilgan bayt: " + (char)b);

// var ms = new MemoryStream();
// byte[] data = Encoding.UTF8.GetBytes("Hello");

// ms.Write(data, 0, data.Length);
// Console.WriteLine("Yozildi: " + Encoding.UTF8.GetString(ms.ToArray()));

// var ms = new MemoryStream();
// ms.WriteByte((byte)'A');

// Console.WriteLine("Yozilgan: " + Encoding.UTF8.GetString(ms.ToArray()));


//     byte[] data = Encoding.UTF8.GetBytes("ABCDEFG");
//     var ms = new MemoryStream(data);

//     ms.Seek(2, SeekOrigin.Begin);
//     int b = ms.ReadByte();
//     Console.WriteLine((char)b);
//   }
// }


// class Program
// {
//   static void Main()
//   {
//     byte[] data = { 72, 101, 108, 108, 111 };
//     using (MemoryStream ms = new MemoryStream(data))
//     {
//       int value;
//       while ((value = ms.ReadByte()) != -1)
//       {
//         Console.WriteLine((char)value);
//       }
//     }
//   }
// }

// class Program
// {
//   static void Main()
//   {
//     string path = "example.txt";
//     string text = "Salom, dunyo";

//     using (FileStream fs = new FileStream(path, FileMode.Create))
//     {
//       byte[] bytes = Encoding.UTF8.GetBytes(text);
//       fs.Write(bytes, 0, bytes.Length);
//     }
//   }
// }


// class Program
// {
//   static void Main()
//   {
//     string path = "example.txt";
//     using (FileStream fs = new FileStream(path, FileMode.Open))
//     {
//       int value;
//       while ((value = fs.ReadByte()) != -1)
//       {
//         Console.WriteLine((char)value);
//       }
//     }
//   }

// }

// class Program
// {
//   static void Main()
//   {
//     StreamWriter writer = new StreamWriter("output.txt");
//     writer.WriteLine("Bu faylga yozildi.");
//     writer.Close();

//     StreamReader reader = new StreamReader("output.txt");
//     string line = reader.ReadLine();
//     Console.WriteLine(line);
//     reader.Close();
//   }
// }


// using System;
// using System.IO;

// class LogAnalyzer
// {
//   static void Main(string[] args)
//   {
//     string logFayl = "log.txt";
//     string chiqishFayl = "hisobot.txt";

//     int infoCount = 0;
//     int warningCount = 0;
//     int errorCount = 0;

//     try
//     {
//       using (StreamReader reader = new StreamReader(logFayl))
//       {
//         string line;
//         while ((line = reader.ReadLine()) != null)
//         {
//           if (line.Contains("[INFO]"))
//           {
//             infoCount++;
//           }
//           else if (line.Contains("[WARNING]"))
//           {
//             warningCount++;
//           }
//           else if (line.Contains("[ERROR]"))
//           {
//             errorCount++;
//           }
//         }

//         using (StreamWriter writer = new StreamWriter(chiqishFayl))
//         {
//           writer.WriteLine("Log fayl analiz natijasi: ");
//           writer.WriteLine($"INFO: {infoCount}");
//           writer.WriteLine($"WARNING: {warningCount}");
//           writer.WriteLine($"ERROR: {errorCount}");
//         }
//         Console.WriteLine("Analiz yakunlandi: Natija hisobot.txt faylga yozildi");
//       }
//     }
//     catch (Exception ex)
//     {
//       Console.WriteLine("Xatolik yuz berdi: " + ex.Message);
//     }
//   }
// }


// class Program
// {
//   static void Main()
//   {
//     using (BinaryWriter writer = new BinaryWriter(File.Open("data.bin", FileMode.Create)))
//     {
//       writer.Write("15");
//       writer.Write("salom");
//       writer.Write(14);
//     }
//   }
// }


// class Program
// {
//   static void Main()
//   {
//     using (BinaryReader reader = new BinaryReader(File.Open("data.bin", FileMode.Open)))
//     {
//       string a = reader.ReadString();
//       string b = reader.ReadString();
//       int c = reader.ReadInt32();

//       Console.WriteLine($"{a}, {b}, {c}");
//     }
//   }
// }


// class BinaryExample
// {
//   static void Main()
//   {
//     string file = "student.bin";

//     using (BinaryWriter writer = new BinaryWriter(File.Open(file, FileMode.Create)))
//     {
//       writer.Write(101);
//       writer.Write(20);
//       writer.Write("Ali");
//     }

//     using (BinaryReader reader = new BinaryReader(File.Open(file, FileMode.Open)))
//     {
//       int id = reader.ReadInt32();
//       int yosh = reader.ReadInt32();
//       string ism = reader.ReadString();

//       Console.WriteLine($"Id: {id}, Yosh: {yosh}, ism: {ism}");
//     }
//   }
// }



