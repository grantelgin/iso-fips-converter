using System;
using System.Data;
using System.Configuration;
using System.Text.RegularExpressions;

/// <summary>
/// Summary description for TimeLib
/// </summary>
public class TimeLib
{
    private string[] ZodiacSigns = { };
    public enum ZodiacSign
    {
        Aquarius,
        Aries,
        Cancer,
        Capricorn,
        Gemini,
        Leo,
        Libra,
        Pisces,
        Sagittarius,
        Scorpio,
        Taurus,
        Virgo
        /*
         Aquarius 	    Jan. 20-Feb 18
         Aries 	        March 21-April 19
         Cancer 	    June 21-July 22
         Capricorn 	    Dec. 22-Jan. 19
         Gemini 	    May 21-June 20
         Leo 	        July 23- Aug. 22
         Libra 	        Sept. 23- Oct. 22
         Pisces 	    Feb. 19-March 20
         Sagittarius 	Nov. 22-Dec. 21
         Scorpio 	    Oct. 23- Nov. 21
         Taurus 	    April 20-May 20
         Virgo 	        Aug. 23-Sept. 22
        */
    }
    public TimeLib()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    /// <summary>
    /// Get current month number since january 2000 (jan 2000 = 1)
    /// </summary>
    /// <returns>Number representing months since januar 2000</returns>
    public static Int16 GetUniqueMonth()
    {
        return (short)(((DateTime.Now.Year - 2000) * 12) + DateTime.Now.Month);
    }

    /// <summary>
    /// Get month count since january 2000 (jan 2000 = 1)
    /// </summary>
    /// <param name="date">DateTime after jan 2000</param>
    /// <returns>Number representing months since januar 2000 relative [date]</returns>
    public static Int16 GetUniqueMonth(DateTime date)
    {
        return (short)(((date.Year - 2000) * 12) + date.Month);
    }

    /// <summary>
    /// Get month count since january 2000 (jan 2000 = 1)
    /// </summary>
    /// <param name="datestr">String in the form 2008-11</param>
    /// <returns></returns>
    public static Int16 GetUniqueMonth(string datestr)
    {
        if (datestr == null)
        {
            return 1;
        }
        else if (datestr[4] != '-')
        {
            return 1;
        }

        try
        {
            string[] parts = datestr.Split('-');


            Int16 y = (short)int.Parse(parts[0]);
            Int16 m = (short)int.Parse(parts[1]);

            return (short)(((y - 2000) * 12) + m);
        }
        catch
        {
            return 1;
        }
    }


    /// <summary>
    /// Returns current date as a string in the form YYYY-[month number]-01
    /// </summary>
    /// <returns></returns>
    public static string GetDateAsStatsString()
    {
        return GetDateAsStatsString(DateTime.Now);
    }

    public DateTime UniqueMonthToDateTime(Int16 um)
    {
        DateTime dt = new DateTime(2000, 1, 1, 0, 0, 0);

        return dt.AddMonths(um);


    }

    /// <summary>
    /// Returns param date as a string in the form YYYY-[month number]-01
    /// </summary>
    /// <returns></returns>
    public static string GetDateAsStatsString(DateTime d)
    {
        return String.Format("{0}-{1}-01", d.Year, StringLib.PadInt(d.Month, 2));
    }

    /// <summary>
    /// str in the form 2009-03-31
    /// </summary>
    /// <param name="str">str in the form 2009-03-31</param>
    /// <returns></returns>
    public static DateTime StatsDateStringtoDateTimeDef(string str, DateTime defaultDt)
    {
        string[] parts = str.Split('-');

        if (parts.Length != 3)
        {
            return defaultDt;
        }
        else if ((!StringLib.IsInt(parts[0])) || (!StringLib.IsInt(parts[1])) || (!StringLib.IsInt(parts[2])))
        {
            return defaultDt;
        }

        return new DateTime(int.Parse(parts[0]), int.Parse(parts[1]), int.Parse(parts[2]));
    }

