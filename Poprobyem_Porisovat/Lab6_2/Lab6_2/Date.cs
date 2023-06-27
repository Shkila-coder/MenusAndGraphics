namespace Lab6_2;

public class Date
{
    private static readonly int[] DaysInMonth = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
    private static readonly string[] MonthsNames = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
    
    public int Day { get; private set; }
    public int Month { get; private set; }
    public int Year { get; private set; }

    public Date(int day, int month, int year)
    {
        if (year <= 0)
            throw new ArgumentException("Year must be positive.");
        
        if (month < 1 || month > 12)
            throw new ArgumentException("Month must be between 1 and 12.");
        
        if (day < 1 || day > DaysInMonth[month - 1] + (month == 2 && IsLeapYear(year) ? 1 : 0))
            throw new ArgumentException("Day is out of range for the given month and year.");

        Day = day;
        Month = month;
        Year = year;
    }

    public Date(Date other)
    {
        Day = other.Day;
        Month = other.Month;
        Year = other.Year;
    }

    public Date Next()
    {
        var day = Day + 1;
        var month = Month;
        var year = Year;
        
        if (day > DaysInMonth[month - 1] + (month == 2 && IsLeapYear(year) ? 1 : 0))
        {
            day = 1;
            month++;
        }
        
        if (month > 12)
        {
            month = 1;
            year++;
        }

        return new Date(day, month, year);
    }

    public Date Prev()
    {
        var day = Day - 1;
        var month = Month;
        var year = Year;
        
        if (day < 1)
        {
            month--;
            if (month < 1)
            {
                month = 12;
                year--;
            }
            day = DaysInMonth[month - 1] + (month == 2 && IsLeapYear(year) ? 1 : 0);
        }

        return new Date(day, month, year);
    }

    private static bool IsLeapYear(int year)
    {
        return year % 4 == 0 && (year % 100 != 0 || year % 400 == 0);
    }

    public bool IsLeapYear()
    {
        return IsLeapYear(Year);
    }

    public static Date operator +(Date d1, Date d2)
    {
        int day = d1.Day + d2.Day;
        int month = d1.Month + d2.Month;
        int year = d1.Year + d2.Year;
        return NormalizeDate(day, month, year);
    }

    public static Date operator -(Date d1, Date d2)
    {
        int day = d1.Day - d2.Day;
        int month = d1.Month - d2.Month;
        int year = d1.Year - d2.Year;
        return NormalizeDate(day, month, year);
    }

    public static Date operator +(Date date, int days)
    {
        return NormalizeDate(date.Day + days, date.Month, date.Year);
    }

    public static Date operator -(Date date, int days)
    {
        return NormalizeDate(date.Day - days, date.Month, date.Year);
    }

    private static Date NormalizeDate(int day, int month, int year)
    {
        while (day > DaysInMonth[month - 1] + (month == 2 && IsLeapYear(year) ? 1 : 0))
        {
            day -= DaysInMonth[month - 1] + (month == 2 && IsLeapYear(year) ? 1 : 0);
            month++;
            if (month > 12)
            {
                month = 1;
                year++;
            }
        }

        while (day <= 0)
        {
            month--;
            if (month <= 0)
            {
                month = 12;
                year--;
            }
            day += DaysInMonth[month - 1] + (month == 2 && IsLeapYear(year) ? 1 : 0);
        }

        return new Date(day, month, year);
    }

    public override string ToString()
    {
        return $"{Day} {MonthsNames[Month - 1]} {Year} г.";
    }
}