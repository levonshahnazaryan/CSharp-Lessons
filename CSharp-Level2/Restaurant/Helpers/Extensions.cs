using System;
using System.Collections.Generic;
using System.Linq;

namespace Restaurant.Helpers
{
    public static class Extensions
    {
        public static IEnumerable<T> GetEnumsValues<T>()
        {
            return Enum.GetValues(typeof(T)).Cast<T>();
        }
    }
}