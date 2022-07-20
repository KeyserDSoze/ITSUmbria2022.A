namespace ITSUmbria.BlackJack
{
    public class Card
    {
        public int Seed { get; set; }
        public int Value { get; set; }
    }
    public class Class1
    {
        public List<Card> Cards { get; set; } = new();

        public void DoSomething()
        {
            var aces = Cards.Where(card => card.Value == 1);
            var aces2 = Where(card => card.Value == 1);
            var aces3 = Where(Check);
            Cards.GroupBy(x => x.Value);
            if (Cards.Sum(x => x.Value) > 21
                && Cards.Any(x => x.Value == 11))
            {
                var newCards = Cards.Where(x => x.Value < 11)
                    .ToList();
                newCards.AddRange(Cards
                .Where(x => x.Value == 11)
                .Select(x => new Card
                {
                    Seed = x.Seed,
                    Value = 1
                }));
                if (newCards.Sum(x => x.Value) > 21)
                {

                }
            }
            foreach (var groupedBySeed in Cards.GroupBy(x => x.Seed))
            {
                var seed = groupedBySeed.Key;
                foreach (var cardForThatSeed in groupedBySeed)
                {
                }
            }
            Cards.OrderBy(x => x.Value);
            Cards.OrderByDescending(x => x.Value);
            Cards.Max(x => x.Value);
        }
        private bool Check(Card card)
        {
            return card.Value == 1;
        }
        public IEnumerable<Card> Where(Func<Card, bool> check)
        {
            List<Card> aces = new List<Card>();
            foreach (var card in Cards)
            {
                if (check.Invoke(card))
                    aces.Add(card);
            }
            return aces;
        }
    }
}