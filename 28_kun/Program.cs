// 📌 MASALANING SHARTI:

// Hayvonlar ierarxiyasini yaratish. Quyidagi talablar asosida mini-loyiha tuzing:
// 🎯 Maqsad:

// Turli xil hayvonlar (masalan: it, mushuk, qush) umumiy xususiyatlarga ega. Barcha hayvonlar:

//     o‘zining nomiga ega bo‘ladi,

//     tovush chiqaradi (MakeSound() metodi),

//     va harakatlanadi (Move() metodi).

// Har bir hayvon o‘ziga xos usulda tovush chiqaradi va harakat qiladi.
// 🧠 OOP talablari:

//     Animal nomli abstract sinf yarating. Unda quyidagilar bo‘lsin:

//         Name (hayvon nomi) — property

//         MakeSound() — abstract metod

//         Move() — abstract metod

//         Info() — umumiy ma'lumot beruvchi metod

//     Dog, Cat, Bird sinflarini Animal sinfidan meros olish orqali yarating.

//         Har biri MakeSound() va Move() metodlarini o‘ziga xos qilib override qilsin.

//     Main() metodi orqali turli hayvonlarni saqlang va ularning metodlarini chaqiring.

// 🧩 Bu loyihada quyidagilar o‘rganiladi:

//     Inheritance (meros olish)

//     Polymorphism (polimorfizm)

//     Abstraction (abstraktsiya)

//     Encapsulation (inkapsulyatsiya)


// abstract Animal
// abstract class Animal
// {
//   public string Name { get; set; }
//   public Animal(string Name)
//   {
//     this.Name = Name;
//   }
//   public abstract void MakeSound();
//   public abstract void Move();

//   public void Info()
//   {
//     Console.WriteLine($"Animal name is {Name}");
//   }
// }


// class Dog : Animal
// {
//   public Dog(string Name) : base(Name) { }
//   public override void MakeSound()
//   {
//     Console.WriteLine($"{Name} is woofing");
//   }

//   public override void Move()
//   {
//     Console.WriteLine($"{Name} is running...");
//   }
// }

// class Cat : Animal
// {
//   public Cat(string Name) : base(Name) { }
//   public override void MakeSound()
//   {
//     Console.WriteLine($"{Name} is meowing");
//   }

//   public override void Move()
//   {
//     Console.WriteLine($"{Name} is walking...");
//   }
// }


// class Bird : Animal
// {
//   public Bird(string Name) : base(Name) { }

//   public override void MakeSound()
//   {
//     Console.WriteLine($"{Name} is singing");
//   }

//   public override void Move()
//   {
//     Console.WriteLine($"{Name} is flying...");
//   }
// }

// class Program
// {
//   static void Main()
//   {
//     Dog dog = new Dog("REX");
//     dog.Info();
//     dog.Move();
//     dog.MakeSound();

//     Console.WriteLine();

//     Cat cat = new Cat("Kiza");
//     cat.Info();
//     cat.Move();
//     cat.MakeSound();

//     Console.WriteLine();

//     Bird bird = new Bird("Kesha");
//     bird.Info();
//     bird.MakeSound();
//     bird.Move();
//   }
// }








// 📌 MASALANING SHARTI:

// Bank hisob tizimini yaratish. Quyidagi talablar asosida mini-loyiha tuzing:
// 🎯 Maqsad:

// Har bir mijoz o‘ziga xos bank hisobiga ega. Hisob quyidagi funksiyalarni bajaradi:

//     mijozning to‘liq ismi bo‘ladi (FullName),
//     hisob raqami mavjud bo‘ladi (AccountNumber),
//     balans saqlanadi (Balance),
//     hisob haqida umumiy ma’lumot beriladi (DisplayInfo()).

// Har bir hisob inkapsulatsiya qilingan ma’lumotlarga ega bo‘ladi.

// 🧠 OOP talablari:

//     AccountBase nomli abstract sinf yarating. Unda quyidagilar bo‘lsin:
//         - DisplayInfo() — abstract metod

//     Account sinfini AccountBase sinfidan meros oling:
//         - FullName, AccountNumber, Balance — xususiyatlar (private + getter/setter)
//         - DisplayInfo() metodini override qiling

//     PremiumAccount sinfini Account sinfidan meros oling:
//         - Qo‘shimcha: AccountType (string, masalan: "Premium")
//         - DisplayInfo() metodini override qilib kengaytiring

