using Microsoft.AspNetCore.Mvc;
using player_card_api.Models;
using Bogus;

namespace player_card_api.Controllers;

[ApiController]
[Route("[controller]")]
public class PlayerDataController : ControllerBase
{

    private readonly Faker<Player> _faker;

    public PlayerDataController()
    {
        _faker = new Faker<Player>()
            .RuleFor(p => p.Name, f => f.Person.FullName)
            .RuleFor(p => p.Team, f => f.Company.CompanyName())
            .RuleFor(p => p.ImageUrl, f => f.Internet.Avatar())
            .RuleFor(p => p.Height, f => f.Random.Number(150, 220))
            .RuleFor(p => p.Weight, f => f.Random.Number(55, 150))
            .RuleFor(p => p.Year, f => f.Person.DateOfBirth.Year)
            .RuleFor(p => p.Passing, f => f.Random.Number(0, 100))
            .RuleFor(p => p.Shooting, f => f.Random.Number(0, 100))
            .RuleFor(p => p.Dribbling, f => f.Random.Number(0, 100))
            .RuleFor(p => p.Rating, f => f.Random.Number(1, 5))
            .RuleFor(p => p.Season, f => f.Make(3, () => new Season
            {
                Year = f.Random.Number(1928, 2023),
                Matches = f.Random.Number(0, 50),
                Goals = f.Random.Number(0, 50),
                Assists = f.Random.Number(0, 50)
            }));
    }

    [HttpGet]
    public Player PlayerData()
    {
        Player player = _faker.Generate();
        return player;
    }
}
