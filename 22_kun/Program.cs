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


