namespace TreehouseDefense
{
	class MapLocation : Point
	{
		public MapLocation(int x, int y, Map map) : base (x, y)
		{
			if (!map.OnMap(this))
			{
				throw new OutOfBoundsException(this + " outside the boundaries of the map.");
			}
		}

		public bool InRangeOf(MapLocation location, int range) => DistanceTo(location) <= range;
	}
}
