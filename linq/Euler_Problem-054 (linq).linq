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

	// Highcard
	int score = d.cards.Max(p => p.value);
	
	// Highcard (Group)
	score += cards
		.GroupBy(p => p.value)
		.Where(p => p.Count() >= 2)
		.SelectMany(p => p)
		.Select(p => p.value)
		.Concat(Enumerable.Repeat(0, 1))
		.Max() * 100;

	// Groups
	score += cards.GroupBy(p => p.value).Select(p => (p.Count()-1)*(p.Count()-1) * 1000).Sum();

	// Flush
	if (cards.GroupBy(p => p.suit).Count() == 1)
		score += 4750;

	// Straight
	if (cards[1].value == cards[0].value - 1  && cards[2].value == cards[1].value - 1 && 
		cards[3].value == cards[2].value - 1  && cards[4].value == cards[3].value - 1)
		score += 4500;

	return score;
}