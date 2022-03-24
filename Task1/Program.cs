/*string hello = "Hello, user! Write a message";
Console.WriteLine(hello);
string secret = "secret word"; 
string input = Console.ReadLine();
if(input.Length>20)
{
    Console.WriteLine("Your message is so big!");
}
if(input==secret)
{
    Console.WriteLine("You know some secret!");
}
Console.ReadKey();*/


// Decompiled with JetBrains decompiler
// Type: Program
// Assembly: Task1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9D485D2E-4B41-4861-996F-DBF2A34111CE
// Assembly location: C:\Users\cherr\source\repos\Lesson_7\Task1\bin\Debug\net6.0\Task1.dll

using System;

Console.WriteLine("Hello, user! Write a message");
string str1 = "secret word";
string str2 = Console.ReadLine();
if (str2.Length > 10)
    Console.WriteLine("Your message is so big!");
if (str2 == str1)
    Console.WriteLine("You know some secret!");
Console.ReadKey();
