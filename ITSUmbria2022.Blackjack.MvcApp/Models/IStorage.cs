namespace ITSUmbria2022.Blackjack.MvcApp.Models
{
    public interface IStorage
    {
        string Id { get; }
        void SaveState();
    }
}
