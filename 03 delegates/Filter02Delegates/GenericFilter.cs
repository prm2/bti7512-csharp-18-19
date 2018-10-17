using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BFH
{
    public class GenericFilter<T>
    {
        public delegate bool FilterProc(T t);

        public T[] GetSubset(T[] source, FilterProc filter)
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