//     Main() metodida turli xil hisoblarni yarating va ularning metodlarini chaqiring.

// 🧩 Bu loyihada quyidagilar o‘rganiladi:

//     ✔️ Abstraction (AccountBase orqali)
//     ✔️ Inheritance (Account va PremiumAccount sinflari orqali)
//     ✔️ Polymorphism (DisplayInfo() metodining turlicha ishlashi orqali)
//     ✔️ Encapsulation (xususiy ma’lumotlarga faqat getter/setter orqali kirish)



// abstract class AccountBase
// {
//   public abstract void DisplayInfo();
// }

// class Account : AccountBase
// {
//   private string FullName { get; set; }
//   private int AccountNumber { get; set; }
//   private double Balance { get; set; }

//   public Account(string FullName, int AccountNumber, double Balance)
//   {
//     this.FullName = FullName;
//     this.AccountNumber = AccountNumber;
//     this.Balance = Balance;
//   }

//   public override void DisplayInfo()
//   {
//     Console.WriteLine($"User's name is {FullName}, AccountNumber is {AccountNumber}, Balance is {Balance}");
//   }

// }

// class PremiumAccount : Account
// {
//   private string AccountType = "Premium";
//   public PremiumAccount(string FullName, int AccountNumber, double Balance) : base(FullName, AccountNumber, Balance) { }
//   public override void DisplayInfo()
//   {
//     Console.WriteLine($"{AccountType}");
//   }
// }


// class Program2
// {
//   static void Main()
//   {
//     Account account = new Account("Javohir", 123456, 10234);
//     account.DisplayInfo();

//     PremiumAccount premiumAccount = new PremiumAccount("Javohir", 123456, 10234);
//     premiumAccount.DisplayInfo();
//   }
// }








// 🔷 Shart:

// "Transport" nomli umumiy sinf yarating. U umumiy xususiyatlar (speed, capacity) va metodga ega bo‘lsin. Undan "Car" va "Bike" degan voris sinflar yarating.

//     Har bir transportning maksimal tezligi (speed) o‘zgarmas bo‘lishi kerak (readonly, const farqlansin).

//     "Car" sinfi o‘zining signalini chalinishini (Honk()) aniqlasin va uni override qilsin.

//     "Bike" sinfi esa sealed bo‘lib, undan boshqa sinf meros ola olmasin.

//     static metod yordamida transportlar sonini hisoblab boradigan logika qo‘shilsin.

//     abstract metoddan foydalanilgan bo‘lsin (StartEngine()), va uni override qilish majburiy bo‘lsin.

//     this va base kalit so‘zlari orqali konstruktorlar ichida atributlarga murojaat qilinsin.

// namespace TransportExample
// {
//   public abstract class Transport
//   {
//     public const int MaxSpeedLimit = 300;
//     public readonly int speed;
//     protected int capacity;
//     private static int transportCount = 0;

//     public Transport(int speed, int capacity)
//     {
//       this.speed = speed;
//       this.capacity = capacity;
//       transportCount++;
//     }

//     public static int GetTransportCount()
//     {
//       return transportCount;
//     }

//     public virtual void Honk()
//     {
//       Console.WriteLine("Transport Honks...");
//     }

//     public abstract void StartEngine();
//   }

//   public class Car : Transport
//   {
//     public Car(int speed, int capacity) : base(speed, capacity) { }

//     public override void Honk()
//     {
//       Console.WriteLine("Car goes beep beep!");
//     }

//     public override void StartEngine()
//     {
//       Console.WriteLine("Car engine started with key.");
//     }
//   }

//   public sealed class Bike : Transport
//   {
//     public Bike(int speed, int capacity) : base(speed, capacity) { }

//     public override void Honk()
//     {
//       Console.WriteLine("Bike rings the bell!");
//     }

//     public override void StartEngine()
//     {
//       Console.WriteLine("Bike doesn't need engine start.");
//     }
//   }

//   class Program
//   {
//     static void Main(string[] args)
//     {
//       Car car = new Car(180, 5);
//       car.Honk();
//       car.StartEngine();

//       Bike bike = new Bike(40, 1);
//       bike.Honk();
//       bike.StartEngine();

//       Console.WriteLine($"Total transports created: {Transport.GetTransportCount()}");
//     }
//   }
// }

