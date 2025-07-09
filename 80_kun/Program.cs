// using System;
// using System.IO;


// class OddiyArxivlash
// {
//   static void Main()
//   {
//     string manba = "manba.txt";
//     string arxiv = "arxiv.bin";
//     string tiklangan = "tiklangan.txt";

//     Arxivla(manba, arxiv);
//     Och(arxiv, tiklangan);
//   }

//   static void Arxivla(string manba, string arxiv)
//   {
//     using (BinaryWriter writer = new BinaryWriter(File.Open(arxiv, FileMode.Create)))
//     {
//       string matn = File.ReadAllText(manba);

//       writer.Write(matn.Length);
//       writer.Write(matn);
//     }

//     Console.WriteLine("✅ Arxivlandi");
//   }

//   static void Och(string arxiv, string tiklangan)
//   {
//     using (BinaryReader reader = new BinaryReader(File.Open(arxiv, FileMode.Open)))
//     {
//       int uzunlik = reader.ReadInt32();
//       string matn = reader.ReadString();

//       File.WriteAllText(tiklangan, matn);
//     }

//     Console.WriteLine("✅ Fayl ochildi");
//   }
// }

// using System;
// using System.IO;
// using System.Xml.Serialization;

// public class Talaba
// {
//   public string Ismi { get; set; }
//   public int Yoshi { get; set; }
// }

// public class Program
// {
//   static void Main()
//   {
//     Talaba talaba = new Talaba
//     {
//       Ismi = "Javohir",
//       Yoshi = 19,
//     };

//     XmlSerializer serializer = new XmlSerializer(typeof(Talaba));
//     using (TextWriter writer = new StreamWriter("talabalar.xml"))
//     {
//       serializer.Serialize(writer, talaba);
//     }

//     XmlSerializer deserializer = new XmlSerializer(typeof(Talaba));
//     using (TextReader reader = new StreamReader("talabalar.xml"))
//     {
//       Talaba t = (Talaba)deserializer.Deserialize(reader);
//       Console.WriteLine($"{t.Ismi} : {t.Yoshi}");
//     }
//   }
// }

// using System;
// using System.IO;
// using System.Xml.Serialization;

// namespace SerializationExample
// {
//   public class Kitob
//   {
//     public string Nomi;
//     public string Muallifi;
//     public int SahifaSoni;

//     public Kitob() { }

//     public Kitob(string nomi, string muallifi, int sahifaSoni)
//     {
//       Nomi = nomi;
//       Muallifi = muallifi;
//       SahifaSoni = sahifaSoni;
//     }

//     public void ChopEt()
//     {
//       Console.WriteLine($"Kitob: {Nomi}, Muallifi: {Muallifi}, Sahifalar: {SahifaSoni}");
//     }
//   }

//   class Program
//   {
//     static void Main()
//     {
//       Kitob kitob = new Kitob("Alkimyogar", "Paulo Coelho", 200);

//       XmlSerializer serializer = new XmlSerializer(typeof(Kitob));
//       using (TextWriter writer = new StreamWriter("kitob.xml"))
//       {
//         serializer.Serialize(writer, kitob);
//         Console.WriteLine("✅ Serialize qilindi");
//       }

//       Kitob k;

//       XmlSerializer deserializer = new XmlSerializer(typeof(Kitob));
//       using (TextReader reader = new StreamReader("kitob.xml"))
//       {
//         k = (Kitob)deserializer.Deserialize
//         (reader);
//         Console.WriteLine("✅ Deserialize qilindi");
//         Console.WriteLine($"{k.Nomi}, {k.Muallifi}, {k.SahifaSoni}");
//       }
//     }
//   }
// }


using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

public class Talaba
{
  public string Ism { get; set; }
  public int Yoshi { get; set; }
}

class Program
{
  static void Main()
  {
    List<Talaba> talabaList = new List<Talaba>
    {
      new Talaba {Ism = "Ali", Yoshi = 20},
      new Talaba {Ism = "Vali", Yoshi = 21}
    };

    XmlSerializer serializer = new XmlSerializer(typeof(List<Talaba>));

    using (TextWriter writer = new StreamWriter("talabalar.xml"))
    {
      serializer.Serialize(writer, talabaList);
    }
    Console.WriteLine("Ro'yxat XML formatda saqlandi");


    XmlSerializer deserializer = new XmlSerializer(typeof(List<Talaba>));

    using (TextReader reader = new StreamReader("talabalar.xml"))
    {
      List<Talaba> talabalar = (List<Talaba>)deserializer.Deserialize(reader);
      foreach (var t in talabalar)
      {
        Console.WriteLine($"Ism: {t.Ism}, Yoshi: {t.Yoshi}");
      }
    }
  }
}
