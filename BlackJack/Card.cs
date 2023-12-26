namespace BlackJack
{
    public class Card {
        private readonly string? _suit;
        private readonly string? _meaning;
        public Card(string? suit, string? meaning) 
        { 
            _suit = suit;
            _meaning = meaning;
        }
        public string? GetSuit()
        {
            return _suit;
        }
    }
    
    public class Player
    {
        public List<Card> _playerHand = new List<Card>();
        Deck deck = new Deck();
        
        public void GetCard(List<Card> Deck)
        {
            _playerHand.Add(deck.GetRandomCard());
        }

        public int GetPlayerScore(List<Card> _playerHand)
        {
            int score = 0;

            for(int i = 0; i < _playerHand.Count; i++)
            {
                if(int.TryParse(_playerHand[i].GetSuit(), out int number)) {
                    score += number;
                }
            }

            return score;
        }
    }
    public class Deck
    {
        public List<Card> _deck = new List<Card>();
        public void FillTheDeck()
        {
            string[] suits = { "Diamonds", "Hearts", "Clubs", "Spades" };
            string[] meanings = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "jack", "queen", "king", "ace" };
            for (int i = 0; i < meanings.Length; i++)
            {
                for (int j = 0; j < suits.Length; j++)
                {
                    Card card = new Card(suits[j], meanings[i]);
                    _deck.Add(card);
                }
            }
        }
        public Card GetRandomCard()
        {
            Random random = new Random();
            Card card;
            int randomNumber;

            randomNumber = random.Next(_deck.Count);
            card = _deck[randomNumber];
            _deck.Remove(card);

            return card;
        }
    }
}
