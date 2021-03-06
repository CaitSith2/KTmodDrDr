﻿sealed class CorrectDates
{
    public int Day;
    public int Month;

    private static int[] _monthLengths = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
    private static int[] _leapMonthLengths = { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
    public int DayInYear(bool leapYear)
    {
        var value = Day;
        for (int i = 0; i < Month - 1; i++)
            value += (leapYear ? _leapMonthLengths : _monthLengths)[i];
        return value;
    }
}