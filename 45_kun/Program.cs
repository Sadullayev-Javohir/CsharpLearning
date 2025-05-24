using System;
using System.Collections.Generic;

// ✅ 1.Filter Adults

// Funksiya nomi: FilterAdults
// Vazifa: Berilgan List<Person> ichidan yoshi 18 yoki undan katta bo‘lganlarni ajrating.

// public class Person
// {
//   public int Age { get; set; }
// }

// class Yechim
// {
//   public static List<Person> Adults(List<Person> persons)
//   {
//     return persons.Where(p => p.Age > 18).ToList();
//   }
//   static void Main()
//   {


//     List<Person> persons = new List<Person>()
//     {
//       new Person {Age = 12},
//       new Person {Age = 23},
//       new Person {Age = 18},
//       new Person {Age = 19},
//       new Person {Age = 52},
//       new Person {Age = 11},
//       new Person {Age = 4}
//     };

//     var adults = Adults(persons);
//     foreach (var p in adults)
//     {
//       Console.WriteLine(p.Age);
//     }
//   }
// }


// ✅ 2.Top 3 Scores

// Funksiya nomi: GetTopScores
// Vazifa: Ballar ro‘yxatidan eng yuqori 3 tasini toping.

// public List<int> GetTopScores(List<int> scores)

// Input: [45, 100, 67, 89, 78, 92]
// Output: [100, 92, 89]

// class Yechim
// {
//   public static List<int> GetTopScores(List<int> scores)
//   {
//     return scores.OrderByDescending(s => s).Take(3).ToList();
//   }
//   static void Main()
//   {
//     List<int> scores = new List<int>() { 45, 100, 67, 89, 78, 92 };

//     List<int> getTop = GetTopScores(scores);
//     foreach (var i in getTop)
//     {
//       Console.WriteLine(i);
//     }
//   }
// }


// ✅ 3.Find Emails with .com

// Funksiya nomi: FindComEmails
// Vazifa: Email ro‘yxatidan .com domenidagi email'larni ajrating.

// public List<string> FindComEmails(List<string> emails)

// Input: ["a@gmail.com", "b@yahoo.uz", "c@mail.com"]
// Output: ["a@gmail.com", "c@mail.com"]

// class Yechim
// {
//   public static List<string> FindComEmails(List<string> emails)
//   {
//     return emails.Where(email => email.EndsWith(".com")).ToList();
//   }

//   static void Main()
//   {
//     List<string> emails = new List<string>() { "a@gmail.com", "b@yahoo.uz", "c@mail.com" };
//     List<string> emailsCom = FindComEmails(emails);
//     foreach (var email in emailsCom)
//     {
//       Console.WriteLine(email);
//     }
//   }
// }


// ✅ 4.Group Students By Age

// Funksiya nomi: GroupByAge
// Vazifa: Studentlar ro‘yxatini yoshi bo‘yicha guruhlang (LINQ GroupBy).

// public Dictionary<int, List<string>> GroupByAge(List<Person> people)

// Input:

// [
//     { Name = "Ali", Age = 18 },
//     { Name = "Vali", Age = 20 },
//     { Name = "Sami", Age = 18 }
// ]

// Output:

// {
//   18: ["Ali", "Sami"],
//     20: ["Vali"]
// }


// ✅ 4.Group Students By Age

// Funksiya nomi: GroupByAge
// Vazifa: Studentlar ro‘yxatini yoshi bo‘yicha guruhlang (LINQ GroupBy).

// public Dictionary<int, List<string>> GroupByAge(List<Person> people)

// Input:

// [
//     { Name = "Ali", Age = 18 },
//     { Name = "Vali", Age = 20 },
//     { Name = "Sami", Age = 18 }
// ]

// Output:

// {
//   18: ["Ali", "Sami"],
//     20: ["Vali"]
// }

// public class Student
// {
//   public string Name { get; set; }
//   public int Age { get; set; }

// }

// class Program
// {
//   public static IEnumerable<IGrouping<int, Student>> GroupByAge(List<Student> students)
//   {
//     return students.GroupBy(student => student.Age);
//   }

//   static void Main()
//   {
//     List<Student> students = new List<Student>()
//     {
//       new Student { Name = "Ali", Age = 18 },
//       new Student { Name = "Vali", Age = 20 },
//       new Student { Name = "Sami", Age = 18 }
//     };

//     var SortedAges = GroupByAge(students);
//     foreach (var s in SortedAges)
//     {
//       Console.WriteLine(s.Key);
//       foreach (var student in s)
//       {
//         Console.WriteLine($"{student.Name}, {student.Age}");
//       }
//     }
//   }
// }









