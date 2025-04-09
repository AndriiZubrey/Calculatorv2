var target = Argument("target", "Run");
var configuration = Argument("configuration", "Release");

Task("Clean")
    .Does(() =>
{
    CleanDirectory("./CalculatorMVC/bin/" + configuration);
    CleanDirectory("./CalculatorMVC/obj/" + configuration);
    CleanDirectory("./CalculatorMVCTests/bin/" + configuration);
    CleanDirectory("./CalculatorMVCTests/obj/" + configuration);
});

Task("Restore")
    .IsDependentOn("Clean")
    .Does(() =>
{
    DotNetRestore("./Calculator.sln");
});

Task("Build")
    .IsDependentOn("Restore")
    .Does(() =>
{
    DotNetBuild("./Calculator.sln", new DotNetBuildSettings
    {
        Configuration = configuration
    });
});

Task("Test")
    .IsDependentOn("Build")
    .Does(() =>
{
    DotNetTest("./CalculatorMVCTests/CalculatorMVCTests.csproj", new DotNetTestSettings
    {
        Configuration = configuration,
        NoBuild = true
    });
});

Task("Run")
    .IsDependentOn("Test")
    .Does(() =>
{
    StartProcess("dotnet", new ProcessSettings
    {
        Arguments = $"run --project ./CalculatorMVC/CalculatorMVC.csproj --configuration {configuration}"
    });
});

RunTarget(target);
