// ✅ 1-MASALA: Student sinfi yaratish
// 🧾 Shart:

//     Student nomli sinf yarating. Unda quyidagi private fieldlar bo‘lsin:

//         name (string)

//         age (int)

//         grade (double)

//     Har bir field uchun public getter va setter metodlarini (yoki property) yozing. age 0 dan kichik bo‘lmasligi kerak, grade esa 0 dan 100 gacha bo‘lishi kerak.
//     Konsolda obyekt yarating va unga qiymat berib, ekranga chiqarilsin.

// class Student
// {
//   private string name;
//   private int age;
//   private double grade;

//   public string Name
//   {
//     get { return name; }
//     set { name = value; }
//   }
//   public int Age
//   {
//     get { return age; }
//     set
//     {
//       if (value >= 0)
//       {
//         age = value;
//       }
//       else
//       {
//         Console.WriteLine("Manfiy son kiritilishi mumkin emas");
//       }
//     }
//   }
//   public double Grade
//   {
//     get { return grade; }
//     set
//     {
//       if (value >= 0 && value <= 100)
//       {
//         grade = value;
//       }
//       else
//       {
//         Console.WriteLine("0 dan 100 gacha bo'lishi kerak.");
//       }
//     }
//   }
//   public void StudentInfo()
//   {
//     Console.WriteLine($"Talaba ismi: {Name}, yoshi: {Age}, bahosi: {Grade}");
//   }
// }

// class Program
// {
//   static void Main(string[] args)
//   {
//     Student student = new Student();
//     student.Name = "Javohir";
//     student.Age = -4;
//     student.Grade = -10;
//     student.StudentInfo();
//   }
// }



// ✅ 2-MASALA: BankAccount sinfi
// 🧾 Shart:

//     BankAccount nomli sinf yarating. Unda quyidagi private field bo‘lsin:

//         balance (double)

//     Quyidagi metodlarni yarating:

//         Deposit(double amount) – balansga pul qo‘shadi.

//         Withdraw(double amount) – balansdan pul yechadi, ammo agar balans yetarli bo‘lmasa, "Yetarli mablag' mavjud emas" degan xabar chiqadi.

//         GetBalance() – balansni qaytaradi (getter sifatida).

//     Konsolda hisob oching, unga pul qo‘shing, pul yeching va balansni ko‘rsating.


// class BankAccount
// {
//   private double balance;
//   public void Deposit(double amount)
//   {
//     if (amount > 0)
//     {
//       balance += amount;
//       Console.WriteLine($"Hisobingizga {amount} qo'shildi. Balansingizda: {balance} pul bor.");
//     }
//     else
//     {
//       Console.WriteLine($"Siz {amount} pul qo'shish imkonsiz");
//     }
//   }
//   public void Withdraw(double amount)
//   {
//     if (amount <= balance)
//     {
//       balance -= amount;
//       Console.WriteLine($"Siz {amount} pul yechib oldingiz. Sizning Hisobingizda {balance} pul qoldi.");
//     }
//     else
//     {
//       Console.WriteLine($"Siz {amount} pul yechib ololmaysiz");
//     }
//   }
//   public void BalanceInfo()
//   {
//     Console.WriteLine($"Sizning balansingiz: {balance}");
//   }
// }

// class Program
// {
//   static void Main(string[] args)
//   {
//     BankAccount bankaccount1 = new BankAccount();
//     bankaccount1.Withdraw(100);
//     bankaccount1.BalanceInfo();

//   }
// }



// ✅ 3-MASALA: Book sinfi
// 🧾 Shart:

//     Book nomli sinf yarating. Unda quyidagi private fieldlar bo‘lsin:

//         title (string)

//         author (string)

//         pages (int) — bu 0 dan kichik bo‘lmasligi kerak.

//     Har bir field uchun property yozing.
//     Konsolda Book obyektini yarating va uning qiymatlarini ekranga chiqaring.


// class Book
// {
//   private string title;
//   private string author;
//   private int page;

//   public string Title
//   {
//     get { return title; }
//     set { title = value; }
//   }
//   public string Author
//   {
//     get { return author; }
//     set { author = value; }
//   }

