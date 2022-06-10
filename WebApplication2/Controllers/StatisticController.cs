using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using WebApplication2;
using WebApplication2.Models;

public class StatisticController : Controller
{
    private static Random _random = new Random();

    public IActionResult Statistic()
    {
        var shops20100 = new List<List<TestModel>>();
        for(int i = 0; i < 100; i++)
        {
            var list = new List<TestModel>()
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
            shops20100.Add(list);
        }
        var shops20500 = new List<List<TestModel>>();
        for (int i = 0; i < 500; i++)
        {
            var list = new List<TestModel>()
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
            shops20500.Add(list);
        }
        var shops201000 = new List<List<TestModel>>();
        for (int i = 0; i < 1000; i++)
        {
            var list = new List<TestModel>()
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
            shops201000.Add(list);
        }
        var shops50 = new List<List<TestModel>>();
        for (int i = 0; i < 100; i++)
        {
            var list = new List<TestModel>()
            {
                new TestModel() { Cords = new Point() { X = _random.Next(0, 50), Y = _random.Next(0, 50) }, Cost = _random.Next(1, 10)},
                new TestModel() { Cords = new Point() { X = _random.Next(0, 50), Y = _random.Next(0, 50) }, Cost = _random.Next(1, 10)},
                new TestModel() { Cords = new Point() { X = _random.Next(0, 50), Y = _random.Next(0, 50) }, Cost = _random.Next(1, 10)},
                new TestModel() { Cords = new Point() { X = _random.Next(0, 50), Y = _random.Next(0, 50) }, Cost = _random.Next(1, 10)},
                new TestModel() { Cords = new Point() { X = _random.Next(0, 50), Y = _random.Next(0, 50) }, Cost = _random.Next(1, 10)},
                new TestModel() { Cords = new Point() { X = _random.Next(0, 50), Y = _random.Next(0, 50) }, Cost = _random.Next(1, 10)},
                new TestModel() { Cords = new Point() { X = _random.Next(0, 50), Y = _random.Next(0, 50) }, Cost = _random.Next(1, 10)},
                new TestModel() { Cords = new Point() { X = _random.Next(0, 50), Y = _random.Next(0, 50) }, Cost = _random.Next(1, 10)},
                new TestModel() { Cords = new Point() { X = _random.Next(0, 50), Y = _random.Next(0, 50) }, Cost = _random.Next(1, 10)}
            };
            shops50.Add(list);
        }

        var shops100 = new List<List<TestModel>>();
        for (int i = 0; i < 100; i++)
        {
            var list = new List<TestModel>()
            {
                new TestModel() { Cords = new Point() { X = _random.Next(0, 100), Y = _random.Next(0, 100) }, Cost = _random.Next(1, 10)},
                new TestModel() { Cords = new Point() { X = _random.Next(0, 100), Y = _random.Next(0, 100) }, Cost = _random.Next(1, 10)},
                new TestModel() { Cords = new Point() { X = _random.Next(0, 100), Y = _random.Next(0, 100) }, Cost = _random.Next(1, 10)},
                new TestModel() { Cords = new Point() { X = _random.Next(0, 100), Y = _random.Next(0, 100) }, Cost = _random.Next(1, 10)},
                new TestModel() { Cords = new Point() { X = _random.Next(0, 100), Y = _random.Next(0, 100) }, Cost = _random.Next(1, 10)},
                new TestModel() { Cords = new Point() { X = _random.Next(0, 100), Y = _random.Next(0, 100) }, Cost = _random.Next(1, 10)},
                new TestModel() { Cords = new Point() { X = _random.Next(0, 100), Y = _random.Next(0, 100) }, Cost = _random.Next(1, 10)},
                new TestModel() { Cords = new Point() { X = _random.Next(0, 100), Y = _random.Next(0, 100) }, Cost = _random.Next(1, 10)},
                new TestModel() { Cords = new Point() { X = _random.Next(0, 100), Y = _random.Next(0, 100) }, Cost = _random.Next(1, 10)}
            };
            shops100.Add(list);
        }

        //*************************2010000******************************************

        var beeAlgoritm20100 = new List<AlghoritmResult>();
        var greedyAlgoritm20100 = new List<AlghoritmResult>();
        var enumerationAlgoritm20100 = new List<AlghoritmResult>();
        foreach (var shop in shops20100)
        {
            beeAlgoritm20100.Add(Alghoritm.Bee(shop));
            greedyAlgoritm20100.Add(Alghoritm.Greedy(shop));
            enumerationAlgoritm20100.Add(Alghoritm.Enumeration(shop));
        };
        var beeList20100 = new List<int>();
        var greedyList20100 = new List<int>();
        var enumerationList20100 = new List<int>();
        for (int i = 0; i < 100; i++)
        {
            beeList20100.Add(beeAlgoritm20100[i].Result);
            greedyList20100.Add(greedyAlgoritm20100[i].Result);
            enumerationList20100.Add(enumerationAlgoritm20100[i].Result);
        }
        var beeAverage20100 = beeList20100.Average();
        var greedyAverage20100 = greedyList20100.Average();
        var enumerationAverage20100 = enumerationList20100.Average();

        //*************************20500******************************************

        var beeAlgoritm20500 = new List<AlghoritmResult>();
        var greedyAlgoritm20500 = new List<AlghoritmResult>();
        var enumerationAlgoritm20500 = new List<AlghoritmResult>();
        foreach (var shop in shops20500)
        {
            beeAlgoritm20500.Add(Alghoritm.Bee(shop));
            greedyAlgoritm20500.Add(Alghoritm.Greedy(shop));
            enumerationAlgoritm20500.Add(Alghoritm.Enumeration(shop));
        };
        var beeList20500 = new List<int>();
        var greedyList20500 = new List<int>();
        var enumerationList20500 = new List<int>();
        for (int i = 0; i < 500; i++)
        {
            beeList20500.Add(beeAlgoritm20500[i].Result);
            greedyList20500.Add(greedyAlgoritm20500[i].Result);
            enumerationList20500.Add(enumerationAlgoritm20500[i].Result);
        }
        var beeAverage20500 = beeList20500.Average();
        var greedyAverage20500 = greedyList20500.Average();
        var enumerationAverage20500 = enumerationList20500.Average();

        //*************************201000*****************************************

        var beeAlgoritm201000 = new List<AlghoritmResult>();
        var greedyAlgoritm201000 = new List<AlghoritmResult>();
        var enumerationAlgoritm201000 = new List<AlghoritmResult>();
        foreach (var shop in shops201000)
        {
            beeAlgoritm201000.Add(Alghoritm.Bee(shop));
            greedyAlgoritm201000.Add(Alghoritm.Greedy(shop));
            enumerationAlgoritm201000.Add(Alghoritm.Enumeration(shop));
        };
        var beeList201000 = new List<int>();
        var greedyList201000 = new List<int>();
        var enumerationList201000 = new List<int>();
        for (int i = 0; i < 1000; i++)
        {
            beeList201000.Add(beeAlgoritm201000[i].Result);
            greedyList201000.Add(greedyAlgoritm201000[i].Result);
            enumerationList201000.Add(enumerationAlgoritm201000[i].Result);
        }
        var beeAverage201000 = beeList201000.Average();
        var greedyAverage201000 = greedyList201000.Average();
        var enumerationAverage201000 = enumerationList201000.Average();

        //*************************50100*****************************************

        var beeAlgoritm50 = new List<AlghoritmResult>();
        var greedyAlgoritm50 = new List<AlghoritmResult>();
        var enumerationAlgoritm50 = new List<AlghoritmResult>();
        foreach (var shop in shops50)
        {
            beeAlgoritm50.Add(Alghoritm.Bee(shop));
            greedyAlgoritm50.Add(Alghoritm.Greedy(shop));
            enumerationAlgoritm50.Add(Alghoritm.Enumeration(shop));
        };
        var beeList50 = new List<int>();
        var greedyList50 = new List<int>();
        var enumerationList50 = new List<int>();
        for (int i = 0; i < 100; i++)
        {
            beeList50.Add(beeAlgoritm50[i].Result);
            greedyList50.Add(greedyAlgoritm50[i].Result);
            enumerationList50.Add(enumerationAlgoritm50[i].Result);
        }
        var beeAverage50 = beeList50.Average();
        var greedyAverage50 = greedyList50.Average();
        var enumerationAverage50 = enumerationList50.Average();

        //*************************100100****************************************

        var beeAlgoritm100 = new List<AlghoritmResult>();
        var greedyAlgoritm100 = new List<AlghoritmResult>();
        var enumerationAlgoritm100 = new List<AlghoritmResult>();
        foreach (var shop in shops100)
        {
            beeAlgoritm100.Add(Alghoritm.Bee(shop));
            greedyAlgoritm100.Add(Alghoritm.Greedy(shop));
            enumerationAlgoritm100.Add(Alghoritm.Enumeration(shop));
        };
        var beeList100 = new List<int>();
        var greedyList100 = new List<int>();
        var enumerationList100 = new List<int>();
        for (int i = 0; i < 100; i++)
        {
            beeList100.Add(beeAlgoritm100[i].Result);
            greedyList100.Add(greedyAlgoritm100[i].Result);
            enumerationList100.Add(enumerationAlgoritm100[i].Result);
        }
        var beeAverage100 = beeList100.Average();
        var greedyAverage100 = greedyList100.Average();
        var enumerationAverage100 = enumerationList100.Average();

        var pointsBee20 = new List<Point>()
        {
            new Point() { X = 100, Y = (int)(beeAverage20100*100) },
            new Point() { X = 500, Y = (int)(beeAverage20500*100) },
            new Point() { X = 1000, Y = (int)(beeAverage201000*100) }
        };

        var pointsGreedy20 = new List<Point>()
        {
            new Point() { X = 100, Y = (int)(greedyAverage20100*100) },
            new Point() { X = 500, Y = (int)(greedyAverage20500*100) },
            new Point() { X = 1000, Y = (int)(greedyAverage201000*100) }
        };

        var pointsEnumeration20 = new List<Point>()
        {
            new Point() { X = 100, Y = (int)(enumerationAverage20100*100) },
            new Point() { X = 500, Y = (int)(enumerationAverage20500*100) },
            new Point() { X = 1000, Y = (int)(enumerationAverage201000*100) }
        };

        var pointsBee = new List<Point>()
        {
            new Point() { X = 20, Y = (int)(beeAverage20100*100) },
            new Point() { X = 50, Y = (int)(beeAverage50*100) },
            new Point() { X = 100, Y = (int)(beeAverage100*100) }
        };

        var pointsGreedy = new List<Point>()
        {
            new Point() { X = 20, Y = (int)(greedyAverage20100*100) },
            new Point() { X = 50, Y = (int)(greedyAverage50*100) },
            new Point() { X = 100, Y = (int)(greedyAverage100*100) }
        };

        var pointsEnumeration = new List<Point>()
        {
            new Point() { X = 20, Y = (int)(enumerationAverage20100*100) },
            new Point() { X = 50, Y = (int)(enumerationAverage50*100) },
            new Point() { X = 100, Y = (int)(enumerationAverage100*100) }
        };

        var models1 = new List<Result>(
        new[] {
            new Result()
            {
                MarkerSize = 7,
                Type = "line",
                Color = "red",
                LegendText = "Бджолиний",
                MarkerType = "circle"
            },
            new Result()
            {
                MarkerSize = 7,
                LegendText = "Жадний",
                Type = "line",
                Color = "green",
                MarkerType = "circle"
            },
            new Result()
            {
                MarkerSize = 7,
                LegendText = "Перебору",
                Type = "line",
                Color = "blue",
                MarkerType = "circle"
            }
        }
        );

        models1[0].Points = pointsBee20;
        models1[1].Points = pointsGreedy20;
        models1[2].Points = pointsEnumeration20;

        var models2 = new List<Result>(
        new[] {
            new Result()
            {
                MarkerSize = 7,
                LegendText = "Бджолиний",
                Type = "line",
                Color = "red",
                MarkerType = "circle"
            },
            new Result()
            {
                MarkerSize = 7,
                LegendText = "Жадний",
                Type = "line",
                Color = "green",
                MarkerType = "circle"
            },
            new Result()
            {
                MarkerSize = 7,
                LegendText = "Перебору",
                Type = "line",
                Color = "blue",
                MarkerType = "circle"
            }
        }
        );

        models2[0].Points = pointsBee;
        models2[1].Points = pointsGreedy;
        models2[2].Points = pointsEnumeration;

        ViewBag.Bee20100 = beeAlgoritm20100;
        ViewBag.Bee20500 = beeAlgoritm20500;
        ViewBag.Bee201000 = beeAlgoritm201000;
        ViewBag.Bee50 = beeAlgoritm50;
        ViewBag.Bee100 = beeAlgoritm100;
        ViewBag.BeeAverage20100 = beeAverage20100;
        ViewBag.BeeAverage20500 = beeAverage20500;
        ViewBag.BeeAverage201000 = beeAverage201000;
        ViewBag.BeeAverage50 = beeAverage50;
        ViewBag.BeeAverage100 = beeAverage100;

        ViewBag.Greedy20100 = greedyAlgoritm20100;
        ViewBag.Greedy20500 = greedyAlgoritm20500;
        ViewBag.Greedy201000 = greedyAlgoritm201000;
        ViewBag.Greedy50 = greedyAlgoritm50;
        ViewBag.Greedy100 = greedyAlgoritm100;
        ViewBag.GreedyAverage20100 = greedyAverage20100;
        ViewBag.GreedyAverage20500 = greedyAverage20500;
        ViewBag.GreedyAverage201000 = greedyAverage201000;
        ViewBag.GreedyAverage50 = greedyAverage50;
        ViewBag.GreedyAverage100 = greedyAverage100;

        ViewBag.Enumeration20100 = enumerationAlgoritm20100;
        ViewBag.Enumeration20500 = enumerationAlgoritm20500;
        ViewBag.Enumeration201000 = enumerationAlgoritm201000;
        ViewBag.Enumeration50 = enumerationAlgoritm50;
        ViewBag.Enumeration100 = enumerationAlgoritm100; 
        ViewBag.EnumerationAverage20100 = enumerationAverage20100;
        ViewBag.EnumerationAverage20500 = enumerationAverage20500;
        ViewBag.EnumerationAverage201000 = enumerationAverage201000;
        ViewBag.EnumerationAverage50 = enumerationAverage50;
        ViewBag.EnumerationAverage100 = enumerationAverage100;

        ViewBag.Models1 = JsonConvert.SerializeObject(models1);
        ViewBag.Models2 = JsonConvert.SerializeObject(models2);

        return View();
    }
}