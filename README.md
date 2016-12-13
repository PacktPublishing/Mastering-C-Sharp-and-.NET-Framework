# Mastering __C#__ and .NET Programming
This is the code repository for [Mastering C# and .NET Programming](https://www.packtpub.com/application-development/mastering-c-and-net-programming?utm_source=github&utm_medium=repository&utm_campaign=9781785884375), published by [Packt](https://www.packtpub.com/?utm_source=github&utm_medium=repository). It contains all the supporting project files necessary to work through the book from start to finish.

##About the Book
Mastering C# and .NET Programming will take you in to the depths of C# 6.0 and .NET 4.6, so you can understand how the platform works when it runs your code, and how you can use this knowledge to write efficient applications. Take full advantage of the new revolution in .NET development, including open source status and cross-platform capability, and get to grips with the architectural changes of CoreCLR.

##Instructions and Navigation
All of the code is organized into folders. Each folder starts with number followed by the application name. For example, Chapter02.

You will see code something similar to the following:

```
namespace Chapter02_01
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = DateTime.Now;
            // Boxing and Unboxing
            int y = 3; // this is declared in the stack
            // Boxing y in a Heap reference z
            // If we change z, y remains the same.
            object z = y;
            // Unboxing y into h (the value of 
            // z is copied to the stack)
            int h = (int)z;

        }
    }
}

```

Software and Hardware List

| Chapter  | Software required             | OS required |
| -------- | ----------------------------- | ------------|
| 1 to 13  |Visual Studio CE 2015 Update 1 | Windows     |
| 1 to 13  |SysInternals Tools             | Windows     |
| 1 to 13  |CLR Profiler                   | Windows     |

##Related C# and .NET Products:
* [C# 6 and .NET Core 1.0: Modern Cross-Platform Development](https://www.packtpub.com/application-development/c-6-and-net-core-10?utm_source=github&utm_campaign=9781785285691&utm_medium=repository)
* [Reactive Programming for .NET Developers](https://www.packtpub.com/web-development/reactive-programming-net-developers?utm_source=github&utm_campaign=9781785882883&utm_medium=repository)
* [C# Programming Cookbook](https://www.packtpub.com/application-development/c-programming-cookbook?utm_source=github&utm_campaign=9781786467300&utm_medium=repositoryc)






### Suggestions and Feedback
[Click here] (https://docs.google.com/forms/d/e/1FAIpQLSe5qwunkGf6PUvzPirPDtuy1Du5Rlzew23UBp2S-P3wB-GcwQ/viewform) if you have any feedback or suggestions.
