namespace WebApplication2.Models
{
    public struct BeeModel : IComparable<BeeModel>
    {
        public int Difference { get; set; }
        public int Result { get; set; }
        public string Point { get; set; }
        public int CompareTo(BeeModel bee)
        {
            return Result - bee.Result;
        }
    }
}
