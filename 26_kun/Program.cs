// Bir ta "Car" nomli class yarating.
// Bu classda bitta field — Model bo‘lsin.
// Constructor orqali Model qiymatini tashqaridan qabul qilib olib o‘rnating.
// Keyin, obyekt yaratib, o‘sha mashinaning modelini ekranga chiqarib bering.

// class Car
// {
//   public string Model;

//   public Car(string Model)
//   {
//     this.Model = Model;
//   }
// }

// class Program
// {
//   static void Main(string[] args)
//   {
//     Car car1 = new Car("Tesla");
//     Console.WriteLine(car1.Model);
//   }
// }


// 2-masala: Default Constructor haqida
// 📋 Masala sharti:

//     Person nomli class yarating.
//     Unda Name degan field bo‘lsin.
//     Constructor parametrsiz bo‘lib, Name ga "No name" qiymatini bersin.
//     Obyekt yaratib, ismni ekranga chiqarilsin.

// class Person
// {
//   public string Name;
//   public Person()
//   {
//     Name = "No name";
//   }
// }

// class Program
// {
//   static void Main(string[] args)
//   {
//     Person person = new Person();
//     Console.WriteLine(person.Name);
//   }
// }


// 3-masala: Overloaded Constructor
// 📋 Masala sharti:

//     Student nomli class yarating.
//     Classda Name va Age fieldlari bo‘lsin.
//     Ikkita constructor yarating: biri faqat Name olsin, ikkinchisi Name va Age olsin.

// class Student
// {
//   public string Name;
//   public int Age;

//   public Student(string Name)
//   {
//     this.Name = Name;
//     Console.WriteLine($"Student ismi: {Name}");
//   }
//   public Student(string Name, int Age)
//   {
//     this.Name = Name;
//     this.Age = Age;
//     Console.WriteLine($"Studentning ismi: {Name}, yoshi: {Age}");
//   }
// }

// class Program
// {
//   static void Main(string[] args)
//   {
//     Student student1 = new Student("Javohir");
//     Student student2 = new Student("Jasur", 18);

//   }
// }


// 4-masala: Oddiy Inheritance
// 📋 Masala sharti:

//     Animal nomli class yarating,
//     unda Eat() metodi bo‘lsin.
//     Dog classi Animal classidan meros olsin va o‘zining Bark() metodiga ega bo‘lsin.

// class Animal
// {
//   public void Eat()
//   {
//     Console.WriteLine("Animal is eating");
//   }
// }

// class Dog : Animal
// {
//   public void Bark()
//   {
//     Console.WriteLine("Dog is barking..");
//   }
// }

// class Program
// {
//   static void Main(string[] args)
//   {
//     Animal dog1 = new Dog();
//     Dog dog2 = (Dog)dog1;
//     dog2.Eat();
//     dog2.Bark();
//   }Manager
// }



// 5-masala: Inheritance va Constructor ishlashi
// 📋 Masala sharti:

//     Employee classi yarating va constructorida "Employee created" chiqarsin.
//     Manager classi Employee classidan meros olib, o‘z constructorida "Manager created" chiqarsin.
//     Manager obyektini yaratganda, ikkala xabar chiqsin.


// class Employee
// {
//   public Employee()
//   {
//     Console.WriteLine("Employee created");
//   }
// }

// class Manager : Employee
// {
//   public Manager() : base()
//   {
//     Console.WriteLine("Manager created");
//   }
// }

// class Program
// {
//   static void Main(string[] args)
//   {
//     // Employee emp = new Employee();
//     Manager manager = new Manager();
//   }
// }


// 6-masala: Encapsulation - private field va method
// 📋 Masala sharti:

//     BankAccount nomli class yarating.
//     balance fieldi private bo‘lsin.
//     Deposit() va GetBalance() public metodlar orqali foydalanilsin.

