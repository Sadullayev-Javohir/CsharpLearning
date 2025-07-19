using System.Threading.Tasks;

// class Program
// {
//   static Task task = new Task(() =>
//   {
//     Console.WriteLine("Task ishlayapti...");
//   });

//   static void Main()
//   {
//     task.Start();
//     task.Wait();
//   }
// }


// class Program
// {
//   static async Task Main()
//   {
//     Task task = Task.Run(() =>
//     {
//       Console.WriteLine("Task ishlayapti");
//     });
//     await task;
//   }
// }

// class Program
// {
//   static void Main()
//   {
//     Task task = Task.Factory.StartNew(() =>
//     {
//       Console.WriteLine("Task Factory ishga tushdi");
//     });
//     task.Wait();
//   }
// }

// class Program
// {
//   static Task<int> task = Task.Run(() =>
//   {
//     int sum = 0;
//     for (int i = 0; i <= 100; i++) sum += i;
//     return sum;
//   });

//   static async Task Main()
//   {
//     int result = task.Result;
//     Console.WriteLine($"Natija: {result}");
//   }
// }


// class Program
// {
//   static async Task Main()
//   {
//     await method();
//   }
//   static async Task method()
//   {
//     await Task.Run(() =>
//     {
//       Console.WriteLine("Ichki task ishlayapti");
//     });
//     Console.WriteLine("Task tugadi");
//   }
// }


// class Program
// {
//   static async Task Main()
//   {
//     Task t1 = Task.Run(() =>
//     {
//       Console.WriteLine("t1 ishlayapti");
//       Task.Delay(1000).Wait();
//     });

//     Task t2 = Task.Run(() =>
//     {
//       Console.WriteLine("t2 ishlayapti");
//       Task.Delay(1500).Wait();
//     });

//     await Task.WhenAll(t1, t2);
//     Console.WriteLine("Ikkala task ishga tushdi");
//   }
// }

// class Program
// {


//   static async Task Main()
//   {
//     Task t1 = Task.Delay(2000);
//     Task t2 = Task.Delay(1000);

//     Task first = await Task.WhenAny(t1, t2);
//     Console.WriteLine("Birinchi tugagan task");
//   }
// }

// class Program
// {
//   static async Task Main()
//   {
//     Task<int> t1 = Task.Run(async () => { await Task.Delay(2000); return 1; });

//     Task<int> t2 = Task.Run(async () => { await Task.Delay(1500); return 2; });

//     Task<int> firstFinished = await Task.WhenAny(t1, t2);
//     int result = await firstFinished;

//     Console.WriteLine($"Birinchi tugagan task natijasi: {result}");
//   }
// }

// class Program
// {
//   static async Task Main()
//   {
//     CancellationTokenSource cts = new CancellationTokenSource();
//     Task task = Task.Run(() =>
//     {
//       for (int i = 0; i < 100; i++)
//       {
//         if (cts.Token.IsCancellationRequested)
//         {
//           Console.WriteLine("Bekor qilindi");
//           return;
//         }
//         Console.WriteLine(i);
//         Thread.Sleep(100);
//       }
//     }, cts.Token);
//     Thread.Sleep(2100);
//     cts.Cancel();

//     await task;
//   }
// }


// class Program
// {
//   static async Task Main()
//   {
//     Task t1 = Task.Run(() =>
//     {
//       Console.WriteLine("Birinchi task");
//     });

//     Task t2 = t1.ContinueWith((prevTask) =>
//     {
//       Console.WriteLine("Ikkinchi task");
//     });
//     t1.Wait();
//   }
// }


// class Program
// {
//   static void Main()
//   {
//     Task<int> task1 = Task.Run(() => Sum(1, 100000));
//     Task<int> task2 = Task.Run(() => Sum(1000001, 20000000));
//     Task<int> task3 = Task.Run(() => Sum(2000001, 30000000));

//     Task.WaitAll(task1, task2, task3);

//     int total = task1.Result + task2.Result + task3.Result;
//     Console.WriteLine($"Umumiy yig'indi: {total}");
//   }

//   static int Sum(int from, int to)
//   {
//     int sum = 0;
//     for (int i = from; i <= to; i++)
//     {
//       sum += i;
//     }
//     return sum;
//   }
// }


// class Program
// {
//   static async Task Main(string[] args)
//   {
//     Task myTask = SampleTask();

//     if (myTask.IsCompleted)
//     {
//       Console.WriteLine("Task tugadi");
//     }
//     else
//     {
//       Console.WriteLine("Task hali tugamagan");
//     }

//     Console.WriteLine("Task bajarilmoqda");

//     await myTask;


//   }
//   static async Task SampleTask()
//   {
//     await Task.Delay(2000);
//     Console.WriteLine("Task ichidagi vazifa bajarildi");
//   }
// }


// class Program
// {
//   static async Task Main()
//   {
//     Task myTask = null;

//     try
//     {
//       myTask = FaultyTask();
//       await myTask;
//     }
//     catch (Exception ex)
//     {
//       Console.WriteLine($"Exception ushlandi: {ex.Message}");
//     }

//     if (myTask != null && myTask.IsFaulted)
//     {
//       Console.WriteLine("Taskda xatolik yuz berdi");
//     }
//     else
//     {
//       Console.WriteLine("Task xatoliksiz tugadi");
//     }
//   }

//   static async Task FaultyTask()
//   {
//     await Task.Delay(1000);
//     throw new InvalidOperationException("Bu test uchun chiqarilgan xatolik");
//   }
// }


class Program
{
  static async Task Main()
  {
    Task myTask = null;

    try
    {
      myTask = FaultyTask();
      await myTask;
    }
    catch
    {
      if (myTask != null && myTask.IsFaulted)
      {
        Console.WriteLine("Taskda xatoliklar mavjud: ");

        foreach (var ex in myTask.Exception.InnerExceptions)
        {
          Console.WriteLine($"Xatolik {ex.Message}");
        }
      }
    }
    static async Task FaultyTask()
    {
      await Task.Delay(1000);
      throw new InvalidOperationException("Noto'g'ri amal bajarildi");
    }
  }
}
