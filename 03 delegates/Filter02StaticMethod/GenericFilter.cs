using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BFH
{
    public class GenericFilter
    {
        public delegate bool FilterProc<T>(T t);

        public static T[] GetSubset<T>(T[] source, FilterProc<T> filter)
        {
            if (source == null)
                return null;

            if (filter == null)
                return source;

            List<T> res = new List<T>();

            foreach (T t in source)
            {
                if (filter(t))
                    res.Add(t);
            }

            return res.ToArray();
        }

    }
}
