A simple Calculator application using .NET Core with NUnit for testing.


mkdir CalculatorApp
cd CalculatorApp


dotnet new classlib -n CalculatorLib
dotnet new nunit -n CalculatorLib.Tests
dotnet sln CalculatorApp.sln add CalculatorLib/CalculatorLib.csproj
dotnet sln CalculatorApp.sln add CalculatorLib.Tests/CalculatorLib.Tests.csproj
dotnet add CalculatorLib.Tests reference CalculatorLib/CalculatorLib.csproj