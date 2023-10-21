// //================Question 1================
//     Console.Write("Enter first number: ");
//     int a = Int32.Parse(Console.ReadLine());
//     Console.Write("Enter second number: ");
//     int b = Int32.Parse(Console.ReadLine());    

//     if (a > b)
//     {
//         a = a + b;
//         b = a - b;
//         a = a - b;
//     }
    
//     Console.WriteLine($"First number - {a}, Second number - {b}.");

//=============Question 2===============


// //=============Question 3===============
// Console.Write("Enter first number: ");
// int a = Int32.Parse(Console.ReadLine()!);
// Console.Write("Enter second number: ");
// int b = Int32.Parse(Console.ReadLine()!);
// Console.Write("Enter third number: ");
// int c = Int32.Parse(Console.ReadLine()!);

// if (a > b)
// {
//     if (a > c)
//     {
//         Console.WriteLine("A is the biggest");
//     }
//     else if (a < c)
//     {
//         Console.WriteLine("C is the biggest");
//     }
//     else 
//     {
//         Console.WriteLine("A and C are the biggest");
//     }
//     }
// else if (a < b)
// {
//     if (b > c) 
//     {
//         Console.WriteLine("B is the biggest");
//     }
//     else if (b < c) 
//     {
//         Console.WriteLine("C is the biggest");
//     }
//     else 
//     {
//         Console.WriteLine("B and C are the biggest");
//     }
//      if (a == b)
//     {
//     if (a == c) 
//     {
//         Console.WriteLine("All are equal");
//     }
//     else if (a < c) 
//     {
//         Console.WriteLine("C is the biggest");
//     }
//     else
//     {
//         Console.WriteLine("A and B are the biggest");
//     }
//     }
// }

//================Question 4=================




// //================Question 5================
// Console.Write("Enter first number: ");
//     int number = Int32.Parse(Console.ReadLine()!);

//     switch (number)
//     {
//         case 0: Console.WriteLine("zero"); break;
//         case 1: Console.WriteLine("one"); break;
//         case 2: Console.WriteLine("two"); break;
//         case 3: Console.WriteLine("three"); break;
//         case 4: Console.WriteLine("four"); break;
//         case 5: Console.WriteLine("five"); break;
//         case 6: Console.WriteLine("six"); break;
//         case 7: Console.WriteLine("seven"); break;
//         case 8: Console.WriteLine("eight"); break;
//         case 9: Console.WriteLine("nine"); break;
//         default: Console.WriteLine("Wrong input"); break;
//     }

//==============question 6=================





// //============Question 7================
//     Console.Write("Enter first number: ");
//     int a = Int32.Parse(Console.ReadLine()!);
//     Console.Write("Enter second number: ");
//     int b = Int32.Parse(Console.ReadLine()!);
//     Console.Write("Enter third number: ");
//     int c = Int32.Parse(Console.ReadLine()!);
//     Console.Write("Enter fourth number: ");
//     int d = Int32.Parse(Console.ReadLine()!);
//     Console.Write("Enter fifth number: ");
//     int e = Int32.Parse(Console.ReadLine()!);

//     if(a > b && a > c && a > d && a > e)
//     {
//         Console.WriteLine($"the biggest number is {a}");
//     }
//     else if(b > a && b > c && b > d && b > e)
//     {
//         Console.WriteLine($"the biggest number is {b}");
//     }
//     else if(c > b && c > a && c > d && c > e)
//     {
//         Console.WriteLine($"the biggest number is {c}");
//     }
//     else if(d > b && d > c && d > a && d > e)
//     {
//         Console.WriteLine($"the biggest number is {d}");
//     }
//     else
//     {
//         Console.WriteLine($"the biggest number is {e}");
//     }
    
// //================Question 8===================
// Console.Write("Enter variable type\n0 for integer,\n1 for double,\n2 for string ");
// int intVar = Int32.Parse(Console.ReadLine()!);

// switch (intVar)
// {
//     case 0:
//         {
//             Console.Write("Enter int variable: ");
//             intVar = Int32.Parse(Console.ReadLine()!);
//             intVar++;
//             Console.WriteLine("Int variable +1 = {0}", intVar);
//             break;
//         }
//     case 1:
//         {
//             Console.Write("Enter double variable: ");
//             double doubleVar = double.Parse(Console.ReadLine()!);
//             doubleVar++;
//             Console.WriteLine("Double variable +1 = {0}", doubleVar);
//             break;
//         }
//     case 2:
//         {
//             Console.Write("Enter string variable: ");
//             string stringVar = Console.ReadLine()!;
//             stringVar = stringVar + '*';
//             Console.WriteLine("String variable +* = {0}", stringVar);
//             break;
//         }
//         default: Console.WriteLine("Wrong input"); break;
//     }

//===============Question 9================
Console.Write("Enter first number: ");
sbyte first = Convert.ToSByte(Console.ReadLine());
Console.Write("Enter second number: ");
sbyte second = Convert.ToSByte(Console.ReadLine());
Console.Write("Enter third number: ");
sbyte third = Convert.ToSByte(Console.ReadLine());
Console.Write("Enter fourth number: ");
sbyte fourth = Convert.ToSByte(Console.ReadLine());
Console.Write("Enter fifth number: ");
sbyte fifth = Convert.ToSByte(Console.ReadLine());

    if(first + second == 0)
    {
        Console.WriteLine("{0}+ {1} = 0", first, second);
    }
    if (first + third == 0)
    {
            Console.WriteLine("{0}+ {1} = 0", first, third);
    }
    if (first + fourth == 0)
    {
        Console.WriteLine("{0}+ {1} = 0", first, fourth);
    }
    if (first + fifth == 0)
    {
        Console.WriteLine("{0}+ {1} = 0", first, fifth);
    }
    if (second + third == 0)
    {
        Console.WriteLine("{0}+ {1} = 0", second, third);
    }
    if (second + fourth == 0)
    {
        Console.WriteLine("{0}+ {1} = 0", second, fourth);
    }
    if (second + fifth == 0)
    {
        Console.WriteLine("{0}+ {1} = 0", second, fifth);
    }
    if (third + fourth == 0)
    {
        Console.WriteLine("{0}+ {1} = 0", third, fourth);
    }
    if (third + fifth == 0)
    {
        Console.WriteLine("{0}+ {1} = 0", third, fifth);
    }
    if (fourth + fifth == 0)
    {
        Console.WriteLine("{0}+ {1} = 0", fourth, fifth);
    }
    if (first + second + third == 0)
    {
        Console.WriteLine("{0}+ {1}+ {2} = 0", first, second, third);
    }
    if (first + second + fourth == 0)
    {
        Console.WriteLine("{0}+ {1}+ {2} = 0", first, second, fourth);
    }
    if (first + second + fifth == 0)
    {
        Console.WriteLine("{0}+ {1}+ {2} = 0", first, second, fifth);
    }
    if (first + third + fourth == 0)
    {
        Console.WriteLine("{0}+ {1}+ {2} = 0", first, third, fourth);
    }
    if (first + third + fifth == 0)
    {
        Console.WriteLine("{0}+ {1}+ {2} = 0", first, third, fifth);
    }
    if (second + third + fourth == 0)
    {
        Console.WriteLine("{0}+ {1}+ {2} = 0", second, third, fourth);
    }
    if (second + third + fifth == 0)
    {
        Console.WriteLine("{0}+ {1}+ {2} = 0", second, third, fifth);
    }
    if (third + fourth + fifth == 0)
    {
        Console.WriteLine("{0}+ {1}+ {2} = 0", third, fourth, fifth);
    }