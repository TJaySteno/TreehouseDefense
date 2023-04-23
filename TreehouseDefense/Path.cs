using System;

namespace TreehouseDefense
{
	internal class Path
	{
		private readonly MapLocation[] _path;

		public int Length => _path.Length;

		public Path(MapLocation[] path) => _path = path;

		public MapLocation GetLocationAt(int pathStep)
		{
			return (pathStep < _path.Length)
				? _path[pathStep]
				: null;
		}

		public bool OnPath(Point point)
		{
			return true;
				// _path.Find(point) != null;
		}
	}
}
