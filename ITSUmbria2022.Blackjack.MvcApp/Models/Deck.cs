namespace ITSUmbria2022.Blackjack.MvcApp.Models
{
    public class Deck : IDeck
    {
        public string Id { get; } = Guid.NewGuid().ToString();
    }
}
