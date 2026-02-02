using System;
using Microsoft.EntityFrameworkCore.Diagnostics;
using NodaTime;

// ReSharper disable once CheckNamespace
namespace Microsoft.EntityFrameworkCore;

public static class InMemoryNodaTimeDbFunctionsExtensions
{
    public static int DateDiffYear(this DbFunctions _, LocalDate startDate, LocalDate endDate)
        => endDate.Year - startDate.Year;

    public static int? DateDiffYear(this DbFunctions _, LocalDate? startDate, LocalDate? endDate)
        => (startDate.HasValue && endDate.HasValue) ? endDate.Value.Year - startDate.Value.Year : null;

    public static int DateDiffYear(this DbFunctions _, LocalDateTime startDateTime, LocalDateTime endDateTime)
        => endDateTime.Year - startDateTime.Year;

    public static int? DateDiffYear(this DbFunctions _, LocalDateTime? startDateTime, LocalDateTime? endDateTime)
        => (startDateTime.HasValue && endDateTime.HasValue) ? endDateTime.Value.Year - startDateTime.Value.Year : null;

    public static int DateDiffMonth(this DbFunctions _, LocalDate startDate, LocalDate endDate)
        => (endDate.Year - startDate.Year) * 12 + endDate.Month - startDate.Month;

    public static int? DateDiffMonth(this DbFunctions _, LocalDate? startDate, LocalDate? endDate)
        => (startDate.HasValue && endDate.HasValue) ? (endDate.Value.Year - startDate.Value.Year) * 12 + endDate.Value.Month - startDate.Value.Month : null;

    public static int DateDiffMonth(this DbFunctions _, LocalDateTime startDateTime, LocalDateTime endDateTime)
        => (endDateTime.Year - startDateTime.Year) * 12 + endDateTime.Month - startDateTime.Month;

    public static int? DateDiffMonth(this DbFunctions _, LocalDateTime? startDateTime, LocalDateTime? endDateTime)
        => (startDateTime.HasValue && endDateTime.HasValue) ? (endDateTime.Value.Year - startDateTime.Value.Year) * 12 + endDateTime.Value.Month - startDateTime.Value.Month : null;

    public static int DateDiffWeek(this DbFunctions _, LocalDate startDate, LocalDate endDate)
        => (int)Period.Between(startDate, endDate, PeriodUnits.Weeks).Weeks;

    public static int? DateDiffWeek(this DbFunctions _, LocalDate? startDate, LocalDate? endDate)
        => (startDate.HasValue && endDate.HasValue) ? (int)Period.Between(startDate.Value, endDate.Value, PeriodUnits.Weeks).Weeks : null;

    public static int DateDiffWeek(this DbFunctions _, LocalDateTime startDateTime, LocalDateTime endDateTime)
        => (int)Period.Between(startDateTime, endDateTime, PeriodUnits.Weeks).Weeks;

    public static int? DateDiffWeek(this DbFunctions _, LocalDateTime? startDateTime, LocalDateTime? endDateTime)
        => (startDateTime.HasValue && endDateTime.HasValue) ? (int)Period.Between(startDateTime.Value, endDateTime.Value, PeriodUnits.Weeks).Weeks : null;

    public static int DateDiffDay(this DbFunctions _, LocalDate startDate, LocalDate endDate)
        => (int)Period.Between(startDate, endDate, PeriodUnits.Days).Days;

    public static int? DateDiffDay(this DbFunctions _, LocalDate? startDate, LocalDate? endDate)
        => (startDate.HasValue && endDate.HasValue) ? (int)Period.Between(startDate.Value, endDate.Value, PeriodUnits.Days).Days : null;

    public static int DateDiffDay(this DbFunctions _, LocalDateTime startDateTime, LocalDateTime endDateTime)
        => (int)Period.Between(startDateTime, endDateTime, PeriodUnits.Days).Days;

    public static int? DateDiffDay(this DbFunctions _, LocalDateTime? startDateTime, LocalDateTime? endDateTime)
        => (startDateTime.HasValue && endDateTime.HasValue) ? (int)Period.Between(startDateTime.Value, endDateTime.Value, PeriodUnits.Days).Days : null;

