using AsiaSushiOnCSharp.Domain.Entity.Base;

namespace AsiaSushiOnCSharp.Domain.Entity.Promotions
{
    public class Promotion : BaseEntity
    {
        public Promotion(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public required string Name { get; set; }

        public required string Description { get; set; }

        //public int? Image { get; set; }
    }
}
