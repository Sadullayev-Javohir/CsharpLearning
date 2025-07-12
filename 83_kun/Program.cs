// public delegate void RingHdl(string name);

// public class Tel
// {
//   public event RingHdl Ring;

//   public void Call(string name)
//   {
//     Console.WriteLine($"{name} qo'ng'iroq qilmoqda");
//     if (Ring != null)
//     {
//       Ring(name);
//     }
//   }
// }

// public class User
// {
//   public void Ans(string name)
//   {
//     Console.WriteLine($"Javob: {name}");
//   }
// }

// public class Program
// {
//   static void Main()
//   {
//     Tel t = new Tel();
//     User u = new User();

//     t.Ring += u.Ans;

//     t.Call("Javohir");
//   }
// }



// public delegate void ButtonClick();

// public class Button
// {
//   public event ButtonClick Clicked;

//   public void Click()
//   {
//     Console.WriteLine("Tugma bosildi");

//     if (Clicked != null)
//     {
//       Clicked();
//     }
//   }
// }

// class Program
// {
//   static void Main()
//   {
//     Button b = new Button();

//     b.Clicked += OnButtonClicked;

//     Console.WriteLine("Enter bosing");
//     Console.ReadLine();

//     b.Click();

//   }
//   static void OnButtonClicked()
//   {
//     Console.WriteLine("Hodisaga javob: Tugma bosilganligi aniqlandi.");
//   }
// }

// public delegate void EventHandler(object sender, EventArgs e);

// public class Button
// {
//   public event EventHandler Click;

//   public void Press()
//   {
//     Console.WriteLine("Tugma bosildi");
//     if (Click != null)
//     {
//       Click(this, EventArgs.Empty);
//     }
//   }
// }

// public class User
// {
//   public void OnButtonClick(object sender, EventArgs e)
//   {
//     Console.WriteLine("Men tugma bosilganini eshitdim");
//   }
// }


// class Program
// {
//   static void Main()
//   {
//     Button btn = new Button();
//     User user = new User();

//     btn.Click += user.OnButtonClick;

//     btn.Press();

//   }
// }


// public class MailEventArgs : EventArgs
// {
//   public string Content { get; set; }

//   public MailEventArgs(string content)
//   {
//     Content = content;
//   }
// }

// public delegate void MailSentHandler(object sender, MailEventArgs e);


// public class PostOffice
// {
//   public event MailSentHandler MailSent;

//   public void SendMail(string content)
//   {
//     Console.WriteLine("Pochta xabari yuborilmoqda...");

//     if (MailSent != null)
//     {
//       MailSent(this, new MailEventArgs(content));
//     }
//   }
// }

// public class Customer
// {
//   public void ReceiveMail(object sender, MailEventArgs e)
//   {
//     Console.WriteLine("Mijoz xabar oldi: " + e.Content);
//   }
// }

// class Program
// {
//   static void Main()
//   {
//     PostOffice post = new PostOffice();
//     Customer client = new Customer();

//     post.MailSent += client.ReceiveMail;

//     post.SendMail("Salom, bu yangi xabar");
//   }
// }


// using System.Threading;

// public class AnalysisEventArgs : EventArgs
// {
//   public int Result { get; set; }
// }

// public class Laboratory
// {
//   public event EventHandler<AnalysisEventArgs> AnalysisCompleted;

//   public void AnalyzeSample()
//   {
//     Console.WriteLine("Tahlil bajarilmoqda");
//     Thread.Sleep(1000);

//     OnAnalysisCompleted(105);
//   }

//   protected virtual void OnAnalysisCompleted(int result)
//   {
//     if (AnalysisCompleted != null)
//     {
//       AnalysisCompleted(this, new AnalysisEventArgs() { Result = result });
//     }
//   }
// }

// public class Doctor
// {
//   public void OnAnalysisReceived(object sender, AnalysisEventArgs e)
//   {
//     Console.WriteLine("Shifokor natijani oldi: " + e.Result);

//     if (e.Result > 100)
//     {
//       Console.WriteLine("🔺 Diqqat. Natija me'yordan yuqori");
//     }
//     else
//     {
//       Console.WriteLine("✅ Natija normal holatda");
//     }
//   }
// }

// class Program
// {
//   static void Main()
//   {
//     Laboratory lab = new Laboratory();
//     Doctor doc = new Doctor();

//     lab.AnalysisCompleted += doc.OnAnalysisReceived;

//     lab.AnalyzeSample();

//   }
// }

// using System.Threading;

// public class DataEventArgs : EventArgs
// {
//   public int Data { get; set; }
// }


// public class Publisher
// {
//   public event EventHandler<DataEventArgs> DataProceed;

//   public void ProcessData()
//   {
//     Console.WriteLine("Ma'lumot qayta ishlanmoqda");
//     Thread.Sleep(1000);
//     OnDataProceed(99);
//   }

//   protected virtual void OnDataProceed(int data)
//   {
//     if (DataProceed != null)
//     {
//       DataProceed(this, new DataEventArgs() { Data = data });
//     }
//   }
// }

// public class Subscriber
// {
//   public void HandleDataProceed(object sender, DataEventArgs e)
//   {
//     Console.WriteLine("Tinglovchi: Hodisa ishladi");
//   }
// }

// class Program
// {
//   static void Main()
//   {
//     Publisher pub = new Publisher();
//     Subscriber sub = new Subscriber();

//     pub.DataProceed += sub.HandleDataProceed;

//     pub.ProcessData();
//   }
// }


public class TemperatureEventArgs : EventArgs
{
  public double Temperature { get; set; }
}

public class TemperatureSensor
{
  public event EventHandler<TemperatureEventArgs> TemperatureExceed;

  public void CheckTemperature(double temp)
  {
    Console.WriteLine($"O'lchangan harorat: {temp} C");

    if (temp > 30)
    {
      OnTemperatureExceed(temp);
    }
  }
  protected virtual void OnTemperatureExceed(double temp)
  {
    if (TemperatureExceed != null)
    {
      TemperatureExceed(this, new TemperatureEventArgs() { Temperature = temp });
    }
  }
}

public class AlarmSystem
{
  public void OnTemperatureWarning(object sender, TemperatureEventArgs e)
  {
    Console.WriteLine($"⚠️ Ogohlantirish! Harorat juda yuqori: {e.Temperature} °C");
  }
}

class Program
{
  static void Main()
  {
    var sensor = new TemperatureSensor();
    var alarm = new AlarmSystem();

    sensor.TemperatureExceed += alarm.OnTemperatureWarning;

    sensor.CheckTemperature(25);
    sensor.CheckTemperature(35);
  }
}
