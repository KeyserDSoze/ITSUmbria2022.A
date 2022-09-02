namespace ITSUmbria2022.Blackjack.MvcApp.Models
{
    public class Storage : IStorage
    {
        public string Id { get; } = Guid.NewGuid().ToString();

        public void SaveState()
        {
            throw new NotImplementedException();
        }
    }
}
