# Calculate the age of person

```csharp
using PayneAgeCalculator.Classes;
using PayneAgeCalculator.Models;

namespace PayneAgeCalculatorTest;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void BaseUsageTest()
    {
        DateTime birthDate = new DateTime(1956, 9, 24,13,15,10);
        Age result = birthDate.Age(new DateTime(2023,1,1,22,3,0));
            
        Console.WriteLine(birthDate.Age().YearsMonthsDays);
        Console.WriteLine(result.YearsMonthsDays);

        Console.WriteLine(result.YearsMonths);
        Console.WriteLine(result.Years);
        Console.WriteLine(result.YearsMonthsDaysTime);
        Console.WriteLine(result.YearsMonthsDaysTimeOnly);
        Console.WriteLine($"{result.YearsMonthsDays} {result.Hours}:{result.Minutes}:{result.Seconds}");


    }
}
```

Results

```
65 years 11 months 19 days
66 years 3 months 8 days
66 years 3 months
66
66 years 3 months 8 days 8:47
66 years 3 months 8 days 8:47 AM
66 years 3 months 8 days 8:47:50
```