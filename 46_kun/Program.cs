// ✅ Misol 1: Enum bilan hafta kunlarini ishlatish

// enum HaftaKunlari
// {
//   Dushanba,
//   Seshanba,
//   Chorshanba,
//   Payshanba,
//   Juma,
//   Shanba,
//   Yakshanba
// }

// class Dastur
// {
//   static void Main()
//   {
//     HaftaKunlari bugun = HaftaKunlari.Juma;
//     Console.WriteLine(bugun == HaftaKunlari.Juma ? "Bugun Juma" : "Bugungi kunni bilmayman");
//   }
// }


// ✅ Misol 2: Struct bilan koordinatalarni ifodalash

// struct Nuqta
// {
//   public int X;
//   public int Y;

//   public Nuqta(int x, int y)
//   {
//     X = x;
//     Y = y;
//   }

//   public void ChopEt()
//   {
//     Console.WriteLine($"Nuqta: ({X}, {Y})");
//   }
// }

// class Dastur
// {
//   static void Main()
//   {
//     Nuqta A = new Nuqta(23, 64);
//     A.ChopEt();
//   }
// }


// 3-Misol

// using System;

// enum HaftaKunlari
// {
//   Dushanba,
//   Seshanba,
//   Chorshanba,
//   Payshanba,
//   Juma,
//   Shanba,
//   Yakshanba
// }

// class Dastur
// {
//   static void Main()
//   {
//     Console.Write("Son kiriting: (1-7)");
//     string input = Console.ReadLine();

//     if (int.TryParse(input, out int raqam))
//     {
//       if (raqam >= 0 && raqam <= 7)
//       {
//         HaftaKunlari tanlanganKun = (HaftaKunlari)raqam;
//         Console.WriteLine($"Tanlangan kun: {tanlanganKun}");
//       }
//     }
//     else
//     {
//       Console.WriteLine("Xato faqat raqam kiriting: ");
//     }
//   }
// }


// 4- Misol

struct koordinata
{
  public int X;
  public int Y;

  public koordinata(int x, int y)
  {
    X = x;
    Y = y;
  }
}

class Dastur
{
  static void Main()
  {
    Console.WriteLine("1-kordinata o'qini kiriting: ");
    Console.Write("x1 ni kiriting: ");
    int x1 = int.Parse(Console.ReadLine());
    Console.Write("x2 ni kiriting: ");
    int x2 = int.Parse(Console.ReadLine());

    Console.WriteLine("2-kordinata o'qini kiriting: ");
    Console.Write("y1 ni kiriting: ");
    int y1 = int.Parse(Console.ReadLine());
    Console.Write("y2 ni kiriting: ");
    int y2 = int.Parse(Console.ReadLine());

    koordinata nuqta1 = new koordinata(x1, y1);
    koordinata nuqta2 = new koordinata(x2, y2);

    Console.WriteLine(Math.Sqrt(Math.Pow(nuqta2.X - nuqta1.X, 2) + Math.Pow(nuqta2.Y - nuqta1.Y, 2)));

  }
}