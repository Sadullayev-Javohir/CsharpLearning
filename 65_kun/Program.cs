// class Program
// {
//   static void Main()
//   {
//     int yosh = -5;
//     if (yosh < 0)
//     {
//       throw new ArgumentOutOfRangeException("Yosh manfiy bo'lishi mumkin emas");
//     }
//   }
// }


// class Program
// {
//   static void Main()
//   {
//     try
//     {
//       int a = 10;
//       int b = 0;
//       int c = a / b;
//       Console.WriteLine(c);
//     }
//     catch (Exception ex)
//     {
//       // Console.WriteLine("Xatolik ushlanib qayta otildi" + ex.Message);
//       throw;
//     }
//   }
// }


// class Program
// {
//   static void Main()
//   {
//     try
//     {
//       CheckAge(15);
//     }
//     catch (Exception ex)
//     {
//       Console.WriteLine("Xatolik" + ex.Message);
//     }
//   }

//   static void CheckAge(int age)
//   {
//     if (age < 18)
//     {
//       throw new Exception("Son 18 yoshdan kichik bo'lmasligi kerak");
//     }
//   }
// }



// class Program
// {
//   static void Main()
//   {
//     try
//     {
//       int a = 10;
//       int b = 0;
//       int c = a / b;
//     }
//     catch (Exception ex)
//     {
//       throw new Exception("0 ga bo'lish mumkin emas");
//     }
//   }
// }


// class Quti<T>
// {
//   public T Variable;

//   public void Add(T Value)
//   {
//     Variable = Value;
//   }

//   public T GetVar()
//   {
//     return Variable;
//   }
// }

// class Program
// {
//   static void Main()
//   {
//     Quti<int> son = new Quti<int>();
//     son.Add(15);
//     Console.WriteLine(son.GetVar());
//   }
// }


public class Asbob
{
  public void Chiqish<T>(T value)
  {
    Console.WriteLine(value);
  }
}

class Program
{
  static void Main()
  {
    Asbob a = new Asbob();
    a.Chiqish<int>(5);
    a.Chiqish<bool>(false);
    a.Chiqish<object>("Hello");
  }
}
