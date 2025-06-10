// using System;

// public class Student
// {
//   public string Ism { get; set; }
//   public string Familya { get; set; }
//   public int Yosh { get; set; }
//   public string Kurs { get; set; }
//   public double Baholar { get; set; }

//   // Konstruktor (Constructor) - obyekt yaratilganda chaqiriladi
//   public Student()
//   {
//     Console.WriteLine("Yangi student obyekti yaratildi");
//   }

//   // Parametrli konstruktor
//   public Student(string ism, string familya, int yosh, string kurs)
//   {
//     Ism = ism;
//     Familya = familya;
//     Yosh = yosh;
//     Kurs = kurs;
//     Console.WriteLine($"Student {ism} {familya} ro'yxatga olindi.");
//   }

//   // Metodlar (Methods)
//   public void MalumotlarniKorish()
//   {
//     Console.WriteLine("===========Student ma'lumotlari =========");
//     Console.WriteLine($"Ism: {Ism}");
//     Console.WriteLine($"Familya: {Familya}");
//     Console.WriteLine($"Yosh: {Yosh}");
//     Console.WriteLine($"Kurs: {Kurs}");
//     Console.WriteLine($"O'rtacha baho: {Baholar}");
//     Console.WriteLine("=================");
//   }

//   public void BahoQoyish(double baho)
//   {
//     if (baho >= 2 && baho <= 5)
//     {
//       Baholar = baho;
//       Console.WriteLine($"{Ism}ga {baho} baho qo'yildi");
//     }
//     else
//     {
//       Console.WriteLine("Baho 2 dan 5 gacha bo'lishi kerak");
//     }
//   }

//   public string StatusiniAniqlash()
//   {
//     if (Baholar > 4.5)
//     {
//       return "Alo talaba";
//     }
//     else if (Baholar > 3.5)
//     {
//       return "Yaxshi talaba";
//     }
//     else if (Baholar > 2.5)
//     {
//       return "Qoniqarli talaba";
//     }
//     else
//     {
//       return "Qoniqarsiz talaba";
//     }
//   }

//   public void Salomlashish()
//   {
//     Console.WriteLine($"Salom! Men {Ism} {Familya}, {Kurs} kurs talabasi");
//   }
// }

// class Program
// {
//   static void Main()
//   {
//     Console.WriteLine("==== OOP - Student classi namunasi ====\n");

//     // 1-usul: Standart konstruktor
//     Student student1 = new Student();
//     student1.Ism = "Ali";
//     student1.Familya = "Karimov";
//     student1.Yosh = 20;
//     student1.Kurs = "2-kurs";

//     // 2-usul parametrli konstruktor
//     Student student2 = new Student("Nodira", "Umarova", 19, "1-kurs");


//     Student student3 = new Student("Bobur", "Tashmatov", 21, "3-kurs");

//     Console.WriteLine("\n=== Studentlar bilan ishlash ===\n");


//     student1.Salomlashish();
//     student1.BahoQoyish(4.6);
//     Console.WriteLine(student1.StatusiniAniqlash());


//   }
// }


// class Student
// {
//   public string Name;
//   public int Age;

//   // Default constructor
//   public Student()
//   {
//     Name = "No name";
//     Age = 0;
//   }

//   // Parametrli constructor
//   public Student(string name, int age)
//   {
//     Name = name;
//     Age = age;
//   }

//   // Copy constructor
//   public Student(Student other)
//   {
//     Name = other.Name;
//     Age = other.Age;
//   }

//   // static constructor
//   static Student()
//   {
//     Console.WriteLine("Static constructor chaqirildi");
//   }

//   // Destruktor
//   ~Student()
//   {
//     // Obyekt xotiradan o'chirilayotganda
//     Console.WriteLine("Destruktor chaqirildi");
//   }
// }


// class Program
// {
//   static void Main()
//   {
//     Student s1 = new Student();
//     Console.WriteLine($"{s1.Name}, {s1.Age}");

//     Student s2 = new Student("Ali", 22);
//     Console.WriteLine($"{s2.Name}, {s2.Age}");

//     Student s3 = new Student(s2);
//     Console.WriteLine($"{s3.Name}, {s3.Age}");
//   }
// }


// class Passport
// {
//   public string Name;
//   public string Number;

//   // Parametrli constructor
//   public Passport(string name, string number)
//   {
//     Name = name;
//     Number = number;
//   }

//   // Copy Constructor
//   public Passport(Passport other)
//   {
//     Name = other.Name;
//     Number = other.Number;
//   }
// }

// class Program
// {
//   static void Main()
//   {
//     Passport original = new Passport("Ali Valiyev", "AD1234567");
//     Passport duplicate = new Passport(original);
//     Console.WriteLine(duplicate.Name);
//   }
// }




// class Book
// {
//   public string bookName;
//   public string bookAuthor;

//   // default constructor
//   public Book()
//   {
//     bookName = "No name";
//     bookAuthor = "No author";
//   }

//   // parametrli constructor
//   public Book(string bookname, string bookauthor)
//   {
//     bookName = bookname;
//     bookAuthor = bookauthor;
//   }

//   // copy constructor
//   public Book(Book other)
//   {
//     bookName = other.bookName;
//     bookAuthor = other.bookAuthor;
//   }

//   ~Book()
//   {
//     Console.WriteLine("Kitob xotiradan o'chirildi");
//   }
// }

// class Program
// {
//   static void Main()
//   {
//     Book book1 = new Book();
//     book1.bookAuthor = "John Cena";
//     book1.bookName = "BodyBuilder";

//     Book book2 = new Book("Life", "Chin Chung");

//     Console.WriteLine($"{book1.bookAuthor}, {book1.bookName}");
//     Console.WriteLine($"{book2.bookAuthor}, {book2.bookName}");
//   }
// }