//   public int Page
//   {
//     get { return page; }
//     set
//     {
//       if (value < 0)
//       {
//         Console.WriteLine("page 0 dan kichik bo'lmasligi kerak");
//       }
//       else
//       {
//         page = value;
//       }
//     }
//   }

//   public void BookInfo()
//   {
//     Console.WriteLine($"Kitob sarlavhasi: {title}, muallifi: {author}, varaqlar soni: {page}");
//   }
// }

// class Program
// {
//   static void Main(string[] args)
//   {
//     Book book1 = new Book();
//     book1.Title = "Kichkina Shaxzoda";
//     book1.Author = "Nodar Dumbadze";
//     book1.Page = 50;
//     book1.BookInfo();
//   }
// }



// ✅ 4-MASALA: Rectangle sinfi
// 🧾 Shart:

//     Rectangle nomli sinf yarating. Unda quyidagi private fieldlar bo‘lsin:

//         width (double) — to‘g‘ri burchakning eni.

//         height (double) — to‘g‘ri burchakning bo‘yi.

//     Har bir field uchun property yozing.
//     Area (yuza) va Perimeter (perimetr) metodlarini yaratib, ularni hisoblaydigan metodlar yozing:

//         Area: Yuzani hisoblash formulasi: width * height

//         Perimeter: Perimetrni hisoblash formulasi: 2 * (width + height)

//     Konsolda to‘g‘ri burchak yaratib, uning yuzasi va perimetrini hisoblang va ekranga chiqaring.


// class Rectangle
// {
//   private double width;
//   private double height;

//   public double Width
//   {
//     get { return width; }
//     set { width = value; }
//   }

//   public double Height
//   {
//     get { return height; }
//     set { height = value; }
//   }

//   public void Area()
//   {
//     Console.WriteLine($"Yuzasi: {width * height}");
//   }
//   public void Perimeter()
//   {
//     Console.WriteLine($"perimetri: {2 * (width + height)}");
//   }
// }

// class Program
// {
//   static void Main(string[] args)
//   {
//     Rectangle rect = new Rectangle();
//     rect.Width = 12.3;
//     rect.Height = 23;
//     rect.Perimeter();
//     rect.Area();
//   }
// }



// ✅ 5-MASALA: PasswordManager sinfi
// 🧾 Shart:

//     PasswordManager nomli sinf yarating. Unda quyidagi private field bo‘lsin:

//         password (string) — foydalanuvchining paroli.

//     Quyidagi metodlarni yaratish kerak:

//         ChangePassword(string newPassword): yangi parolni o‘rnatadi. Yangi parol minimal 8 ta belgidan iborat bo‘lishi kerak.

//         GetPassword(): hozirgi parolni qaytaradi, ammo faqat maxfiy holda ko‘rsatsin (xatolik bo‘lmasligi uchun).

//     Konsolda obyekt yaratib, parolni o‘zgartiring va yangi parolni konsolda chiqaring.


// class PasswordManager
// {
//   private string password;

//   public void ChangePassword(string newPassword)
//   {
//     if (newPassword.Length >= 8)
//     {
//       password = newPassword;
//     }
//     else
//     {
//       Console.WriteLine("Password uzunligi 8 dan baland bo'lishi kerak");
//     }
//   }
//   public void GetPassword()
//   {
//     Console.WriteLine($"Sizning Parolingiz: {password}");
//   }
// }

// class Program
// {
//   static void Main(string[] args)
//   {
//     PasswordManager password1 = new PasswordManager();
//     password1.ChangePassword("12345678");
//     password1.GetPassword();
//   }
// }



// ✅ 6-MASALA: Employee sinfi
// 🧾 Shart:

//     Employee nomli sinf yarating. Unda quyidagi private fieldlar bo‘lsin:

//         name (string) — xodimning ismi.

//         salary (double) — xodimning maoshi.

//         bonus (double) — xodimning bonusini hisoblash uchun metod bo‘lsin, bonusni maoshning 10 foizi sifatida hisoblang.

//     Quyidagi metodlarni yaratish kerak:

