using System;
using System.Collections.Generic;

// public class Box<TYPE>
// {
//   public TYPE value { get; set; }
//   public void ShowValue()
//   {
//     Console.WriteLine("Value: " + value);
//   }
// }

// class Program
// {
//   static void Main()
//   {
//     Box<int> boxInt = new Box<int>();
//     boxInt.value = 15;
//     boxInt.ShowValue();
//   }
// }



// public class Utility
// {
//   public void Print<T>(T value)
//   {
//     Console.WriteLine("Value " + value);
//   }
// }

// public class Program
// {
//   static void Main()
//   {
//     Utility util = new Utility();
//     util.Print<int>(42);
//   }
// }


public class Storage<T>
{
  private List<T> items = new List<T>();

  public void Add(T item)
  {
    items.Add(item);
  }

  public List<T> GetAll()
  {
    return items;
  }
  public T GetAt(int index)
  {
    if (index >= 0 && index < items.Count)
    {
      return items[index];
    }
    throw new IndexOutOfRangeException("Index noto'g'ri");
  }
}


class Program
{
  static void Main()
  {
    Storage<string> stringStorage = new Storage<string>();
    stringStorage.Add("Apple");
    stringStorage.Add("Banana");

    foreach (var item in stringStorage.GetAll())
    {
      Console.WriteLine(item);
    }

    Console.WriteLine("0-indexdagi element: " + stringStorage.GetAt(0));

    Storage<int> intStorage = new Storage<int>();
    intStorage.Add(10);
    intStorage.Add(20);

    Console.WriteLine("1-indexdagi son: " + intStorage.GetAt(1));
  }
}
