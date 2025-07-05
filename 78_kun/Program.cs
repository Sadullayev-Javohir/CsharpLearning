using System.IO;

// class Program
// {
//   static void Main()
//   {
//     FileStream fs = new FileStream("students.txt", FileMode.Create);
//     byte[] data = System.Text.Encoding.UTF8.GetBytes("Query Selector");
//     fs.Write(data, 0, data.Length);
//     fs.Close();
//   }
// }


// class Program
// {
//   static void Main()
//   {
//     FileStream fs = new FileStream("students.txt", FileMode.Open);

//     byte[] buffer = new byte[fs.Length];
//     fs.Read(buffer, 0, buffer.Length);
//     string text = System.Text.Encoding.UTF8.GetString(buffer);
//     Console.WriteLine(text);
//   }
// }

// class Program
// {
//   static void Main()
//   {
//     FileStream source = new FileStream("students.txt", FileMode.Open);
//     FileStream target = new FileStream("hey.txt", FileMode.Create);

//     source.CopyTo(target);
//     source.Close();
//     target.Close();
//   }
// }


// class Program
// {
//   static void Main()
//   {
//     string path = "example.txt";

//     using (FileStream fs = new FileStream(path, FileMode.Create))
//     {
//       byte[] data = System.Text.Encoding.UTF8.GetBytes("Salom");
//       fs.Write(data, 0, data.Length);
//     }

//     using (FileStream fs = new FileStream(path, FileMode.Open))
//     {
//       byte[] buffer = new byte[fs.Length];
//       fs.Read(buffer, 0, buffer.Length);
//       string text = System.Text.Encoding.UTF8.GetString(buffer);
//       Console.WriteLine(text);
//     }
//   }
// }


// class Program
// {
//   static void Main()
//   {
//     string path = "example.txt";
//     using (StreamWriter writer = new StreamWriter(path))
//     {
//       writer.WriteLine("Hi how are you?");
//       writer.WriteLine("Hi, I'm good thank you");
//     }
//     using (StreamReader reader = new StreamReader(path))
//     {
//       string line;
//       while ((line = reader.ReadLine()) != null)
//       {
//         Console.WriteLine(line);
//       }
//     }
//   }
// }
