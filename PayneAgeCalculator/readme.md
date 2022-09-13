# Payne Age Calculator

Calculates the age of person



Provide a date in the past using today as the date to calulate too.
```csharp
DateTime birthDate = new DateTime(1956, 9, 24);
Console.WriteLine(birthDate.Age().YearsMonthsDays);
```

Provide a date in the past and a future date
```csharp
var result = birthDate.Age(DateTime.Now);
Console.WriteLine(result.YearsMonthsDays);
```

Include hours and minutes

```csharp
Console.WriteLine($"{result.YearsMonthsDays} {result.Hours}:{result.Minutes}");
```

Or

```csharp
Console.WriteLine(result.YearsMonthsDaysTime);
```

Include seconds

```csharp
Console.WriteLine($"{result.YearsMonthsDays} {result.Hours}:{result.Minutes}:{result.Seconds}");
```


# See also

NuGet package [myage](https://www.nuget.org/packages/myage/) which is the same as this library but a dotnet tool.
