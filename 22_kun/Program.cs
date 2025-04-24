// ✅ 1-misol: Book klassi yaratilsin. Kitobning nomi va muallifi kiritilsin, va ularni konsolga chiqaradigan metod yozilsin.

// public class Book
// {
//   public string bookName;
//   public string bookAuthor;

//   public void ShowDisplay()
//   {
//     Console.WriteLine($"Book name is {bookName}, book author is {bookAuthor}");
//   }
// }

// class Program
// {
//   static void Main(string[] args)
//   {
//     Book book1 = new Book();
//     book1.bookAuthor = "Chingiz Aytmatov";
//     book1.bookName = "Qiyomat";
//     book1.ShowDisplay();
//   }
// }



// ✅ 2-misol: Circle klassi yaratiladi. Doiraning radiusi beriladi va uning yuzasi hisoblab chiqariladi.

// class Circle()
// {
//   public double pi = 3.14;
//   public double radius;
//   public double s;

//   public void Hisobla(int Radius)
//   {
//     this.radius = Radius;
//     s = pi * Math.Pow(radius, 2);
//     Console.WriteLine($"Yuzasi: {s}");
//   }
// }

// class Program
// {
//   static void Main(string[] args)
//   {
//     Circle circle1 = new Circle();
//     circle1.Hisobla(26);
//   }
// }


// ✅ 3-misol: Student klassi yaratiladi. Ism va baho beriladi. U haqida ma'lumot chiqariladi.

// public class Student
// {
//   public string name;
//   public int grade;

//   public void ShowInfo()
//   {
//     Console.WriteLine(name + " ning bahosi " + grade);
//   }
// }

// class Program
// {
//   static void Main(string[] args)
//   {
//     Student s1 = new Student();
//     s1.name = "Sardor";
//     s1.grade = 90;
//     s1.ShowInfo();
//   }
// }



// ✅ 4-misol: Rectangle klassi yaratiladi. Uzunlik va kenglikdan perimetr hisoblanadi.

// public class Rectangle
// {
//   public int length;
//   public int width;

//   public void GetPerimetr()
//   {
//     int perimetr = 2 * (length + width);
//     Console.WriteLine("Perimetr " + perimetr);
//   }
// }

// class Program
// {
//   static void Main(string[] args)
//   {
//     Rectangle rect = new Rectangle();
//     rect.length = 5;
//     rect.width = 3;
//     rect.GetPerimetr();
//   }
// }


// ✅ 5-misol: Phone klassi yaratiladi. Model va narxi kiritilib, ma'lumot chiqariladi

// class Phone
// {
//   public string Model;
//   public int Cost;

//   public void Info()
//   {
//     Console.WriteLine($"Telefon modeli: {Model}, narxi: {Cost}");
//   }
// }

// class Program
// {
//   static void Main(string[] args)
//   {
//     Phone phone1 = new Phone();
//     phone1.Model = "Redmi";
//     phone1.Cost = 250;
//     phone1.Info(); 
//   }
// }


// ✅ 6-misol: Laptop klassi yaratiladi. RAM va SSD qiymatlari kiritiladi.

// class Laptop
// {
//   public int RAM;
//   public int SSD;

//   public void INFO()
//   {
//     Console.WriteLine($"Laptop ning rami : {RAM}, ssdi: {SSD}");
//   }
// }

// class Program
// {
//   static void Main(string[] args)
//   {
//     Laptop laptop1 = new Laptop();
//     laptop1.RAM = 32;
//     laptop1.SSD = 512;
//     laptop1.INFO();
//   }
// }



// ✅ 7-misol: Dog klassi yaratiladi. Ism va yoshi kiritilib, "Hav-hav!" chiqaradi.

// class Dog
// {
//   public string Name;
//   public int age;

//   public void DogInfo()
//   {
//     Console.WriteLine($"Kuchikning ismi: {Name}, yoshi: {age}");
//   }
//   public void HavHav()
//   {
//     Console.WriteLine("Hav-Hav");
//   }
// }


// class Program
// {
//   public static void Main(string[] args)
//   {
//     Dog dog1 = new Dog();
//     dog1.Name = "REX";
//     dog1.age = 10;
//     dog1.DogInfo();
//     dog1.HavHav();
//   }
// }



// ✅ 8-misol: Movie klassi yaratiladi. Nomi va yili kiritilib, chiqariladi.


// class Movie
// {
//   public string name;
//   public int year;

//   public void movieInfo()
//   {
//     Console.WriteLine($"Kino nomi: {name}, yili: {year}");
//   }
// }

// class Program
// {
//   static void Main(string[] args)
//   {
//     Movie movie1 = new Movie();
//     movie1.name = "Harry Potter 1";
//     movie1.year = 2001;
//     movie1.movieInfo();
//   }
// }


// ✅ 9-misol: BankAccount klassi yaratiladi. Foydalanuvchi balansi ko‘rsatiladi.

// class Bank
// {
//   public string owner;
//   public int balance;

//   public void BalanceInfo()
//   {
//     Console.WriteLine($"Foydalanuvchi: {owner}, Balansi: {balance}");
//   }
// }

// class Program
// {
//   static void Main(string[] args)
//   {
//     Bank bank1 = new Bank();
//     bank1.owner = "Ali";
//     bank1.balance = 225225;
//     bank1.BalanceInfo();
//   }
// }


// ✅ 10-misol: Weather klassi yaratiladi. Harorat va shahar nomi beriladi.


// class Weather
// {
//   public double deegree;
//   public string city;

//   public void WeatherInfo()
//   {
//     Console.WriteLine($"Shahar nomi: {city}, Harorat: {deegree}");
//   }
// }

// class Program
// {
//   static void Main(string[] args)
//   {
//     Weather weather1 = new Weather();
//     weather1.deegree = 24.5;
//     weather1.city = "Tashkent";
//     weather1.WeatherInfo();
//   }
// }