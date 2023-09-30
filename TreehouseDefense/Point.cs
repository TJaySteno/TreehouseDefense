namespace TreehouseDefense
{
	internal class Point
	{
		public readonly int X;
		public readonly int Y;

		public Point(int x, int y) { X = x; Y = y; }

		public int DistanceTo(int x, int y)
		{
			return (int) Math.Sqrt( Math.Pow(X - x, 2) + Math.Pow(Y - y, 2) );
		}

		public override string ToString()
		{
			return $"{X},{Y}"; 
		}

		public override bool Equals(object? obj)
		{
			if(!(obj is Point)) // Using "is" also makes sure it's not NULL.
			{
				return false;
			}

			// Define 'that' as the object we've passed in.
			Point that = obj as Point;

			// 'this' refers to the current instance.
			return this.X.Equals(that.X) && this.Y.Equals(that.Y);
		}

		// When you override Equals(), you need to override GetHashCode() too
		public override int GetHashCode()
		{
			return X.GetHashCode() ^ (31 + Y.GetHashCode());
		}

		public int DistanceTo(Point point)
		{
			return DistanceTo(point.X, point.Y);
		}
	}
}