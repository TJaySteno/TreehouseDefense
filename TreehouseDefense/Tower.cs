namespace TreehouseDefense
{
	internal class Tower
	{
		private readonly MapLocation _location;

		public Tower(MapLocation location)
		{
			if (location.OnPath(this))
			{
				throw new OnPathsException($"{x},{y} is not on the map. (Map: {myMap.Width},{myMap.Height})");
			}

			_location = location;
		}
	}
}
