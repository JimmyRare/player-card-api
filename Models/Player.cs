namespace player_card_api.Models;

public class Player
{
    public required string Name { get; set; }
    public required string Team { get; set; }
    public required string ImageUrl { get; set; }
    public required int Height { get; set; }
    public required int Weight { get; set; }
    public required int Year { get; set; }
    public int Passing { get; set; } = 0;
    public int Shooting { get; set; } = 0;
    public int Dribbling { get; set; } = 0;
    public required int Rating { get; set; }
    public required List<Season> Season { get; set; }
}
