using WebApplication2.Models;

namespace WebApplication2
{
    public class Alghoritm
    {
        public static AlghoritmResult Greedy(List<TestModel> shops)
        {
            shops.Sort();
            var shop1 = shops[0];
            var shop2 = shops[1];
            string point;
            int difference;
            if(Math.Abs(shop1.Cords.X - shop2.Cords.X) > Math.Abs(shop1.Cords.Y - shop2.Cords.Y))
            {
                point = "x";
                difference = (shop1.Cords.X + shop2.Cords.X) / 2;
            }
            else
            {
                point = "y";
                difference = (shop1.Cords.Y + shop2.Cords.Y) / 2;
            }
            var firstPart = new List<TestModel>();
            var secondPart = new List<TestModel>();
            foreach(var shop in shops)
            {
                if (point == "x")
                {
                    if(shop.Cords.X < difference)
                    {
                        firstPart.Add(shop);
                    }
                    else
                    {
                        secondPart.Add(shop);
                    }
                }
                else
                {
                    if (shop.Cords.Y < difference)
                    {
                        firstPart.Add(shop);
                    }
                    else
                    {
                        secondPart.Add(shop);
                    }    
                }
            }
            var result = new AlghoritmResult();
            var cords = new List<Point>();
            if(point == "x")
            {
                cords.Add(new Point() { X = difference, Y = 0 });
                cords.Add(new Point() { X = difference, Y = 20 });
            }
            else
            {
                cords.Add(new Point() { X = 0, Y = difference });
                cords.Add(new Point() { X = 20, Y = difference });
            }
            result.Cords = cords;
            int sum1 = 0;
            int sum2 = 0;
            foreach (var shop in firstPart)
            {
                sum1 += shop.Cost;
            }
            foreach (var shop in secondPart)
            {
                sum2 += shop.Cost;
            }
            result.Result = Math.Abs(sum1 - sum2);
            result.FirstSum = sum1;
            result.SecondSum = sum2;
            return result;
        }

        public static AlghoritmResult Enumeration(List<TestModel> shops)
        {
            var xLineDictionary = new Dictionary<int, int>();
            var xResults = new List<int>();
            for(int dif = 4; dif < 20; dif+=4)
            {
                var res = Result(shops, dif, "x");
                xLineDictionary.Add(dif, res);
                xResults.Add(res);
            }
            xResults.Sort();
            var xRes = xResults.First();
            var xDifference = xLineDictionary.FirstOrDefault(line => line.Value == xRes);      
            
            var yLineDictionary = new Dictionary<int, int>();
            var yResults = new List<int>();
            for(int dif = 4; dif < 20; dif+=4)
            {
                var res = Result(shops, dif, "y");
                yLineDictionary.Add(dif, res);
                yResults.Add(res);
            }
            yResults.Sort();
            var yRes = yResults.First();
            var yDifference = yLineDictionary.FirstOrDefault(line => line.Value == yRes);
            var result = new AlghoritmResult();
            result.Result = xRes > yRes ? xRes : yRes;
            string point;
            if(result.Result == xRes)
            {
                point = "x";
            }
            else
            {
                point = "y";
            }
            var firstPart = new List<TestModel>();
            var secondPart = new List<TestModel>();
            foreach (var shop in shops)
            {
                if (point == "x")
                {
                    if (shop.Cords.X < xDifference.Key)
                    {
                        firstPart.Add(shop);
                    }
                    else
                    {
                        secondPart.Add(shop);
                    }
                }
                else
                {
                    if (shop.Cords.Y < yDifference.Key)
                    {
                        firstPart.Add(shop);
                    }
                    else
                    {
                        secondPart.Add(shop);
                    }
                }
            }
            var cords = new List<Point>();
            if (point == "x")
            {
                cords.Add(new Point() { X = xDifference.Key, Y = 0 });
                cords.Add(new Point() { X = xDifference.Key, Y = 20 });
            }
            else
            {
                cords.Add(new Point() { X = 0, Y = yDifference.Key });
                cords.Add(new Point() { X = 20, Y = yDifference.Key });
            }
            result.Cords = cords;
            int sum1 = 0;
            int sum2 = 0;
            foreach (var shop in firstPart)
            {
                sum1 += shop.Cost;
            }
            foreach (var shop in secondPart)
            {
                sum2 += shop.Cost;
            }
            result.Result = Math.Abs(sum1 - sum2);
            result.FirstSum = sum1;
            result.SecondSum = sum2;
            return result;
        }

