using System;
namespace HumanSimulator
{
    public class Human
    {
        public enum GenderType
        {
            Male,
            Female
        };

        public bool Hair { get; set; }
        public string HairColor { get; set; }
        public string EyeColor { get; set; }
        public GenderType Gender { get; set; }
        public decimal Height { get; set; }
        public decimal Age { get; set; }
        public decimal Weight { get; set; }
        public string Name { get; set; }




        public Human(string name)
        {
            HairColor = string.Empty;
            Hair = true;
            Name = name;
        }

        public string SayHello()
        {
            return "Hello";
        }

        public string SayName()
        {
            return Name;
        }

        public void DyeHair(string color)
        {
            HairColor = color;
        }
    }
}
