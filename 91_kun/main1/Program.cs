// class Person(string firstname, string lastname)
// {
//   public string FirstName { get; } = firstname;
//   public string LastName { get; } = lastname;

//   public void Greet()
//   {
//     Console.WriteLine($"Hello, {FirstName}, {LastName}");
//   }
// }

// class Program
// {
//   static void Main()
//   {
//     var p = new Person("Ali", "Valiyev");
//     p.Greet();
//   }
// }

// class Animal(string name)
// {
//   public void Speak() => Console.WriteLine($"I am {name}");
// }

// class Dog(string name, string breed) : Animal(name)
// {
//   public void ShowBreed() => Console.WriteLine($"Breed: {breed}");
// }

// class Program
// {
//   static void Main()
//   {
//     Dog dog = new Dog("Rex", "Germany");
//     dog.Speak();
//     dog.ShowBreed();
//   }
// }

// struct Point(int x, int y)
// {
//   public void Print() => Console.WriteLine($"X: {x}, Y: {y}");
// }

// class Program
// {
//   static void Main()
//   {
//     var point = new Point(24, 2);
//     point.Print();
//   }
// }


// record Car(string Brand, string Model)
// {
//   public void Print() => Console.WriteLine($"{Brand} {Model}");
// }

// class Program
// {
//   static void Main()
//   {
//     var c = new Car("Chevrolet", "Damas");
//     c.Print();
//   }
// }

// using System;

// class Program
// {
//   static void Main()
//   {
//     var s = new Student("Ali", 20);
//     s.PrintInfo();
//   }
// }


// class Program
// {
//   static void Main()
//   {
//     var greet = (string name = "Mehmon") => $"Salom: {name}";

//     Console.WriteLine(greet());

//   }
// }

// class Program
// {
//   static void Main()
//   {
//     int[] numbers = [1, 2, 3, 4];
//     int[] numbers2 = new int[] { 1, 2, 3, 4 };
//     int[] numbers3 = [.. numbers, 4, 6, 7];
//     Console.WriteLine(String.Join(",", numbers3));
//   }
// }

// using Num = System.Int32;

// class Program
// {
//   static void Main()
//   {
//     Num son = 125;
//     Console.WriteLine(son);
//   }
// }

// using System;
// using System.Collections.Generic;
// using StringList = System.Collections.Generic.List<string>;


// class Program
// {
//   static void Main()
//   {
//     StringList names = ["Ali", "Vali"];
//     Console.WriteLine(String.Join(", ", names));
//   }
// }

// class User
// {
//   public required string Name { get; set; }
//   public int Age { get; set; }
// }

// class Program
// {
//   static void Main()
//   {
//     var u = new User() { };
// }



