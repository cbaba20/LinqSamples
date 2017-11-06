﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queries
{
    public static class MyLinqMethod
    {
        public static IEnumerable<T> Filter<T>(this IEnumerable<T>source,Func<T,bool>predicate)
        {
            //var result = new List<T>();

            foreach (var item in source)
            {
                if (predicate(item))
                {
                    yield return item;
                }
            }

            //return result;
        }
    }
}
