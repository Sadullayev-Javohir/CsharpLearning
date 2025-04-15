while (true)
{
  string savedUserName = "Javohir";
  string savedPassword = "1234";
  Console.WriteLine("***Login Tizimi***");
  Console.WriteLine("Username kiriting: ");
  string enterUsername = Convert.ToString(Console.ReadLine());
  Console.WriteLine("Parolni kiriting: ");
  string enterPassword = Convert.ToString(Console.ReadLine());
  if (savedUserName == enterUsername && savedPassword == enterPassword)
  {
    Console.WriteLine("Tizimga Xush kelibsiz");
    break;
  }
  else if (savedUserName != enterUsername && savedPassword == enterPassword)
  {
    Console.WriteLine("Username Xato");
  }
  else if (savedUserName == enterUsername && savedPassword != enterPassword)
  {
    Console.WriteLine("Password Xato");
  }
  else
  {
    Console.WriteLine("Username va Password Xato");
  }
}