namespace ITSUmbria2022.Blackjack.MvcApp.Models
{
    public class Player : IPlayer
    {
        public string Id { get; } = Guid.NewGuid().ToString();
    }
}