    public static short GetDayCountForUniqueMonth(short UniqueMonth)
    {
        int year = 0;
        int monthOfYear = 0;

        year = 2000 + (UniqueMonth / 12);
        monthOfYear = UniqueMonth % 12;

        return Convert.ToSByte(DateTime.DaysInMonth(year, monthOfYear));



    }

    public static ZodiacSign GetStarSign(DateTime birthDate)
    {
        int month = birthDate.Month;
        int day = birthDate.Day;

        switch (month)
        {
            /*Aries 	 March 21-April 19
              Taurus 	 April 20-May 20
              Gemini 	 May 21-June 20
              Cancer 	 June 21-July 22
              Leo 	 July 23- Aug. 22
              Virgo 	 Aug. 23-Sept. 22
            	    	
              Libra 	 Sept. 23- Oct. 22
              Scorpio 	 Oct. 23- Nov. 21
              Sagittarius 	 Nov. 22-Dec. 21
              Capricorn 	 Dec. 22-Jan. 19
              Aquarius 	 Jan. 20-Feb 18
              Pisces 	 Feb. 19-March 20*/
            case 1:
                if (day <= 19)
                    return ZodiacSign.Capricorn;
                else
                    return ZodiacSign.Aquarius;

            case 2:
                if (day <= 18)
                    return ZodiacSign.Aquarius;
                else
                    return ZodiacSign.Pisces;

            case 3:
                if (day <= 20)
                    return ZodiacSign.Pisces;
                else
                    return ZodiacSign.Aries;

            case 4:
                if (day <= 19)
                    return ZodiacSign.Aries;
                else
                    return ZodiacSign.Taurus;

            case 5:
                if (day <= 20)
                    return ZodiacSign.Taurus;
                else
                    return ZodiacSign.Gemini;

            case 6:
                if (day <= 20)
                    return ZodiacSign.Gemini;
                else
                    return ZodiacSign.Cancer;

            case 7:
                if (day <= 22)
                    return ZodiacSign.Cancer;
                else
                    return ZodiacSign.Leo;

            case 8:
                if (day <= 22)
                    return ZodiacSign.Leo;
                else
                    return ZodiacSign.Virgo;

            case 9:
                if (day <= 22)
                    return ZodiacSign.Virgo;
                else
                    return ZodiacSign.Libra;

            case 10:
                if (day <= 22)
                    return ZodiacSign.Libra;
                else
                    return ZodiacSign.Scorpio;

            case 11:
                if (day <= 21)
                    return ZodiacSign.Scorpio;
                else
                    return ZodiacSign.Sagittarius;

            case 12:
                if (day <= 21)
                    return ZodiacSign.Sagittarius;
                else
                    return ZodiacSign.Capricorn;

            default:
                return ZodiacSign.Libra;
        }
    }

    public static string GetStarSignStr(DateTime birthDate)
    {
        int month = birthDate.Month;
        int day = birthDate.Day;

        switch (month)
        {
            /*Aries 	 March 21-April 19
              Taurus 	 April 20-May 20
              Gemini 	 May 21-June 20
              Cancer 	 June 21-July 22
              Leo 	 July 23- Aug. 22
              Virgo 	 Aug. 23-Sept. 22
            	    	
              Libra 	 Sept. 23- Oct. 22
              Scorpio 	 Oct. 23- Nov. 21
              Sagittarius 	 Nov. 22-Dec. 21
              Capricorn 	 Dec. 22-Jan. 19
              Aquarius 	 Jan. 20-Feb 18
              Pisces 	 Feb. 19-March 20*/
            case 1:
                if (day <= 19)
                    return "Capricorn";
                else
                    return "Aquarius";

            case 2:
                if (day <= 18)
                    return "Aquarius";
                else
                    return "Pisces";

            case 3:
                if (day <= 20)
                    return "Pisces";
                else
                    return "Aries";

            case 4:
                if (day <= 19)
                    return "Aries";
                else
                    return "Taurus";

            case 5:
                if (day <= 20)
                    return "Taurus";
                else
                    return "Gemini";

            case 6:
                if (day <= 20)
                    return "Gemini";
                else
                    return "Cancer";

            case 7:
                if (day <= 22)
                    return "Cancer";
                else
                    return "Leo";

            case 8:
                if (day <= 22)
                    return "Leo";
                else
                    return "Virgo";

            case 9:
                if (day <= 22)
                    return "Virgo";
                else
                    return "Libra";

            case 10:
                if (day <= 22)
                    return "Libra";
                else
                    return "Scorpio";

            case 11:
                if (day <= 21)
                    return "Scorpio";
                else
                    return "Sagittarius";

            case 12:
                if (day <= 21)
                    return "Sagittarius";
                else
                    return "Capricorn";

            default:
                return string.Empty;
        }
    }

