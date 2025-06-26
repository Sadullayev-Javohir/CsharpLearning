// string[] names = { "John", "Alice", "Bob", "Alice" };

// var sorted = names.OrderByDescending(name => name)
//         .ThenByDescending(name => name.Length)
//         .ToList();

// sorted.ForEach(Console.WriteLine);


// string[] names = { "John", "Alice", "Bob", "Alice" };

// var sorted = names.Reverse().ToList();

// sorted.ForEach(Console.WriteLine);



// var talabalar = new List<Talaba> {
//     new Talaba { Id = 1, Ism = "Ali", FakultetId = 1 },
//     new Talaba { Id = 2, Ism = "Vali", FakultetId = 2 }
// };

// var fakultetlar = new List<Fakultet> {
//     new Fakultet { Id = 1, Nomi = "Informatika" },
//     new Fakultet { Id = 2, Nomi = "Fizika" }
// };

// var birlashtirilgan = talabalar.Join(
//   fakultetlar,
//   t => t.Id,
//   f => f.Id,
//   (t, f) => new { t.Ism, f.Nomi }
// );

// // Natija:
// // Ali - Informatika
// // Vali - Fizika

// public class Talaba
// {
//   public int Id { get; set; }
//   public string Ism { get; set; }
//   public int FakultetId { get; set; }
// }

// public class Fakultet
// {
//   public int Id { get; set; }
//   public string Nomi { get; set; }
// }

// public class StringPrinter<T> where T : class
// {
//   public void Print(T value)
//   {
//     Console.WriteLine(value);
//   }
// }

// class Program
// {
//   static void Main()
//   {
//     StringPrinter<string> matn = new StringPrinter<string>();
//     matn.Print("Salom");
//   }
// }



// public class Array<T> where T : class
// {
//   public void PrintArray(T[] values)
//   {
//     foreach(var i in values)
//     {
//       Console.WriteLine(i);
//     }
//   }
// }

// class Program
// {
//   static void Main()
//   {
//     Array<string> sonlar = new Array<string>();
//     sonlar.PrintArray(new string[] { "banana", "apple" });
//   }
// }


// public class ObjectLogger<T> where T : class
// {
//   public void Log(T obj)
//   {
//     Console.WriteLine("Object: " + obj.ToString());
//   }
// }

// class Program
// {
//   static void Main()
//   {
//     // Foydalanish:
//     var logger = new ObjectLogger<object>();
//     logger.Log(5); // string ham object bo‘la oladi
//   }
// }



// public class MyClass
// {
//   public string Name { get; set; }
// }

// public class classSaver<T> where T : class
// {
//   public void Saved(T value)
//   {
//     Console.WriteLine("Saved" + value);
//   }
// }

// class Program
// {
//   static void Main()
//   {
//     var saver = new classSaver<MyClass>();
//     saver.Saved(new MyClass { Name = "Javohir" });
//   }
// }
