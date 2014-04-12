using System.Collections.Generic;

                                                                                                                            // ReSharper disable CheckNamespace
namespace System.Linq
                                                                                                                            // ReSharper restore CheckNamespace
{
    public static class StringExtensions
    {
        /// <summary>
        /// Returns a substring from the start of a string with specified length.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.String"/> that contains at least the specified number of characters.
        /// </returns>
        /// <param name="source">The string to return a substring from.</param>
        /// <param name="count">The length of substring to return.</param>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> is null.</exception>
        public static string Take(this string source, int count)
        {
            if (source == null)
            {
                throw new ArgumentNullException("source");
            }
            return count <= 0 
                ? String.Empty 
                : source.Substring(0, Math.Min(count, source.Length));
        }

        /// <summary>
        /// Bypasses the specified number of starting characters and returns the remainder of the string.
        /// </summary>
        /// 
        /// <param name="source">An <see cref="T:System.String"/> to return a substring from.</param>
        /// <param name="count">The number of characters to skip before returning the remaining elements.</param>
        /// <returns>
        /// An <see cref="T:System.String"/> which is the subset of <paramref name="source"/> after skipping <paramref name="count"/> elements..
        /// </returns>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> is null.</exception>
        public static string Skip(this string source, int count)
        {
            if (source == null)
            {
                throw new ArgumentNullException("source");
            }
            return count <= 0
                       ? source
                       : count >= source.Length
                             ? String.Empty
                             : source.Substring(count);
        }


        /// <summary>
        /// Determines whether two strings are equal.
        /// </summary>
        /// 
        /// <returns>
        /// true if the two strings are equal; otherwise, false.
        /// </returns>
        /// <param name="first">An <see cref="T:System.String"/> to compare to <paramref name="second"/>.</param>
        /// <param name="second">An <see cref="T:System.String"/> to compare to the first <see cref="T:System.String"/>.</param>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="first"/> or <paramref name="second"/> is null.</exception>
        public static bool SequenceEqual(this string first, string second)
        {
            if (first == null)
            {
                throw new ArgumentNullException("first");
            }
            if (second == null)
            {
                throw new ArgumentNullException("second");
            }
            return first == second;
        }

        /// <summary>
        /// Determines whether two strings are equal by comparing their elements by using a specified <see cref="T:System.Collections.Generic.IEqualityComparer`1"/>.
        /// </summary>
        /// 
        /// <returns>
        /// true if the two strings are of equal equal according to <paramref name="comparison"/>; otherwise, false.
        /// </returns>
        /// <param name="first">An <see cref="T:System.String"/> to compare to <paramref name="second"/>.</param>
        /// <param name="second">An <see cref="T:System.String"/> to compare to the first <see cref="T:System.String"/>.</param>
        /// <param name="comparison">An <see cref="T:System.StringComparison"/> to use to compare strings.</param>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="first"/> or <paramref name="second"/> is null.</exception>
        public static bool SequenceEqual(this string first, string second, StringComparison comparison)
        {
            if (first == null)
            {
                throw new ArgumentNullException("first");
            }
            if (second == null)
            {
                throw new ArgumentNullException("second");
            }
            return string.Equals(first, second, comparison);
        }

        /// <summary>
        /// Creates an array from a <see cref="T:System.String"/>.
        /// </summary>
        /// 
        /// <returns>
        /// An array that contains the characters from the input string.
        /// </returns>
        /// <param name="source">An <see cref="T:System.String"/> to create an array from.</param>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> is null.</exception>
        public static char[] ToArray(this string source)
        {
            if (source == null)
            {
                throw new ArgumentNullException("source");
            }
            return source.ToCharArray();
        }

        /// <summary>
        /// Creates a <see cref="T:System.Collections.Generic.List`1"/> from an <see cref="T:System.String"/>.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.Collections.Generic.List`1"/> that contains elements from the input sequence.
        /// </returns>
        /// <param name="source">The <see cref="T:System.String"/> to create a <see cref="T:System.Collections.Generic.List`1"/> from.</param>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> is null.</exception>
        public static List<char> ToList(this string source)
        {
            if (source == null)
            {
                throw new ArgumentNullException("source");
            }
            return new List<char>(source.ToCharArray());
        }

        /// <summary>
        /// Returns the string.
        /// </summary>
        /// 
        /// <returns>
        /// The <paramref name="source"/>.
        /// </returns>
        /// <param name="source">The sequence to return.</param>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> is null.</exception>
        public static string DefaultIfEmpty(this string source)
        {
            if (source == null)
            {
                throw new ArgumentNullException("source");
            }
           return source == "" ? new string('\0', 1) : source;
        }

        /// <summary>
        /// Returns the first character of a string.
        /// </summary>
        /// 
        /// <returns>
        /// The first character in the specified string.
        /// </returns>
        /// <param name="source">The <see cref="T:System.String"/> to return the first character of.</param>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> is null.</exception>
        /// <exception cref="T:System.InvalidOperationException">The source string is empty.</exception>
        public static char First(this string source)
        {
            if (source == null)
            {
                throw new ArgumentNullException("source");
            }

            if (source.Length == 0)
            {
                throw new InvalidOperationException("The source string cannot be empty but is.");
            }

            return source[0];
        }

        /// <summary>
        /// Returns the first character of a string, or a default value if the string is empty.
        /// </summary>
        /// 
        /// <returns>
        /// default(<see cref="T:System.Char"/>) if <paramref name="source"/> is empty; otherwise, the first character in <paramref name="source"/>.
        /// </returns>
        /// <param name="source">The <see cref="T:System.String"/> to return the first character of.</param>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> is null.</exception>
        public static char FirstOrDefault(this string source)
        {
            if (source == null)
            {
                throw new ArgumentNullException("source");
            }
            return source.Length == 0
                       ? default(char)
                       : source[0];
        }

        /// <summary>
        /// Returns the last character of a string.
        /// </summary>
        /// 
        /// <returns>
        /// The value at the last characgter in the source string.
        /// </returns>
        /// <param name="source">A <see cref="T:System.String"/> to return the last character of.</param>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> is null.</exception>
        /// <exception cref="T:System.InvalidOperationException">The source string is empty.</exception>
        public static char Last(this string source)
        {
            if (source == null)
            {
                throw new ArgumentNullException("source");
            }
            int length = source.Length;

            if (length == 0)
            {
                throw new InvalidOperationException("Source string cannot be empty but is.");
            }

            return source[length - 1];
        }

        /// <summary>
        /// Returns the last character of a string that satisfies a specified condition.
        /// </summary>
        /// 
        /// <returns>
        /// The last character in the string that passes the test in the specified predicate function.
        /// </returns>
        /// <param name="source">An <see cref="T:System.String"/> to return a character from.</param>
        /// <param name="predicate">A function to test each character for a condition.</param>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="predicate"/> is null.</exception>
        /// <exception cref="T:System.InvalidOperationException">No character satisfies the condition in <paramref name="predicate"/>.-or-The source string is empty.</exception>
        public static char Last(this string source, Func<char, bool> predicate)
        {
            return LastImpl(source, predicate, true);
        }

        /// <summary>
        /// Returns the last element of a string, or a default value if the string is empty.
        /// </summary>
        /// 
        /// <returns>
        /// default(<see cref="T:System.Char"/>) if the source string is empty; otherwise, the last string in the <see cref="T:System.String"/>.
        /// </returns>
        /// <param name="source">A <see cref="T:System.String"/> to return the last character of.</param>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> is null.</exception>
        public static char LastOrDefault(this string source)
        {
            if (source == null)
            {
                throw new ArgumentNullException("source");
            }
            int length = source.Length;
            return length == 0
                       ? default(char)
                       : source[length - 1];
        }

        /// <summary>
        /// Returns the last character of a string that satisfies a condition or a default value if no such character is found.
        /// </summary>
        /// 
        /// <returns>
        /// default(<see cref="T:System.Char"/>) if the string is empty or if no characters pass the test in the predicate function; otherwise, the last character that passes the test in the predicate function.
        /// </returns>
        /// <param name="source">A <see cref="T:System.String"/> to return an character from.</param>
        /// <param name="predicate">A function to test each character for a condition.</param>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> or <paramref name="predicate"/> is null.</exception>
        public static char LastOrDefault(this string source, Func<char, bool> predicate)
        {
            return LastImpl(source, predicate, false);
        }

        private static char LastImpl(string source, Func<char, bool> predicate, bool throwExceptionOnEmptyOrNotFound)
        {
            if (source == null)
            {
                throw new ArgumentNullException("source");
            }
            if (predicate == null)
            {
                throw new ArgumentNullException("predicate");
            }
            int length = source.Length;

            if (length == 0)
            {
                if (throwExceptionOnEmptyOrNotFound)
                {
                    throw new InvalidOperationException("Source string cannot be empty but is.");
                }
                return default(char);

            }

            var chars = source.ToCharArray();
            int i = source.Length;
            while (i-- > 0)
            {
                var c = chars[i];
                if (predicate(c))
                {
                    return c;
                }
            }
            if (throwExceptionOnEmptyOrNotFound)
            {
                throw new InvalidOperationException("Predicate test did not match any characters in source string: " + source);
            }
            return default(char);
        }

        /// <summary>
        /// Returns the character at a specified index in a string.
        /// </summary>
        /// 
        /// <returns>
        /// The character at the specified position in the source string.
        /// </returns>
        /// <param name="source">A <see cref="T:System.String"/> to return a character from.</param>
        /// <param name="index">The zero-based index of the character to retrieve.</param>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> is null.</exception>
        /// <exception cref="T:System.ArgumentOutOfRangeException"><paramref name="index"/> is less than 0 or greater than or equal to the number of elements in <paramref name="source"/>.</exception>
        public static char ElementAt(this string source, int index)
        {
            if (source == null)
            {
                throw new ArgumentNullException("source");
            }
            if (index < 0 || index >= source.Length)
            {
                throw new ArgumentOutOfRangeException("index", index,
                                                      String.Format(
                                                          "Argument of of range. Requested character index {0} of a string with {1} characters.",
                                                          index,
                                                          source.Length));
            }
            return source[index];
        }

        /// <summary>
        /// Returns the character at a specified index in a string or a default value if the index is out of range.
        /// </summary>
        /// 
        /// <returns>
        /// default(<see cref="T:System.Char"/>) if the index is outside the bounds of the source string; otherwise, the character at the specified position in the source string.
        /// </returns>
        /// <param name="source">A <see cref="T:System.String"/> to return a character from.</param>
        /// <param name="index">The zero-based index of the character to retrieve.</param>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> is null.</exception>
        public static char ElementAtOrDefault(this string source, int index)
        {
            if (source == null)
            {
                throw new ArgumentNullException("source");
            }
            if (index < 0 || index >= source.Length)
            {
                return default(char);
            }
            return source[index];
        }

        /// <summary>
        /// Determines whether a string contains any elements (opposite of empty).
        /// </summary>
        /// 
        /// <returns>
        /// true if the source string contains any characters; otherwise, false.
        /// </returns>
        /// <param name="source">The <see cref="T:System.String"/> to check for emptiness.</param>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> is null.</exception>
        public static bool Any(this string source)
        {
            if (source == null)
            {
                throw new ArgumentNullException("source");
            }
            return source.Length != 0;
        }



        /// <summary>
        /// Returns the number of characters in a string.
        /// </summary>
        /// 
        /// <returns>
        /// The number of characters in the input string.
        /// </returns>
        /// <param name="source">A string that contains characters to be counted.</param>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> is null.</exception>
        public static int Count(this string source)
        {
            if (source == null)
            {
                throw new ArgumentNullException("source");
            }
            return source.Length;
        }


        /// <summary>
        /// Returns an <see cref="T:System.Int64"/> that represents the total number of characters in a string.
        /// </summary>
        /// 
        /// <returns>
        /// The number of characters in the source string.
        /// </returns>
        /// <param name="source">An <see cref="T:System.String"/> that contains the characters to be counted.</param>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> is null.</exception>
        public static long LongCount(this string source)
        {
            if (source == null)
            {
                throw new ArgumentNullException("source");
            }
            return source.Length;
        }

        /// <summary>
        /// Determines whether a string contains a specified character by using the default equality comparer.
        /// </summary>
        /// 
        /// <returns>
        /// true if the source strings contains a character that has the specified value; otherwise, false.
        /// </returns>
        /// <param name="source">A string in which to locate a value.</param>
        /// <param name="value">The value to locate in the sequence.</param>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="source"/> is null.</exception>
        public static bool Contains(this string source, char value)
        {
            if (source == null)
            {
                throw new ArgumentNullException("source");
            }
            return source.IndexOf(value) >= 0;
        }

        //
        // Other Enumerable methods that I have not optimized for strings, most of which cannot be optimized for strings
        // or make no sense in context of strings.
        //
        //public static string Where(this string source, Func<string, bool> predicate)
        //public static string Where(this string source, Func<string, int, bool> predicate)
        //public static IEnumerable<TResult> Select<string, TResult>(this string source, Func<string, TResult> selector)
        //public static IEnumerable<TResult> Select<string, TResult>(this string source, Func<string, int, TResult> selector)
        //public static IEnumerable<TResult> SelectMany<string, TResult>(this string source, Func<string, IEnumerable<TResult>> selector)
        //public static IEnumerable<TResult> SelectMany<string, TResult>(this string source, Func<string, int, IEnumerable<TResult>> selector)
        //public static IEnumerable<TResult> SelectMany<string, TCollection, TResult>(this string source, Func<string, int, IEnumerable<TCollection>> collectionSelector, Func<string, TCollection, TResult> resultSelector)
        //public static IEnumerable<TResult> SelectMany<string, TCollection, TResult>(this string source, Func<string, IEnumerable<TCollection>> collectionSelector, Func<string, TCollection, TResult> resultSelector)
        //public static string TakeWhile(this string source, Func<string, bool> predicate)
        //public static string TakeWhile(this string source, Func<string, int, bool> predicate)
        //public static string SkipWhile(this string source, Func<string, bool> predicate)
        //public static string SkipWhile(this string source, Func<string, int, bool> predicate)
        //public static IEnumerable<TResult> Join<TOuter, TInner, TKey, TResult>(this IEnumerable<TOuter> outer, IEnumerable<TInner> inner, Func<TOuter, TKey> outerKeySelector, Func<TInner, TKey> innerKeySelector, Func<TOuter, TInner, TResult> resultSelector)
        //public static IEnumerable<TResult> Join<TOuter, TInner, TKey, TResult>(this IEnumerable<TOuter> outer, IEnumerable<TInner> inner, Func<TOuter, TKey> outerKeySelector, Func<TInner, TKey> innerKeySelector, Func<TOuter, TInner, TResult> resultSelector, IEqualityComparer<TKey> comparer)
        //public static IEnumerable<TResult> GroupJoin<TOuter, TInner, TKey, TResult>(this IEnumerable<TOuter> outer, IEnumerable<TInner> inner, Func<TOuter, TKey> outerKeySelector, Func<TInner, TKey> innerKeySelector, Func<TOuter, IEnumerable<TInner>, TResult> resultSelector)
        //public static IEnumerable<TResult> GroupJoin<TOuter, TInner, TKey, TResult>(this IEnumerable<TOuter> outer, IEnumerable<TInner> inner, Func<TOuter, TKey> outerKeySelector, Func<TInner, TKey> innerKeySelector, Func<TOuter, IEnumerable<TInner>, TResult> resultSelector, IEqualityComparer<TKey> comparer)
        //public static IOrderedEnumerable OrderBy<string, TKey>(this string source, Func<string, TKey> keySelector)
        //public static IOrderedEnumerable OrderBy<string, TKey>(this string source, Func<string, TKey> keySelector, IComparer<TKey> comparer)
        //public static IOrderedEnumerable OrderByDescending<string, TKey>(this string source, Func<string, TKey> keySelector)
        //public static IOrderedEnumerable OrderByDescending<string, TKey>(this string source, Func<string, TKey> keySelector, IComparer<TKey> comparer)
        //public static IOrderedEnumerable ThenBy<string, TKey>(this IOrderedEnumerable source, Func<string, TKey> keySelector)
        //public static IOrderedEnumerable ThenBy<string, TKey>(this IOrderedEnumerable source, Func<string, TKey> keySelector, IComparer<TKey> comparer)
        //public static IOrderedEnumerable ThenByDescending<string, TKey>(this IOrderedEnumerable source, Func<string, TKey> keySelector)
        //public static IOrderedEnumerable ThenByDescending<string, TKey>(this IOrderedEnumerable source, Func<string, TKey> keySelector, IComparer<TKey> comparer)
        //public static IEnumerable<IGrouping<TKey, string>> GroupBy<string, TKey>(this string source, Func<string, TKey> keySelector)
        //public static IEnumerable<IGrouping<TKey, string>> GroupBy<string, TKey>(this string source, Func<string, TKey> keySelector, IEqualityComparer<TKey> comparer)
        //public static IEnumerable<IGrouping<TKey, TElement>> GroupBy<string, TKey, TElement>(this string source, Func<string, TKey> keySelector, Func<string, TElement> elementSelector)
        //public static IEnumerable<IGrouping<TKey, TElement>> GroupBy<string, TKey, TElement>(this string source, Func<string, TKey> keySelector, Func<string, TElement> elementSelector, IEqualityComparer<TKey> comparer)
        //public static IEnumerable<TResult> GroupBy<string, TKey, TResult>(this string source, Func<string, TKey> keySelector, Func<TKey, string, TResult> resultSelector)
        //public static IEnumerable<TResult> GroupBy<string, TKey, TElement, TResult>(this string source, Func<string, TKey> keySelector, Func<string, TElement> elementSelector, Func<TKey, IEnumerable<TElement>, TResult> resultSelector)
        //public static IEnumerable<TResult> GroupBy<string, TKey, TResult>(this string source, Func<string, TKey> keySelector, Func<TKey, string, TResult> resultSelector, IEqualityComparer<TKey> comparer)
        //public static IEnumerable<TResult> GroupBy<string, TKey, TElement, TResult>(this string source, Func<string, TKey> keySelector, Func<string, TElement> elementSelector, Func<TKey, IEnumerable<TElement>, TResult> resultSelector, IEqualityComparer<TKey> comparer)
        //public static IEnumerable<TResult> Zip<TFirst, TSecond, TResult>(this IEnumerable<TFirst> first, IEnumerable<TSecond> second, Func<TFirst, TSecond, TResult> resultSelector)
        //public static string Distinct(this string source)
        //public static string Distinct(this string source, IEqualityComparer comparer)
        //public static string Union(this string first, string second)
        //public static string Union(this string first, string second, IEqualityComparer comparer)
        //public static string Intersect(this string first, string second)
        //public static string Intersect(this string first, string second, IEqualityComparer comparer)
        //public static string Except(this string first, string second)
        //public static string Except(this string first, string second, IEqualityComparer comparer)        
        //public static string Reverse(this string source)
        //public static Dictionary<TKey, string> ToDictionary<string, TKey>(this string source, Func<string, TKey> keySelector)
        //public static Dictionary<TKey, string> ToDictionary<string, TKey>(this string source, Func<string, TKey> keySelector, IEqualityComparer<TKey> comparer)
        //public static Dictionary<TKey, TElement> ToDictionary<string, TKey, TElement>(this string source, Func<string, TKey> keySelector, Func<string, TElement> elementSelector)
        //public static Dictionary<TKey, TElement> ToDictionary<string, TKey, TElement>(this string source, Func<string, TKey> keySelector, Func<string, TElement> elementSelector, IEqualityComparer<TKey> comparer)
        //public static ILookup<TKey, string> ToLookup<string, TKey>(this string source, Func<string, TKey> keySelector)
        //public static ILookup<TKey, string> ToLookup<string, TKey>(this string source, Func<string, TKey> keySelector, IEqualityComparer<TKey> comparer)
        //public static ILookup<TKey, TElement> ToLookup<string, TKey, TElement>(this string source, Func<string, TKey> keySelector, Func<string, TElement> elementSelector)
        //public static ILookup<TKey, TElement> ToLookup<string, TKey, TElement>(this string source, Func<string, TKey> keySelector, Func<string, TElement> elementSelector, IEqualityComparer<TKey> comparer)
        //public static IEnumerable<TResult> OfType<TResult>(this IEnumerable source)
        //public static IEnumerable<TResult> Cast<TResult>(this IEnumerable source)
        //public static string First(this string source, Func<string, bool> predicate)
        //public static string FirstOrDefault(this string source, Func<string, bool> predicate)
        //public static string Single(this string source)
        //public static string Single(this string source, Func<string, bool> predicate)
        //public static string SingleOrDefault(this string source)
        //public static string SingleOrDefault(this string source, Func<string, bool> predicate)
        //public static IEnumerable<TResult> Repeat<TResult>(TResult element, int count)
        //public static IEnumerable<TResult> Empty<TResult>()
        //public static bool Any(this string source, Func<string, bool> predicate)
        //public static bool All(this string source, Func<string, bool> predicate)
        //public static int Count(this string source, Func<string, bool> predicate)
        //public static long LongCount(this string source, Func<string, bool> predicate)
        //public static string Aggregate(this string source, Func<string, string, string> func)
        //public static TAccumulate Aggregate<string, TAccumulate>(this string source, TAccumulate seed, Func<TAccumulate, string, TAccumulate> func)
        //public static TResult Aggregate<string, TAccumulate, TResult>(this string source, TAccumulate seed, Func<TAccumulate, string, TAccumulate> func, Func<TAccumulate, TResult> resultSelector)
        //public static int Sum(this IEnumerable<int> source)
        //public static int? Sum(this IEnumerable<int?> source)
        //public static long Sum(this IEnumerable<long> source)
        //public static long? Sum(this IEnumerable<long?> source)
        //public static float Sum(this IEnumerable<float> source)
        //public static float? Sum(this IEnumerable<float?> source)
        //public static double Sum(this IEnumerable<double> source)
        //public static double? Sum(this IEnumerable<double?> source)
        //public static decimal Sum(this IEnumerable<decimal> source)
        //public static decimal? Sum(this IEnumerable<decimal?> source)
        //public static int Sum(this string source, Func<string, int> selector)
        //public static int? Sum(this string source, Func<string, int?> selector)
        //public static long Sum(this string source, Func<string, long> selector)
        //public static long? Sum(this string source, Func<string, long?> selector)
        //public static float Sum(this string source, Func<string, float> selector)
        //public static float? Sum(this string source, Func<string, float?> selector)
        //public static double Sum(this string source, Func<string, double> selector)
        //public static double? Sum(this string source, Func<string, double?> selector)
        //public static decimal Sum(this string source, Func<string, decimal> selector)
        //public static decimal? Sum(this string source, Func<string, decimal?> selector)
        //public static int Min(this IEnumerable<int> source)
        //public static int? Min(this IEnumerable<int?> source)
        //public static long Min(this IEnumerable<long> source)
        //public static long? Min(this IEnumerable<long?> source)
        //public static float Min(this IEnumerable<float> source)
        //public static float? Min(this IEnumerable<float?> source)
        //public static double Min(this IEnumerable<double> source)
        //public static double? Min(this IEnumerable<double?> source)
        //public static decimal Min(this IEnumerable<decimal> source)
        //public static decimal? Min(this IEnumerable<decimal?> source)
        //public static string Min(this string source)
        //public static int Min(this string source, Func<string, int> selector)
        //public static int? Min(this string source, Func<string, int?> selector)
        //public static long Min(this string source, Func<string, long> selector)
        //public static long? Min(this string source, Func<string, long?> selector)
        //public static float Min(this string source, Func<string, float> selector)
        //public static float? Min(this string source, Func<string, float?> selector)
        //public static double Min(this string source, Func<string, double> selector)
        //public static double? Min(this string source, Func<string, double?> selector)
        //public static decimal Min(this string source, Func<string, decimal> selector)
        //public static decimal? Min(this string source, Func<string, decimal?> selector)
        //public static TResult Min<string, TResult>(this string source, Func<string, TResult> selector)
        //public static int Max(this IEnumerable<int> source)
        //public static int? Max(this IEnumerable<int?> source)
        //public static long Max(this IEnumerable<long> source)
        //public static long? Max(this IEnumerable<long?> source)
        //public static double Max(this IEnumerable<double> source)
        //public static double? Max(this IEnumerable<double?> source)
        //public static float Max(this IEnumerable<float> source)
        //public static float? Max(this IEnumerable<float?> source)
        //public static decimal Max(this IEnumerable<decimal> source)
        //public static decimal? Max(this IEnumerable<decimal?> source)
        //public static string Max(this string source)
        //public static int Max(this string source, Func<string, int> selector)
        //public static int? Max(this string source, Func<string, int?> selector)
        //public static long Max(this string source, Func<string, long> selector)
        //public static long? Max(this string source, Func<string, long?> selector)
        //public static float Max(this string source, Func<string, float> selector)
        //public static float? Max(this string source, Func<string, float?> selector)
        //public static double Max(this string source, Func<string, double> selector)
        //public static double? Max(this string source, Func<string, double?> selector)
        //public static decimal Max(this string source, Func<string, decimal> selector)
        //public static decimal? Max(this string source, Func<string, decimal?> selector)
        //public static TResult Max<string, TResult>(this string source, Func<string, TResult> selector)
        //public static double Average(this IEnumerable<int> source)
        //public static double? Average(this IEnumerable<int?> source)
        //public static double Average(this IEnumerable<long> source)
        //public static double? Average(this IEnumerable<long?> source)
        //public static float Average(this IEnumerable<float> source)
        //public static float? Average(this IEnumerable<float?> source)
        //public static double Average(this IEnumerable<double> source)
        //public static double? Average(this IEnumerable<double?> source)
        //public static decimal Average(this IEnumerable<decimal> source)
        //public static decimal? Average(this IEnumerable<decimal?> source)
        //public static double Average(this string source, Func<string, int> selector)
        //public static double? Average(this string source, Func<string, int?> selector)
        //public static double Average(this string source, Func<string, long> selector)
        //public static double? Average(this string source, Func<string, long?> selector)
        //public static float Average(this string source, Func<string, float> selector)
        //public static float? Average(this string source, Func<string, float?> selector)
        //public static double Average(this string source, Func<string, double> selector)
        //public static double? Average(this string source, Func<string, double?> selector)
        //public static decimal Average(this string source, Func<string, decimal> selector)
        //public static decimal? Average(this string source, Func<string, decimal?> selector)
        //public static string DefaultIfEmpty(this string source, string defaultValue)

        // While we can optimize Concat significantly, becuse String.Concat exists as a static method, we cannot create and
        // use a Concat(this string) extension method. The compiler complains about accessing a static method in non-static context.
        //public static string Concat(this string first, string second)
    }
}
