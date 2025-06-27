// public class Saver<T> where T : class
// {
//   public void Save(T value)
//   {
//     Console.WriteLine("Saved: " + value.ToString());
//   }
// }

// public class MyClass
// {
//   public int Num { get; set; }
// }

// class Program
// {
//   static void Main()
//   {
//     Saver<string> s1 = new Saver<string>();
//     s1.Save("hello");
//     Saver<List<int>> s2 = new Saver<List<int>>();
//     Saver<object> s3 = new Saver<object>();
//     var student = new MyClass { Num = 52 };
//     var s4 = new Saver<MyClass>();

//   }
// }


// public class StructValue<T> where T : struct
// {
//   public T Add(T a, T b)
//   {
//     return (dynamic)a + (dynamic)b;
//   }
// }

// public class Program
// {
//   static void Main()
//   {
//     var intNum = new StructValue<int>();
//     Console.WriteLine(intNum.Add(4, 6));

//     var doubleNum = new StructValue<double>();
//     Console.WriteLine(doubleNum.Add(24, 6));

//   }
// }


// public struct Point
// {
//   public int X;
//   public int Y;
// }

// public class PointHandler<T> where T : struct
// {
//   public void Display(T point)
//   {
//     Console.WriteLine(point.ToString());
//   }
// }

// public class Program
// {
//   static void Main()
//   {
//     var handler = new PointHandler<Point>();
//   }
// }

// public class User
// {
//   public string Name { get; set; }

//   public User()
//   {
//     Name = "Default";
//   }
// }

// public class Factory<T> where T : new()
// {
//   public T Create()
//   {
//     return new T();
//   }
// }

// class Program
// {
//   static void Main()
//   {
//     var f = new Factory<User>();
//     var user = f.Create();
//     Console.WriteLine(user.Name);
//   }
// }



// public class Animal
// {
//   public void Speak()
//   {
//     Console.WriteLine("Generic method started");
//   }
// }

// public class Dog : Animal
// {
//   public void Bark()
//   {
//     Console.WriteLine("Woof");
//   }
// }

// public class FactoryAnimal<T> where T : Animal
// {
//   public void MakeItSpeak(T animal)
//   {
//     animal.Speak();
//   }
// }

// class Program
// {
//   static void Main()
//   {
//     var fa = new FactoryAnimal<Animal>();
//     fa.MakeItSpeak(new Dog());
//   }
// }


// public interface IPrintable
// {
//   void Print();
// }

// public class Document : IPrintable
// {
//   public void Print()
//   {
//     Console.WriteLine("Printing document");
//   }
// }

// public class Phone : IPrintable
// {
//   public void Print()
//   {
//     Console.WriteLine("Printing phone");
//   }
// }

// public class GenericP<T> where T : IPrintable
// {
//   public void GenericMethod(T item)
//   {
//     item.Print();
//   }
// }

// class Program
// {
//   static void Main()
//   {
//     GenericP<Phone> phone = new GenericP<Phone>();
//     phone.GenericMethod(new Phone());

//     GenericP<Document> document = new GenericP<Document>();
//     document.GenericMethod(new Document());

//   }
// }

// ✅ 1. where T : class — Foydalanuvchi ma’lumotini saqlash
// 🔹 Masala sharti:

// Siz SaveManager<T> nomli generic sinf yaratmoqchisiz. U faqat reference type bo‘lgan ma’lumotlarni saqlashi mumkin. Masalan: User, Product va h.k.

// public class SaveManager<T> where T : class
// {
//   public void Saved(T item)
//   {
//     Console.WriteLine("Saved" + item.ToString());
//   }
// }

// public class User
// {
//   public string Name { get; set; }
//   public override string ToString() => $"Foydalanuvchi: {Name}";
// }


// class Program
// {
//   static void Main()
//   {
//     var user = new SaveManager<User>();
//     user.Saved(new User { Name = "Javohir" });
//   }

// }


// ✅ 2. where T : struct — Qiymatlarni ro‘yxatga chiqarish
// 🔹 Masala sharti:

// Siz ValuePrinter<T> sinfi yaratmoqchisiz, u faqat raqam yoki qiymat (value type) turlarini qabul qiladi va ularni konsolga chiqaradi.

