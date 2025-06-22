// class Program
// {
//   public class Quti<T>
//   {
//     public T variable;
//     public void Add(T value)
//     {
//       variable = value;
//     }

//     public void Print()
//     {
//       Console.WriteLine(variable);
//     }
//   }
//   static void Main()
//   {
//     Quti<int> son = new Quti<int>();
//     son.variable = 24;
//     son.Print();
//   }
// }

// class Generic
// {
//   public void Method<T>(T variable)
//   {
//     Console.WriteLine(variable);
//   }
// }


// class Program
// {
//   static void Main()
//   {
//     Generic son = new Generic();
//     son.Method<object>(false);
//   }
// }


// class MyStack<T>
// {
//   private List<T> sonlar = new List<T>();

//   public void Push(T value)
//   {
//     sonlar.Add(value);
//   }

//   public T Pop()
//   {
//     if (sonlar.Count == 0)
//     {
//       throw new InvalidOperationException("Bo'sh List");
//     }
//     T item = sonlar[sonlar.Count - 1];
//     sonlar.RemoveAt(sonlar.Count - 1);
//     return item;
//   }

//   public int Count => sonlar.Count;
//   public bool isEmpty => sonlar.Count == 0;
// }

// class Program
// {
//   static void Main()
//   {
//     MyStack<int> sonlar = new MyStack<int>();
//     sonlar.Push(4);
//     sonlar.Push(2);
//     sonlar.Push(6);

//     Console.WriteLine(sonlar.Count);
//     try
//     {
//       sonlar.Pop();
//       sonlar.Pop();
//       sonlar.Pop();
//       sonlar.Pop();
//     }
//     catch (Exception ex)
//     {
//       Console.WriteLine("Xatolik " + ex.Message);
//     }
//   }
// }


// class Hisob<T> where T : struct
// {
//   public T qiymat;
//   public Hisob(T qiymat)
//   {
//     this.qiymat = qiymat;
//   }

//   public void ShowQiymat()
//   {
//     Console.WriteLine("Qiymat: " + qiymat);

//   }
//   public T GetQiymat()
//   {
//     return qiymat;
//   }
// }

// class Program
// {
//   static void Main()
//   {
//     Hisob<int> son = new Hisob<int>(100);
//     son.ShowQiymat();
//     Console.WriteLine(son.GetQiymat());

//   }
// }

// class Bazaviy
// {
//   public string Ism { get; set; }

//   public Bazaviy(string ism)
//   {
//     Ism = ism;
//   }
//   public void SalomDe()
//   {
//     Console.WriteLine($"Salom, men {Ism}");
//   }
// }

// class Talaba : Bazaviy
// {
//   public int Yoshi { get; set; }

//   public Talaba(string ism, int yoshi) : base(ism)
//   {
//     Yoshi = yoshi;
//   }

//   public void YoshiChiqar()
//   {
//     Console.WriteLine($"Yoshim: {Yoshi}");
//   }
// }


// class Hisob<T> where T : Bazaviy
// {
//   private T obj;

//   public Hisob(T obj)
//   {
//     this.obj = obj;
//   }

//   public void Malumotchiqar()
//   {
//     obj.SalomDe();
//   }
// }


// class Program
// {
//   static void Main()
//   {
//     Talaba talaba = new Talaba("Javohir", 19);
//     Hisob<Talaba> hisob = new Hisob<Talaba>(talaba);

//     hisob.Malumotchiqar();

//     Console.ReadLine();
//   }
// }



// interface IId<T>
// {
//   T GetId();
// }

// class Foydalanuvchi : IId<int>
// {
//   public int GetId() => 1;
// }

// class Mahsulot : IId<string>
// {
//   public string GetId() => "PP--023";
// }

// class Program
// {
//   static void Main()
//   {
//     IId<int> one = new Foydalanuvchi();
//     Console.WriteLine(one.GetId());

//     IId<string> two = new Mahsulot();
//     Console.WriteLine(two.GetId());
//   }

// }

// class Quti<T>
// {
//   public T qiymat;
//   public void SetQiymat(T qiymat)
//   {
//     this.qiymat = qiymat;
//   }

//   public T GetQiymat()
//   {
//     return qiymat;
//   }
// }

// class Program
// {
//   static void Main()
//   {
//     Quti<int> son = new Quti<int>();
//     son.SetQiymat(25);
//     Console.WriteLine(son.GetQiymat());


//     Quti<string> matn = new Quti<string>();
//     matn.SetQiymat("anxiety");
//     Console.WriteLine(matn.GetQiymat());

//     Quti<double> katta = new Quti<double>();
//     katta.SetQiymat(859825.252);
//     Console.WriteLine(katta.GetQiymat());
//   }
// }


// class Solishtirish<T>
// {
//   public T value1;
//   public T value2;

//   public Solishtirish(T value1, T value2)
//   {
//     this.value1 = value1;
//     this.value2 = value2;
//   }

//   public bool Tengmi()
//   {
//     return value1.Equals(value2);
//   }
// }


// class Program
// {
//   static void Main()
//   {
//     // Solishtirish<int> sonlar = new Solishtirish<int>(5, 5);
//     // Console.WriteLine(sonlar.Tengmi());

//     Solishtirish<string> matn = new Solishtirish<string>("hello", "hell");
//     Console.WriteLine(matn.Tengmi());
//   }
// }



// interface IId<T>
// {
//   T GetId();
// }

// class Foydalanuvchi : IId<int>
// {
//   public int GetId()
//   {
//     return 1;
//   }
// }

// class Mahsulot : IId<string>
// {
//   public string GetId()
//   {
//     return "124-faf";
//   }
// }

// class Program
// {
//   static void Main()
//   {
//     Foydalanuvchi f = new Foydalanuvchi();
//     Console.WriteLine(f.GetId());

//     Mahsulot m = new Mahsulot();
//     Console.WriteLine(m.GetId());
//   }
// }



// class Quti<T>
// {
//   public static int soni = 0;

//   public Quti()
//   {
//     soni++;
//   }
// }

// class Program
// {
//   static void Main()
//   {
//     Quti<string> harf1 = new Quti<string>();
//     Quti<string> harf2 = new Quti<string>();
//     Quti<string> harf3 = new Quti<string>();

//     Quti<int> son1 = new Quti<int>();
//     Quti<int> son2 = new Quti<int>();
//     Quti<int> son3 = new Quti<int>();
//     Quti<int> son4 = new Quti<int>();

//     Console.WriteLine("Quti string soni: " + Quti<string>.soni);
//     Console.WriteLine("Quti int soni: " + Quti<int>.soni);
//   }
// }


// class A
// {
//   public T Max<T>(T a, T b) where T : IComparable<T>
//   {
//     return a.CompareTo(b) > 0 ? a : b;
//   }
// }

// class Program
// {
//   static void Main()
//   {
//     A a1 = new A();
//     Console.WriteLine(a1.Max(5, 7));
//   }
// }