    public static int DateDiffHour(this DbFunctions _, LocalDateTime startDateTime, LocalDate endDateTime)
        => (int)Period.Between(startDateTime, endDateTime.AtMidnight(), PeriodUnits.Hours).Hours;

    public static int? DateDiffHour(this DbFunctions _, LocalDateTime? startDateTime, LocalDateTime? endDateTime)
        => (startDateTime.HasValue && endDateTime.HasValue) ? (int)Period.Between(startDateTime.Value, endDateTime.Value, PeriodUnits.Hours).Hours : null;

    public static int DateDiffHour(this DbFunctions _, LocalTime startTime, LocalTime endTime)
        => (int)Period.Between(startTime, endTime, PeriodUnits.Hours).Hours;

    public static int? DateDiffHour(this DbFunctions _, LocalTime? startTime, LocalTime? endTime)
        => (startTime.HasValue && endTime.HasValue) ? (int)Period.Between(startTime.Value, endTime.Value, PeriodUnits.Hours).Hours : null;

    public static int DateDiffMinute(this DbFunctions _, LocalDateTime startDateTime, LocalDateTime endDateTime)
        => (int)Period.Between(startDateTime, endDateTime, PeriodUnits.Minutes).Minutes;

    public static int? DateDiffMinute(this DbFunctions _, LocalDateTime? startDateTime, LocalDateTime? endDateTime)
        => (startDateTime.HasValue && endDateTime.HasValue) ? (int)Period.Between(startDateTime.Value, endDateTime.Value, PeriodUnits.Minutes).Minutes : null;

    public static int DateDiffMinute(this DbFunctions _, LocalTime startTime, LocalTime endTime)
        => (int)Period.Between(startTime, endTime, PeriodUnits.Minutes).Minutes;

    public static int? DateDiffMinute(this DbFunctions _, LocalTime? startTime, LocalTime? endTime)
        => (startTime.HasValue && endTime.HasValue) ? (int)Period.Between(startTime.Value, endTime.Value, PeriodUnits.Minutes).Minutes : null;

    public static int DateDiffSecond(this DbFunctions _, LocalDateTime startDateTime, LocalDateTime endDateTime)
        => (int)Period.Between(startDateTime, endDateTime, PeriodUnits.Seconds).Seconds;

    public static int? DateDiffSecond(this DbFunctions _, LocalDateTime? startDateTime, LocalDateTime? endDateTime)
        => (startDateTime.HasValue && endDateTime.HasValue) ? (int)Period.Between(startDateTime.Value, endDateTime.Value, PeriodUnits.Seconds).Seconds : null;

    public static int DateDiffSecond(this DbFunctions _, LocalTime startTime, LocalTime endTime)
        => (int)Period.Between(startTime, endTime, PeriodUnits.Seconds).Seconds;

    public static int? DateDiffSecond(this DbFunctions _, LocalTime? startTime, LocalTime? endTime)
        => (startTime.HasValue && endTime.HasValue) ? (int)Period.Between(startTime.Value, endTime.Value, PeriodUnits.Seconds).Seconds : null;

    public static int DateDiffMillisecond(this DbFunctions _, LocalDateTime startDateTime, LocalDateTime endDateTime)
        => (int)Period.Between(startDateTime, endDateTime, PeriodUnits.Milliseconds).Milliseconds;

    public static int? DateDiffMillisecond(this DbFunctions _, LocalDateTime? startDateTime, LocalDateTime? endDateTime)
        => (startDateTime.HasValue && endDateTime.HasValue) ? (int)Period.Between(startDateTime.Value, endDateTime.Value, PeriodUnits.Milliseconds).Milliseconds : null;

    public static int DateDiffMillisecond(this DbFunctions _, LocalTime startTime, LocalTime endTime)
        => (int)Period.Between(startTime, endTime, PeriodUnits.Milliseconds).Milliseconds;

    public static int? DateDiffMillisecond(this DbFunctions _, LocalTime? startTime, LocalTime? endTime)
        => (startTime.HasValue && endTime.HasValue) ? (int)Period.Between(startTime.Value, endTime.Value, PeriodUnits.Milliseconds).Milliseconds : null;
}