// byte a = 127;
// short b = a;
// int c = b;
// long d = c;
// float e = d;
// double f = e;


// float f = 5022.14f;
// byte a = (byte)f;
// Console.WriteLine(a);

// int a = 15;
// float f = (float)a;
// Console.WriteLine(f);



class Animal
{
  public void Speak()
  {
    Console.WriteLine("Animal is speaking...");
  }
}
class Dog : Animal
{
  public void Bark()
  {
    Console.WriteLine("Dog is barking..");
  }
}

class Cat : Animal
{
  public void Meow()
  {
    Console.WriteLine("Cat is barking..");
  }
}

class Program
{
  static void Main()
  {
    // Animal[] animals = new Animal[2];
    // animals[0] = new Dog();
    // animals[1] = new Cat();
    // animals[0].Speak();
    // Dog dog = new Dog();
    // Animal a = dog;

    // Animal a = new Dog();
    // a.Speak();
    // Dog d = (Dog)a;
    // d.Bark();
    // string matn = "Salom";
    // string matn2 = "Hello";
    // Console.WriteLine(matn);


    // object obj = 12;

    // // if (obj is not string)
    // // {
    // //   Console.WriteLine("Bu string emas");
    // // }
    // Console.WriteLine(obj is int);


    // try
    // {
    //   int a = 300;
    //   byte b = Convert.ToByte(a);
    // }
    // catch (OverflowException ex)
    // {
    //   Console.WriteLine("Xatolik: " + ex.Message);
    // }
    // finally
    // {
    //   Console.WriteLine("Tugadi");
    // }

    // int a = 15;
    // string b = Convert.ToString(a);
    // Console.WriteLine(b);


    // string s = "24";
    // int a = int.Parse(s);
    // Console.WriteLine(a);

    // string s = "123";
    // if (int.TryParse(s, out int result))
    // {
    //   Console.WriteLine("To'g'ri son: " + result);
    // }
    // else
    // {
    //   Console.WriteLine("Xatolik ");
    // }


    // int num = 5;
    // object obj = num;
    // Console.WriteLine(obj.GetType());

    // object obj = 5;
    // int num = (int)obj;
    // Console.WriteLine(num.GetType());


    // int a = 5;
    // object obj = a; //boxing bo'layapti

    // int b = (int)obj; // unboxing bo'layapti
    // Console.WriteLine(b);

    // double x = 12.8;
    // int y = (int)x;
    // Console.WriteLine(y);
    // int x = (int)(object)15;
    // Console.WriteLine(x);

    // object obj = "Salom";
    // string str = obj as string;
    // Console.WriteLine(str);



    // object[] data = { 5, "3.2", true, 7.8, "hello", 10, "100", false, null };

    // double sum = 0;

    // foreach (var item in data)
    // {
    //   if (item is int i)
    //   {
    //     sum += i;
    //   }
    //   else if (item is double d)
    //   {
    //     sum += d;
    //   }
    //   else if (item is string s)
    //   {
    //     if (double.TryParse(s, out double dd))
    //     {
    //       sum += dd;
    //     }
    //   }
    // }

    // Console.WriteLine("Yig'indi: " + sum);

    // Console.Write("Son kiriting: ");
    // int inputNum = Convert.ToInt32(Console.ReadLine());

    // double a = inputNum;

    // Console.WriteLine("Kiritilgan son: " + a);

    // Console.Write("Son kiriting: ");
    // double doubleNum = Convert.ToInt64(Console.ReadLine());

    // int change = (int)doubleNum;

    // Console.WriteLine("Kiritilgan son: " + change);


    // Console.WriteLine("Son kiriting: ");

    // string matnliSon = (Console.ReadLine());

    // int son = int.Parse(matnliSon);

    // Console.WriteLine("Kiritilgan son: " + son);


    // Console.Write("Son kiriting: ");

    // string son = Console.ReadLine();

    // if (int.TryParse(son, out int natija))
    // {
    //   Console.WriteLine("Kvadrat: " + (natija * natija));
    // }
    // else
    // {
    //   Console.WriteLine("Xatolik raqam emas bu");
    // }

    





  }
}

