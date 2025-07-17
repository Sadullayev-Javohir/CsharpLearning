// using System.Collections.Generic;

// interface IObserver
// {
//   public void Update(string news);
// }

// class NewsAgency
// {
//   private List<IObserver> observers = new List<IObserver>();

//   public void Subscribe(IObserver observer)
//   {
//     observers.Add(observer);
//   }

//   public void Publish(string news)
//   {
//     Console.WriteLine("Yangi yangilik: " + news);
//     foreach (var observer in observers)
//     {
//       observer.Update(news);
//     }
//   }
// }

// class Subscriber : IObserver
// {
//   private string name;

//   public Subscriber(string name)
//   {
//     this.name = name;
//   }

//   public void Update(string news)
//   {
//     Console.WriteLine($"{name} ga yangi xabar keldi: " + news);
//   }
// }


// class Program
// {
//   static void Main()
//   {
//     var agency = new NewsAgency();

//     var laylo = new Subscriber("Laylo");
//     var ali = new Subscriber("Ali");

//     agency.Subscribe(laylo);
//     agency.Subscribe(ali);

//     agency.Publish("Bugun havo judda issiq");
//     ali.Update("Hey leave me alone");
//   }
// }

using System;
using System.Collections.Generic;

public interface IObserver
{
  void Update(string message);
}

public interface ISubject
{
  void RegisterObserver(IObserver observer);
  void RemoveObserver(IObserver observer);
  void NotifyObservers();
}

public class NewsAgency : ISubject
{
  private List<IObserver> observers = new List<IObserver>();
  private string news;

  public void RegisterObserver(IObserver observer)
  {
    observers.Add(observer);
  }

  public void RemoveObserver(IObserver observer)
  {
    observers.Remove(observer);
  }

  public void NotifyObservers()
  {
    foreach (var observer in observers)
    {
      observer.Update(news);
    }
  }

  public void AddNews(string news)
  {
    this.news = news;
    NotifyObservers();
  }
}


public class NewsReader : IObserver
{
  public string Name { get; }

  public NewsReader(string name)
  {
    Name = name;
  }

  public void Update(string message)
  {
    Console.WriteLine($"{Name} received news: {message}");
  }
}

class Program
{
  static void Main()
  {
    NewsAgency agency = new NewsAgency();

    NewsReader reader1 = new NewsReader("Ali");
    NewsReader reader2 = new NewsReader("Vali");

    agency.RegisterObserver(reader1);
    agency.RegisterObserver(reader2);

    agency.AddNews("Bugun yomg'ir yog'adi");

    agency.RemoveObserver(reader1);

    agency.AddNews("Ertaga quyoshli havo bo'ladi");
  }
}


// public class NewsAgency
// {
//   public event Action<string> NewsPublished;

//   public void PublishNews(string news)
//   {
//     NewsPublished?.Invoke(news);
//   }
// }

// public class NewsReader
// {
//   public NewsReader(NewsAgency agency, string name)
//   {
//     agency.NewsPublished += (news) => Console.WriteLine($"{name} ga xabar keldi {news}");
//   }
// }

// class Program
// {
//   static void Main()
//   {
//     var agency = new NewsAgency();
//     var reading1 = new NewsReader(agency, "Ali");
//     var reading2 = new NewsReader(agency, "Vali");

//     agency.PublishNews("Bozor narxlari oshdi");
//   }
// }



// using System;
// using System.Threading.Tasks;

// class Program
// {
//   static async Task Main()
//   {
//     Console.WriteLine("Hisoblash boshlandi");
//     int natija = await MyAsyncMethod();
//     Console.WriteLine($"Natija: {natija}");
//     Console.WriteLine("Dastur tugadi");
//   }

//   public static async Task<int> MyAsyncMethod()
//   {
//     await Task.Delay(2000);
//     return 42;
//   }
// }

// using System.Threading;

// class Program
// {
//   static void MyMain()
//   {
//     Console.WriteLine("Oqim boshlandi");
//     Thread.Sleep(2000);
//     Console.WriteLine("Oqim tugadi");
//   }
//   static void Main()
//   {
//     Thread t = new Thread(MyMain);
//     t.Start();

//     t.Join();
//     Console.WriteLine("Join dan keyin chiqish");
//   }
// }


// using System.Threading;

// class Program
// {
//   static void MyMain()
//   {
//     Thread.Sleep(5000);
//   }

//   static void Main()
//   {
//     Thread t = new Thread(MyMain);
//     Console.WriteLine("Boshlanishda: " + t.IsAlive);
//     t.Start();
//     Console.WriteLine("Ishlaganda: " + t.IsAlive);
//     t.Join();
//     Console.WriteLine("Tugaganda: " + t.IsAlive);

//   }
// }


// using System;
// using System.Threading;

// class Program
// {
//   static void ShowThreadInfo()
//   {
//     Thread t = Thread.CurrentThread;
//     Console.WriteLine($"Joriy oqim ID: {t.ManagedThreadId}");
//     Console.WriteLine($"Is background: {t.IsBackground}");
//   }

//   static void Main()
//   {
//     Thread t = new Thread(ShowThreadInfo);
//     t.Start();

//     ShowThreadInfo(); // Main oqimda ham ko‘rsatamiz
//   }
// }

// using System.Threading.Tasks;
// class Program
// {
//   static void Main()
//   {
//     Task t1 = new Task(() => Console.WriteLine("Hello"));
//     t1.Start();
//     t1.Wait();
//   }
// }
