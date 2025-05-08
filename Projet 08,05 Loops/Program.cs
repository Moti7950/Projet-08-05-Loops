// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//for (int i = 1; i < 11; i++)
//{
//    Console.WriteLine(i);
//}
//for (int i = 0; i <101; i+=2)
//{
//    Console.WriteLine(i);
//}
//string[] prenoms = { "Jean", "aaul", "aacques", "aarie", "Pierre" };
//foreach (string prenom in prenoms)
//{
//   if (prenom[0] == 'a')
//    {
//        Console.WriteLine(prenom);
//    }
//}

//1
//for (int i = 1; i <=5; i++)
//{
//    Console.WriteLine(i);
//}
//2
//int i = 2;
//while (i <=10)
//{
//    if (i % 2 == 0)
//    {
//        Console.WriteLine(i);   
//    }
//    i++;
//}
//3

//4
//Console.WriteLine("Please enter a sintax");
//while (true)
//{
//    string input = Console.ReadLine();
//    if (input == "Exit")
//    {
//        break;
//    }
//}
//5
//for (int i =i; i>= 10 :i++)
//{
//    Console.WriteLine(" Accss allowed");
//}
//6
//for ( int i = 1; i <=20; i++)
//{
//    if (i%3!=0)
//    {
//        Console.WriteLine(i);
//    }
//}
//7
//int i = 5;
//while (i > 1)
//{
//    Console.WriteLine(i-1);
//    i--;
//}
//8
//for (int i=  0; i <=10; i++)
//{
//    if (i%2==0)
//    {
//        Console.WriteLine(i+" Even");
//    }
//    else
//    {
//        Console.WriteLine(i+" Odd"); 
//    }
//}
//9
//Console.WriteLine("Please enter a number: ");
//int number = int.Parse(Console.ReadLine());
//if (number == 8200)
//{ Console.WriteLine("Insurance");
//}
//10
//while (true)
//{
//    Console.WriteLine("Please entr a user name: ");
//    string userName = Console.ReadLine();
//    if (userName == "admin")
//    { break; }
//    else
//    { continue;
//    }
//}
//11
//int sum = 0;
//for (int i = 1; i <=100; i++)
//{
//    if (i% 7==0)
//    {
//        sum+=1;
//    }
//}
//Console.WriteLine(sum);
//12
//Console.WriteLine("Please enter a password: ");
//string password =Console.ReadLine();
//if (password.Length == 8)
//{
//    Console.WriteLine("you have 8 Digeht");
//}
//else
//{ Console.WriteLine("Invalid Password!"); }
//13
//Console.WriteLine("Please enter string: ");
//string input = Console.ReadLine();
//foreach (char c in input)
//{
//    if (char.IsDigit(c))
//    {
//        Console.WriteLine(c);
//    }
//}
//14
//Console.WriteLine("Please enter a password: ");
//string password = Console.ReadLine();
//while (true)
//{
//    if (password.Length <8)
//    {
//        Console.WriteLine("Password must be at least 8 characters long.");
//        password = Console.ReadLine();
//    }
//    else
//    {
//        Console.WriteLine("Password is valid.");
//        break;
//    }
//}
//15
//for (int i = 0; i <= 10; i++)
//{
//    bool prime = true;
//    if (i <= 1)
//    {
//        prime = false;
//    }
//    else
//    {
//        for (int j = 2; j <= Math.Sqrt(i); j++)
//        {
//            if (i % j == 0)
//            {
//                prime = false;
//                break;
//            }
//        }
//    }
//    if (prime)
//    {
//        Console.WriteLine(i + " is prime");
//    }
//}

//16

//21
//string username = "admin";
//string password = "1234";
//while (true)
//{
//    Console.WriteLine("Please enter a user name: ");
//    string inputUsername = Console.ReadLine();
//    Console.WriteLine("Please enter a password: ");
//    string inputPassword = Console.ReadLine();
//    if ( username == inputUsername && password == inputPassword)
//    {
//        Console.WriteLine("welcome");
//        break;
//    }
//    else
//    {
//        Console.WriteLine("Incorect password or user name!");
//    }
//    {

//    }
//}
//22
//using System.Globalization;

//Random random = new Random();
//List<int> randomNumber = new List<int>();
//for (int i = 0; i <= 6; i++)
//{
//    int number = random.Next(0, 10);
//    randomNumber.Add(number);
//}
//Console.WriteLine("NumberStyles: " +string.Join(", ",randomNumber));
//23
//Console.WriteLine("Please enter Password: ");
//string input = Console.ReadLine();
//bool lether = false;
//bool digit = false;
//foreach (char c in input)
//{
//    if (char.IsDigit(c))
//    {
//        digit = true;
//    }
//    if (char.IsLetter(c))
//    {
//        lether = true;
//    }
//}
//if (lether == true)
//{
//    Console.WriteLine("found letters");
//}
//if (digit == true)
//{
//    Console.WriteLine("found numbers");
//}
//24
//Console.WriteLine("Please enter Password: ");
//string input = Console.ReadLine();
//foreach (char c in input)
//{
//    if (char.IsDigit(c))
//    {
//        Console.WriteLine("Number");
//    }
//    if (char.IsLetter(c))
//    {
//        Console.WriteLine(c);
//    }
//}
//25
//Console.WriteLine("Please ");
//string input = Console.ReadLine();
//foreach (char c in input)
//{
//    if (c == '8' || c == '2' || c =='0')
//    {
//        Console.WriteLine("found");
//    }
//    else
//    {
//        Console.WriteLine("not found");
//    }
//}