//         CalculateBonus() – bonusni hisoblash.

//         DisplayEmployeeInfo() – xodim haqidagi barcha ma'lumotlarni chiqarish.

//     Konsolda Employee obyektini yaratib, xodimning maoshi va bonusini chiqarib bering.



// class Employee
// {
//   private string name;
//   private double salary;
//   private double bonus;

//   public string Name
//   {
//     get { return name; }
//     set { name = value; }
//   }
//   public double Salary
//   {
//     get { return salary; }
//     set { salary = value; }
//   }

//   public void CalculateBonus()
//   {
//     bonus = salary * 0.1;
//     Console.WriteLine($"Sizning bonusingiz: {bonus}");
//   }

//   public void DisplayEmployeeInfo()
//   {
//     Console.WriteLine($"Sinzing ismingiz: {name}, maosh va bonus bilan birga: {bonus + salary}");
//   }
// }

// class Program
// {
//   static void Main(string[] args)
//   {
//     Employee employee = new Employee();
//     employee.Name = "Javohir";
//     employee.Salary = 10000;
//     employee.CalculateBonus();
//     employee.DisplayEmployeeInfo();
//   }
// }




// ✅ 7-MASALA: Student sinfi
// 🧾 Shart:

//     Student nomli sinf yarating. Unda quyidagi private fieldlar bo‘lsin:

//         name (string) — talabning ismi.

//         grades (int[]) — talabning baholari (masalan, 5 ta baho).

//     Quyidagi metodlarni yaratish kerak:

//         AddGrades(int[] grades) – talabning baholarini qo‘shadi.

//         CalculateAverage() – talabning o‘rtacha bahosini hisoblaydi.

//         DisplayStudentInfo() – talabning ismi va o‘rtacha bahosini chiqaradi.

//     Konsolda Student obyektini yaratib, baholarni qo‘shing va o‘rtacha bahoni chiqaring.


// class Student
// {
//   private string name;
//   private int[] grades;
//   public Student(string name, int[] grades)
//   {
//     this.name = name;
//     this.grades = grades;
//   }
//   public void AddGrades(int[] newGrades)
//   {
//     grades = newGrades;
//   }

//   public double CalculateAverage()
//   {
//     double total = 0;
//     foreach (int grade in grades)
//     {
//       total += grade;
//     }
//     return total / grades.Length;
//   }

//   public void DisplayStudentInfo()
//   {
//     Console.WriteLine($"Talabaning ismi: {name}, O'rtacha Baho: {CalculateAverage():F2}");
//   }
// }

// class Program
// {
//   static void Main(string[] args)
//   {
//     int[] grades = { 5, 4, 3, 5, 5 };
//     Student student1 = new Student("Javohir", grades);
//     student1.DisplayStudentInfo();
//     student1.AddGrades(grades);
//   }
// }


// ✅ Masala 8: Book sinfi (set/get)
// 🧾 Shart:

//     Book nomli sinf yarating. Sinfda quyidagi private fieldlar bo‘lsin:

//         title (string) — kitobning nomi.

//         author (string) — kitobning muallifi.

//     Sinfda Title va Author nomli public property’lar bo‘lsin. Har bir property uchun get va set metodlari ishlatilishi kerak:

//         Title — kitob nomini o‘zgartirish yoki olish uchun.

//         Author — kitob muallifini o‘zgartirish yoki olish uchun.

//     Konsolda kitob nomi va muallifini chiqarib, ularni yangilang va yana chiqarib ko‘rsating.

// class Book
// {
//   public string Title { get; set; }
//   public string Author { get; set; }

//   public void DisplayInfo()
//   {
//     Console.WriteLine($"Kitob sarlavhasi: {Title}, muallifi: {Author}");
//   }
// }

// class Program
// {
//   static void Main(string[] args)
//   {
//     Book book = new Book();
//     book.Author = "Nodar Dumbadze";
//     book.Title = "Kichkina Shaxzoda";
//     book.DisplayInfo();
//     book.Author = "Alisher Navoiy";
//     book.DisplayInfo();


//   }
// }


