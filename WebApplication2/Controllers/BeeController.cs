using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using WebApplication2;
using WebApplication2.Models;

public class BeeController : Controller
{
    private static Random _random = new Random();

    public IActionResult Bee()
    {
        var shops = new List<TestModel>()
        {
            new TestModel() { Cords = new Point() { X = _random.Next(0, 20), Y = _random.Next(0, 20) }, Cost = _random.Next(1, 10)},
            new TestModel() { Cords = new Point() { X = _random.Next(0, 20), Y = _random.Next(0, 20) }, Cost = _random.Next(1, 10)},
            new TestModel() { Cords = new Point() { X = _random.Next(0, 20), Y = _random.Next(0, 20) }, Cost = _random.Next(1, 10)},
            new TestModel() { Cords = new Point() { X = _random.Next(0, 20), Y = _random.Next(0, 20) }, Cost = _random.Next(1, 10)},
            new TestModel() { Cords = new Point() { X = _random.Next(0, 20), Y = _random.Next(0, 20) }, Cost = _random.Next(1, 10)},
            new TestModel() { Cords = new Point() { X = _random.Next(0, 20), Y = _random.Next(0, 20) }, Cost = _random.Next(1, 10)},
            new TestModel() { Cords = new Point() { X = _random.Next(0, 20), Y = _random.Next(0, 20) }, Cost = _random.Next(1, 10)},
            new TestModel() { Cords = new Point() { X = _random.Next(0, 20), Y = _random.Next(0, 20) }, Cost = _random.Next(1, 10)},
            new TestModel() { Cords = new Point() { X = _random.Next(0, 20), Y = _random.Next(0, 20) }, Cost = _random.Next(1, 10)}
        };
        var bee = Alghoritm.Bee(shops);
        var models = new List<Result>(
        new[] {
            new Result()
            {
                MarkerSize = 10,
                LegendText = "Магазин",
                Type = "scatter",
                Color = "red",
                MarkerType = "square"
            },
            new Result()
            {
                MarkerSize = 0,
                LegendText = "Лінія поділу",
                Type = "line",
                Color = "green",
                MarkerType = "circle"
            }
        }
        );

        foreach (var shop in shops)
        {
            models[0].Points.Add(shop.Cords);
        }

        var points2 = new List<Point>()
        {
            bee.Cords[0],
            bee.Cords[1]
        };

        models[1].Points = points2;
        ViewBag.Shops = shops;
        ViewBag.Bee = bee;
        ViewBag.Models = JsonConvert.SerializeObject(models);
        return View();
    }
}