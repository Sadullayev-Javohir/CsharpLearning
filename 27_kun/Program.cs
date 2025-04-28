// 1-Misol:

// Shart:
// Shape nomli abstract sinf yarating. Unda Area() degan abstract metod bo‘lsin. Rectangle va Circle klasslari Shape dan meros olib, o‘ziga xos Area() metodini to‘ldirsin.


// abstract class Shape
// {
//   public abstract double Area();
// }

// class Rectangle : Shape
// {
//   public double Width { get; set; }
//   public double Height { get; set; }
//   public Rectangle(double Width, double Height)
//   {
//     this.Width = Width;
//     this.Height = Height;
//   }
//   public override double Area()
//   {
//     return Width * Height;
//   }
// }

// class Circle : Shape
// {
//   public double Radius { get; set; }

//   public Circle(double Radius)
//   {
//     this.Radius = Radius;
//   }
//   public override double Area()
//   {
//     return Math.PI * Radius * Radius;
//   }
// }

// class Program
// {
//   static void Main()
//   {
//     Circle circle = new Circle(30.3);
//     Console.WriteLine(circle.Area());

//     Rectangle rectangle = new Rectangle(20.2, 10.3);
//     Console.WriteLine(rectangle.Area());
//   }
// }



// 2-Misol:

// Shart:
// IVehicle interfeysini yarating. Start() va Stop() metodlarini e'lon qiling. Car va Bike klasslari ushbu interfeysni implementatsiya qilsin.

// interface IVehicle
// {
//   void Start();
//   void Stop();
// }

// class Car : IVehicle
// {

//   public void Start()
//   {
//     Console.WriteLine("Car is starting...");
//   }
//   public void Stop()
//   {
//     Console.WriteLine("Car is stoping...");
//   }
// }

// class Bike : IVehicle
// {
//   public void Start()
//   {
//     Console.WriteLine("Bike is starting...");
//   }

//   public void Stop()
//   {
//     Console.WriteLine("Bike is stopping...");
//   }
// }

// class Program
// {
//   static void Main()
//   {
//     Car car = new Car();
//     car.Start();
//     car.Stop();

//     Bike bike = new Bike();
//     bike.Start();
//     bike.Stop();
//   }
// }


// 3-Misol:

// Shart:
// Animal abstract sinfini yarating. Unda MakeSound() abstract metodini e'lon qiling. Cow va Dog klasslari bu metodni o‘zida to‘ldirsin.

// abstract class Animal
// {
//   public abstract void MakeSound();
// }

// class Cow : Animal
// {
//   public override void MakeSound()
//   {
//     Console.WriteLine("Cow is mooo");
//   }
// }

// class Dog : Animal
// {
//   public override void MakeSound()
//   {
//     Console.WriteLine("Dog is barking...");
//   }
// }

// class Program
// {
//   static void Main()
//   {
//     Dog dog1 = new Dog();
//     Cow cow1 = new Cow();
//     dog1.MakeSound();
//     cow1.MakeSound();
//   }
// }




// 4-Misol:

// Shart:
// IDrawable interfeysini yarating. Draw() metodini e'lon qiling. Square va Circle klasslari interfeysni implementatsiya qilsin.

// interface IDrawable
// {
//   void Draw();
// }

// class Square : IDrawable
// {
//   public void Draw()
//   {
//     Console.WriteLine("Square is drawing...");
//   }
// }

// class Circle : IDrawable
// {
//   public void Draw()
//   {
//     Console.WriteLine("Circle is drawing...");
//   }
// }


// class Program
// {
//   static void Main()
//   {
//     Square square = new Square();
//     Circle circle = new Circle();
//     square.Draw();
//     circle.Draw();
//   }
// }




// 5-Misol:

// Shart:
// Appliance nomli abstract sinf yarating. Unda TurnOn() va TurnOff() metodlarini aniqlang. WashingMachine va Refrigerator klasslari ularni to‘ldirsin.

// abstract class Appliance
// {
//   public abstract void TurnOn();
//   public abstract void TurnOff();
// }

// class WashingMachine : Appliance
// {
//   public override void TurnOn()
//   {
//     Console.WriteLine("WashingMachine TurnOn");
//   }
//   public override void TurnOff()
//   {
//     Console.WriteLine("WashingMachine TurnOff");
//   }
// }


