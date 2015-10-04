<Query Kind="Program">
  <Reference>&lt;RuntimeDirectory&gt;\System.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\System.Net.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\System.Net.Http.dll</Reference>
  <Namespace>System.Net</Namespace>
</Query>

struct Match
{
	public Deck deck_1;
	public Deck deck_2;
}

struct Deck
{
	public Card[] cards;
}

struct Card
{
	public int value;
	public int suit;
}

void Main()
{
	//Get(@"https://projecteuler.net/project/resources/p054_poker.txt");
	
	Get(@"C:\Users\schwoerm\Desktop\M\Bef\p054_poker.txt")
		.Where(p => GetScore(p.deck_1) > GetScore(p.deck_2))
		.Count()
		.Dump();
	(" =" + 376).Dump();
	
	"".Dump();
	
	Get(@"C:\Users\schwoerm\Desktop\M\Bef\p054_poker.txt")
		.Select(p => (GetScore(p.deck_1) > GetScore(p.deck_2)) ? "+" : "-")
		.Aggregate((a, b) => a + Environment.NewLine +  b)
		.GetHashCode()
		.Dump();
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
		var cards = line.Split(' ').Select(p => new Card(){value = p[0]-'0', suit = p[1]}).ToList();
		
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
	using (WebClient client = new WebClient ()) // WebClient class inherits IDisposable
	{
		return client.DownloadString(url);
	}
}

int GetScore(Deck d)
{
	Card[] cards = d.cards.OrderByDescending(p => p.value).ToArray();

	int HighCard = d.cards.Max(p => p.value);
	int HighCombinationCard = 0;
	int CombinationType = 0;
	
	// Royal Flush: Ten, Jack, Queen, King, Ace, in same suit.
	if (cards[0].value == 14 && cards[1].value == cards[0].value - 1 
		&& cards[2].value == cards[1].value - 1 && cards[3].value == cards[2].value - 1 
		&& cards[4].value == cards[3].value - 1 && cards.GroupBy(p => p.suit).Count() == 1)
	{
		HighCombinationCard = HighCard;
		CombinationType = 15;
	}
	// Straight Flush: All cards are consecutive values of same suit.
	else if (cards[1].value == cards[0].value - 1 
		&& cards[2].value == cards[1].value - 1 && cards[3].value == cards[2].value - 1 
		&& cards[4].value == cards[3].value - 1 && cards.GroupBy(p => p.suit).Count() == 1)
	{
		HighCombinationCard = HighCard;
		CombinationType = 14;
	}
	// Four of a Kind: Four cards of the same value.
	else if (cards.GroupBy(p => p.value).Any(p => p.Count() == 4))
	{
		HighCombinationCard = cards.GroupBy(p => p.value).Single(p => p.Count() == 4).First().value;
		CombinationType = 13;
	}
	// Full House: Three of a kind and a pair.
	else if (cards.GroupBy(p => p.value).All(p => p.Count() == 3 || p.Count() == 2))
	{
		HighCombinationCard = cards.GroupBy(p => p.value).Single(p => p.Count() == 3).First().value;
		CombinationType = 12;
	}
	// Flush: All cards of the same suit.
	else if (cards.GroupBy(p => p.suit).Count() == 1)
	{
		HighCombinationCard = HighCard;
		CombinationType = 10;
	}
	// Straight: All cards are consecutive values.
	else if (cards[1].value == cards[0].value - 1 && cards[2].value == cards[1].value - 1 
			&& cards[3].value == cards[2].value - 1 && cards[4].value == cards[3].value - 1)
	{
		HighCombinationCard = HighCard;
		CombinationType = 9;
	}
	// Three of a Kind: Three cards of the same value.
	else if (cards.GroupBy(p => p.value).Any(p => p.Count() == 3))
	{
		HighCombinationCard = cards.GroupBy(p => p.value).Single(p => p.Count() == 3).First().value;
		CombinationType = 8;
	}
	// Two Pairs: Two different pairs.
	else if (cards.GroupBy(p => p.value).Count(p => p.Count() == 2) == 2)
	{
		HighCombinationCard = cards.GroupBy(p => p.value).Where(p => p.Count() == 2).Max(p => p.Max(q => q.value));
		CombinationType = 7;
	}
	// One Pair: Two cards of the same value.
	else if (cards.GroupBy(p => p.value).Count(p => p.Count() == 2) == 1)
	{
		HighCombinationCard = cards.GroupBy(p => p.value).Single(p => p.Count() == 2).First().value;
		CombinationType = 6;
	}
	// High Card: Highest value card.
	else
	{
		HighCombinationCard = HighCard;
		CombinationType = 5;
	}
	
	return HighCard + HighCombinationCard * 256 + CombinationType * 256 * 256;
}