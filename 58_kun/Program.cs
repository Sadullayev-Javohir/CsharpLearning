// class Student
// {
//   private int age;

//   public int Age
//   {
//     get { return age; }
//     set
//     {
//       if (value >= 0 && value <= 150)
//       {
//         age = value;
//       }
//       else
//       {
//         Console.WriteLine("Yaroqsiz yosh");
//       }
//     }
//   }
// }

// class Program
// {
//   static void Main()
//   {
//     Student student1 = new Student();
//     student1.Age = 15;
//   }
// }


// public class User
// {
//   public string UserName { get; private set; }
//   public string Password { private get; set; }

//   public User(string UserName, string Password)
//   {
//     this.UserName = UserName;
//     this.Password = Password;
//   }

//   public bool CheckPassword(string inputPassword)
//   {
//     return Password == inputPassword;
//   }
// }

// class Program
// {
//   static void Main()
//   {
//     User user = new User("javohir_sadullayev", "123456");

//     Console.WriteLine("UserName: " + user.UserName);

//     Console.WriteLine("Parol to'gr'imi ? " + (user.CheckPassword("123456") ? "Ha" : "Yo'q"));
//   }
// }



// public class Shape
// {
//   public virtual double CalculateArea()
//   {
//     return 0;
//   }
// }

// public class Circle : Shape
// {
//   public double Radius { get; set; }

//   public Circle(double radius)
//   {
//     Radius = radius;
//   }

//   public override double CalculateArea()
//   {
//     return Math.PI * Radius * Radius;
//   }
// }

// public class Rectangle : Shape
// {
//   public double Width { get; set; }
//   public double Height { get; set; }

//   public Rectangle(double Width, double Height)
//   {
//     this.Width = Width;
//     this.Height = Height;
//   }

//   public override double CalculateArea()
//   {
//     return Width * Height;
//   }
// }

// public class Triangle : Shape
// {
//   public double Base { get; set; }
//   public double Height { get; set; }

//   public Triangle(double b, double h)
//   {
//     Base = b;
//     Height = h;
//   }

//   public override double CalculateArea()
//   {
//     return 0.5 * Base * Height;
//   }
// }


// public class Program
// {
//   public static void Main()
//   {
//     Shape[] shapes = new Shape[]
//     {
//       new Circle(3),
//       new Rectangle(4, 5),
//       new Triangle(6, 3)
//     };

//     foreach (Shape shape in shapes)
//     {
//       Console.WriteLine($"Area: {shape.CalculateArea()}");
//     }
//   }
// }



// public class Calculator
// {
//   public int Add(int a, int b)
//   {
//     return a + b;
//   }

//   public int Add(int a, int b, int c)
//   {
//     return a + b + c;
//   }

//   public double Add(double a, double b)
//   {
//     return a + b;
//   }
// }

// class Program
// {
//   static void Main()
//   {
//     Calculator calc = new Calculator();

//     Console.WriteLine(calc.Add(2, 3));
//     Console.WriteLine(calc.Add(1, 2, 3));

//     Console.WriteLine(calc.Add(1.5, 2.5));
//   }
// }


// public abstract class Shape
// {
//   public abstract double CalculateArea();

//   public void Display()
//   {
//     Console.WriteLine("Shaklning maydoni: " + CalculateArea());
//   }
// }


// public class Circle : Shape
// {
//   public double Radius { get; set; }

//   public Circle(double radius)
//   {
//     Radius = radius;
//   }

//   public override double CalculateArea()
//   {
//     return Math.PI * Radius * Radius;
//   }
// }


// public class Rectangle : Shape
// {
//   public double Width { get; set; }
//   public double Height { get; set; }

//   public Rectangle(double Width, double Height)
//   {
//     this.Width = Width;
//     this.Height = Height;
//   }

//   public override double CalculateArea()
//   {
//     return Width * Height;
//   }
// }

// public class Program
// {
//   public static void Main()
//   {
//     Circle s1 = new Circle(5);
//     s1.Display();

//     Rectangle s2 = new Rectangle(4, 7);
//     s2.Display();
//   }
// }


// public abstract class Animal
// {
//   public abstract void MakeSound();
// }

// class Dog : Animal
// {
//   public override void MakeSound()
//   {
//     Console.WriteLine("Woof");
//   }
// }

// class Cat : Animal
// {
//   public override void MakeSound()
//   {
//     Console.WriteLine("Meow");
//   }
// }

// class Program
// {
//   static void Main()
//   {
//     Animal cat1 = new Cat();
//     cat1.MakeSound();

//     Animal dog1 = new Dog();
//     dog1.MakeSound();
//   }
// }


// 🎯 Vazifa: Abstract klassdan foydalanib grafik editor tuzish
// 🔧 Tushuncha:

//     Grafik editor — rasm chizadigan, shakllarni joylashtiradigan dastur. U yerda har xil shakllar bo‘ladi: Doira, To‘rtburchak, Uchburchak va h.k.

//     Bu shakllar uchun umumiy abstract klass yaratiladi: Shape

//     Har bir shakl bu klassni meros oladi va Draw() metodini override qiladi.


// public abstract class Shape
// {
//   public abstract void Draw();
// }

// class Circle : Shape
// {
//   public override void Draw()
//   {
//     Console.WriteLine("Circle is drawing");
//   }
// }

// class Rectangle : Shape
// {
//   public override void Draw()
//   {
//     Console.WriteLine("Rectange is drawing");
//   }
// }

// class Triangle : Shape
// {
//   public override void Draw()
//   {
//     Console.WriteLine("Triangle is drawing");
//   }
// }

// class Program
// {
//   static void Main()
//   {
//     // Shape c1 = new Circle();
//     // c1.Draw();

//     // Shape tr = new Triangle();
//     // tr.Draw();

//     // Shape rc = new Rectangle();
//     // rc.Draw();

//     List<Shape> list = new List<Shape>();
//     list.Add(new Circle());
//     list.Add(new Rectangle());
//     list.Add(new Triangle());

//     foreach (var shape in list)
//     {
//       shape.Draw();
//     }
//   }
// }
