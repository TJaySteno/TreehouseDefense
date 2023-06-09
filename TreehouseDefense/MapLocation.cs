﻿namespace TreehouseDefense
{
	class MapLocation : Point
	{
		public MapLocation(int x, int y, Map map) : base (x, y)
		{
			if (!map.OnMap(this))
			{
				throw new OutOfBoundsException($"{x},{y} is not on the map. (Map: {map.Width},{map.Height})");
			}
		}

		public bool InRangeOf(MapLocation location, int range) => DistanceTo(location) <= range;
	}
}
