// ✅ 1-Misol: Oddiy meros olish

// Shart: Person nomli class yarating, unda Name va SayHello() metodlari bo‘lsin. Student classi Person dan meros olib, Study() metodi qo‘shilsin.

// class Person
// {
//   public string Name { get; set; }
//   public void SayHello()
//   {
//     Console.WriteLine($"Hello {Name}");
//   }
// }

// class Student : Person
// {
//   public void Study()
//   {
//     Console.WriteLine($"{Name} is at study.");
//   }
// }


// class Program
// {
//   static void Main(string[] args)
//   {
//     Student s = new Student();
//     s.Name = "Javohir";
//     s.SayHello();
//     s.Study();
//   }
// }


// ✅ 2-Misol: Multilevel inheritance

// Shart: Device → Phone → Smartphone tarzida uchta class yarating. Har birida o‘ziga xos metod bo‘lsin.

// class Device
// {
//   public void DeviceVoid()
//   {
//     Console.WriteLine("Device Void");
//   }
// }

// class Phone : Device
// {
//   public void PhoneVoid()
//   {
//     Console.WriteLine("PhoneVoid");
//   }
// }

// class Smartphone : Phone
// {
//   public void SmartphoneVoid()
//   {
//     Console.WriteLine("SmartphoneVoid");
//   }
// }

// class Program
// {
//   static void Main(string[] args)
//   {
//     Smartphone smartphone = new Smartphone();
//     smartphone.DeviceVoid();
//     smartphone.PhoneVoid();
//     smartphone.SmartphoneVoid();
//   }
// }


// ✅ 3-Misol: base kalit so‘zidan foydalanish

// Shart: Animal classda Speak() metodi bo‘lsin. Dog class undan meros olib, o‘sha metodni chaqirganda avval otaning metodini, so‘ng o‘zini chiqarsin.

// class Animal
// {
//   public virtual void Speak()
//   {
//     Console.WriteLine("Woow woow");
//   }
// }

// class Dog : Animal
// {
//   public override void Speak()
//   {
//     base.Speak();
//     Console.WriteLine("Dog woof");
//   }
// }

// class Program
// {
//   static void Main(string[] args)
//   {
//     Dog dog = new Dog();
//     dog.Speak();
//   }
// }


// ✅ 4-Misol: Protected field ishlatish

// Shart: Person classda protected age maydonini e’lon qiling. Employee undan meros olib, ShowAge() metodi orqali yoshni ko‘rsatsin.

// class Person
// {
//   protected int Age = 25;
// }

// class Employee : Person
// {
//   public void ShowAge()
//   {
//     Console.WriteLine($"Sizning yoshingizL {Age}");
//   }
// }

// class Program
// {
//   static void Main(string[] args)
//   {
//     Employee emp = new Employee();
//     emp.ShowAge();
//   }
// }


// ✅ 5-Misol: Bir nechta child classlar (Hierarchical inheritance)

// Shart: Vehicle class yarating. Car va Motorcycle undan meros olsin va o‘z metodlariga ega bo‘lsin.

// class Vehicle
// {

// }

// class Car : Vehicle
// {
//   public void CarName()
//   {
//     Console.WriteLine("BWM");
//   }
// }

// class Motorcycle : Car
// {
//   public void MotorcycleName()
//   {
//     Console.WriteLine("Motorello");
//   }
// }

// class Program
// {
//   public static void Main(string[] args)
//   {
//     Car car1 = new Car();
//     car1.CarName();
//     Motorcycle motorcycle1 = new Motorcycle();
//     motorcycle1.MotorcycleName();

//   }

// }



// ✅ 6-Misol: Constructorlar bilan inheritance

// Shart: Person class konstruktorida ism qabul qilsin. Teacher class undan meros olib, konstruktorida base kalit so‘zidan foydalansin.

// class Person
// {
//   protected string Name;
//   public Person(string name)
//   {
//     Name = name;
//   }

//   public void Introduce()
//   {
//     Console.WriteLine($"Hi, I am {Name}");
//   }
// }

// class Teacher : Person
// {
//   public Teacher(string name) : base(name) { }

//   public void Teach()
//   {
//     Console.WriteLine($"{Name}");
//   }
// }

// class Program
// {
//   static void Main(string[] args)
//   {
//     Teacher teacher = new Teacher("Javohir");
//     teacher.Introduce();
//     teacher.Teach();
//   }
// }



// ✅ 7-Misol: Virtual va override metodlar

// Shart: Shape classida Draw() metodi virtual bo‘lsin. Circle va Rectangle uni override qilib, o‘ziga xos chiqish bersin.

// class Shape
// {
//   public virtual void Draw()
//   {
//     Console.WriteLine("Drawing shape...");
//   }
// }

// class Rectangle : Shape
// {
//   public override void Draw()
//   {
//     Console.WriteLine("Drawing Rectangle...");
//   }
// }

// class Circle : Shape
// {
//   public override void Draw()
//   {
//     Console.WriteLine("Drawing Circle...");
//   }
// }

// class Program
// {
//   static void Main(string[] args)
//   {
//     Shape shape = new Shape();
//     shape.Draw();
//     Rectangle rectangle = new Rectangle();
//     rectangle.Draw();
//     Circle circle = new Circle();
//     circle.Draw();
//   }
// }



// ✅ 8-Misol: Type Casting (Upcasting & Downcasting)

// Shart: Animal classidan Cat meros olsin. Animal tipidagi objectni Cat ga casting qiling va o‘z metodidan foydalaning.

// class Animal
// {
//   public void Eat() => Console.WriteLine("Animal eating...");

// }

// class Cat : Animal
// {
//   public void Meow() => Console.WriteLine("Cat Meow");
// }


// class Program
// {
//   static void Main(string[] args)
//   {
//     Animal a = new Cat();
//     a.Eat();

//     Cat c = (Cat)a;
//     c.Eat();
//     c.Meow();
//   }
// }



// ✅ 9-Misol: Method hiding (new keyword)

// Shart: Base classda Print() metodi bo‘lsin. Child classda yangi Print() metodi yaratib, new keyword bilan yashiring.

// class Base
// {
//   public void Print()
//   {
//     Console.WriteLine("Base print");
//   }
// }

// class Child : Base
// {
//   public new void Print() => Console.WriteLine("Child print");
// }

// class Program
// {
//   static void Main(string[] args)
//   {
//     Base obj1 = new Child();
//     obj1.Print();

//     Child obj2 = new Child();
//     obj2.Print();
//   }

// }



// ✅ 10-Misol: Real hayot modeli — Bank account

// Shart: BankAccount class umumiy hisobni yuritsin. SavingsAccount class undan meros olib, foiz hisoblash funksiyasini qo‘shsin.

class BankAccount
{
  public double Balance { get; set; }
  public void Deposit(double amount)
  {
    Balance += amount;
    Console.WriteLine($"Deposited: {amount}, New Balance: {Balance}");
  }
}

class SavingsAccount : BankAccount
{
  public void AddInterest(double rate)
  {
    double interest = Balance * rate / 100;
    Balance += interest;
    Console.WriteLine($"Interest added: {interest}, New balance: {Balance}");
  }
}

class Program
{
  static void Main(string[] args)
  {
    SavingsAccount sa = new SavingsAccount();
    sa.Balance = 300;
    sa.Deposit(2000);
    sa.AddInterest(8);
  }
}