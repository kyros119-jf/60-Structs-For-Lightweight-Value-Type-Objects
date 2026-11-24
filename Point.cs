namespace _60_Structs_For_Lightweight_Value_Type_Objects
{
    public struct Point
    {
        public int X;
        public int Y;
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
     public double DistanceFromOrigin()
        {
            return Math.Sqrt(X * X + Y * Y);
        }
    }
}
