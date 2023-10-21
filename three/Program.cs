// using System.ComponentModel;
// //Question 1: to check even or odd number
// int number - 71
// int check = number % 2;
// if (check == 1)
// {
//     Console.WriteLine("number is odd number");
// }
// else
// {
//     Console.WriteLine("number is even number");
// }

// //Question 2: bool to check if number is divisible by 5 and 7

// int number = 37;
// bool check1 = number % 5 == 0 ;
// bool check2 = number % 7 == 0;
// if (check1 && check2)
// {
//     Console.WriteLine("yes it is divisible");
// }
// else
// {
//     Console.WriteLine("not divisible by 5 and 7");
// }

// // Question 3:
// int number = 63724;
// int div100= number / 100;
// int mod10 = div100 % 10;
// if (mod10 == 7)
// {
// Console.WriteLine("third digit is: "mod10);
// }
// else
// {
//     Console.WriteLine(mod10 + " is not equal to 7");
// }

// //Question 4:Write an expression that checks whether the third bit in a given integer is 1 or 0.
//     int number = 452;    
//     Console.WriteLine(((number >> 3) & 1) == 1);

// // Question 5:  Write an expression that calculates the area of a trapezoid by given sides a, b and height h
//     float a, b, h, area;
//     a = 2;
//     b = 3;
//     h = 7;
//     area = ((a + b)*h)/2;
//     Console.WriteLine(area);

// //Question 6: Write a program that prints on the console the perimeter and the area of a rectangle by given side and height entered by the user.
//     int area, perimeter;
//     Console.Write("Enter a: ");
//     int a = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Enter b: ");
//     int b = Convert.ToInt32(Console.ReadLine());
//     perimeter = (a + b) * 2;
//     area = a * b;
//     Console.WriteLine("area = "+ area + " perimeter = "+ perimeter);

// // Question 8:The gravitational field of the Moon is approximately 17% of that on the Earth. Write a program that calculates the weight of a man on the moon by a given weight on the Earth.
//     Console.WriteLine("Enter weight: ");
//     int weight = Convert.ToInt32(Console.ReadLine());
//     double moonWeight = weight * 0.17;
//     Console.WriteLine($"This person will weight {moonWeight} kg on the Moon.");

// Question 8: Write an expression that checks for a given point {x, y} if it is within the circle K[{0, 0}, R=5]. Explanation: the point {0, 0} is the center of the circle and 5 is the radius








//Question 9: Write an expression that checks for given point {x, y} if it is within the circle K[{0, 0}, R=5] and out of the rectangle [{-1, 1}, {5, 5}]. Clarification: for the rectangle the lower left and the upper right corners are given.







// // Question 10:
// Console.Write("Enter number: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int a = number / 1000;
// int b = (number / 100) % 10;
// int c = (number / 10) % 10;
// int d = number % 10;
// int sum = a + b + c + d;
// Console.WriteLine("1.Sum of digits = "+sum);
// Console.WriteLine("2.Digits backwards = {3}{2}{1}{0}", a, b, c, d);
// Console.WriteLine("3.Last digit on first place = {3}{0}{1}{2}", a, b, c, d);
// Console.WriteLine("4.Replace third and second digit = {0}{2}{1}{3}", a, b, c, d);

//Question 11: 
int number = 19;
    bool isPrime = true;
    if (number > 2)
        for (int i = 2; i <= Math.Ceiling(Math.Sqrt(number)); ++i)
        {
            if (number % i == 0) isPrime = false;
        }
    Console.WriteLine("{number} is prime?: {isPrime}");