        public static AlghoritmResult Bee(List<TestModel> shops)
        {
            var _random = new Random();
            var current = new List<BeeModel>();
            var bee1 = new BeeModel() { Point = "x", Difference = _random.Next(2, 18) };
            bee1.Result = Result(shops, bee1.Difference, bee1.Point);
            current.Add(bee1);
            var bee2 = new BeeModel() { Point = "x", Difference = _random.Next(2, 18) };
            bee2.Result = Result(shops, bee2.Difference, bee2.Point);
            current.Add(bee2);
            var bee3 = new BeeModel() { Point = "y", Difference = _random.Next(2, 18) };
            bee3.Result = Result(shops, bee3.Difference, bee3.Point);
            current.Add(bee3);
            var bee4 = new BeeModel() { Point = "y", Difference = _random.Next(2, 18) };
            bee4.Result = Result(shops, bee4.Difference, bee4.Point);
            current.Add(bee4);
            current.Sort();
            var flag = true;
            while(current.Count < 20 && flag)
            {
                flag = false;
                var firstBee = current[0];
                var secondBee = current[1];
                var bee11 = new BeeModel() { Difference = firstBee.Difference - 1, Point = firstBee.Point, Result = Result(shops, firstBee.Difference - 1, firstBee.Point)};
                var bee12 = new BeeModel() { Difference = firstBee.Difference + 1, Point = firstBee.Point, Result = Result(shops, firstBee.Difference + 1, firstBee.Point)};
                var bee21 = new BeeModel() { Difference = secondBee.Difference - 1, Point = secondBee.Point, Result = Result(shops, secondBee.Difference - 1, secondBee.Point)};
                var bee22 = new BeeModel() { Difference = secondBee.Difference + 1, Point = secondBee.Point, Result = Result(shops, secondBee.Difference + 1, secondBee.Point)};
                var newBeeX = new BeeModel() { Difference = _random.Next(1, 19), Point = "x" };
                var newBeeY = new BeeModel() { Difference = _random.Next(1, 19), Point = "y" };
                newBeeX.Result = Result(shops, newBeeX.Difference, "x");
                newBeeY.Result = Result(shops, newBeeY.Difference, "y");

                if(!current.Contains(bee11) && firstBee.Difference != 1)
                {
                    current.Add(bee11);
                    flag = true;
                }                    
                if(!current.Contains(bee12) && firstBee.Difference != 19)
                {
                    current.Add(bee12);
                    flag = true;
                }
                if (!current.Contains(bee21) && secondBee.Difference != 19)
                {
                    current.Add(bee21);
                    flag = true;
                }
                if (!current.Contains(bee22) && secondBee.Difference != 19)
                {
                    current.Add(bee22);
                    flag = true;
                }
                if(!current.Contains(newBeeX))
                {
                    current.Add(newBeeX);
                    flag = true;
                }                
                if(!current.Contains(newBeeY))
                {
                    current.Add(newBeeY);
                    flag = true;
                }
                current.Sort();
            }
            var beeResult = current.First();
            var result = new AlghoritmResult();
            result.Result = beeResult.Result;
            var firstPart = new List<TestModel>();
            var secondPart = new List<TestModel>();
            foreach (var shop in shops)
            {
                if (beeResult.Point == "x")
                {
                    if (shop.Cords.X < beeResult.Difference)
                    {
                        firstPart.Add(shop);
                    }
                    else
                    {
                        secondPart.Add(shop);
                    }
                }
                else
                {
                    if (shop.Cords.Y < beeResult.Difference)
                    {
                        firstPart.Add(shop);
                    }
                    else
                    {
                        secondPart.Add(shop);
                    }
                }
            }
            var cords = new List<Point>();
            if (beeResult.Point == "x")
            {
                cords.Add(new Point() { X = beeResult.Difference, Y = 0 });
                cords.Add(new Point() { X = beeResult.Difference, Y = 20 });
            }
            else
            {
                cords.Add(new Point() { X = 0, Y = beeResult.Difference });
                cords.Add(new Point() { X = 20, Y = beeResult.Difference });
            }
            result.Cords = cords;
            int sum1 = 0;
            int sum2 = 0;
            foreach (var shop in firstPart)
            {
                sum1 += shop.Cost;
            }
            foreach (var shop in secondPart)
            {
                sum2 += shop.Cost;
            }
            result.Result = Math.Abs(sum1 - sum2);
            result.FirstSum = sum1;
            result.SecondSum = sum2;
            return result;
        }

        private static int Result(List<TestModel> shops, int difference, string point)
        {
            var firstPart = new List<TestModel>();
            var secondPart = new List<TestModel>();
            foreach (var shop in shops)
            {
                if (point == "x")
                {
                    if (shop.Cords.X < difference)
                    {
                        firstPart.Add(shop);
                    }
                    else
                    {
                        secondPart.Add(shop);
                    }
                }
                else
                {
                    if (shop.Cords.Y < difference)
                    {
                        firstPart.Add(shop);
                    }
                    else
                    {
                        secondPart.Add(shop);
                    }
                }
            }
            var result = new AlghoritmResult();
            var cords = new List<Point>();
            if (point == "x")
            {
                cords.Add(new Point() { X = difference, Y = 0 });
                cords.Add(new Point() { X = difference, Y = 20 });
            }
            else
            {
                cords.Add(new Point() { X = 0, Y = difference });
                cords.Add(new Point() { X = 20, Y = difference });
            }
            result.Cords = cords;
            int sum1 = 0;
            int sum2 = 0;
            foreach (var shop in firstPart)
            {
                sum1 += shop.Cost;
            }
            foreach (var shop in secondPart)
            {
                sum2 += shop.Cost;
            }
            return Math.Abs(sum1 - sum2);
        }
    }
}
