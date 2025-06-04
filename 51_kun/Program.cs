using System.Text.RegularExpressions;

class Program
{
  static void Main()
  {
    // string email = "a@a.c";
    // // Console.WriteLine(Regex.IsMatch(email, @"^[\w\.-]+@[\w\.-]+\.\w+$"));
    // Console.WriteLine(Regex.IsMatch(email, @"^[\w\.-]+@[\w\.-]+\.\w+$"));


    // string phone = "+998949421706";
    // Console.WriteLine(Regex.IsMatch(phone, @"\+998\d{9}$"));

    // string input = "Telefon: 99894-942-17-06";
    // MatchCollection numbers = Regex.Matches(input, @"\d+");

    // foreach (Match match in numbers)
    // {
    //   Console.WriteLine(match);
    // }


    // string dirty = "My number is 998949421706";
    // string clean = Regex.Replace(dirty, @"\d", "*");
    // Console.WriteLine(clean);

    // Regex regex = new Regex("hello", RegexOptions.IgnoreCase);
    // bool match = regex.IsMatch("HeLLo");
    // Console.WriteLine(match);

    // string input = "My name is Ali and I am 25 years old.";
    // Match match = Regex.Match(input, @"My name is (\w+) and I am (\d+) years old");
    // Console.WriteLine(match.Groups[1].Value);
    // Console.WriteLine(match.Groups[2].Value);

    // string text = "apple.banana;grape|cherry";
    // string[] parts = Regex.Split(text, @"[.;|]");
    // foreach (var part in parts)
    // {
    //   Console.WriteLine(part);
    // }


    // string text = "My email is someone@example.com";
    // string result = Regex.Replace(text, @"[\w\._]+@[\w\.-]+\.+\w+", "[hidden]");
    // Console.WriteLine(result);
  }
}

// public static class MyExtensions
// {
//   public static int WordCount(this string str)
//   {
//     return str.Split(' ').Length;
//   }

//   public static bool IsCapitalized(this string str)
//   {
//     if (string.IsNullOrEmpty(str))
//     {
//       return false;
//     }
//     return char.IsUpper(str[0]);
//   }

//   public static string ToCapitalize(this string str)
//   {
//     if (string.IsNullOrEmpty(str))
//     {
//       return str;
//     }
//     return char.ToUpper(str[0]) + str.Substring(1);
//   }

//   public static string ReverseString(this string str)
//   {
//     return new string(str.Reverse().ToArray());
//   }
// }

// class Program
// {
//   static void Main()
//   {
//     // string text = "Hey leave me alone";
//     // Console.WriteLine(text.WordCount());
//     string text1 = "saturn";
//     // Console.WriteLine(text1.IsCapitalized());
//     Console.WriteLine(text1.ToCapitalize());
//     Console.WriteLine(text1.ReverseString());
//   }
// }




// class Program
// {
//   static void bubbleSort(int[] arr, int n)
//   {
//     for (int i = 0; i < n - 1; i++)
//     {
//       for (int j = 0; j < n - i - 1; j++)
//       {
//         if (arr[j] > arr[j + 1])
//         {
//           // 5, 1
//           int temp = arr[j]; // 5
//           arr[j] = arr[j + 1]; // 1
//           arr[j + 1] = temp; // 5
//         }
//       }
//     }
//   }

//   static void printArray(int[] arr, int n)
//   {
//     for (int i = 0; i < n; i++)
//     {
//       Console.WriteLine(arr[i]);
//     }
//   }
//   static void Main()
//   {
//     int[] arr = { 23, 65, 2, 7, 1, 0 };
//     bubbleSort(arr, arr.Length);
//     printArray(arr, arr.Length);

//   }
// }

// class Program
// {
//   static void selectionSort(int[] arr, int n)
//   {
//     for (int i = 0; i < n - 1; i++)
//     {
//       int min = i;
//       for (int j = i + 1; j < n; j++)
//       {
//         if (arr[j] < arr[min])
//         {
//           min = j;
//         }
//       }

//       int temp = arr[min];
//       arr[min] = arr[i];
//       arr[i] = temp;
//     }
//   }

//   static void printArray(int[] arr, int n)
//   {
//     for (int i = 0; i < n; i++)
//     {
//       Console.WriteLine(arr[i]);
//     }
//   }

//   static void Main()
//   {
//     int[] nums = { 54, 6, 2, 7, 35, 76 };
//     int length = nums.Length;
//     selectionSort(nums, length);
//     printArray(nums, length);
//   }
// }