    public static bool IsOverTheAgeOf(DateTime dob, int ageInYears)
    {
        return dob.AddYears(ageInYears) < DateTime.Now;
    }


    public static bool IsValidStatsDateString(string statsDateStr)
    {
        //is in the form 2009-02-29

        statsDateStr = statsDateStr.Trim();
        if (statsDateStr == null)
        {
            return false;
        }
        else if (statsDateStr.Length != 10)
        {
            return false;
        }
        else
        {
            return System.Text.RegularExpressions.Regex.IsMatch(statsDateStr, @"[0-9][0-9][0-9][0-9]-[0-9][0-9]-[0-9][0-9]");
        }
    }

    public static string TimeSpanToString(TimeSpan ts1)
    {
        ts1 = ts1.Duration();

        if (ts1.Days > 0)
        {
            //x days, y hours, z mins
            if (ts1.Hours > 0)
            {
                if (ts1.Minutes > 0)
                {
                    return String.Format("{0} days, {1} hours, {2} minutes", ts1.Days, ts1.Hours, ts1.Minutes);
                }
                else
                {
                    return String.Format("{0} days, {1} hours", ts1.Days, ts1.Hours);
                }
            }
            else
            {
                if (ts1.Minutes > 0)
                {
                    return String.Format("{0} days, {1} minutes", ts1.Days, ts1.Minutes);
                }
                else
                {
                    return String.Format("{0} days", ts1.Days);
                }
            }
        }
        else if (ts1.Hours > 0)
        {
            //x hours, y minutes
            if (ts1.Minutes > 0)
            {
                return String.Format("{0} hours, {1} minutes", ts1.Hours, ts1.Minutes);
            }
            else
            {
                return String.Format("{0} hours", ts1.Hours);
            }
        }
        else if (ts1.Minutes > 0)
        {
            int mins = 1;

            if (ts1.Minutes == 0) mins = 1;
            else mins = ts1.Minutes;

            return String.Format("{0} minutes", mins);
        }
        else
        {
            return String.Format("{0} seconds", ts1.Seconds);
        }
    }

    public static string TimeSpanToString(TimeSpan ts1, out bool IsInThePast)
    {
        IsInThePast = ts1.CompareTo(ts1.Duration()) != 0;

        return TimeSpanToString(ts1);
    }

    public static bool TimePeriodOverlap(DateTime BS, DateTime BE, DateTime TS, DateTime TE)
    {
        // More simple?
        // return !((TS < BS && TE < BS) || (TS > BE && TE > BE));

        // The version below, without comments 
        /*
        return (
            (TS >= BS && TS < BE) || (TE <= BE && TE > BS) || (TS <= BS && TE >= BE)
        );
        */

        return (
            // 1. Case:
            //
            //       TS-------TE
            //    BS------BE 
            //
            // TS is after BS but before BE
            (TS >= BS && TS < BE)
            || // or

            // 2. Case
            //
            //    TS-------TE
            //        BS---------BE
            //
            // TE is before BE but after BS
            (TE <= BE && TE > BS)
            || // or

            // 3. Case
            //
            //  TS----------TE
            //     BS----BE
            //
            // TS is before BS and TE is after BE
            (TS <= BS && TE >= BE)
        );
    }

    public static bool TimePeriodOverlap(DateTime dt1, TimeSpan dts1, DateTime dt2, DateTime dts2)
    {
        return TimePeriodOverlap(dt1, dt1 + dts1, dt2, dts2);
    }


}
