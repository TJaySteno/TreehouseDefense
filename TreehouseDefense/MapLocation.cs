namespace TreehouseDefense
{
	class MapLocation : Point
	{
		public MapLocation(int x, int y, Map myMap) : base (x, y)
		{
			if (!myMap.OnMap(this))
			{
				throw new OutOfBoundsException($"{x},{y} is not on the map. (Map: {myMap.Width},{myMap.Height})");
			}
		}
	}
}
