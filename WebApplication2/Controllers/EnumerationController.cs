using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using WebApplication2;
using WebApplication2.Models;

public class EnumerationController : Controller
{
    private static Random _random = new Random();

    public IActionResult Enumeration()
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
        var enumeration = Alghoritm.Enumeration(shops);
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
            enumeration.Cords[0],
            enumeration.Cords[1]
        };

        models[1].Points = points2;
        ViewBag.Shops = shops;
        ViewBag.Enumeration = enumeration;
        ViewBag.Models = JsonConvert.SerializeObject(models);
        return View();
    }
}