// interface IVehicle
// {
//   void Start();
//   void Stop();
// }

// class Car : IVehicle
// {
//   public void Start()
//   {
//     Console.WriteLine("Car is starting");
//   }

//   public void Stop()
//   {
//     Console.WriteLine("Car is stopping");
//   }
// }

// class Program
// {
//   static void Main()
//   {
//     IVehicle car1 = new Car();

//     car1.Start();
//   }
// }



// class Student : IComparable
// {
//   public string Name { get; set; }
//   public int Score { get; set; }

//   public int CompareTo(object obj)
//   {
//     Student other = obj as Student;
//     if (other == null) return 1;

//     return this.Score.CompareTo(other.Score);
//   }
// }

// class Program
// {
//   static void Main()
//   {
//     List<Student> students = new List<Student>()
//   {
//     new Student {Name = "Ali", Score = 235},
//     new Student {Name = "Vali", Score = 323},
//     new Student {Name = "Sami", Score = 234},
//   };

//     students.Sort();

//     foreach (var s in students)
//     {
//       Console.WriteLine($"{s.Name}: {s.Score}");
//     }
//   }
// }

// using System;
// using System.Collections;
// using System.Collections.Generic;


// class Program
// {
//   static void Main()
//   {
//     List<string> names = new List<string> { "Ali", "Vali", "Guli" };
//     foreach (string name in names)
//     {
//       Console.WriteLine(name);
//     }
//   }

// }


// using System;
// using MyApp.Tools;

// namespace MyApp
// {
//   class Program
//   {
//     static void Main()
//     {
//       Calculator calc = new Calculator();
//       Console.WriteLine("Natija: " + calc.Add(5, 2));
//     }
//   }
// }


// public class Student : ICloneable
// {
//   public string Name { get; set; }
//   public int Age { get; set; }

//   public object Clone()
//   {
//     return this.MemberwiseClone();
//   }
// }

// class Program
// {
//   static void Main()
//   {
//     Student s1 = new Student { Name = "Ali", Age = 20 };
//     Student s2 = (Student)s1.Clone();
//     Console.WriteLine($"s2.Name: {s2.Name}, s2.Age: {s2.Age}");
//   }
// }


// interface IReadable
// {
//   void Read();
// }

// interface IWriteable
// {
//   void Write();
// }

// class Document : IReadable, IWriteable
// {
//   public void Read()
//   {
//     Console.WriteLine("Reading document...");
//   }

//   public void Write()
//   {
//     Console.WriteLine("Writing document...");
//   }
// }

// class Program
// {
//   static void Main()
//   {
//     Document doc1 = new Document();
//     doc1.Write();
//   }
// }


// interface IEntity
// {
//   int Id { get; set; }
// }

// interface IPerson : IEntity
// {
//   string Name { get; set; }
// }

// class Employee : IPerson
// {
//   public string Name { get; set; }
//   public int Id { get; set; }
// }

// class Program
// {
//   static void Main()
//   {
//     Employee e1 = new Employee();
//     e1.Name = "Javohir";
//     Console.WriteLine(e1.Name);
//   }
// }



// class Base
// {
//   public virtual void Display() => Console.WriteLine("Base");
// }

// class Derived : Base
// {
//   public sealed override void Display() => Console.WriteLine("Derived");
// }


// sealed class Maxfiy
// {
//   public string UserName { get; }
//   public string Password { get; }

//   public Maxfiy()
//   {
//     UserName = "Javohir";
//     Password = "123456";
//   }

//   public void Korish()
//   {
//     Console.WriteLine("Ko'rildi");
//   }
// }

// class Program
// {
//   static void Main()
//   {
//     Maxfiy m = new Maxfiy();
//     m.Korish();
//     Console.WriteLine(m.UserName);
//   }
// }

namespace ToStringMisol
{
  class Shaxs
  {
    public string Ism { get; set; }
    public int Yosh { get; set; }

    public Shaxs(string ism, int yosh)
    {
      Ism = ism;
      Yosh = yosh;
    }

    public string ToString()
    {
      return $"Bu shaxs: Ism = {Ism}, Yosh = {Yosh}";
    }
  }

  class Program
  {
    static void Main()
    {
      Shaxs shaxs = new Shaxs("Javohir", 25);
      // Console.WriteLine(shaxs.ToString());
      Console.WriteLine(shaxs);
    }
  }
}
