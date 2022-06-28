# Unit Testing in C#

## Why Write Tests?
So far we've been manually testing our code, as in after we write some code, we run our code to make sure the behavior of the program matches our expected behavior. If it doesn't, then there is a bug. If there is a bug, we "debug" by tracking down which part of the program is not functioning as intended. Once we narrow down the problem and fix it, we run the program again, and make sure the fix we deployed actually fixed the problem/bug.
This has served us well so far, and you can get pretty far in this manual testing.

But what if, there is a whole team working on a piece of software, or what if, you're building a big application with many moving parts, or you plan on supporting that application for years to come?

As we write more functionality and add new features to our program, we have to make sure that not only the new feature we are adding works, but also, ALL of the pre-existing features Still work. This is okay to manually confirm when the program is small, but as the program grows, doing this manually become inefficient super quickly.

## Automated Tests
Instead of manually testing every single piece of code for its intended behavior, we write instruction for the testing frameworks to execute to make sure the code functions as it's supposed to.

### Different Types of Testing
- Unit Testing: testing the smallest subsection of code you can separate it out
- Integration Testing
- End to End Testing

## Unit Testing
Is a type of testing that is focused on testing a _small, isolated_ piece of code.
Unit testing works on the premise of if all individual, small parts work, collection of them should also work.

## xUnit
Is the testing framework for C#. 

## coverlet
is a code coverage tool- it calculates how much of your code is currently being covered by unit tests.

## NuGet Package Manager
This is where you go and find all the tools, libraries, and frameworks available in .NET Platform. Support for NuGet is integrated in .NET SDK. In order to use it, you go `dotnet add package package-name` inside your project folder. Go to [NuGet](https://www.nuget.org/) to browse which packages are available for use.

## How to initialize a testing project
We'll create a separate testing project where we'll put all our testing code
We'll take advantage of one .NET SDK's templates to get us a testing project
`dotnet new xunit -n test-project-name-here`