//Asks for User's first and last name 
Console.Write("What is your first name. >> "); 
string F_name = Console.ReadLine() + " "; 
Console.Write("What is your last name. >> "); 
string L_name = Console.ReadLine() + "."; 
//Will greet User 
Console.WriteLine("It is nice to meet you, " + F_name + L_name); 
//Asks User to put numbers into variables x, y, and z 
Console.Write("What shall x be? >> "); 
int x = Convert.ToInt32(Console.ReadLine()); 
Console.Write("What shall y be? >> "); 
int y = Convert.ToInt32(Console.ReadLine()); 
Console.Write("What shall z be? >> "); 
int z = Convert.ToInt32(Console.ReadLine()); 
//Will not only do math with variables x, y, and z, but also make new variables and do math with those ones as well. 
int a = x + y + z; 
Console.Write($"a = {a}"); 
y -= x; 
int b = x * z; 
a /= y; 
x %= b; 
//Will print all current mathematical variables. 
Console.Write($"x = {x}, y = {y}, z = {z}, a = {a}, b = {b}."); 