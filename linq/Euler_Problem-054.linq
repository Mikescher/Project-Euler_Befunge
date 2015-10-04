<Query Kind="Program">
  <Reference>&lt;RuntimeDirectory&gt;\System.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\System.Net.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\System.Net.Http.dll</Reference>
  <Namespace>System.Net</Namespace>
</Query>

struct Match { public Deck deck_1, deck_2; }
struct Deck  { public Card[] cards;        }
struct Card  { public int value, suit;     }

const long H = 'H' - 'A';
const long C = 'C' - 'A';
const long S = 'S' - 'A';
const long D = 'D' - 'A';

const long SUM1 = H*H*H*H*H;
const long SUM2 = C*C*C*C*C;
const long SUM3 = S*S*S*S*S;
const long SUM4 = D*D*D*D*D;

List<long> SUMS = new List<long>{ SUM1, SUM2, SUM3, SUM4 };

void Main()
{
	Get(@"https://projecteuler.net/project/resources/p054_poker.txt");
		.Select(p => GetScore(p.deck_1) + "-" + GetScore(p.deck_2))
		.ToList()[35].Dump();

	Get(@"https://projecteuler.net/project/resources/p054_poker.txt");
		.Select(p => GetScore(p.deck_1) + "-" + GetScore(p.deck_2))
		.Aggregate((a, b) => a + Environment.NewLine +  b)
		;//.Dump();

	Get(@"https://projecteuler.net/project/resources/p054_poker.txt");
		.Where(p => GetScore(p.deck_1) > GetScore(p.deck_2))
		.Count()
		.Dump();

	(" =" + 376).Dump();
	
	"".Dump();
	
	Get(@"https://projecteuler.net/project/resources/p054_poker.txt");
		.Select(p => (GetScore(p.deck_1) > GetScore(p.deck_2)) ? "+" : "-")
		.Aggregate((a, b) => a + Environment.NewLine +  b)
		.GetHashCode()
		.Dump();
		
	TestFlush();
}

void TestFlush()
{
	Enumerable.Repeat(AllC().Where(p => SUMS.Contains(  p.Aggregate( (a,b) => a*b )  )).Count() == 4, 1).Dump();
}

IEnumerable<List<long>> AllC()
{
	var x = new List<long>{H, C, S, D};

	foreach (var a in x)
	foreach (var b in x)
	foreach (var c in x)
	foreach (var d in x)
	foreach (var e in x)
		yield return new List<long>{a, b, c, d, e};
}

List<Match> Get(string url)
{
	var lines = GetHTTP(url)
		.Replace("A", ">")
		.Replace("K", "=")
		.Replace("Q", "<")
		.Replace("J", ";")
		.Replace("T", ":")
		.Split('\n')
		.Where(p => p != "");
		
	var result = new List<Match>();
	
	foreach (string line in lines)
	{
		var cards = line.Split(' ').Select(p => new Card(){value = p[0]-'0', suit = p[1] - 'A'}).ToList();
		
		Match m = new Match()
		{
			deck_1 = new Deck(){ cards = cards.Skip(0).Take(5).ToArray() }, 
			deck_2 = new Deck(){ cards = cards.Skip(5).Take(5).ToArray() }, 
		};
		
		result.Add(m);
	}
	
	return result;
}

string GetHTTP(string url)
{
	using (WebClient client = new WebClient())
	{
		return client.DownloadString(url);
	}
}

int GetScore(Deck d)
{
	Card[] cards = d.cards.ToArray();
	
	int[] array = Enumerable.Repeat(0, 15).ToArray();
	int score = 0;
	int flushSum = 1;

	int highCard = 0;
	int highGroup = 0;

	foreach(Card c in cards)
	{
		highCard = Math.Max(highCard, c.value);
		flushSum *= c.suit;
		if (array[c.value] > 0)
			highGroup = Math.Max(highGroup, c.value);
		array[c.value]++;
	}

	int straightIndex = 0;

	for(int i = 1; i < 15; i++)
	{
		score += (array[i]-1)*(array[i])*256;
		
		if (array[i] > 0 && array[i-1] > 0)
			straightIndex++;
	}
	score += highCard;
	score += highGroup * 15;

	if (straightIndex == 4)
		score += 2540;
	if (SUMS.Contains(flushSum))
		score += 2550;
		
	return score;
}

/*
In the card game poker, a hand consists of five cards and are ranked, from lowest to highest, in the following way:

    High Card: Highest value card.                                   {0-14} * [1]    = {0-14}
    High Card: Highest value card. (GROUP)                           {0-14} * [15]   = 210
    One Pair: Two cards of the same value.                           2 * [256]       = 512
    Two Pairs: Two different pairs.                                  4 * [256]       = 1024
    Three of a Kind: Three cards of the same value.                  6 * [256]       = 1536
    Straight: All cards are consecutive values.                      [2540]          = 2540
    Flush: All cards of the same suit.                               [2550]          = 2550
    Full House: Three of a kind and a pair.                          10 * [256]      = 2560
    Four of a Kind: Four cards of the same value.                    12 * [256]      = 3072
    Straight Flush: All cards are consecutive values of same suit.   [2540] + [2550] = 5090
    Royal Flush: Ten, Jack, Queen, King, Ace, in same suit.          [2540] + [2550] = 5090

The cards are valued in the order:
2, 3, 4, 5, 6, 7, 8, 9, 10, Jack, Queen, King, Ace.

If two players have the same ranked hands then the rank made up of the highest value wins; 
for example, a pair of eights beats a pair of fives (see example 1 below). 
But if two ranks tie, for example, 
both players have a pair of queens, then highest cards in each hand are compared (see example 4 below); 
if the highest cards tie then the next highest cards are compared, and so on.

Consider the following five hands dealt to two players:

Hand		Player 1				Player 2					Winner
#################################################################################

1			5H 5C 6S 7S KD			2C 3S 8S 8D TD				Player 2
			Pair of Fives			Pair of Eights

2	 		5D 8C 9S JS AC			2C 5C 7D 8S QH				Player 1
			Highest card Ace		Highest card Queen

3			2D 9C AS AH AC			3D 6D 7D TD QD				Player 2
			Three Aces				Flush with Diamonds

4			4D 6S 9H QH QC			3D 6D 7H QD QS				Player 1
			Pair of Queens			Pair of Queens
			Highest card Nine		Highest card Seven

5			2H 2D 4C 4D 4S			3C 3D 3S 9S 9D				Player 1
			Full House				Full House 
			With Three Fours		with Three Threes

The file, poker.txt, contains one-thousand random hands dealt to two players. 
Each line of the file contains ten cards (separated by a single space): 
the first five are Player 1's cards and the last five are Player 2's cards. 
You can assume that all hands are valid (no invalid characters or repeated cards), 
each player's hand is in no specific order, and in each hand there is a clear winner.

How many hands does Player 1 win?
*/