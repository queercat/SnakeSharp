# Design Document
> We're making Snake in C#.

# Project Setup
> We'll need to create a new console project.

```sh
dotnet new console
```

You should now see a whole host of new files in the solution explorer (but not solution).

![image](https://github.com/queercat/SnakeSharp/assets/22136781/68afcf6a-8098-451a-ac8b-2b240555788f)

The file that defines how to build and run our application is our `SnakeSharp.csproj` file. Solution and `.csproj` files make it so that we can run, build, and links parts of our applications together.

```xml
<Project Sdk="Microsoft.NET.Sdk">

  <PropertyGroup>
    <OutputType>Exe</OutputType>
    <TargetFramework>net8.0</TargetFramework>
    <ImplicitUsings>enable</ImplicitUsings>
    <Nullable>enable</Nullable>
  </PropertyGroup>

</Project>
```

Inspecting it we see that it just defines our application as an executable, targeting the .NET 8 framework version, and that we can use nullable and implicit using declarations.

You can build your project with `dotnet build` and you can actually run your project with `dotnet run`. Your IDE abstracts away a lot of this for you.
