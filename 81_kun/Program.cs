// using System;
// using Newtonsoft.Json;
// using System.IO;


// public class Talaba
// {
//   public string Ism { get; set; }
//   public int Yosh { get; set; }
//   public bool Faol { get; set; }
// }


// class Program
// {
//   static void Main()
//   {
//     Talaba talaba = new Talaba { Ism = "Ali", Yosh = 23, Faol = true };

//     string json = JsonConvert.SerializeObject(talaba, Formatting.Indented);

//     Console.WriteLine(json);


//     Talaba tiklangan = JsonConvert.DeserializeObject<Talaba>(json);
//     Console.WriteLine($"Ism: {tiklangan.Ism}, Yosh: {tiklangan.Yosh}, Faol: {tiklangan.Faol}");
//   }
// }


// public class Konfiguratsiya
// {
//   [JsonIgnore]
//   public string ConnectionString { get; set; }
//   public int MaxUserCount { get; set; }
//   public bool EnableLogging { get; set; }
// }

// public class Program
// {
//   static void Main()
//   {
//     string jsonConfig = File.ReadAllText("config.json");
//     Konfiguratsiya config = JsonConvert.DeserializeObject<Konfiguratsiya>(jsonConfig);

//     Console.WriteLine($"Connection: {config.ConnectionString}");
//     Console.WriteLine($"Max User Count: {config.MaxUserCount}");
//     Console.WriteLine($"Logging: {config.EnableLogging}");
//   }
// }


// public class Appsettings
// {
//   public string AppName { get; set; }
//   public string Version { get; set; }
//   public bool UseDarkMode { get; set; }
// }

// class Program
// {
//   static void Main()
//   {
//     string json = File.ReadAllText("appsettings.json");

//     Appsettings app = JsonConvert.DeserializeObject<Appsettings>(json);

//     Console.WriteLine(app.AppName);
//     Console.WriteLine(app.Version);
//     Console.WriteLine(app.UseDarkMode);
//   }

// }


// using System.IO;

// string path = "exam.txt";
// File.WriteAllText(path, "You are welcome");


// using (StreamWriter writer = new StreamWriter("exam.txt"))
// {
//   writer.WriteLine("hey leave me alone");
// }

// string matn = File.ReadAllText("exam.txt");
// Console.WriteLine(matn);

// using (StreamReader reader = new StreamReader("exam.txt"))
// {
//   string line;
//   while ((line = reader.ReadLine()) != null)
//   {
//     Console.WriteLine(line);
//   }
// }


// File.AppendAllText("exam.txt", "yangi qator qo'shildi");
// File.AppendAllText("exam.txt", "2 yangi qator qo'shildi");


// using (StreamWriter writer = new StreamWriter("exam.txt", append: true))
// {
//   writer.Write("Yana qo'shildi new line");
// }

// File.Delete("exmaple.txt");
// File.Move("exam1.txt", "exam.txt");
// File.Copy("exam1.txt", "exam.txt");

// Directory.CreateDirectory("papka");


// using System;
// using System.IO;
// using System.Xml.Serialization;
// using System.Text.Json;

// public class Person
// {
//   public string Name { get; set; }
//   public int Age { get; set; }
// }


// class Program
// {
//   static void Main()
//   {
//     Person person = new Person { Name = "Ali", Age = 20 };
//     XmlSerializer serializer = new XmlSerializer(typeof(Person));
//     using (TextWriter writer = new StreamWriter("person.xml"))
//     {
//       serializer.Serialize(writer, person);
//     }

//     using (TextReader reader = new StreamReader("person.xml"))
//     {
//       Person p = (Person)serializer.Deserialize(reader);
//       Console.WriteLine($"{p.Name}, {p.Age}");
//     }

//   }
// }

// public class Person
// {
//   public string Name { get; set; }
//   public int Age { get; set; }
// }

// class Program
// {
//   static void Main()
//   {
//     // Person person = new Person() { Name = "Ali", Age = 25 };
//     // string json = JsonSerializer.Serialize(person);
//     // File.WriteAllText("person.json", json);

//     string json = File.ReadAllText("person.json");
//     Person p = JsonSerializer.Deserialize<Person>(json);
//     Console.WriteLine($"{p.Name} - {p.Age}");
//   }
// }

// delegate int MyDelegate(int a, int b);

// class Program
// {
//   static int Add(int a, int b)
//   {
//     return a + b;
//   }

//   static int Multiply(int a, int b)
//   {
//     return a * b;
//   }

//   static void Main()
//   {
//     MyDelegate ob;

//     ob = Add;
//     Console.WriteLine(ob(4, 2));

//     ob = Multiply;
//     Console.WriteLine(ob(15, 5));
//   }
// }

// delegate int Operation(int a, int b);

// class Calculation
// {
//   static int Calculate(int x, int y, Operation op)
//   {
//     return op(x, y);
//   }

//   static int Ayirish(int x, int y)
//   {
//     return x - y;
//   }

//   static void Main()
//   {
//     Console.WriteLine(Calculate(4, 1, Ayirish));
//   }
// }


// using System.Collections.Generic;

// delegate int Delegate(int a);

// class Program
// {
//   static int Square(int x) => x * x;

//   public static List<int> Process(List<int> numbers, Delegate d)
//   {
//     List<int> result = new List<int>();

//     foreach (var i in numbers)
//     {
//       result.Add(d(i));
//     }
//     return result;
//   }

//   static void Main()
//   {
//     List<int> sonlar = new List<int>() { 1, 3, 4, 5, 6 };
//     var deleg = Process(sonlar, Square);
//     Console.WriteLine(string.Join(", ", deleg));
//   }
// }


delegate void MyDelegate();

// class Program
// {
//   static void Hello()
//   {
//     Console.WriteLine("Salom, dunyo");
//   }

//   static void Main()
//   {
//     MyDelegate d = Hello;
//     d();
//   }
// }


delegate int Calculator(int a, int b);

class Dastur
{
  static int Add(int x, int y) => x + y;
  static int Multiply(int x, int y) => x * y;

  static void Main()
  {
    Calculator op = Add;
    Console.WriteLine(op(3, 5));

    op = Multiply;
    Console.WriteLine(op(3, 5));
  }
}


delegate int MathOp(int x);

class Program
{
  static int Square(int x) => x * x;
  static int Double(int x) => x * 2;

  static void Process(int num, MathOp op)
  {
    Console.WriteLine("Natija: " + op(num));
  }

  static void Main()
  {
    Process(4, Square);
    Process(5, Double);
  }
}


// delegate void ShowMessage(string msg);

// class Program
// {
//   static void Main()
//   {
//     ShowMessage show = delegate (string text)
//     {
//       Console.WriteLine("Anonymous: " + text);
//     };
//     show("Delegate bilan ishlayapti");
//   }
// }


// delegate int Transform(int x);

// class Program
// {
//   static void Main()
//   {
//     Transform cube = x => x * x * x;
//     Console.WriteLine(cube(3));
//   }
// }


// delegate void Notify();

// class Program
// {
//   static void First()
//   {
//     Console.WriteLine("1");
//   }
//   static void Second()
//   {
//     Console.WriteLine("2");
//   }

//   static void Main()
//   {
//     Notify n = First;
//     n += Second;
//     n();
//   }
// }

// delegate void ShowMessage(string text);

// class Program
// {
//   static void Main()
//   {
//     ShowMessage show = delegate (string text)
//     {
//       Console.WriteLine("Matn: " + text);
//     };
//     show("Hello World");
//   }
// }

