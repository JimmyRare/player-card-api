namespace player_card_api.Models;

public class Season
{
    public required int Year { get; set; }
    public int Matches { get; set; } = 0;
    public int Goals { get; set; } = 0;
    public int Assists { get; set; } = 0;
}