// public class ValuePrinter<T> where T : struct
// {
//   public void Print(T value)
//   {
//     Console.WriteLine("Qiymat: " + value);
//   }
// }

// class Program
// {
//   static void Main()
//   {
//     ValuePrinter<int> son = new ValuePrinter<int>();
//     son.Print(5);

//   }
// }


// ✅ 3. where T : new() — Obyekt yaratuvchi (Factory)
// 🔹 Masala sharti:

// Siz ObjectFactory<T> sinfini yaratmoqchisiz. U har doim yangi obyekt yaratadi, lekin faqat bo‘sh konstruktor mavjud bo‘lsa ishlaydi.


// public class ObjectFactory<T> where T : new()
// {
//   public T Create() => new T();
// }

// public class Book()
// {
//   public string Title { get; set; } = "No title";
// }

// class Program
// {
//   static void Main()
//   {
//     var factory = new ObjectFactory<Book>();
//     var book = factory.Create();
//     book.Title = "Titanic";
//     Console.WriteLine("Kitob nomi: " + book.Title);
//   }
// }

// ✅ 4. where T : BaseClass — Bazaviy funksiyani ishlatish
// 🔹 Masala sharti:

// Processor<T> sinfini yarating. Bu sinf BaseClass dan meros olgan obyektlar bilan ishlaydi va Describe() metodini chaqiradi.


// public class BaseProduct
// {
//   public virtual void Describe()
//   {
//     Console.WriteLine("Umumiy ma'lumot");
//   }
// }

// public class Laptop : BaseProduct
// {
//   public override void Describe()
//   {
//     Console.WriteLine("Bu Laptop mahsuloti");
//   }
// }

// public class Processor<T> where T : BaseProduct
// {
//   public void ShowDescription(T value)
//   {
//     value.Describe();
//   }
// }

// class Program
// {
//   static void Main()
//   {
//     var processor = new Processor<Laptop>();
//     processor.ShowDescription(new Laptop());
//   }
// }


// ✅ 5. where T : IInterface — Interfeysli obyektlarni boshqarish
// 🔹 Masala sharti:

// ActionHandler<T> sinfi faqat IRunnable interfeysini implement qilgan classlar bilan ishlaydi. Har bir T Run() metodiga ega bo'lishi kerak.

// public interface IRunnable
// {
//   void Run();
// }

// public class Robot : IRunnable
// {
//   public void Run() => Console.WriteLine("Robot harakatlanmoqda");
// }

// public class ActionHandler<T> where T : IRunnable
// {
//   public void Execute(T item)
//   {
//     item.Run();
//   }
// }

// class Program
// {
//   static void Main()
//   {
//     var handler = new ActionHandler<Robot>();
//     handler.Execute(new Robot());
//   }
// }


// ✅ 6. where T : class, new() — Reference type yaratish va ishlatish
// 🔹 Masala sharti:

// Creator<T> sinfi T turidagi obyektni yaratadi. T faqat class bo‘lishi va bo‘sh konstruktorga ega bo‘lishi kerak.


// public class Message
// {
//   public string message { get; set;} = "Salom";
// }

// public class Creator<T> where T : class, new()
// {
//   public T creatorObject() => new T();
// }

// class Program
// {
//   static void Main()
//   {
//     var creator = new Creator<Message>();
//     var msg = creator.creatorObject();
//     Console.WriteLine(msg.message);
//   }
// }


// ✅ 7. where T : BaseClass, IInterface, new() — Ko‘p cheklovli generic
// 🔹 Masala sharti:

// SystemRunner<T> sinfi BaseSystem dan meros olgan, IRun interfeysini implement qilgan va bo‘sh konstruktorli classlar bilan ishlaydi.

// public class BaseSystem
// {
//   public void Init() => Console.WriteLine("Tizim tayyorlandi");
// }

// public interface IRun
// {
//   void Run();
// }

// public class AppSystem : BaseSystem, IRun
// {
//   public void Run() => Console.WriteLine("Tizim ishga tushdi");
// }

// public class SystemRunner<T> where T : BaseSystem, IRun, new()
// {
//   public void Start()
//   {
//     T system = new T();
//     system.Init();
//     system.Run();
//   }
// }

// class Program
// {
//   static void Main()
//   {
//     var runner = new SystemRunner<AppSystem>();
//     runner.Start();
//   }
// }
