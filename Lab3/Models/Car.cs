using Lab3_23.Models.Base;

namespace Lab3_23.Models
{
    public class Car: BaseEntity
    {
        public string? Brand { get; set; }
        public string? Model{get;set;}
        public string? Vin { get; set; }
        public int HorsePower{get;set;}
        public int Torque{get;set;}

    }
}