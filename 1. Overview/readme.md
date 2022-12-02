# Overview, Tools and Acquisition

> We'll get started with a quick overview of .NET 7: what it is, why you should care, and how to get set up to start using it.

## Prerequisites

### Visual Studio 2022 Community
It’s best if you have the latest Visual Studio 2022 (free Community level is fine), since there are some new desktop tooling enhancements in the recent previews. You’ll need the following workloads:
 * ASP.NET and web development
 * .NET desktop development
 * .NET Multi-platform App UI development

You can check to see what workloads you have installed by just running the installer (from the start menu, bring up Visual Studio Installer and click on Modify for Visual Studio 2022 if installed).

### Visual Studio Code
* Download [Visual Studio Code](https://code.visualstudio.com)

### .NET 7 SDK

Install [the latest .NET 7 SDK](https://dotnet.microsoft.com/download/dotnet/7.0) for your operating system.

### Container Tools

- [Git](https://git-scm.com/downloads)
- [Docker Desktop](https://www.docker.com/products/docker-desktop)
- [WSL2](https://docs.microsoft.com/en-us/windows/wsl/install)

## Small Labs if you Like

### Creating a new .NET 7 console application using Command Line tools

1. From the command line, run `dotnet new console`
1. Type `dotnet run` to run the application. You'll see a simple "Hello World" message.

### Exploring and Editing the Application using Visual Studio Code

1. Type `code .` to launch Visual Studio Code in the current directory.
1. Take a look at the Program.cs file.
1. Change the "Hello World" message to "Hello .NET".
1. Switch to the console and type `dotnet run` to to see the update.

### Creating a new .NET 7 application using Visual Studio 2022

1. Follow the steps in the [Building a complete .NET 7 solution on Windows, using Visual Studio 2022](https://docs.microsoft.com/en-us/dotnet/articles/core/tutorials/using-on-windows-full-solution) tutorial.
    > Note: If you'd like simpler one to get started, you can first complete the [Building a C# Hello World application with .NET 7 in Visual Studio 2022](https://docs.microsoft.com/en-us/dotnet/articles/csharp/getting-started/with-visual-studio) tutorial.

### Extra Credit: Create a Class Library and Xunit test solution

List available options from `dotnet new`:
```csharp
dotnet new
```
Now create a solution with a class library and a test project:
```csharp
dotnet new sln -o MyApp
cd MyApp
dotnet new classlib -o MyApp
dotnet new xunit -o MyApp.Test
dotnet sln add MyApp/MyApp.csproj
dotnet sln add MyApp.Test/MyApp.Test.csproj
cd MyApp.Test
dotnet add reference ../MyApp/MyApp.csproj
dotnet restore
dotnet build
dotnet test
```