// using System;
// using System.Net.Http;
// using System.Threading.Tasks;
// using System.Text.Json;
// using System.Text.Json.Serialization;

// public class Post
// {
//   public int userId { get; set; }
//   public int Id { get; set; }
//   public string Title { get; set; }
//   public string body { get; set; }
// }

// public class Api
// {
//   private static readonly HttpClient client = new HttpClient();

//   public static async Task RunAsync()
//   {
//     try
//     {
//       string url = "https://jsonplaceholder.typicode.com/posts/1";
//       HttpResponseMessage response = await client.GetAsync(url);

//       string responseBody = await response.Content.ReadAsStringAsync();

//       Console.WriteLine(responseBody);
//     }
//     catch (Exception ex)
//     {
//       Console.WriteLine("Xatolik " + ex.Message);
//     }
//   }
// }


// using System;

// public record Person(string FirstName, string LastName);

// class Program
// {
//   static void Main()
//   {
//     var person = new Person("Ali", "Valiyev");
//     Console.WriteLine(person);
//   }
// }


// public class PersonClass
// {
//   public string FirstName { get; set;
//   }
//   public string LastName { get; set; }
// }

// public record PersonRecord(string FirstName, string LastName);

// class Program
// {
//   static void Main()
//   {
//     var c1 = new PersonClass { FirstName = "Ali", LastName = "Valiyev" };
//     var c2 = new PersonClass { FirstName = "Ali", LastName = "Valiyev" };

//     Console.WriteLine(c1 == c2);

//     var r1 = new PersonRecord("Ali", "Valiyev");
//     var r2 = new PersonRecord("Ali", "Valiyev");

//     Console.WriteLine(r1 == r2);
//   }
// }



// public record Product
// {
//   public string Name { get; init; }
//   public decimal Price { get; init; }
// }

// class Program
// {
//   static void Main()
//   {
//     var product = new Product { Name = "Smartphone", Price = 1342.24m };

//     Console.WriteLine(product);
//   }
// }

public record Product(string Name, decimal Price);

class Program
{
  static void Main()
  {
    var p1 = new Product("TV", 1200m);
    var p2 = new Product("TV", 1200m);

    Console.WriteLine(p1 == p2);
    Console.WriteLine(p1.Equals(p2));
    var p3 = p1 with { Price = 1100m };

    Console.WriteLine(p1);
    Console.WriteLine(p2);
  }
}

// public record Person(string FirstName, string LastName);

// class Program
// {
//   static void Main()
//   {
//     var person = new Person("Ali", "Valiyev");

//     var (first, last) = person;

//     Console.WriteLine("Ism: " + first);
//     Console.WriteLine("Familya: " + last);
//   }
// }


// public record Book
// {
//   public string Title { get; init; }
//   public string Author { get; set; }
// }

// class Program
// {
//   static void Main()
//   {
//     var book = new Book { Title = "C#", Author = "Anders Hejlsberg" };
//     Console.WriteLine(book);
//   }
// }

// public record Animal(string name);
// public record Dog(string name, string breed) : Animal(name);

// class Program
// {
//   static void Main()
//   {
//     var dog = new Dog("Rex", "German Shepherd");
//     Console.WriteLine(dog);
//     Console.WriteLine(dog.name);
//   }
// }

// public readonly record struct Point(int X, int Y);

// class Program
// {
//   static void Main()
//   {
//     var p1 = new Point(3, 4);
//     var p2 = new Point(3, 4);

//     Console.WriteLine(p1 == p2);
//     Console.WriteLine(p1);
//   }
// }


// public record City(string Name, int Population);
// public record City
// {
//   public string Name { get; init; }
//   public int Population { get; init; }
// }

// class Program
// {
//   static void Main()
//   {
//     var city = new City { Name = "Toshkent", Population = 250000 };
//     Console.WriteLine(city);
//   }
// }

// public record Order(int Id, string Item, decimal Price);

// class Program
// {
//   static void Main()
//   {
//     var order1 = new Order(1, "Monitor", 250.00m);
//     var order2 = order1 with { Price = 2230.9m };

//     Console.WriteLine(order1);
//     Console.WriteLine(order2);
//   }
// }

// class Program
// {
//   static void Main()
//   {
//     // var person = ("Ali", "Valiyev");
//     // Console.WriteLine(person.Item1);
//     // Console.WriteLine(person.Item2);


//     // var person = (FirstName: "Ali", LastName: "Vali");
//     // Console.WriteLine(person.FirstName);
//     // Console.WriteLine(person.LastName);

//     (string name, int age) GetPersonInfo()
//     {
//       return ("Ali", 25);
//     }

//     var (name, age) = GetPersonInfo();
//     Console.WriteLine($"Ism: {name}, Yosh: {age}");
//   }
// }


// class Program
// {
//   static void Main()
//   {
//     // object obj = "Salom";
//     // if (obj is string s)
//     // {
//     //   Console.WriteLine($"Bu satr: {s}");
//     // }

//     // string GetStatus(int score) => score switch
//     // {
//     //   < 50 => "Yomon",
//     //   >= 50 and < 75 => "O'rtacha",
//     //   >= 75 => "A'lo",
//     //   _ => "Noma'lum"
//     // };
//     // string GetStatus(int score) => score switch
//     // {
//     //   <= 50 => "Yomon",
//     //   >= 50 and < 75 => "O‘rtacha",
//     //   <= 75 => "A’lo",
//     //   _ => "Noma’lum"
//     // };

//     // Console.WriteLine(GetStatus(154));

//     object value = 24;

//     string result = value switch
//     {
//       int i when i > 0 => "Musbat son",
//       int i => "Manfiy yoki nol",
//       string s => $"Bu satr: {s}",
//       _ => "Noma'lum"
//     };
//     Console.WriteLine(result);
//   }
// }
// class Program
// {
//   static void Main()
//   {
//     int? age = null;

//     if (age != null)
//     {
//       Console.WriteLine("Yosh: " + age);
//     }
//     else
//     {
//       Console.WriteLine("Yosh ko'rsatilmagan");
//     }
//   }
// }
