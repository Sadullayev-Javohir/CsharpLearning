// ✅ 1. Oddiy konstruktor — obyekt yaratilganda xabar chiqarsin

// Shart:
// Hello nomli klass yaratilsin. Obyekt yaratilganda "Salom, bu konstruktor!" xabari chiqsin.


// class Hello
// {
//   public Hello()
//   {
//     Console.WriteLine("Salom, Bu konstruktor");
//   }
// }

// class Program
// {
//   static void Main(string[] args)
//   { 
//     Hello hello = new Hello();
//   }
// }



// ✅ 2. Parametrli konstruktor — kitob nomini saqlash

// Shart:
// Book nomli klassda konstruktor kitob nomini qabul qilib, Title propertysiga saqlasin.

// class Book
// {
//   private string Title;

//   public Book(string title)
//   {
//     Title = title;
//     Console.WriteLine($"Kitob nomi: {Title}");
//   }
// }

// class Chiqar
// {
//   static void Main(string[] args)
//   {
//     Book book1 = new Book("G'arbiy frontda o'zgarish yo'q");
//   }
// }


// ✅ 3. this orqali parametr va field farqlansin

// Shart:
// User klassi Name fieldiga konstruktor orqali qiymat qabul qilsin, parametr va field nomi bir xil bo‘lsin.

// class User
// {
//   private string Name;
//   public User(string Name)
//   {
//     this.Name = Name;
//     Console.WriteLine($"User ning ismi: {Name}");
//   }
// }

// class Program
// {
//   static void Main(string[] args)
//   {
//     User user1 = new User("Javohir");
//   }
// }


// ✅ 4. Ikki xil konstruktor: default va parametrli

// Shart:
// Dog klassi uchun bir parametrsiz va bir parametrli konstruktor yozilsin.

// class Dog
// {
//   private string Name;

//   public Dog()
//   {
//     Console.WriteLine("Vav-Vav");
//   }
//   public Dog(string name)
//   {
//     this.Name = name;
//     Console.WriteLine($"Kuchukning ismi: {Name}");
//   }
// }

// class Program
// {
//   public static void Main(string[] args)
//   {
//     Dog dog1 = new Dog();
//     Dog dog2 = new Dog("Obcherka");
//   }
// }


// ✅ 5. this() orqali boshqa konstruktorni chaqirish

// Shart:
// Student klassida ikkita konstruktor bo‘lsin. Default konstruktor this() orqali ikkinchi konstruktorni chaqirsin.

// using System.ComponentModel;

// class Student
// {
//   public string Name;
//   public int Age;

//   public Student() : this("No name", 0) { }
//   public Student(string name, int age)
//   {
//     Name = name;
//     Age = age;
//     Console.WriteLine("Name: " + Name + " " + "Age: " + Age);
//   }
// }

// class Program
// {
//   static void Main(string[] args)
//   {
//     Student student1 = new Student("Javohir", 23);
//   }
// }



// ✅ 6. Copy constructor — boshqa obyektdan qiymat olish

// Shart:
// Person klassida bir obyektning qiymatini boshqasiga nusxalovchi konstruktor yozilsin.



// class Person
// {
//   private string Name;

//   public Person(string name)
//   {
//     Name = name;
//     Console.WriteLine($"Ism: {Name}");
//   }
//   public Person(Person OtherName)
//   {
//     Name = OtherName.Name;
//     Console.WriteLine($"Boshqa ism: {Name}");
//   }
// }

// class Program
// {
//   static void Main(string[] args)
//   {
//     Person person1 = new Person("Javohir");
//     Person person2 = new Person(person1);

//   }
// }



// ✅ 7. Kvadratning yuzasini hisoblaydigan konstruktor

// Shart:
// Square klassi tomon uzunligi orqali maydonni hisoblasin.

// class Square
// {
//   double Side;
//   double s;

//   public Square(double side)
//   {
//     Side = side;
//     s = Side * Side;
//     Console.WriteLine($"Kvadratning yuzi: {s}");
//   }
// }

// class Program
// {
//   static void Main(string[] args)
//   {
//     Square square1 = new Square(23);
//   }
// }


// ✅ 8. Konstruktor ichida holat chiqarilsin

// Shart:
// Laptop klassi yaratilganda, brendi konstruktor orqali berilsin va ekranga chiqsin.

// class Laptop
// {
//   public string Brand;

//   public Laptop(string brand)
//   {
//     Brand = brand;
//     Console.WriteLine($"Laptop brandi: {Brand}");
//   }
// }

// class Program
// {
//   static void Main(string[] args)
//   {
//     Laptop laptop1 = new Laptop("Lenovo");
//   }
// }

// ✅ 9. this bilan bir nechta property'ni farqlash

// Shart:
// Employee klassi Name va Position fieldlariga qiymat berishda this ishlatilishi kerak.

// class Employee
// {
//   string Name;
//   string Position;

//   public Employee(string Name, string Position)
//   {
//     this.Name = Name;
//     this.Position = Position;
//     Console.WriteLine($"Ism: {Name}, lavozimi: {Position}");
//   } 
// }

// class Program
// {
//   static void Main(string[] args)
//   {
//     Employee employee1 = new Employee("Javohir", "Software programming");
//   }
// }


// ✅ 10. Konstruktor + method yordamida ma’lumot chiqarish

// Shart:
// Car klassi konstruktor orqali model va yilni qabul qilib, ShowInfo metodi bilan chiqarib bersin.

// class Car
// {
//   string Model;
//   int Year;

//   public Car(string model, int year)
//   {
//     Model = model;
//     Year = year;
//   }

// public void ShowInfo()
//   {
//     Console.WriteLine($"Mashina modeli: {Model}, yili: {Year}");
//   }
// }

// class Program
// {
//   static void Main(string[] args)
//   {
//     Car car1 = new Car("Mercedez Benz", 2025);
//     car1.ShowInfo();
//   }
// }