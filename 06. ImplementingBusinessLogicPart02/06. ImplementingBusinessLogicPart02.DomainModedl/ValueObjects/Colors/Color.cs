using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06._ImplementingBusinessLogicPart02.DomainModedl.ValueObjects.Colors
{
    public class Color
    {
        //public int Id { get; set; }
        public int Red { get; set; }
        public int Green { get; set; }
        public int Blue { get; set; }
        public Color(int red, int green, int blue)
        {
            Red = red;
            Green = green;
            Blue = blue;
        }
        public Color Mix(Color color) =>
             new(
                 Red + color.Red,
                 Green + color.Green,
                 Blue + color.Blue
                );

        public override bool Equals(object? obj)
        {
            var other = obj as Color;
            if (other == null) return false;
            return other.Red == Red && Green == other.Green && Blue == other.Blue;
        }
        public static bool operator == (Color left,Color right)
        {
            return left.Equals(right);

        }
        public static bool operator != (Color left,Color right)
        {
            return left != right;
        }
    }
}
