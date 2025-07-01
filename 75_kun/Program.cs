using System;
using System.Xml.Linq;

// class Program
// {
//   static void Main()
//   {
//     XElement talaba = new XElement("student",
//       new XElement("talaba",
//       new XElement("Ism", "Javohir"),
//       new XElement("Yosh", 15),
//       new XElement("Manzil", "Toshkent")
//       ),
//       new XElement("talaba",
//       new XElement("Ism", "Javohir"),
//       new XElement("Yosh", 15),
//       new XElement("Manzil", "Toshkent")
//       )
//     );

//     talaba.Save("talab.xml");
//     Console.WriteLine("Saqlandi");
//   }
// }


// class Program
// {
//   static void Main()
//   {
//     XElement talaba = XElement.Load("talab.xml");

//     string ism = talaba.Element("Ism").Value;
//     string yosh = talaba.Element("Yosh").Value;
//     string manzil = talaba.Element("Manzil").Value;

//     Console.WriteLine($"{ism} {yosh} {manzil}");
//   }
// }


// class Program
// {
//   static void Main()
//   {
//     XElement config = new XElement("Konfiguratsiya",
//       new XElement("Sozlama",
//         new XAttribute("nomi", "Til"),
//         "O'zbekcha"
//       ),
//       new XElement("Sozlama",
//         new XAttribute("nomi", "Tema"),
//         "Qorong'i"
//       ),
//       new XElement("Sozlama",
//         new XAttribute("nomi", "AvtoSaqlash"),
//         true
//       )
//     );
//     config.Save("config.xml");
//     Console.WriteLine("Saqlandi");
//   }

// }


// class Program
// {
//   static void Main()
//   {
//     XElement config = XElement.Load("config.xml");

//     foreach (XElement item in config.Elements("Sozlama"))
//     {
//       string attr = item.Attribute("nomi").Value;
//       string value = item.Value;

//       Console.WriteLine($"{attr} : {value}");
//     }
//   }
// }


// class Program
// {
//   static void Main()
//   {
//     XElement config = XElement.Load("config.xml");

//     foreach (XElement sozlama in config.Elements("Sozlama"))
//     {
//       if (sozlama.Attribute("nomi").Value == "Tema" && sozlama.Value == "Qorong'i")
//       {
//         sozlama.Value = "Yorug'";
//       }
//     }

//     config.Save("config.xml");
//     Console.WriteLine("Saqlandi");
//   }
// }


// class Program
// {
//   static void Main()
//   {
//     XElement students = new XElement("Talabalar",
//       new XElement("Talaba",
//         new XAttribute("ID", "1"),
//         new XElement("Ism", "Ali"),
//         new XElement("Familya", "Karimov"),
//         new XElement("Kurs", 1),
//         new XElement("Reyting", 87)
//       ),
//       new XElement("Talaba",
//         new XAttribute("ID", "2"),
//         new XElement("Ism", "Dilnoza"),
//         new XElement("Familya", "Saidova"),
//         new XElement("Kurs", 2),
//         new XElement("Reyting", 93)
//       ),
//       new XElement("Talaba",
//         new XAttribute("ID", "3"),
//         new XElement("Ism", "Diyor"),
//         new XElement("Familya", "Ergashev"),
//         new XElement("Kurs", 1),
//         new XElement("Reyting", 76)
//       )
//     );

//     students.Save("students.xml");
//   }
// }


class Program
{
  static void Main()
  {
    XElement config = XElement.Load("students.xml");

    foreach (var item in config.Elements("Talaba"))
    {
      string id = item.Attribute("ID").Value;
      string ism = item.Element("Ism").Value;
      string familya = item.Element("Familya").Value;
      string kurs = item.Element("Kurs").Value;
      string reyting = item.Element("Reyting").Value;

      Console.WriteLine($"id: {id}, ism: {ism}, familya: {familya}, kurs: {kurs}, reyting: {reyting}\n");
    }
  }
}


// class Program
// {
//   static void Main()
//   {
//     XElement config = XElement.Load("students.xml");

//     var yuqoriReyting = config.Elements("Talaba").Where(t => int.Parse(t.Element("Reyting").Value) > 85);

//     foreach (var i in yuqoriReyting)
//     {
//       Console.WriteLine($"{i.Element("Ism").Value} {i.Element("Familya").Value}");
//     }
//   }
// }


// class Program
// {
//   static void Main()
//   {
//     XElement config = XElement.Load("students.xml");

//     var birinchiKurs = config.Elements("Talaba").Where(t => t.Element("Kurs").Value == "1");

//     foreach (var i in birinchiKurs)
//     {
//       Console.WriteLine($"{i.Element("Ism").Value}, {i.Element("Kurs").Value}");
//     }
//   }
// }


class Dastur
{
  static void Main()
  {
    XElement config = XElement.Load("students.xml");

    var removeitem = config.Elements("Talaba").Where(t => int.Parse(t.Element("Reyting").Value) < 80);

    foreach (var i in removeitem)
    {
      i.Remove();
      Console.WriteLine("O'chirildi");
    }

    config.Save("students.xml");
    Console.WriteLine("Saqlandi");
  }
}
