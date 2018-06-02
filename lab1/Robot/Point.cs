
namespace Robot_Program
{
    internal sealed class Point
    {
        public int x;
        public int y;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public override int GetHashCode()
        {
            return x ^ y;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || this.GetType() != obj.GetType())
                return false;

            Point p = (Point)obj;

            return (x == p.x) && (y == p.y);
        }

        public Point DeepCopy()
        {
            return new Point(this.x, this.y);
        }
    }
}
