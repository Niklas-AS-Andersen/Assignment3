using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace BDSA2020.Assignment02
{
    public static class Extensions
    {
        public static IEnumerable<T> Flatten<T> (this IEnumerable<IEnumerable<T>> items) 
        {
            foreach (var item in items)
            {
                foreach (var it in item)
                {
                    yield return it;
                }
            }
        }

        public static IEnumerable<T> Filter<T> (this IEnumerable<T> items, Predicate<T> predicate)
        {
            foreach (var item in items)
            {
                if (predicate(item))
                {
                    yield return item;
                }
            }
        }

        public static bool IsSecure(this Uri uri)
        {
            return uri.Scheme.Equals("https");
        }

        public static int WordCount(this string str)
        {
            /* char[] delimiterChars = { ' ', ',', '.', ':', '\t' };

            // var reg = new Regex("\\P{L}");

            return str.Split(delimiterChars).Length; */

            return str.Split(
                new char[] {' ', ',', '.', '?', '!'},
                StringSplitOptions.RemoveEmptyEntries).Length;
        }
    }
}
