using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public static class Utils
{
    public static bool IsAny<T>(this IEnumerable<T> data)
    {
        return data != null && data.Any();
    }
    public static T RandomElement<T>(this IEnumerable<T> enumerable)
    {


        return enumerable.RandomElementUsing<T>(new Random());

    }

    public static T RandomElementUsing<T>(this IEnumerable<T> enumerable, Random rand)
    {
        int index = rand.Next(0, enumerable.Count());
        return enumerable.ElementAt(index);
    }
}