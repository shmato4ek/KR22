using System.Drawing;

namespace WebApplication2.Models
{
    public class TestModel: IComparable<TestModel>
    {
        public int Cost { get; set; }
        public Point Cords { get; set; }
        public int CompareTo(TestModel? shop)
        {
            if (shop is null) throw new ArgumentException("Некорректное значение параметра");
            return shop.Cost - Cost;
        }
    }
}
