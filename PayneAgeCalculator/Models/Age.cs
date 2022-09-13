namespace PayneAgeCalculator.Models;

public class Age
{
    public int Years { get; set; }
    public int Months { get; set; }
    public int Days { get; set; }
    public int Hours { get; set; }
    public int Minutes { get; set; }
    public int Seconds { get; set; }
    public int Milliseconds { get; set; }
    /// <summary>
    /// Date to calculate off of a later date
    /// </summary>
    public DateTime From { get; set; }
    /// <summary>
    /// Date to calculate off a earlier date
    /// </summary>
    public DateTime To { get; set; }

    /// <summary>
    /// Returns yyyy years mm months dd days
    /// </summary>
    public string YearsMonthsDays => $"{Years} years {Months} months {Days} days";
    /// <summary>
    /// Returns yyyy years mm months dd days HH hours:MM minutes
    /// </summary>
    public string YearsMonthsDaysTime => $"{Years} years {Months} months {Days} days {Hours}:{Minutes}";
    /// <summary>
    /// Returns yyyy years mm months dd days HH hours:MM minutes AM/PM
    /// </summary>
    public string YearsMonthsDaysTimeOnly => $"{Years} years {Months} months {Days} days {new TimeOnly(Hours,Minutes)}";
    /// <summary>
    /// Returns yyyy years mm months
    /// </summary>
    public string YearsMonths => $"{Years} years {Months} months";
}