using System;
using System.Collections.Generic;
using System.Linq;

namespace Org.Webelopers.Api.Extensions
{
    public static class EnumerableHelper<TE>
    {
        public static readonly Random randomInstance;

        static EnumerableHelper()
        {
            randomInstance = new Random();
        }

        public static T Random<T>(IEnumerable<T> input)
        {
            IEnumerable<T> enumerable = input.ToList();
            return enumerable.ElementAt(randomInstance.Next(enumerable.Count()));
        }
    }

    public static class RandomGetter
    {
        public static Random Get() => EnumerableHelper<object>.randomInstance;
    }
    
    public static class EnumerableExtensions // linq get random item from list https://stackoverflow.com/a/15960665
    {
        public static T Random<T>(this IEnumerable<T> input) => 
            EnumerableHelper<T>.Random(input);

        public static IEnumerable<T> Shuffle<T>(this IEnumerable<T> input) =>
            input.OrderBy(arg => RandomGetter.Get().Next());
    }
}