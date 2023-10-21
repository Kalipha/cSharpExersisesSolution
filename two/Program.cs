// ushort number1 = 52130;
// sbyte number2 = -115;
// uint number3 = 4825932;
// byte number4 = 97;
// short number5 = -10000;
// short number6 = 20000;
// byte number7 = 224;
// uint number8 = 970700000;
// sbyte number9 = 112;
// sbyte number10 = -44;
// int number11 = -1000000;
// ushort number12 = 1992;
// long number13 = 123456789123456789;
// Console.WriteLine($"ushort:{number1}, sbyte:{number2}, uint:{number3}, byte:{number4}, short:{number5}, short:{number6}, byte:{number7}, uint:{number8}, sbyte:{number9}, sbyte:{number10}, ushort:{number11}, long:{number12}");

// //=============Question 2==============
// double number1 = 34.567839023;
// float number2 = 12.345f;
// double number3 = 8923.1234857;
// decimal number4 = 3456.091124875956542151256683467m;
// Console.WriteLine($"double:{number1}, float:{number2}, double:{number3}, decimal:{number4}");

//================Question 3==============
decimal number1 = 5.25745243896m;
decimal number2 = 9.8544531763m;
number1 += number2;
Console.WriteLine(number1.ToString("#.######"));

//===========Question 4================
//===========Question 5===============
//================Question 6==========
// bool isMale = true;
// //==============Question 7============
// string first = "Hello";
// string second= "World";
// object fresh = first + " " + second;
// Console.WriteLine(fresh);

// //=============Question 8============
// string first = "Hello";
// string second= "World";
// object fresh = first + " " + second;
// string hi = fresh.ToString()!;
// Console.WriteLine(hi);

// //=============Questin 9===========
// string str1 = "The \"use\" of quotations causes difficulties.";        
// string str2 = "The " + "\u0022" + "use" + "\u0022" + " of quotations causes difficulties";
// Console.WriteLine(str1 +"\n"+str2);

// //==============Question 10============
// Console.WriteLine("  0        0 ");
// Console.WriteLine("0    0    0    0");
// Console.WriteLine(" 0    0  0    0");
// Console.WriteLine("  0    00    0");
// Console.WriteLine("   0        0 ");
// Console.WriteLine("    0      0  ");
// Console.WriteLine("     0    0   ");
// Console.WriteLine("      0  0   ");
// Console.WriteLine("        0   ");

// //============Question 11================
// Console.WriteLine("    ©");
// Console.WriteLine("   © ©");
// Console.WriteLine("  ©   ©");
// Console.WriteLine(" ©     ©");
// Console.WriteLine("©©©©©©©©©");

//==========Question 12===========
string firstName;
string lastName;
byte age;
char gender;
int id;

//===========Question 13============
int a = 5;
int b = 10;
a = a + b;
b = a - b;
a = a - b;
Console.WriteLine("a:{0} b:{1}", a, b);