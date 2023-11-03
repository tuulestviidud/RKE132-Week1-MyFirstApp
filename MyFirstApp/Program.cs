// This is a comment to my code


//rakendus küsib kasutajalt sisestada tema nime
//rakendus tervitab kasutajat nimepidi

Console.WriteLine("Enter your name");
//string - sõne
string userName = Console.ReadLine();

Console.WriteLine("Hello" + ", "  + userName + "!");
//string interpolation

Console.WriteLine($"Hello, {userName}!");