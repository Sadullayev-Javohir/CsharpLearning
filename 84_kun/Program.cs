// public interface IKuzatuvchi
// {
//   public void Yangilash(float harorat);
// }

// public interface IObyekt
// {
//   void KuzatuvchiniQoshish(IKuzatuvchi kuzatuvchi);
//   void KuzatuvchiniOchirish(IKuzatuvchi kuzatuvchi);
//   void BarchagaXabarYuborish();
// }

// public class ObhavoStansiyasi : IObyekt
// {
//   private List<IKuzatuvchi> kuzatuvchilar = new List<IKuzatuvchi>();
//   private float joriyHarorat;

//   public void KuzatuvchiniQoshish(IKuzatuvchi kuzatuvchi)
//   {
//     kuzatuvchilar.Add(kuzatuvchi);
//   }

//   public void KuzatuvchiniOchirish(IKuzatuvchi kuzatuvchi)
//   {
//     kuzatuvchilar.Remove(kuzatuvchi);
//   }

//   public void BarchagaXabarYuborish()
//   {
//     foreach (var kuzatuvchi in kuzatuvchilar)
//     {
//       kuzatuvchi.Yangilash(joriyHarorat);
//     }
//   }

//   public void HaroratniOzgartirish(float yangiHarorat)
//   {
//     Console.WriteLine($"[Stansiya] Harorat yangilandi: {yangiHarorat}°C");
//     joriyHarorat = yangiHarorat;
//     BarchagaXabarYuborish();
//   }
// }


// public class TelefonEkrani : IKuzatuvchi
// {
//   private string QurilmaNomi;

//   public TelefonEkrani(string nomi)
//   {
//     QurilmaNomi = nomi;
//   }

//   public void Yangilash(float harorat)
//   {
//     Console.WriteLine($"{QurilmaNomi} qurilmasi: Yangi harorat - {harorat}°C");
//   }
// }

// class program
// {
//   static void Main()
//   {
//     ObhavoStansiyasi stansiya = new ObhavoStansiyasi();

//     TelefonEkrani telefon1 = new TelefonEkrani("Samsung");
//     IKuzatuvchi telefon2 = new TelefonEkrani("IPhone");

//     stansiya.KuzatuvchiniQoshish(telefon1);
//     stansiya.KuzatuvchiniQoshish(telefon2);

//     stansiya.HaroratniOzgartirish(45.2f);
//   }
// }

// public interface IDocument
// {
//   void Print();
// }

// public class WordHujjat : IDocument
// {
//   public void Print()
//   {
//     Console.WriteLine("Word chop etilmoqda");
//   }
// }

// public class Printer
// {
//   public void ChopEt(IDocument hujjat)
//   {
//     hujjat.Print();
//   }
// }

// class Program
// {
//   static void Main()
//   {
//     Printer printer = new Printer();
//     IDocument word = new WordHujjat();

//     printer.ChopEt(word);
//   }
// }

public interface IListKuzatuvchi
{
  void ListOzgarganda(string xabar);
}


public class ObservableList<T>
{
  private List<T> elementlar = new List<T>();
  private List<IListKuzatuvchi> kuzatuvchilar = new List<IListKuzatuvchi>();

  public void ElementQoshish(T element)
  {
    elementlar.Add(element);
    KuzatuvchilargaXabar($"Element qo'shildi: {element}");
  }

  public void ElementOchirish(T element)
  {
    if (elementlar.Remove(element))
    {
      KuzatuvchilargaXabar($"element o'chirildi");
    }
    else
    {
      KuzatuvchilargaXabar($"element topilmadi");
    }
  }

  public void KuzatuvchiQoshish(IListKuzatuvchi kuzatuvchi)
  {
    kuzatuvchilar.Add(kuzatuvchi);
  }

  public void KuzatuvchiOchirish(IListKuzatuvchi kuzatuvchi)
  {
    kuzatuvchilar.Remove(kuzatuvchi);
  }

  private void KuzatuvchilargaXabar(string xabar)
  {
    foreach (var kuzatuvchi in kuzatuvchilar)
    {
      kuzatuvchi.ListOzgarganda(xabar);
    }
  }
}

public class KonsolKuzatuvchi : IListKuzatuvchi
{
  private string nom;

  public KonsolKuzatuvchi(string nom)
  {
    this.nom = nom;
  }

  public void ListOzgarganda(string xabar)
  {
    Console.WriteLine($"{nom} - xabar: {xabar}");
  }
}

class Program
{
  static void Main()
  {
    var list = new ObservableList<string>();

    var kuzatuvchi1 = new KonsolKuzatuvchi("Kuzatuvchi1");
    var kuzatuvchi2 = new KonsolKuzatuvchi("Kuzatuvchi2");

    list.ElementQoshish("Olma");
    list.ElementQoshish("Behi");
    list.ElementQoshish("Gilos");
    list.ElementQoshish("Nok");

  }
}
