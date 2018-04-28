namespace InvaderGame
{
    public class Map
    {
        public readonly int Heigh;
        public readonly int Width;

        public Map(int width, int height)
        {
            Width = width;
            Heigh = height;
        }

        public bool OnMap(Point point)
        {
            bool inBounds = point.X >= 0 && point.X < Width && 
                            point.Y >= 0 && point.Y < Heigh;
            return inBounds;
        }
    }
}
