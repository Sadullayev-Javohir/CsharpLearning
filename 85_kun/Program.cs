// using System;
// using System.Net.Http;
// using System.Threading.Tasks;

// class Program
// {
//   static async Task Main()
//   {
//     Console.WriteLine("Ma'lumot yuklanmoqda");
//     try
//     {
//       using HttpClient client = new();
//       string data = await client.GetStringAsync("https://example.com");
//       Console.WriteLine("Yuklangan ma'lumot");
//       Console.WriteLine(data.Length);
//     }
//     catch (Exception ex)
//     {
//       Console.WriteLine(ex.Message);
//     }
//   }
// }


// using System;
// using System.Threading.Tasks;

// class Program
// {
//   public delegate Task AsyncEventHandler();

//   public static event AsyncEventHandler Happened;

//   static async Task Main(string[] args)
//   {
//     Happened += async () =>
//     {
//       Console.WriteLine("Dastur boshlnadi");
//       await Task.Delay(3000);
//       Console.WriteLine("Dastur 3 soniya kutildi");
//     };

//     Console.WriteLine("Enter bosilsa chiqariladi");
//     Console.ReadLine();

//     if (Happened != null)
//     {
//       await Happened.Invoke();
//     }
//     Console.WriteLine("Dastur tugadi");
//   }
// }


// class Program
// {
//   public static async Task MyTask()
//   {
//     Console.WriteLine("Ishga tushayapti async");
//     await Task.Delay(2000);
//     Console.WriteLine("2 soniya kutildi");
//   }
//   static async Task Main()
//   {
//     Console.WriteLine("MyTask method calling");
//     await MyTask();
//     Console.WriteLine("Dastur tugadi");
//   }
// }


// using System;
// using System.Threading.Tasks;

// class Program
// {
//   static async Task Main()
//   {
//     Console.WriteLine("First step");
//     await MyAsyncMethod();
//     Console.WriteLine("Third step");
//   }

//   static async Task MyAsyncMethod()
//   {
//     Console.WriteLine("Second step (kutish boshlandi)");
//     await Task.Delay(3000);
//     Console.WriteLine("Kutish tugadi");
//   }
// }


// using System;
// using System.Threading;

// class Program
// {
//   static void Main()
//   {
//     Console.WriteLine("Sinxron kutish boshlanmoqda...");
//     DelayWithSleep(); // Bu yerda thread butunlay band bo‘ladi
//     Console.WriteLine("Sinxron kutish tugadi.");
//   }

//   static void DelayWithSleep()
//   {
//     Console.WriteLine("Thread.Sleep(3000) ishga tushdi.");
//     Thread.Sleep(3000); // 3 soniya threadni bloklaydi
//     Console.WriteLine("Thread.Sleep tugadi (3 soniya o‘tdi).");
//   }
// }


// using System;
// using System.Threading.Tasks;

// class Program
// {
//   static async Task Main()
//   {
//     Console.WriteLine("Asinxron kutish boshlanmoqda...");
//     await DelayWithTask(); // Boshqa ishlar davom ettirishi mumkin
//     Console.WriteLine("Asinxron kutish tugadi.");
//   }

//   static async Task DelayWithTask()
//   {
//     Console.WriteLine("Task.Delay(3000) ishga tushdi.");
//     await Task.Delay(3000); // 3 soniya kutadi, lekin thread band emas
//     Console.WriteLine("Task.Delay tugadi (3 soniya o‘tdi).");
//   }
// }


// using System;
// using System.Threading.Tasks;

// class Program
// {
//   static async Task<int> GetNumberAsync()
//   {
//     await Task.Delay(1000);
//     return 42;
//   }

//   static async Task Main(string[] args)
//   {
//     int result = await GetNumberAsync();

//     Console.WriteLine("Olingan son: " + result);
//     Console.WriteLine("Dastur tugadi");
//     Console.ReadLine();
//   }
// }


// class Program
// {
//   static async Task SomeMethod()
//   {
//     Console.WriteLine("1");
//     await Task.Delay(2000);
//     Console.WriteLine("2");
//   }

//   static async Task Main()
//   {
//     await SomeMethod();
//   }
// }

// using System;
// using System.Threading.Tasks;
class Dastur
{
  public delegate Task MyEventHandler(object sender, EventArgs args);

  public static event MyEventHandler MyEvent;

  static async Task Main(string[] args)
  {
    MyEvent += async (sender, eventArgs) =>
    {
      Console.WriteLine("Hodisa boshlandi, 3 soniya kuting.");
      await Task.Delay(3000);
      Console.WriteLine("Asinxron ish bajarildi");
    };

    Console.WriteLine("Enter tugmasini bosing");
    Console.ReadLine();

    if (MyEvent != null)
    {
      await MyEvent.Invoke(null, EventArgs.Empty);
    }

    Console.WriteLine("Dastur tugadi");
    Console.ReadLine();
  }
}


// using System.Threading.Tasks;

// class Program
// {
//   public event Func<Task> OnSomethingAsync;

//   public async Task TriggerEventAsync()
//   {
//     if (OnSomethingAsync != null)
//     {
//       Delegate[] handlers = OnSomethingAsync.GetInvocationList();

//       foreach (Func<Task> handler in handlers)
//       {
//         await handler();
//       }
//     }
//   }

//   static async Task Main(string[] args)
//   {
//     Program program = new Program();

//     program.OnSomethingAsync += async () =>
//     {
//       Console.WriteLine("Hodisa boshlandi, 3 soniya kuting");
//       await Task.Delay(3000);
//       Console.WriteLine("Asinxron handler ishni tugatdi");
//     };

//     Console.WriteLine("Dastur tugadi.");
//     Console.ReadLine();

//     await program.TriggerEventAsync();

//     Console.WriteLine("Dastur tugadi. ");
//     Console.ReadLine();
//   }
// }

// class FileUploader
// {
//   public event Func<Task> OnFileUploaded;

//   public async Task UploadFileAsync()
//   {
//     Console.WriteLine("Fayl yuklanmoqda...");
//     await Task.Delay(1000);
//     Console.WriteLine("Fayl yuklandi");

//     if (OnFileUploaded != null)
//     {
//       Delegate[] handlers = OnFileUploaded.GetInvocationList();
//       foreach (Func<Task> handler in handlers)
//       {
//         await handler();
//       }
//     }
//   }
// }

// class Program
// {
//   static async Task Main()
//   {
//     FileUploader uploader = new FileUploader();

//     uploader.OnFileUploaded += async () =>
//     {
//       await Task.Delay(3000);
//       Console.WriteLine("Log yozildi./ Fayl yuklandi");
//     };

//     uploader.OnFileUploaded += async () =>
//     {
//       await Task.Delay(2000);
//       Console.WriteLine("Email yuborildi");
//     };

//     uploader.OnFileUploaded += async () =>
//     {
//       await Task.Delay(2000);
//     };

//     Console.WriteLine("Yuklashni boshlash uchun Enter bosing");
//     Console.ReadLine();

//     await uploader.UploadFileAsync();
//   }
// }


class Program
{
  public static event Func<Task> OnProcessAsync;

  static async Task Main()
  {
    OnProcessAsync += async () =>
    {
      Console.WriteLine("Jarayon boshlandi");
      await Task.Delay(2000);
      Console.WriteLine("Jarayon tugadi");
    };

    Console.WriteLine("Enter put");
    Console.ReadLine();

    if (OnProcessAsync != null)
    {
      await OnProcessAsync.Invoke();
    }
    Console.WriteLine("Dastur tugadi");
  }
}
