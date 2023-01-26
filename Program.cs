
//Console.WriteLine("Hello, World!");
//System.Console.Write("Typing 1st number: ");
//int firstNumber = Convert.ToInt32(Console.ReadLine());
//System.Console.Write("Enter opration(+,-,/,*,%): ");
//string opration = Console.ReadLine();
//System.Console.Write("Typing 2nd number: ");
//int secondNumber = Convert.ToInt32(Console.ReadLine());


//if (firstNumber >=0)
//{
//        System.Console.WriteLine("1st number is positev!");
//}
//else
//{
//        System.Console.WriteLine("1st number is negative!");
//}


//if (firstNumber>secondNumber)
//{
//        System.Console.WriteLine($"1st number is greater than 2nd number!");
//}
//else if (firstNumber==secondNumber)
//{
//        System.Console.WriteLine($"1st number is equal to 2nd number!");
//}
//else
//{
//        System.Console.WriteLine($"1st number is less 2nd number!");
//}
 

 // Ternary opratori ? :
 //string message = 
 //       !(firstNumber >=0) 
 //               ? "1st number is not positive!"
 //               : "1st number is not negative!";
//System.Console.WriteLine(message);
// logical opirator: &&, ||, !


//switch (opration)
//{
  //      case ("+"):
  //      System.Console.WriteLine($"{firstNumber} + {secondNumber} = {firstNumber+secondNumber}");
  //      break;
  //      case ("-"):
  //      System.Console.WriteLine($"{firstNumber} - {secondNumber} = {firstNumber-secondNumber}");
  //      break;
  //      case ("/"):
  //      System.Console.WriteLine($"{firstNumber} / {secondNumber} = {firstNumber/secondNumber}");
  //      break;
  //      case ("*"):
  //      System.Console.WriteLine($"{firstNumber} * {secondNumber} = {firstNumber*secondNumber}");
  //      break;
  //      case ("%"):
  //      System.Console.WriteLine($"{firstNumber} % {secondNumber} = {firstNumber%secondNumber}");
  //      break;
  //      default:
  //      System.Console.WriteLine("Operation Not Found!");
  //      break;
//}


//string result = opration switch 
//{
 //       "+" =>$"{firstNumber} + {secondNumber} = {firstNumber+secondNumber}",
 //       "-" =>$"{firstNumber} - {secondNumber} = {firstNumber-secondNumber}",
 //       "/" =>$"{firstNumber} / {secondNumber} = {firstNumber/secondNumber}",
 //       "*" =>$"{firstNumber} * {secondNumber} = {firstNumber*secondNumber}",
 //       "%" =>$"{firstNumber} % {secondNumber} = {firstNumber%secondNumber}",
 //       _ =>"Operation Not Found!"
//};
//System.Console.WriteLine(result);


//if (firstNumber > 0)
//{
  //      int countr = 0;
  //      while (countr < firstNumber)
  //      {
  //              System.Console.WriteLine(countr);
  //              countr++;
  //      }


        // Vazifa 1 dan 100 gacha bulgan sonlarni orasidan faqat juftlarini while loopi orqali 
        //consolega chiqarish 

//}
//if (firstNumber>0)
//{
  //      int counter = 0;
  //      while (counter<firstNumber)
  //      {
  //              System.Console.WriteLine(counter);
  //              counter+=2;
  //      }
//}


//string password ="";
//do 
//{
  //      System.Console.Write("Enter password: ");
  //      password = Console.ReadLine();
//}while (password!="jahongir");


// Vazifa keschada while loopi orqali kescha ishga tushishidan avval passworni surasin va password to'g'ri 
// bulsa kescha ishga tushsin !
//System.Console.Write("Enter you name: ");
//string ism = Convert.ToString(Console.ReadLine());
//System.Console.WriteLine($"Hello {ism}");

//string password = "";
//do 
//{
 //       System.Console.Write("Enter password: ");
 //       password = Console.ReadLine();
//}while (password != "lenovo.net7");

//System.Console.Write("Enter you age: ");
//int yosh = Convert.ToInt32(Console.ReadLine());
//string ismm = "Kescha";
//System.Console.WriteLine($"Hello {ismm}");
//int yoshh = 3;
//if (yosh > yoshh)
//{
 //       System.Console.WriteLine($"{ism}'s age is {yosh - yoshh} years older than {ismm}'s!");
//}
//else if (yosh == yoshh)
//{
 //       System.Console.WriteLine($"{ism}'s age is equal to {ismm}'s age!");
//}
//else 
//{
 //       System.Console.WriteLine($"{ism}'s age is {yoshh - yosh} years younger than {ismm}'s age!");
//}

//Array mavzu ya'ni bir necha o'zgaruvchilar yig'indisi


