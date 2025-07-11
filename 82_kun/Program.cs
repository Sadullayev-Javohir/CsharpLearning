// class Program
// {
//   static void SayHello()
//   {
//     Console.WriteLine("Hello World");
//   }
//   static void PrintName(string name)
//   {
//     Console.WriteLine("Name: " + name);
//   }
//   static void Add(int a, int b)
//   {
//     Console.WriteLine("Add " + (a + b));
//   }
//   static void Main()
//   {
//     Action action1 = SayHello;
//     Action<string> action2 = PrintName;
//     Action<int, int> action3 = Add;

//     action1();
//     action2("Javohir");
//     action3(3, 6);
//   }
// }


// public class Program
// {
//   static int GetRandomNumber()
//   {
//     return new Random().Next(1, 100);
//   }

//   static int Square(int x)
//   {
//     return x * x;
//   }

//   static int Multiply(int a, int b)
//   {
//     return a * b;
//   }

//   static void Main()
//   {
//     Func<int> func1 = GetRandomNumber;
//     Func<int, int> func2 = Square;
//     Func<int, int, int> func3 = Multiply;

//     Console.WriteLine(func1());
//     Console.WriteLine(func2(5));
//     Console.WriteLine(func3(5, 5));
//   }
// }


// class Program
// {
//   static void ProcessData(int x, Action<int> callback)
//   {
//     Console.WriteLine("Malumot ishlanmoqda");
//     callback(x);
//   }

//   static void PrintDouble(int x)
//   {
//     Console.WriteLine("Natija: " + (x * 2));
//   }

//   static void Main()
//   {
//     ProcessData(5, PrintDouble);
//   }
// }


// class Program
// {
//   static int Calculate(int a, int b, Func<int, int, int> operation)
//   {
//     return operation(a, b);
//   }

//   static int Add(int a, int b) => a + b;
//   static int Subtract(int a, int b) => a - b;

//   static void Main()
//   {
//     Console.WriteLine(Calculate(14, 16, Add));
//     Console.WriteLine(Calculate(14, 16, Subtract));
//   }
// }

// class Program
// {
//   static void Main()
//   {
//     Action<string> sayHi = name => Console.WriteLine("Salom " + name);
//     sayHi("Javohir");

//     Func<int, int, int> divide = (a, b) => a / b;
//     Console.WriteLine(divide(10, 2));
//   }
// }


// class Program
// {
//   static void Menu(Action option1, Action option2)
//   {
//     Console.WriteLine("1. SayHello");
//     Console.WriteLine("2. SayBye");
//     Console.WriteLine("Tanlang: ");
//     string choice = Console.ReadLine();

//     if (choice == "1") option1();
//     if (choice == "2") option2();
//   }

//   static void SayHello()
//   {
//     Console.WriteLine("Hello");
//   }
//   static void SayBye()
//   {
//     Console.WriteLine("Bye");
//   }

//   static void Main()
//   {
//     Menu(SayHello, SayBye);
//   }
// }


// class Program
// {
//   static void Run(Action<int> callback)
//   {
//     callback(5);
//   }

//   static void Main()
//   {
//     Run(x => Console.WriteLine(x * x));
//   }
// }



// class Program
// {
//   static void SayHello()
//   {
//     Console.WriteLine("Hello");
//   }

//   static void Greet(string name)
//   {
//     Console.WriteLine("Hello " + name);
//   }

//   static void AddNumbers(int a, int b)
//   {
//     Console.WriteLine("a + b = " + (a + b));
//   }

//   static void Main()
//   {
//     Action action1 = SayHello;
//     Action<string> action2 = Greet;
//     Action<int, int> action3 = AddNumbers;

//     action1();
//     action2("Javohir");
//     action3(24, 6);
//   }
// }


// class Program
// {
//   static void Main()
//   {
//     Console.WriteLine("Son kiriting: ");
//     int son = int.Parse(Console.ReadLine());

//     Func<int, int> square = x => x * x;
//     Console.WriteLine(square(son));
//   }
// }


// public class Program
// {
//   static void Main()
//   {
//     Console.Write("Birinchi son: ");
//     int a = Convert.ToInt32(Console.ReadLine());

//     Console.Write("Ikkinchi son: ");
//     int b = Convert.ToInt32(Console.ReadLine());

//     Console.Write("Amal tanlang (+, -, *, /): ");
//     string op = Console.ReadLine();

//     Func<int, int, int> operation;

//     switch (op)
//     {
//       case "+": operation = (x, y) => x + y; break;
//       case "-": operation = (x, y) => x - y; break;
//       case "*": operation = (x, y) => x * y; break;
//       case "/": operation = (x, y) => y != 0 ? x / y : 0; break;
//       default:
//         Console.WriteLine("Noto‘g‘ri amal tanlandi.");
//         return; // Dasturdan chiqamiz
//     }

//     int result = operation(a, b);
//     Console.WriteLine(result);
//   }
// }


// class Program
// {
//   static void Main()
//   {
//     Process(15, PrintResult);
//   }
//     static void Process(int number, Action<int> callback)
//     {
//       int result = number * 2;
//       callback(result);
//     }

//     static void PrintResult(int x)
//     {
//       Console.WriteLine("natija: " + x);
//     }
// }


