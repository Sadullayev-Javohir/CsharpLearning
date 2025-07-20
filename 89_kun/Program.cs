// using System;
// using System.Threading.Tasks;

// class Program
// {
//   static async Task Hey()
//   {
//     Console.WriteLine("Hey leave me alone");
//     await Task.Delay(2000);
//   }

//   static async Task Main()
//   {
//     await Hey();
//   }
// }

// using System;
// using System.Threading.Tasks;

// class Program
// {
//   static async Task Main()
//   {
//     Console.WriteLine("1. Ish boshlandi");
//     await Do();
//     Console.WriteLine("3.Tugadi");
//   }
//   static async Task Do()
//   {
//     Console.WriteLine("2.Vazifa bajarilmoqda");
//     await Task.Delay(3000);
//     Console.WriteLine("2. Vazifa tugadi");
//   }
// }



// class Program
// {
//   static async Task Main()
//   {
//     // Thread thread = new Thread(() =>
//     // {
//     //   Console.WriteLine("Thread da ish bajarildi");
//     // });
//     // thread.Start();

//     await Task.Run(() =>
//     {
//       Console.WriteLine("Tak ishladi");
//     });
//   }
// }


// using System;
// using System.Net.Http;
// using System.Threading.Tasks;

// class Program
// {
//   static async Task Main()
//   {
//     await Gett();
//   }
//   static async Task Gett()
//   {
//     using HttpClient client = new HttpClient();
//     HttpResponseMessage response = await client.GetAsync("https://jsonplaceholder.typicode.com/posts/1");

//     if (response.IsSuccessStatusCode)
//     {
//       string json = await response.Content.ReadAsStringAsync();
//       Console.WriteLine(json);
//     }
//   }
// }

using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

// class Program
// {
//   static async Task Postt()
//   {
//     using HttpClient client = new HttpClient();

//     var data = new
//     {
//       title = "bpp",
//       body = "bar",
//       userId = 1
//     };

//     var json = System.Text.Json.JsonSerializer.Serialize(data);
//     var content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");

//     HttpResponseMessage response = await client.PostAsync("https://jsonplaceholder.typicode.com/posts", content);

//     string result = await response.Content.ReadAsStringAsync();

//     Console.WriteLine(result);
//   }
//   static async Task Main()
//   {
//     await Postt();
//   }
// }


// class Program
// {
//   static async Task Main()
//   {
//     await Deletee();
//   }

//   static async Task Deletee()
//   {
//     using HttpClient client = new HttpClient();

//     HttpResponseMessage response = await client.DeleteAsync("https://jsonplaceholder.typicode.com/posts/1");

//     Console.WriteLine(response.StatusCode);


//   }
// }


class Program
{
  static async Task Main()
  {
    await Patch();
  }
  static async Task Patch()
  {
    using HttpClient client = new HttpClient();

    var patchData = new
    {
      email = "ali123@gmail.com",
    };

    var json = System.Text.Json.JsonSerializer.Serialize(patchData);
    var content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");

    var request = new HttpRequestMessage(new HttpMethod("PATCH"), "https://jsonplaceholder.typicode.com/posts/1")
    {
      Content = content
    };
    try
    {
      HttpResponseMessage response = await client.SendAsync(request);
      response.EnsureSuccessStatusCode();
      string result = await response.Content.ReadAsStringAsync();
      Console.WriteLine(result);
    }
    catch (Exception ex)
    {
      Console.WriteLine("Xatolik " + ex);
    }
  }
}
