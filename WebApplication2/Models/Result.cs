using System.Drawing;

namespace WebApplication2.Models
{
    public class Result
    {
        public string Type { get; set; }
        public int MarkerSize { get; set; }
        public string Color { get; set; }
        public string MarkerType { get; set; }
        public string LegendText { get; set; }
        public List<Point> Points { get; set; } = new List<Point>();
    }
}