//System.Console.WriteLine("Let me tell you abaut my frinds.");
//string [] frindsName = {"Xudoyberdi","Egamberdi","Baxrom","Davron"};
//int [] frindsAge = {23,21,21,31}; 
//string [] adress = {"Samarkand","Sirdarya","Kharshi","Navoi"};
//System.Console.WriteLine($"{frindsName[0]} is {frindsAge[0]} years old and was born in {adress[0]} ! ");
//System.Console.WriteLine($"{frindsName[1]} is {frindsAge[1]} years old and was born in {adress[1]} ! ");
//System.Console.WriteLine($"{frindsName[2]} is {frindsAge[2]} years old and was born in {adress[2]} ! ");
//System.Console.WriteLine($"{frindsName[3]} is {frindsAge[3]} years old and was born in {adress[3]} ! ");

//Xatoliklar turi ikki xil bular ekan bulardan 
// Campair qilishda xatolik berar ekan bu xatolik dastur ishlashdan avval buladigan xatolik 
// Run taim error ya'ni dastur ishlab turgandagi xatolik 

//System.Console.WriteLine("Let me tell you abaut my friends.");
//string [] friendsName = new string [4];
//int [] friendsAge = new int [4];

//System.Console.Write("Enter you name friend: ");
//string ism = Console.ReadLine();
//friendsName[0] = ism;
//System.Console.Write($"Enter you age {ism}: ");
//int yosh = Convert.ToInt32(Console.ReadLine());
//friendsAge[0] = yosh; 

//System.Console.Write("Enter you name friend: ");
//string ism1 = Console.ReadLine();
//friendsName[1] = ism1;
//System.Console.Write($"Enter you age {ism1}: ");
//int yosh1 = Convert.ToInt32(Console.ReadLine());
//friendsAge[1] = yosh1; 

//System.Console.Write("Enter you name friend: ");
//string ism2 = Console.ReadLine();
//friendsName[2] = ism2;
//System.Console.Write($"Enter you age {ism2}: ");
//int yosh2 = Convert.ToInt32(Console.ReadLine());
//friendsAge[2] = yosh2; 

//System.Console.Write("Enter you name friend: ");
//string ism3 = Console.ReadLine();
//friendsName[3] = ism3;
//System.Console.Write($"Enter you age {ism3}: ");
//int yosh3 = Convert.ToInt32(Console.ReadLine());
//friendsAge[3] = yosh3; 
//       System.Console.WriteLine($"Name and age of My friends {ism} is {yosh} years old , {ism1} is {yosh1} years old, {ism2} is {yosh2} years old, {ism3} is {yosh3} years old");

//System.Console.Write("Enter you name : ");
//string ism = Console.ReadLine();
//System.Console.Write($"Hello {ism} Enter you age :");
//int yosh = Convert.ToInt32(Console.ReadLine());
//System.Console.Write("What city were you born in : ");
//string city = Console.ReadLine();
//System.Console.Write("Where do you want to buy BMW : ");
//string car =Console.ReadLine();
//if (car == "M8 Compenetion")
//{
 // System.Console.WriteLine("Buy BMW M8 component automatic V12 6.4 liter biturbo black 2023 price $189000 !");
//}
//else if (car == "M7 series") 
//{
 // System.Console.WriteLine("Buy BMW M7 series automatic V8 5.4 liter biturbo black 2023 price $154000");
//}
//else
//{
 // System.Console.WriteLine("Buy BMW M5 component automatic V8 4.4 liter biturbo black 2023 price $120000");
//}

//string [] frindsName =new string [4];
//frindsName [0] ="Xudoyberdi";
//frindsName [1] ="Egamberdi";
//frindsName [2] = "Baxrom";
//frindsName [3] = "Davron";
//int [] frindsAge =new int [4];
//frindsAge [0]= 23;
//frindsAge [1] = 21;
//frindsAge [2] = 21;
//frindsAge [3] = 31;

//System.Console.WriteLine($"{frindsName[0]} is {frindsAge[0]} year old!");
//System.Console.WriteLine($"{frindsName[1]} is {frindsAge[1]} year old!");
//System.Console.WriteLine($"{frindsName[2]} is {frindsAge[2]} year old!");
//System.Console.WriteLine($"{frindsName[3]} is {frindsAge[3]} year old!");

//foreach (string frindName in frindsName)
//{
 // System.Console.WriteLine(frindName);
//}

//for (int i=1; i<frindsName.Length; i++)
//{
 // System.Console.WriteLine($"{frindsName[i]} is {frindsAge[i]} year old!");
//}

//int [] Numbers = new int [10];
//for (int i=1; i<11; i++)
//{
 // System.Console.WriteLine(i);
//}

for (int i=1; i<=10; i++)
{
  for (int iT=1; iT<=10; iT++)
  {
    System.Console.WriteLine($"{i} x {iT} = {i*iT}");
  }
  System.Console.Write("\n");
}