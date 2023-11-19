namespace PowerStartDDD.DomainModelBuildingBlocks.ValueObjects.ValueObjects
{
    public class ColorValueObject(int red, int green, int blue)
    {
        public readonly int Red  = red;
        public readonly int Green  = green;
        public readonly int Blue = blue;

        public ColorValueObject MixWith(ColorValueObject other)=>
            new(Math.Min(Red + other.Red, 255),
                Math.Min(Green + other.Green, 255),
                Math.Min(Blue + other.Blue, 255));

        public override bool Equals(object? obj)
        {
            var other = obj as ColorValueObject;

            return other != null
                && other.Red == Red
                && other.Blue == Blue
                && other.Green == Green;
        }

        public static bool operator ==(ColorValueObject left, ColorValueObject right)
        {
            if(left is null)
                return right is null;
            return left.Equals(right);
        }

        public static bool operator !=(ColorValueObject left, ColorValueObject right) =>
            !(left == right);

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public override string ToString()
        {
            return $"R:{Red} - G:{Green} - Blue:{Blue}";
        }

    }
}
