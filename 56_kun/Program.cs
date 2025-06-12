// class Person
// {
//   string name;

//   public Person setName(string name)
//   {
//     this.name = name;
//     return this;
//   }

//   public void Greet()
//   {
//     Console.WriteLine("Hello " + name);
//   }
// }

// class Program
// {
//   static void Main()
//   {
//     Person p1 = new Person();
//     p1.setName("Javohir").Greet();
//   }
// }


// class Person
// {
//   string name;
//   int age;

//   public Person(string name)
//   {
//     this.name = name;
//     Console.WriteLine("Name constructor: " + name);
//   }

//   public Person(string name, int age) : this(name)
//   {
//     Console.WriteLine("Age constructor: " + age);
//   }
// }

// class Program
// {
//   static void Main()
//   {
//     Person p1 = new Person("Javohir", 23);
//   }
// }


// class Animal
// {
//   public Animal(string type)
//   {
//     Console.WriteLine($"Hayvon turi : {type}");
//   }
// }

// class Dog : Animal
// {
//   public Dog(string type, string name) : base(type)
//   {
//     Console.WriteLine($"Kuchukning nomi : {name}");
//   }
// }

// class Program
// {
//   static void Main()
//   {
//     Dog dog1 = new Dog("Obcherka", "Rex");
//   }
// }


// class Transport
// {
//   public void Move()
//   {
//     Console.WriteLine("Transport is moving");
//   }
// }

// class LandTransport : Transport
// {
//   public void Drive()
//   {
//     Console.WriteLine("Driving on land");
//   }
// }

// class Car : LandTransport
// {
//   public void Honk()
//   {
//     Console.WriteLine("Car is honking");
//   }
// }

// class Program
// {
//   static void Main()
//   {
//     Car myCar = new Car();
//     myCar.Honk();
//     myCar.Drive();
//     myCar.Move();
//   }
// }



// Transport (asosiy class)
// ├── LandTransport
// │   └── Car
// │   └── Bike
// ├── WaterTransport
// │   └── Boat
// │   └── Ship
// ├── AirTransport
//     └── Airplane
//     └── Helicopter


// class Transport
// {
//   public string Name;
//   public int Speed;
//   public int Capacity;

//   public void Move()
//   {
//     Console.WriteLine($"{Name} is moving");
//   }

//   public void ShowInfo()
//   {
//     Console.WriteLine($"Mashina nomi: {Name}, tezligi: {Speed}, odamlar soni : {Capacity}");
//   }
// }

// class LandTransport : Transport
// {
//   public int WheelCount;
//   public bool HasEngine;

//   public void Drive()
//   {
//     Console.WriteLine($"{Name} is driving.\n{Name} {WheelCount} ta balon bor. Va motor: {HasEngine}");
//   }
// }

// class Car : LandTransport
// {
//   public string FuelType;
//   public bool IsAutomatic;

//   public void Honk()
//   {
//     Console.WriteLine($"{Name} mashina signal chaldi");
//   }

//   public void Info()
//   {
//     Console.WriteLine($"Yoqilg'i turi : {FuelType} va Avtomatikmi : {IsAutomatic}");
//   }
// }

// class Program
// {
//   static void Main()
//   {
//     Car car1 = new Car();
//     car1.Name = "Nexia";
//     car1.Move();
//   }
// }





// class Transport
// {
//   public Transport(string name)
//   {
//     Console.WriteLine($"Transport {name} created");
//   }
// }

// class Car : Transport
// {
//   public Car() : base("Cobalt")
//   {
//     Console.WriteLine($"Car created");
//   }
// }

// class Program
// {
//   static void Main()
//   {
//     Car car1 = new Car();
//   }
// }



// class Car
// {
//   public string Brand;
//   public int Year;

//   public Car(string brand, int year)
//   {
//     Brand = brand;
//     Year = year;
//     Console.WriteLine($"Car created: {Brand}, {Year}");
//   }

//   public Car(string brand) : this(brand, 2024)
//   {
//     Console.WriteLine("Deafult year 2024 set");
//   }

//   public Car() : this("Unknown", 2023)
//   {
//     Console.WriteLine("Default car created");
//   }
// }

// class Program
// {
//   static void Main()
//   {
//     // Car car1 = new Car("Toyota", 2022);
//     // Car car2 = new Car("BMW");
//     Car car3 = new Car();
//   }
// }

// class Book
// {
//   public string Title;
//   public string Author;
// }

// class Program
// {
//   static void Main()
//   {
//     Book book1 = new Book();
//     book1.Title = "Sariq devni minib";
//     book1.Author = "X.Tukhtaboyev";
//   }
// }


class Animal
{
  protected string type = "Mammal";
}

class Dog : Animal
{
  public void ShowType()
  {
    Console.WriteLine("Dog is a " + type);
  }
}

class Program
{
  static void Main()
  {
    Dog dog1 = new Dog();
    dog1.ShowType();
  }
}