// class Program
// {
//   static void Main()
//   {
//     Console.Write("Ismingizni kiriting: ");
//     string name = Console.ReadLine();

//     Func<string, bool> isLong = s => s.Length > 5;

//     if (isLong(name))
//       Console.WriteLine("Uzun ism");
//     else
//       Console.WriteLine("Qisqa ism");
//   }
// }


// class MyPublisher
// {
//   public event EventHandler birorVoqea;
//   public void TriggerEvent()
//   {
//     Console.WriteLine("Hodisa chaqirildi");
//     birorVoqea?.Invoke(this, EventArgs.Empty);
//   }

// }
// class MySubscriber
// {
//   public void Respond(object sender, EventArgs e)
//   {
//     Console.WriteLine("Hodisaga javob beradi");
//   }
// }

// class Program
// {
//   static void Main()
//   {
//     var publisher = new MyPublisher();
//     var subscriber = new MySubscriber();

//     publisher.birorVoqea += subscriber.Respond;

//     publisher.TriggerEvent();
//   }
// }


// class DoorBell
// {
//   public event EventHandler BellRang;

//   public void PressButton()
//   {
//     Console.WriteLine("Qo'ng'iroq bosildi");
//     BellRang?.Invoke(this, EventArgs.Empty);
//   }
// }

// class HouseOwner
// {
//   public void AnswerDoor(object sender, EventArgs e)
//   {
//     Console.WriteLine("Uy egasi: Kim keldi?");
//   }
// }


// class Program
// {
//   static void Main()
//   {
//     var doorBell = new DoorBell();
//     var owner = new HouseOwner();

//     doorBell.BellRang += owner.AnswerDoor;

//     doorBell.PressButton();
//   }
// }

// delegate void MyCustomDelegate(string message);

// class Button
// {
//   public event MyCustomDelegate Click;

//   public void SimulateClick()
//   {
//     Console.WriteLine("Bosildi");
//     Click?.Invoke("button clicked");
//   }
// }

// class Listener
// {
//   public void OnClick(string msg)
//   {
//     Console.WriteLine("Listener: " + msg);
//   }
// }


// class Program
// {
//   static void Main()
//   {
//     var button = new Button();
//     var listener = new Listener();

//     button.Click += listener.OnClick;
//     button.SimulateClick();
//   }
// }



// class Sensor
// {
//   public event EventHandler Danger;

//   public void Detect()
//   {
//     Console.WriteLine("Sensor: Harakat aniqlanmoqda");
//     Danger?.Invoke(this, EventArgs.Empty);
//   }
// }


// class Alarm
// {
//   public void OnDanger(object sender, EventArgs e)
//   {
//     Console.WriteLine("Alarm: Xavf aniqlandi");
//   }
// }


// class Program
// {
//   static void Main()
//   {
//     Sensor sensor = new Sensor();
//     Alarm alarm = new Alarm();

//     sensor.Danger += alarm.OnDanger;
//     sensor.Detect();
//   }
// }


// class MyEventArgs : EventArgs
// {
//   public string Message { get; set; }
// }

// class Broadcaster

// {
//   public event EventHandler<MyEventArgs> BroadCast;

//   public void Send()
//   {
//     Console.WriteLine("Xabar yuborilmoqda");
//     BroadCast?.Invoke(this, new MyEventArgs { Message = "Yangi Xabar" });
//   }
// }

// class Receiver
// {
//   public void Receive(object sender, MyEventArgs e)
//   {
//     Console.WriteLine("Qabul qilindi: " + e.Message);
//   }
// }


// class Program
// {
//   static void Main()
//   {
//     Broadcaster broadcaster = new Broadcaster();
//     Receiver receiver = new Receiver();

//     broadcaster.BroadCast += receiver.Receive;

//     broadcaster.Send();
//   }
// }


// class MyPublisher
// {
//   public event EventHandler Something;

//   public void RaiseEvent()
//   {
//     Something?.Invoke(this, EventArgs.Empty);
//   }
// }


// class MySubscriber
// {
//   public void Respond(object sender, EventArgs e)
//   {
//     Console.WriteLine("Hodisa yuz berdi");
//   }
// }


// class Program
// {
//   static void Main()
//   {
//     var publisher = new MyPublisher();
//     var subscriber = new MySubscriber();

//     publisher.Something += subscriber.Respond;
//     publisher.RaiseEvent();
//   }
// }


class Alarm
{
  public event EventHandler AlarmTriggered;

  public void Trigger()
  {
    AlarmTriggered?.Invoke(this, EventArgs.Empty);
  }
}
class Police
{
  public void Respond(object sender, EventArgs e)
  {
    Console.WriteLine("Politsiya Tez yordamga chiqamiz: ");
  }
}

class FireDepartment
{
  public void Respond(object sender, EventArgs e)
  {
    Console.WriteLine("O't o'chiruvchi: Suv tayyor");
  }
}
class Program
{
  static void Main()
  {
    var alarm = new Alarm();
    var police = new Police();
    var fire = new FireDepartment();

    alarm.AlarmTriggered += police.Respond;
    alarm.AlarmTriggered += fire.Respond;

    alarm.Trigger();
  }
}


