// delegate void MyDelegate(string msg);

// class Program
// {
//   static void Display(string msg)
//   {
//     Console.WriteLine("Xabar " + msg);

//   }

//   static void Main()
//   {
//     MyDelegate d = Display;
//     d("Hello, how are you");
//   }
// }


// class MyEventClass
// {
//   public delegate void Notify();
//   public event Notify OnNotify;

//   public void Trigger()
//   {
//     Console.WriteLine("Hodisa yuz berdi");
//     OnNotify.Invoke();
//   }
// }

// class Program
// {
//   static void Main()
//   {
//     MyEventClass obj = new MyEventClass();
//     obj.OnNotify += () => Console.WriteLine("Hodisa yuz berdi");

//     obj.Trigger();
//   }
// }


// public delegate void MyEventHandler(string msg);

// public class Publisher
// {
//   public event MyEventHandler MyEvent;

//   public void RaiseEvent(string msg)
//   {
//     if (MyEvent != null)
//     {
//       MyEvent(msg);
//     }
//   }
// }

// public class Subscriber
// {
//   public void Handler(string msg)
//   {
//     Console.WriteLine("text: " + msg);
//   }
// }

// class Program
// {
//   static void Main()

//   {
//     Publisher p = new Publisher();
//     Subscriber s = new Subscriber();

//     p.MyEvent += s.Handler;

//     p.RaiseEvent("Hey leave me alone");
//   }
// }


// public delegate void EventHandler(object sender, EventArgs e);

// class Publisher
// {
//   public event EventHandler MyEvent;

//   public void RaiseEvent()
//   {
//     Console.WriteLine("Publisher ishga tushirilmoqda");
//     MyEvent?.Invoke(this, EventArgs.Empty);
//   }
// }

// class Subscriber
// {
//   public void Handler(object sender, EventArgs e)
//   {
//     Console.WriteLine("Event qabul qilindi");
//   }
// }

// class Program
// {
//   static void Main()
//   {
//     Publisher p = new Publisher();
//     Subscriber s = new Subscriber();

//     p.MyEvent += s.Handler;
//     p.RaiseEvent();
//   }
// }

// public class MyEventArgs : EventArgs
// {
//   public string Info { get; set; }
// }

// public class Publisher
// {
//   public event EventHandler<MyEventArgs> MyEvent;

//   public void RaiseEvent()
//   {
//     Console.WriteLine("Ish bajarilmoqda...");

//     MyEvent?.Invoke(this, new MyEventArgs { Info = "Tugadi" });
//   }
// }


// public class Subscriber
// {
//   public void Handler(object sender, MyEventArgs e)
//   {
//     Console.WriteLine("Voqea qabul qilindi. Ma'lumot: " + e.Info);
//   }
// }


// class Program
// {
//   static void Main()
//   {
//     Publisher p = new Publisher();
//     var s = new Subscriber();

//     p.MyEvent += s.Handler;

//     p.RaiseEvent();
//   }
// }


// public delegate void MyDelegate(string msg);

// class Program
// {
//   static void Main()
//   {
//     MyDelegate del = delegate (string msg)
//     {
//       Console.WriteLine("anonim " + msg);
//     };

//     MyDelegate lambda = (msg) => Console.WriteLine("lambda: " + msg);
//     del("Hey");
//     lambda("Yeah");
//   }
// }


public delegate void MyMultiDelegate(string text);

public class Operations
{
  public void PrintA(string s) => Console.WriteLine("A: " + s);
  public void PrintB(string s) => Console.WriteLine("B: " + s);
}

class Dastur
{
  static void Main()
  {
    Operations op = new Operations();

    MyMultiDelegate d = op.PrintA;
    d += op.PrintB;

    d("Multicast ishladi");
  }
}

class Program
{
  public delegate int ProcessDelegate(int x);

  public static List<int> ProcessList(List<int> numbers, ProcessDelegate process)
  {
    var result = new List<int>();
    foreach (var i in numbers)
    {
      result.Add(process(i));
    }
    return result;
  }
  public static int Square(int x) => x * 2;

  static void Main()
  {
    var nums = new List<int>() { 1, 2, 3, 4, 5 };
    var squared = ProcessList(nums, Square);
    Console.WriteLine(string.Join(", ", squared));
  }
}


