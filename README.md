StringExtensions
================

Overloads of `Enumerable` extension methods specifically optimized for use on strings.

The new optimized extension methods are added to the existing `System.Linq` namespace, so all you need to do to take advantage of these methods is reference the dll. The compiler will recognize that more specific methods are available and will use them in place of `Enumerable.Xxx` as appropriate. All implementations are drop-in replacements for their corresponding `Enumerable` methods and are tested to provide the same results given the same inputs. The included project includes 3,000+ unit tests verifying output from `StringExtensions` matches output `Enumerable`, in a variety of languages, character sets, and intermixing empty and null strings.

The following methods are optimized:
----------------------------------

```c#
bool Any(this string source)
bool Contains(this string source, char value)
bool SequenceEqual(this string first, string second)
bool SequenceEqual(this string first, string second, StringComparison comparison)
char ElementAt(this string source, int index)
char ElementAtOrDefault(this string source, int index)
char First(this string source)
char FirstOrDefault(this string source)
char Last(this string source)
char Last(this string source, Func<char, bool> predicate)
char LastOrDefault(this string source)
char LastOrDefault(this string source, Func<char, bool> predicate)
char[] ToArray(this string source)
int Count(this string source)
List<char> ToList(this string source)
long LongCount(this string source)
string DefaultIfEmpty(this string source)
string Skip(this string source, int count)
string Take(this string source, int count)
```
