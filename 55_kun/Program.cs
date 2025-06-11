// public class Counter
// {
//   public static int Count = 0;

//   public Counter()
//   {
//     Count++;
//   }
// }

// class Program
// {
//   static void Main()
//   {
//     Counter c1 = new Counter();
//     Counter c2 = new Counter();
//     Console.WriteLine(Counter.Count);
//   }
// }


// public class MathUtility
// {
//   public static int Add(int a, int b)
//   {
//     return a + b;
//   }

//   public static double CircleArea(double radius)
//   {
//     return Math.PI * radius * radius;
//   }
// }

// class Program
// {
//   static void Main()
//   {
//     int sum = MathUtility.Add(5, 6);
//     double area = MathUtility.CircleArea(2.35);
//     Console.WriteLine($"Sum: {sum}, CircleArea: {area}");
//   }
// }



// class MathHelper
// {
//   public static int Square(int number)
//   {
//     return number * number;
//   }
// }

// class Program
// {
//   static void Main()
//   {
//     int son = MathHelper.Square(6);
//     Console.WriteLine(son);
//   }
// }


// class Logger
// {
//   static Logger()
//   {
//     Console.WriteLine("Loggin");
//   }

//   public static void Log(string message)
//   {
//     Console.WriteLine(message);
//   }
// }

// class Program
// {
//   static void Main()
//   {
//     Logger.Log("Hey leave me alone");
//   }
// }


// static class Converter
// {
//   public static double ToCelsius(double fahrenheit)
//   {
//     return (fahrenheit - 32) * 5 / 9;
//   }
// }

// class Program
// {
//   static void Main()
//   {
//     double celcius = Converter.ToCelsius(98.6);
//     Console.WriteLine(celcius);
//   }
// }


// static class Utilities
// {
//   public static int Sum(int a, int b)
//   {
//     return a + b;
//   }

//   public static bool IsEven(int number)
//   {
//     return number % 2 == 0;
//   }

//   public static string capitalize(string word)
//   {
//     if (string.IsNullOrEmpty(word)) return word;
//     return char.ToUpper(word[0]) + word.Substring(1).ToLower();
//   }

//   public static int Max(int a, int b)
//   {
//     return (a > b) ? a : b;
//   }
// }

// class Program
// {
//   static void Main()
//   {
//     Console.WriteLine(Utilities.Sum(3, 5));
//     Console.WriteLine(Utilities.IsEven(6));
//     Console.WriteLine(Utilities.capitalize("hello"));
//     Console.WriteLine(Utilities.Max(10, 5));
//   }
// }

// class A
// {
//   public static int counter = 0;
//   public A()
//   {
//     counter++;
//   }
// }

// class B : A
// {
//   public B() : base()
//   {
//     counter += 2;
//   }
// }

// class Program
// {
//   static void Main()
//   {
//     A a1 = new A();
//     B b1 = new B();
//     B b2 = new B();
//     Console.WriteLine(A.counter);
//   }
// }

// class Parent
// {
//   public void SayHello()
//   {
//     Console.WriteLine("Hello Parent");
//   }
// }

// class Child : Parent
// {
//   public void SayHi()
//   {
//     Console.WriteLine("Hello Child");
//   }
// }

// class Program
// {
//   static void Main()
//   {
//     Child c1 = new Child();
//     c1.SayHi();
//     c1.SayHello();
//   }
// }

// class Animal
// {
//   public Animal(string name)
//   {
//     Console.WriteLine("Animal created: " + name);
//   }
// }

// class Dog : Animal
// {
//   public Dog(string name) : base(name)
//   {
//     Console.WriteLine("Dog created: " + name);
//   }
// }


// class Program
// {
//   static void Main()
//   {
//     Dog dog1 = new Dog("Rex");
//   }
// }

// class Animal
// {
//   public virtual void Speak()
//   {
//     Console.WriteLine("Animal speak");
//   }
// }

// class Cat : Animal
// {
//   public override void Speak()
//   {
//     base.Speak();
//     Console.WriteLine("Cat meows");
//   }
// }

// class Program
// {
//   static void Main()
//   {
//     Cat cat1 = new Cat();
//     cat1.Speak();
//   }
// }


// class Animal
// {
//   public virtual string Type => "Generic Animal";
// }

// class Dog : Animal
// {
//   public override string Type => base.Type + " - Dog";
// }

// class Program
// {
//   static void Main()
//   {
//     Dog myanimal = new Dog();
//     Console.WriteLine(myanimal.Type);
//   }
// }


// 🧩 Masala: Transport vositalari ierarxiyasi
// 📋 Masala sharti:

// Quyidagi vazifalarni C# dasturida bajaring:

//     Vehicle nomli ota klass yarating.

//         Unda StartEngine() va StopEngine() nomli virtual metodlar bo‘lsin.

//         Har bir metod ekranga "Engine started" va "Engine stopped" deb chiqarsin.

//     Car nomli voris klass yarating.

//         Vehicle klassidan meros olsin.

//         StartEngine() metodini override qiling va ekranga "Car engine started" deb chiqaring.

//         StopEngine() metodida esa base.StopEngine() dan foydalaning.

//     Dasturda obyektlar yarating va metodlarni chaqiring:

//         Vehicle turidagi obyekt yarating va ikkala metodni chaqiring.

//         Car turidagi obyekt yarating va ikkala metodni chaqiring.


// class Vehicle
// {
//   public virtual void StartEngine()
//   {
//     Console.WriteLine("Engine started");
//   }

//   public virtual void StopEngine()
//   {
//     Console.WriteLine("Engine Stopped");
//   }
// }

// class Car : Vehicle
// {
//   public override void StartEngine()
//   {
//     Console.WriteLine("Car engine started");
//   }

//   public override void StopEngine()
//   {
//     base.StopEngine();
//   }
// }

// class Program
// {
//   static void Main()
//   {
//     Vehicle vehicle1 = new Vehicle();
//     vehicle1.StartEngine();
//     vehicle1.StopEngine();

//     Car car1 = new Car();
//     car1.StartEngine();
//     car1.StopEngine();

//   }
// }


// public class A
// {
//   public A(int x)
//   {
//     Console.WriteLine($"A: {x}");
//   }
// }

// public class B : A
// {
//   public B() : this(5) { }
//   public B(int x) : base(x)
//   {
//     Console.WriteLine($"B: {x}");

//   }
// }

// class Program
// {
//   static void Main()
//   {
//     A a1 = new A(2);
//     B obj = new B();
//   }
// }



public class Friend
{

  public Friend() : this("Dilshod")
  {
    Console.WriteLine("Then I came to greet Alisher.");
  }
  
  public Friend(string name)
  {
    Console.WriteLine($"Hello, {name}");
  }
}

class Program
{
  static void Main()
  {
    Friend f = new Friend();
  }
}