// class Refrigerator : Appliance
// {
//   public override void TurnOn()
//   {
//     Console.WriteLine("Refrigerator TurnOn");
//   }

//   public override void TurnOff()
//   {
//     Console.WriteLine("Refrigerator TurnOff");
//   }
// }


// class Program
// {
//   static void Main()
//   {
//     WashingMachine washingMachine = new WashingMachine();
//     Refrigerator refrigerator = new Refrigerator();
//     washingMachine.TurnOn();
//     refrigerator.TurnOff();
//   }
// }



// 6-Misol:

// Shart:
// IWorker interfeysini yarating. Work() metodini e'lon qiling. Engineer va Doctor klasslari ushbu interfeysni implementatsiya qilsin.


// interface Iworker
// {
//   void Work();
// }

// class Doctor : Iworker
// {
//   public void Work()
//   {
//     Console.WriteLine("His work is Doctor");
//   }
// }

// class Engineer : Iworker
// {
//   public void Work()
//   {
//     Console.WriteLine("His work is Engineer");
//   }
// }


// class Program
// {
//   static void Main()
//   {
//     Doctor doctor = new Doctor();
//     doctor.Work();
//     Engineer engineer = new Engineer();
//     engineer.Work();
//   }
// }



// 7-Misol:

// Shart:
// Vehicle abstract sinfini yarating va Move() abstract metodini yarating. Truck va Boat klasslari bu metodni to‘ldirsin.

// abstract class Vehicle
// {
//   public abstract void Move();
// }

// class Truck : Vehicle
// {
//   public override void Move()
//   {
//     Console.WriteLine("Truck is moving...");
//   }
// }

// class Boat : Vehicle
// {
//   public override void Move()
//   {
//     Console.WriteLine("Boat is moving...");
//   }
// }


// class Program
// {
//   static void Main()
//   {
//     Truck truck = new Truck();
//     Boat boat = new Boat();

//     truck.Move();
//     boat.Move();
//   }
// }



// 8-Misol:

// Shart:
// IPlayable interfeysini yarating. Play() metodini e'lon qiling. Guitar va Piano klasslari ushbu interfeysni implementatsiya qilsin.
// interface IPlayable
// {
//   void Play();
// }

// class Guitar : IPlayable
// {
//   public void Play()
//   {
//     Console.WriteLine("Guitar is playing...");
//   }
// }

// class Piano : IPlayable
// {
//   public void Play()
//   {
//     Console.WriteLine("Piano is playing...");
//   }
// }


// class Program
// {
//   static void Main()
//   {
//     Guitar guitar = new Guitar();
//     guitar.Play();

//     Piano piano = new Piano();
//     piano.Play();
//   }
// }



// 9-Misol:

// Shart:
// Employee abstract sinfini yarating va CalculateSalary() metodini e'lon qiling. Manager va Developer klasslari o‘z ish haqlarini hisoblab bersin.

// abstract class Employee
// {
//   public abstract double CalculateSalary();
// }

// class Manager : Employee
// {
//   public override double CalculateSalary()
//   {
//     return 6000;
//   }
// }

// class Developer : Employee
// {
//   public override double CalculateSalary()
//   {
//     return 8000;
//   }
// }


// class Program
// {
//   static void Main()
//   {
//     Manager manager = new Manager();
//     Console.WriteLine($"{manager.CalculateSalary()}");

//     Developer developer = new Developer();
//     Console.WriteLine($"{developer.CalculateSalary()}");
//   }
// }


// 10-Misol:

// Shart:
// IDriveable interfeysini yarating. Drive() metodini e'lon qiling. Truck va Motorbike klasslari interfeysni implementatsiya qilsin.

// interface IDriveable
// {
//   void Drive();
// }

// class Truck : IDriveable
// {
//   public void Drive()
//   {
//     Console.WriteLine("Truck is driving...");
//   }
// }

// class Motorbike : IDriveable
// {
//   public void Drive()
//   {
//     Console.WriteLine("Motorbike is driving...");
//   }
// }


// class Program
// {
//   static void Main()
//   {
//     Truck truck = new Truck();
//     Motorbike motorbike = new Motorbike();
//     truck.Drive();
//     motorbike.Drive();
//   }
// }



