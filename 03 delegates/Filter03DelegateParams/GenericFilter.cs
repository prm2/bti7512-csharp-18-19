using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BFH
{
    public class GenericFilter<T>
    {
        public delegate bool FilterProc(T t);

        public FilterProc Filter { get; set; }

        public T[] GetSubset(T[] source, params FilterProc[] filter)
        {
            if (source == null)
                return null;

            if (filter == null)
                return source;

            List<T> res = new List<T>();

            foreach (T t in source)
            {
                bool inRes = true;
                for (int i = 0; i < filter.Length; i++)
                    if ((filter[i] != null) && (!filter[i](t)))
                        inRes = false;
                if (inRes)
                    res.Add(t);
            }

            return res.ToArray();
        }

    }
}
