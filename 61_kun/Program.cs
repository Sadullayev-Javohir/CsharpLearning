// public class AgeTooLowException : Exception
// {
//   public AgeTooLowException(string message) : base(message){}
// }

// public class Program
// {
//   static void CheckAge(int age)
//   {
//     if (age < 18)
//     {
//       throw new AgeTooLowException("Yosh 18 dan kichik bo'lmasligi kerak.");
//     }
//     Console.WriteLine("Yosh to'g'ri");
//   }

//   static void Main()
//   {
//     try
//     {
//       CheckAge(15);
//     }
//     catch (AgeTooLowException ex)
//     {
//       Console.WriteLine($"Xatolik: {ex.Message}");
//     }
//   }
// }


// public class NotEnoughBalanceException : Exception
// {
//   public NotEnoughBalanceException(string message) : base(message) { }
// }

// public class BankAccount
// {
//   public int Balance { get; private set; } = 20000;

//   public void Withdraw(int amount)
//   {
//     if (amount > Balance)
//     {
//       throw new NotEnoughBalanceException("Pul yetarli emas");
//     }
//     Balance -= amount;
//     Console.WriteLine($"{amount} yechildi. Hozir sizda {Balance} pul qoldi");
//   }
// }

// class Program
// {
//   static void Main()
//   {
//     try
//     {
//       BankAccount b1 = new BankAccount();
//       b1.Withdraw(20001);
//     }
//     catch (NotEnoughBalanceException ex)
//     {
//       Console.WriteLine("Xatolik: " + ex.Message);
//     }
//     finally
//     {
//       Console.WriteLine("Tugadi");
//     }
//   }
// }


// public class AgeTooLowException : Exception
// {
//   public int UserId { get; }
//   public AgeTooLowException(string message, int UserId) : base(message)
//   {
//     this.UserId = UserId;
//   }
// }

// public class Program
// {
//   static void CheckAge(int age, int UserId)
//   {
//     if (age < 18)
//     {
//       throw new AgeTooLowException("Yosh 18 dan kichik", UserId);
//     }
//     Console.WriteLine("Yosh to'g'ri");
//   }

//   public static void Main()
//   {
//     try
//     {
//       CheckAge(16, 101);
//     }
//     catch (AgeTooLowException ex)
//     {
//       Console.WriteLine($"Xatolik: {ex.Message}");
//       Console.WriteLine($"Foydalanuvchi ID: {ex.UserId}");
//     }
//     finally
//     {
//       Console.WriteLine("Tugadi");
//     }
//   }
// }


// public class PasswordTooWeakException : Exception
// {
//   public int UserId;
//   public PasswordTooWeakException(string message, int UserId) : base(message)
//   {
//     this.UserId = UserId;
//   }
// }

// public class Program
// {
//   static void CheckPassword(string password, int UserId)
//   {
//     if (password.Length < 8)
//     {
//       throw new PasswordTooWeakException("Parol juda zaif. Kuchli parol o'rnating.", UserId);
//     }
//     Console.WriteLine("Parol kuchli va qabul qilindi");
//   }

//   public static void Main()
//   {
//     try
//     {
//       CheckPassword("12", 698636);
//     }
//     catch (PasswordTooWeakException ex)
//     {
//       Console.WriteLine("Xatolik " + ex.Message);
//       Console.WriteLine("Foydaluvchi ID " + ex.UserId);
//     }
//   }
// }


// public class ProductStockException : Exception
// {
//   public string productname { get; }
//   public int productid { get; }

//   public ProductStockException(string message, string productname, int productid) : base(message)
//   {
//     this.productname = productname;
//     this.productid = productid;
//   }
// }

// public class Program
// {
//   static void CheckStock(string ProductName, int ProductId, int stock)
//   {
//     if (stock <= 0)
//     {
//       throw new ProductStockException("Mahsulot mavjud emas.", ProductName, ProductId);
//     }
//     Console.WriteLine($"Mahsulot nomi: {ProductName}, ProductId: {ProductId}, Mahsulot {stock} ta qolgan");
//   }
//   static void Main()
//   {

//     try
//     {
//       CheckStock("Apple Iphone", 1001, -9);
//     }
//     catch (ProductStockException ex)
//     {
//       Console.WriteLine("Xatolik: " + ex.Message);
//       Console.WriteLine("Mahsulot nomi: " + ex.productname);
//       Console.WriteLine("Mahsulot ID: " + ex.productid);
//     }
//   }
// }



// using System;

// class Program
// {
//   static int Divide(int a, int b)
//   {
//     return a / b;
//   }

//   static void Main()
//   {
//     int x = 10;
//     int y = 0;
//     int result = Divide(x, y); // Bu yerda xatolik chiqadi
//     Console.WriteLine($"Natija: {result}");
//   }
// }


// class Program
// {
//   static void BubbleSort(int[] arr, int size)
//   {
//     for (int i = 0; i < size - 1; i++)
//     {
//       for (int j = 0; j < size - i - 1; j++)
//       {
//         if (arr[j] > arr[j + 1])
//         {
//           int temp = arr[j];
//           arr[j] = arr[j + 1];
//           arr[j + 1] = temp;
//         }
//       }
//     }
//   }

//   static void Main()
//   {
//     int[] arr = { 15, 16, 7, 8, 2, 23 };
//     BubbleSort(arr, arr.Length);
//     Console.WriteLine(string.Join(" ", arr));
//   }
// }


using System;
using System.Diagnostics;

class Program
{
  static void Main()
  {
    Trace.Listeners.Add(new ConsoleTraceListener());

    Trace.WriteLine("Dastur boshlandi");

    try
    {
      int a = 10;
      int b = 0;
      int result = a / b;
    }
    catch (Exception ex)
    {
      Trace.WriteLine($"Xatolik yuz berdi: {ex.Message}");
    }
    Trace.WriteLine("Dastur tugadi");
  }

}
