<Query Kind="Program">
  <Reference>&lt;RuntimeDirectory&gt;\System.Net.Http.dll</Reference>
  <Namespace>System.Net.Http</Namespace>
  <Namespace>System.Net</Namespace>
</Query>

/*
For a number written in Roman numerals to be considered valid there are basic rules which must be followed.
Even though the rules allow some numbers to be expressed in more than one way there is always a "best" way
of writing a particular number.

For example, it would appear that there are at least six ways of writing the number sixteen:

~~~
IIIIIIIIIIIIIIII
VIIIIIIIIIII
VVIIIIII
XIIIIII
VVVI
XVI
~~~

However, according to the rules only XIIIIII and XVI are valid,
and the last example is considered to be the most efficient, as it uses the least number of numerals.

The 11K text file, roman.txt, contains one thousand numbers written in valid,
but not necessarily minimal, Roman numerals;
see **About... Roman Numerals** for the definitive rules for this problem.

Find the number of characters saved by writing each of these in their minimal form.

*Note:* You can assume that all the Roman numerals in the file contain no more 
than four consecutive identical units.

About... Roman Numerals
=======================

> How do you read and write Roman numerals?

Traditional Roman numerals are made up of the following denominations:

~~~
I = 1
V = 5
X = 10
L = 50
C = 100
D = 500
M = 1000
~~~

In order for a number written in Roman numerals to be considered valid there are three basic rules 
which must be followed.

Numerals must be arranged in descending order of size.

`M`, `C`, and `X` cannot be equalled or exceeded by smaller denominations.

`D`, `L`, and `V` can each only appear once.

For example, the number sixteen could be written as `XVI` or `XIIIIII`,
with the first being the preferred form as it uses the least number of numerals.
We could not write `IIIIIIIIIIIIIIII` because we are making `X` (ten) from smaller denominations,
nor could we write VVVI because the second and third rule are being broken.

The "descending size" rule was introduced to allow the use of subtractive combinations.
For example, four can be written `IV` because it is one before five.
As the rule requires that the numerals be arranged in order of size it should be clear to
a reader that the presence of a smaller numeral out of place, so to speak,
was unambiguously to be subtracted from the following numeral rather than added.

For example, nineteen could be written `XIX` = `X (ten) + IX (nine)`.
Note also how the rule requires `X` (ten) be placed before `IX` (nine),
and `IXX` would not be an acceptable configuration (descending size rule).
Similarly, `XVIV` would be invalid because `V` can only appear once in a number.

Generally the Romans tried to use as few numerals as possible when displaying numbers.
For this reason, `XIX` would be the preferred form of nineteen over other valid combinations,
like `XIIIIIIIII` or `XVIIII`.

By mediaeval times it had become standard practice to avoid more than three consecutive
identical numerals by taking advantage of the more compact subtractive combinations.
That is, `IV` would be written instead of `IIII`,
`IX` would be used instead of `IIIIIIIII` or `VIIII`, and so on.

In addition to the three rules given above,
if subtractive combinations are used then the following four rules must be followed.

 - Only one `I`, `X`, and `C` can be used as the leading numeral in part of a subtractive pair.
 - `I` can only be placed before `V` and `X`.
 - `X` can only be placed before `L` and `C`.
 - `C` can only be placed before `D` and `M`.

Which means that `IL` would be considered to be an invalid way of writing forty-nine,
and whereas `XXXXIIIIIIIII`, `XXXXVIIII`, `XXXXIX`, `XLIIIIIIIII`, `XLVIIII`, and `XLIX`
are all quite legitimate, the latter is the preferred (minimal) form.
However, minimal form was not a rule and there still remain in Rome many examples
where economy of numerals has not been employed.
For example, in the famous Colosseum the numerals above the forty-ninth entrance
is written `XXXXVIIII` rather than `XLIX`.

It is also expected, but not required, that higher denominations should be used whenever possible;
for example, `V` should be used in place of `IIIII`, `L` should be used in place of `XXXXX`,
and `D` should be used in place of `CCCCC`.
However, in the church of Sant'Agnese fuori le Mura (St Agnes' outside the walls),
found in Rome, the date, `MCCCCCCVI` (1606), is written on the gilded and coffered wooden ceiling;
I am sure that many would argue that it should have been written `MDCVI`.

So if we believe the adage, "when in Rome do as the Romans do,"
and we see how the Romans write numerals, then it clearly gives us much more freedom
than many would care to admit.
*/

string HttpGet(string url) { using (var c = new WebClient()) { return c.DownloadString(url); } }

void Main()
{
	var DATA = File.ReadAllLines(Path.Combine(Path.GetDirectoryName(Util.CurrentQueryPath), @"p089_roman.txt"));
	//var DATA = HttpGet(@"http://projecteuler.net/project/resources/p089_roman.txt").Split('\n').ToArray();

	DATA.Select(o => o.Length - ToRomanCount(RomanToNumeric(o))).Sum().Dump();
}

public static int RomanToNumeric(string romanNum)
{
	int[] ints = romanNum.ToCharArray().Select(x =>
	{
		return x == 'I' ? 1 :
			   x == 'V' ? 5 :
			   x == 'X' ? 10 :
			   x == 'L' ? 50 :
			   x == 'C' ? 100 :
			   x == 'D' ? 500 :
			   x == 'M' ? 1000 : 0;
	}).ToArray();


	int calc = 0;
	for (int i = 0; i < ints.Length; i++)
	{
		calc += (i + 1 < ints.Length && ints[i + 1] > ints[i]) ? -ints[i] : ints[i];
	}
	return calc;
}

public static int ToRomanCount(int num)
{
	int[] roman = { 0, 1, 2, 3, 2, 1, 2, 3, 4, 2 };

	int result = 0;

	result += (num / 1000);
	result += (roman[(num % 1000) / 100]);
	result += (roman[(num % 100) / 10]);
	result += (roman[num % 10]);

	return result;
}

/*
I don't know why this problem has such a high number.

We simply parse all the roman numbers in the file and create minimal roman literals from them.
Then we simply sum all the length-differences together.

And it wasn't really hard to write algorithms for these two conversions. Both are pretty straight forward.
(And for number->roman we didn't even have to go the whole way, we only need the *length* of the result)

For the conversion roman->number we first search for the length of the roman literal.
Then we go backwards through the letters and get the value of each letter (cached by the array in line one).
If the value of the letter is greater than the last value we increment the total value (by the letter value),
otherwise we decrement it.
I found it easier to traverse the number backwards because we can cache the value of the last digit and do the algorithm this way with less `g` calls.

For the conversion number->optimal_roman_length i found this nice formula:

~~~
(n/1000) + R[(N%1000)/100] + R[(N%100)/10] + R[N%10]

// n is our number
// R is defined as an array with { 0, 1, 2, 3, 2, 1, 2, 3, 4, 2 }
~~~
*/
