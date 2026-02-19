namespace Esoteric.Models
{
    public class Player
    {
        public int Id { get; set; }
        public string Player_Nick { get; set; } = null!;
        public int Currency_Wood { get; set; }
        public int Currency_Gold { get; set; }
    }
}
