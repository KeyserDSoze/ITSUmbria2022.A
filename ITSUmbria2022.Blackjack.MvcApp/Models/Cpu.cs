namespace ITSUmbria2022.Blackjack.MvcApp.Models
{
    public interface IGameManager
    {
        ICpu Cpu { get; }
        IDeck Deck { get; }
        IPlayer Player { get; }
        IStorage Storage { get; }
    }
    public class GameManager : IGameManager
    {
        public GameManager(ICpu cpu, IDeck deck, IPlayer player, IStorage storage)
        {
            Cpu = cpu;
            Deck = deck;
            Player = player;
            Storage = storage;
        }

        public ICpu Cpu { get; }
        public IDeck Deck { get; }
        public IPlayer Player { get; }
        public IStorage Storage { get; }
    }

    public class Cpu : ICpu
    {
        public Cpu(IDeck deck)
        {
            Deck = deck;
        }
        public IDeck Deck { get; }
    }
}
