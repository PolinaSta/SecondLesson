// 1. Задача.
// void ShowNumber(){
//     int num = new Random().Next(10,100);
//     int firstNum = num/10;
//     int SecondNum = num/10;
//     Console.Write(num + "->");
//     if (firstNum>SecondNum){
//      Console.WriteLine(firstNum);   
//     }
//     else{
//         Console.WriteLine(SecondNum);
//     }
// }
// ShowNomber();


// 2. Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.
// int NumberWithoutSecDig(int Number){
//     int NewNumber = Number / 100 * 10 + Number % 10;
//     return NewNumber;
// }
// int Number = new Random().Next(100, 1000);
// int a = NumberWithoutSecDig(Number);
// Console.WriteLine(a + " " + Number);


// 3. Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно

// void MultiNum(int a, int b){
//     if(b%a == 0){
//         Console.WriteLine(b + " кратно " + a);
//     }else{
//         Console.WriteLine(b + " не кратно " + a + ", остаток " + b%a);
//     }
// }

// Console.WriteLine("Введите последовательно два числа:");
// int num1 = Convert.ToInt32(Console.ReadLine());
// int num2 = Convert.ToInt32(Console.ReadLine());

// MultiNum(num1,num2);


// MultiNum(num1, num2);}

// 4. Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
// 14 -> нет 
// 46 -> нет 
// 161 -> да

// void NumDiv(int a){
//     if(a%7 == 0 && a%23 ==0){
//         Console.WriteLine(a + " кратно 23 и 7");
//     }else{
//         Console.WriteLine(a + " не кратно 23 и 7");
//     }
// }

// Console.WriteLine("Введите число: ");
// NumDiv(Convert.ToInt32(Console.ReadLine()));


// 5. Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
// 5, 25  ->  да
// -4, 16  ->  да
// 25, 5  ->  да
// 8,9  ->  нет

// void NumDiv(int a, int b){
//     if(a == b*b){
//         Console.WriteLine(a + " квадрат " + b);
//     }else{
//         Console.WriteLine(a + " не квадрат " + b);
//     }
// }

// Console.WriteLine("Введите два числа: ");
// NumDiv(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));


// ДОМАШНЕЕ ЗАДАНИЕ

// 1. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// void NumberSecond(int num){
// if(num > 99 && num < 1000){
//     int result = num / 10 % 10;
//     Console.WriteLine(num + " -> " + result);
// }
// else {
//      Console.WriteLine("Заданное число не является трехзначным");
// }
// }
// Console.WriteLine("Введите число:");
// int num = Convert.ToInt32(Console.ReadLine());
// NumberSecond(num);


// 2. Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// void NumberThird(int num){
// if(num <= 99){
//     Console.WriteLine("Заданное число не является трехзначным");
//     }
// if(num > 99){
//     while(num > 999){
//          num = num / 10;
//      }
//     Console.WriteLine(num + ", его третье число - " + num%10);
// }
// }
// Console.WriteLine("Введите число:");
// int num = Convert.ToInt32(Console.ReadLine());
// NumberThird(num);


// 3. Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// Console.WriteLine("Введите число обозначающее день недели:");
// int num = Convert.ToInt32(Console.ReadLine());
// void NumberOfDay(int num){
// if(num==6 | num==7){
//     Console.WriteLine("Выходной день");
// }
// else {
//     Console.WriteLine("Будний день");
// }
// }
// NumberOfDay(num);

