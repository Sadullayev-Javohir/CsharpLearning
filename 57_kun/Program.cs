public class Car
{
  private int speed;
  public int Speed
  {
    get { return speed; }
    set { speed = value; }
  }
}

class Program
{
  static void Main()
  {
    Car car1 = new Car();
    car1.Speed = 100;
    Console.WriteLine($"{car1.Speed}");
  }
}
