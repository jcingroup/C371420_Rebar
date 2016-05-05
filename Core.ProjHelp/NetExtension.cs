﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;

namespace ProcCore.NetExtension
{
    public static class ExtensionDateTime
    {
        public static string ToStandardDate(this DateTime dt)
        {
            return dt.ToString("yyyy/MM/dd");
        }
        public static string ToStandardTime(this DateTime dt)
        {
            return dt.ToString("HH:mm:ss");
        }
        public static string ToStandardDateTime(this DateTime dt)
        {
            return dt.ToString("yyyy/MM/dd HH:mm:ss");
        }
        public static string ToStandardDateTime2(this DateTime dt)
        {
            return dt.ToString("yyyy-MM-dd HH:mm:ss");
        }

        public static string ToOnlyStandardDate(this DateTime dt)
        {
            return dt.ToString("yyyy-MM-dd") + " 00:00:00";
        }

        public static string To民國年(this DateTime dt)
        {
            return (dt.Year - 1911).ToString() + dt.ToString("/MM/dd");
        }
        public static DateTime MonthLastDay(this DateTime dt)
        {
            String s = dt.Year + "/" + dt.Month + "/" + DateTime.DaysInMonth(dt.Year, dt.Month);
            return DateTime.Parse(s);
        }
        public static DateTime MonthFirstDay(this DateTime dt)
        {
            String s = dt.Year + "/" + dt.Month + "/1";
            return DateTime.Parse(s);
        }
        public static int WeekNo(this DateTime dt)
        {
            if (dt.DayOfWeek == DayOfWeek.Sunday)
            {
                return 0;
            }
            if (dt.DayOfWeek == DayOfWeek.Monday)
            {
                return 1;
            }
            if (dt.DayOfWeek == DayOfWeek.Tuesday)
            {
                return 2;
            }
            if (dt.DayOfWeek == DayOfWeek.Wednesday)
            {
                return 3;
            }
            if (dt.DayOfWeek == DayOfWeek.Thursday)
            {
                return 4;
            }
            if (dt.DayOfWeek == DayOfWeek.Friday)
            {
                return 5;
            }
            if (dt.DayOfWeek == DayOfWeek.Saturday)
            {
                return 6;
            }
            else
            {
                return 0;
            }
        }

        /// <summary>
        /// 行事曆元件計算用
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public static DateTime CalendarFirstDay(this DateTime dt)
        {
            DateTime f = dt.MonthFirstDay();
            int w = f.WeekNo();
            DateTime g = f.AddDays(0 - w);
            return g;
        }
        /// <summary>
        /// 行事曆元件計算用
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public static DateTime CalendarLastDay(this DateTime dt)
        {
            DateTime f = dt.MonthLastDay();
            int w = f.WeekNo();
            DateTime g = f.AddDays(6 - w);
            return g;
        }

        public static DateTime WeekFirstDay(this DateTime dt)
        {
            int w = dt.WeekNo();
            DateTime g = dt.AddDays(0 - w);
            return g;
        }
        public static DateTime WeekLastDay(this DateTime dt)
        {
            int w = dt.WeekNo();
            DateTime g = dt.AddDays(6 - w);
            return g;
        }
    }

    public static class ExtensionInt
    {
        public static String[] ToStringArray(this int[] s)
        {

            List<String> r = new List<String>();
            foreach (int i in s)
            {
                r.Add(i.ToString());
            }
            return r.ToArray();
        }
    }

    public static class ExtensionString
    {
        public static String JoinArray(this String[] s, String JoinChar)
        {
            String r = String.Join(JoinChar, s);
            return r;
        }
        public static String GetFileExt(this String s)
        {
            int c = s.LastIndexOf('.');
            String r = String.Empty;
            if (c > 0)
                r = s.Substring(c);
            else
                r = "";

            return r.ToLower();
        }
        public static String GetFileName(this String s)
        {
            int c = s.LastIndexOf('\\');
            string r = string.Empty;
            if (c > 0)
            {
                r = s.Substring(c);
            }
            else
            {
                c = s.LastIndexOf('/');
                if (c > 0)
                {
                    r = s.Substring(c);
                }
                else
                {
                    r = s;
                }
            }
            return r;
        }
        public static String Right(this String s, int n)
        {
            return s.Substring(n > s.Length ? 0 : s.Length - n);
        }
        public static String Left(this String s, int n)
        {
            return s.Substring(0, n > s.Length ? s.Length : n);
        }

        #region 繁簡轉換
        private const int LocaleSystemDefault = 0x0800;
        private const int LcmapSimplifiedChinese = 0x02000000;
        private const int LcmapTraditionalChinese = 0x04000000;

        [DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern int LCMapString(int locale, int dwMapFlags, string lpSrcStr, int cchSrc,
                                              [Out] string lpDestStr, int cchDest);
        public static String ToSimplified(this String argSource)
        {
            var t = new String(' ', argSource.Length);
            LCMapString(LocaleSystemDefault, LcmapSimplifiedChinese, argSource, argSource.Length, t, argSource.Length);
            return t;
        }
        public static String ToTraditional(this String argSource)
        {
            var t = new String(' ', argSource.Length);
            LCMapString(LocaleSystemDefault, LcmapTraditionalChinese, argSource, argSource.Length, t, argSource.Length);
            return t;
        }
        #endregion
    }

    public static class ExtensionBoolean
    {
        public static String BooleanValue(this Boolean s, string TrueString, string FalseString)
        {
            if (s) return TrueString; else return FalseString;
        }
    }
    public static class ExtensionObject
    {
        public static int CInt(this object o)
        {
            return int.Parse(o.ToString());
        }
    }
}