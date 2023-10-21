// Console.WriteLine("Enter the number");
// int n = Int32.Parse(Console.ReadLine()!);
// for (int i = 1; i <= n; i++ )
// {
//     Console.WriteLine(i + " ");
// }

//=============Question 2==============
// int counter = 0;  
//     Console.Write("Enter number: ");
//     int num = Int32.Parse(Console.ReadLine()!);

//     for (int i = 1; i <= num; i++)
//     {
//         if (i % (3*7) == 0) counter++;
//     }
    
//     Console.WriteLine("total numbers divisible by 3 and 7 = "+ counter);

//==============Question 3================



//=============Question 4================



//==============Question 5================
    // Console.WriteLine("enter nth value: ");
    // int sum = Int32.Parse(Console.ReadLine()!);
    // int num1 = 0;
    // int num2 = 1;
    // int num3 = 0;
    
    // Console.Write(num1+" ");
    // Console.Write(num2+" ");
    
    // for(int i = 0; i < sum; i++)
    // {
    //     num3 = num1 + num2;
    //     num1 = num2;
    //     num2 = num3;
    //     Console.Write(num3+" ");
    // }
//===============Question 6,7,8,9,10,11=============

// //===============Question 12================
//     Console.Write("Enter number: ");
//     int n = Int32.Parse(Console.ReadLine()!);    
//     string binary = Convert.ToString(n, 2);
//     Console.WriteLine($"Result is {binary}");

//===============Question 13====================
    // Console.Write("Enter binary number: ");
    // int n = Convert.ToInt32(Console.ReadLine()!,2);
    // Console.WriteLine($"Result is {n}");

//===================Question 14=========================

    Console.Write("Enter decimal number: ");
    int n = Convert.ToInt32(Console.ReadLine()!);
    Console.WriteLine($"Result is {n.ToString("X")}");