// class BankAccount
// {
//   private double balance = 20.03;
//   private double deposit;
//   private double getbalance;
//   public void Deposit(double deposit)
//   {
//     this.deposit = deposit;
//     balance += deposit;
//     Console.WriteLine($"Siz {deposit} pul qo'shdingiz. Sizda {balance} pul bor.");
//   }
//   public void getBalance(double getbalance)
//   {
//     this.getbalance = getbalance;
//     balance -= getbalance;
//     Console.WriteLine($"Sizning hisobingizdan {getbalance} oldindi. Hozir hisobingizda {balance} qoldi.");
//   }
//   public void showBalance()
//   {
//     Console.WriteLine($"Sizning hisobingizda {balance} pul bor.");
//   }
// }

// class Program
// {
//   public static void Main(String[] args)
//   {
//     BankAccount bankAccount1 = new BankAccount();
//     bankAccount1.Deposit(1000);
//     bankAccount1.getBalance(1020.03);
//     bankAccount1.showBalance();

//   }
// }


// 7-masala: Encapsulation - Properties bilan
// 📋 Masala sharti:

//     User class yarating.
//     name fieldini private qiling.
//     Property orqali uni o‘qish va o‘zgartirishga ruxsat bering.

// class User
// {
//   private string name;

//   public string Name
//   {
//     get { return name; }
//     set { if (!string.IsNullOrEmpty(value)) name = value; }
//   }
// }

// class Program
// {
//   static void Main(string[] args)
//   {
//     User user1 = new User();
//     user1.Name = "Javohir";
//     Console.WriteLine(user1.Name);
//   }
// } 



// 8-masala: Polymorphism - Method Overloading
// 📋 Masala sharti:

//     MathOperations class yarating.
//     Unda Multiply metodini ikki xil shaklda overload qiling:
//     biri butun sonlar uchun, ikkinchisi double sonlar uchun.

// class MathOperations
// {
//   public void Multiply(int a, int b)
//   {
//     Console.WriteLine($"{a} + {b} = {a + b}");
//   }

//   public void Multiply(double a, double b)
//   {
//     Console.WriteLine($"{a} + {b} = {a + b}");
//   }
// }

// class Program
// {
//   static void Main(string[] args)
//   {
//     MathOperations math1 = new MathOperations();
//     math1.Multiply(2, 3);
//     math1.Multiply(2.2, 4.2);
//   }
// }



// 9-masala: Polymorphism - Method Overriding
// 📋 Masala sharti:

//     Shape class yarating va Draw() metodini yarating.
//     Circle classi Shapedan meros olib, Draw() metodini override qilsin.

// class Shape
// {
//   public virtual void Draw()
//   {
//     Console.WriteLine("Draw shape");
//   }
// }

// class Circle : Shape
// {
//   public override void Draw()
//   {
//     Console.WriteLine("Draw Circle");
//   }
// }

// class Program
// {
//   static void Main(string[] args)
//   {
//     Circle circle = new Circle();
//     circle.Draw();
//   }
// }


// 10-masala: Polymorphism - Array of Objects bilan
// 📋 Masala sharti:

//     Vehicle class yarating va Move() metodini virtual qilib yarating.
//     Bike va Truck classlari undan meros olib, Move() metodini o‘ziga moslab override qilsin.
//     Ularni arrayga joylashtirib, har birini Move() metodini chaqiring.

// class Vehicle
// {
//   public virtual void Move()
//   {
//     Console.WriteLine("Move Vehicle");
//   }
// }

// class Bike : Vehicle
// {
//   public override void Move()
//   {
//     Console.WriteLine("Bike is moving");
//   }
// }

// class Truck : Vehicle
// {
//   public override void Move()
//   {
//     Console.WriteLine("Truck is moving");
//   }
// }

// class Program
// {
//   static void Main(string[] args)
//   {
//     Vehicle[] vehicles = { new Bike(), new Truck() };
//     foreach (Vehicle vehicle in vehicles)
//     {
//       vehicle.Move();
//     }
//   }
// }