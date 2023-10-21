// // Question 1
// Console.Write("Enter first number: ");
// int a = Int32.Parse(Console.ReadLine()!);
// Console.Write("Enter Second number: ");
// int b = Int32.Parse(Console.ReadLine()!);
// Console.Write("Enter Third number: ");
// int c = Int32.Parse(Console.ReadLine()!);
// int Result = a + b + c;
// Console.WriteLine($"The total number is: {Result}");

// // Question 2
//     Console.Write("Enter radius: ");
//     int r = Int32.Parse(Console.ReadLine()!);
//     double perimeter = 2 * Math.PI * r;
//     double area = Math.PI * r * r;
//     Console.WriteLine($"perimeter: {perimeter}, area: {area}");

// //Question 3
//     Console.WriteLine("======fill appropriately======");
//     Console.Write("Company's name: ");
//     string CName = Console.ReadLine()!;
//     Console.Write("Company's Address: ");
//     string CAddress = Console.ReadLine()!;
//     Console.Write("Company's Phone number: ");
//     double CPhone = Int64.Parse(Console.ReadLine()!);
//     Console.Write("Company's Fax Number: ");
//     double CFax = Int64.Parse(Console.ReadLine()!);
//     Console.Write("Company's Website: ");
//     string CWeb = Console.ReadLine()!;
//     Console.Write("Manager's name:");
//     string MName = Console.ReadLine()!;
//     Console.Write("Manager's Surname:");
//     string MSurname = Console.ReadLine()!;
//     Console.Write("Manager's Phone number:");
//     double MPhone = Int64.Parse(Console.ReadLine()!);

//     Console.WriteLine($"\n =======Company Info======= \nCompany Name: {CName}\nCompany Address: {CAddress}\nCompany Phone: {CPhone}\nCompany Fax Number: {CFax}\nCompany Website: {CWeb}\n\nManager Info\nManager Name: {MName}\nManager Surname: {MSurname}\nManager Phone: {MPhone}");

//Question 4:



// //Question 5
// int counter = 0;  
//     Console.Write("Enter first number: ");
//     int a = Int32.Parse(Console.ReadLine());
//     Console.Write("Enter second number: ");
//     int b = Int32.Parse(Console.ReadLine());
    
//     for (int i = a; i <= b; i++)
//     {
//         if (i % 5 == 0) counter++;
//     }
    
//     Console.WriteLine("total numbers divisible by 5 ="+ counter);


// //Question 6
//     Console.Write("Enter first number: ");
//     int a = Int32.Parse(Console.ReadLine());
//     Console.Write("Enter second number: ");
//     int b = Int32.Parse(Console.ReadLine());
//     int greater = Math.Max(a, b);
//     Console.WriteLine(greater);

 
// // Question 7
// int a, b, c, d, e;
// bool integer = true;

// do
// {
//     Console.Write("Enter first integer");
//     int a = Int32.TryParse(Console.ReadLine());
//     if (a != integer);
//     {
//         Console.WriteLine("input only integer");
//     }
// } while (a != integer);

// do
// {
//     Console.Write("Enter second integer");
//     IntegerCorrect = Int32.TryParse(Console.ReadLine(), out b);
//     if (b != integer)
//     {
//         Console.WriteLine("input only integer");
//     }
// } while (b != integer);

// do
// {
//     Console.Write("Enter third integer");
//     IntegerCorrect = Int32.TryParse(Console.ReadLine());
//     if (c != integer)
//     {
//         Console.WriteLine("input only integer");
//     }
// } while (c != integer);

// do
// {
//     Console.Write("Enter fourth integer");
//     IntegerCorrect = Int32.TryParse(Console.ReadLine());
//     if (d != integer)
//     {
//         Console.WriteLine("input only integer");
//     }
// } while (d != integer);

// do
// {
//     Console.Write("Enter fifth integer");
//     IntegerCorrect = Int32.TryParse(Console.ReadLine());
//     if (e != integer)
//     {
//         Console.WriteLine("input only integer");
//     }
// } while (e != integer);

// //Console.WriteLine("total sum ="+ result);

// //Question 8
//     Console.Write("Enter first number: ");
//     int a = Int32.Parse(Console.ReadLine()!);
//     Console.Write("Enter second number: ");
//     int b = Int32.Parse(Console.ReadLine()!);
//     Console.Write("Enter third number: ");
//     int c = Int32.Parse(Console.ReadLine()!);
//     Console.Write("Enter forth number: ");
//     int d = Int32.Parse(Console.ReadLine()!);
//     Console.Write("Enter fifth number: ");
//     int e = Int32.Parse(Console.ReadLine()!);
    
//         if (a > b && a > c && a > d && a > e)
//         {
//             Console.WriteLine("{0} is the biggest.", a);
//         }
//         else if (b > a && b > c && b > d && b > e)
//         {
//             Console.WriteLine("{0} is the biggest.", b);
//         }
//         else if (c > a && c > b && c > d && c > e)
//         {
//             Console.WriteLine("{0} is the biggest.", c);
//         }
//         else if (d > a && d > b && d > c && d > e)
//         { 
//             Console.WriteLine("{0} is the biggest.", d);
//         }
//         else if (e > a && e > b && e > c && e > d)
//         {
//             Console.WriteLine("{0} is the biggest.", e);
//         }
//         else Console.WriteLine("All numbers are equal");

// //Question 9
//     double d, x1, x2;
//     Console.Write("Enter A: ");
//     double a = Int32.Parse(Console.ReadLine());
//     Console.Write("Enter B: ");
//     double b = Int32.Parse(Console.ReadLine());
//     Console.Write("Enter C: ");
//     double c = Int32.Parse(Console.ReadLine());

//     d = b * b - 4 * a * c;

//     if (d < 0) 
//     {
//         Console.WriteLine("There are no real roots.");
//     }
//     else if (d == 0)
//     {
//         x1 = (-b / (2 * a));
//         Console.WriteLine("X={0}", x1);
//     }
//     else
//     {
//         x1 = (-b + Math.Sqrt(d)) / (2 * a);
//         x2 = (-b - Math.Sqrt(d)) / (2 * a);
//         Console.WriteLine("X1={0}, X2={1}", x1, x2);
//     }

// //Question 10
//     int sum = 0;
    
//     Console.Write("Enter numbers count: ");
//     int length = Int32.Parse(Console.ReadLine());
    
//     for (int i = 0; i < length; i++)
//     {
//         Console.Write("Enter {0} number: ", i + 1);
//         sum += Int32.Parse(Console.ReadLine());
//     }
    
//     Console.WriteLine($"Sum of all numbers is {sum}.");

// //=============Question 11=====================
//     int sum = 0;
    
//     Console.Write("Enter number: ");
//     int length = Int32.Parse(Console.ReadLine()!);
    
//     for (int i = 1; i <= length; i++)
//     {
//         Console.WriteLine(i);
//     }

// //=================Question 12=================
//     int num1 = 0;
//     int num2 = 1;
//     int sum = 1;
//     int count = 0;
    
//     Console.WriteLine(num1);
    
//     while(count < 100)
//     {
//         sum = num1 + num2;
//         num1 = num2;
//         num2 = sum;
//         Console.WriteLine(num2);
//         count++;
//     }

// //===================Question 13===================
//     Console.Write("Enter last number: ");
//     int length = Int32.Parse(Console.ReadLine());
//     double sum = 1.0;
    
//     for (int i = 2; i <= length; i++)
//     {
//         sum += (1.0 / i);
//     }
    
//     Console.WriteLine("{0:F3}", sum);
