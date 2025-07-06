using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using GrigorDimitrovProfile.Models;

public class RonaldoController : Controller
{
    public IActionResult Index()
    {
        var profile = new Athlete
        {
            Name = "Кристиано Роналдо",
            BirthDate = new DateTime(1985, 2, 5),
            Country = "Португалия",
            Sport = "Футбол",
            Ranking = 1,
            Biography = "Кристиано Роналдо е един от най-великите футболисти в историята, с пет Златни топки и стотици голове в клубната и националната сцена."
        };

        return View(profile);
    }

    [Authorize]
    public IActionResult Details()
    {
        var details = new Athlete
        {
            Name = "Кристиано Роналдо",
            BirthDate = new DateTime(1985, 2, 5),
            Country = "Португалия",
            Sport = "Футбол",
            Ranking = 1,
            Biography = "Кариерата на Роналдо включва отбори като Спортинг Лисабон, Манчестър Юнайтед, Реал Мадрид, Ювентус и Ал-Наср. Известен с невероятна физика, скорост и голов нюх."
        };

        return View(details);
    }
}
