using System;

namespace TreehouseDefense
{
	internal class Tower
	{
		private const int _range = 1;
		private const int _power = 1;
		private const double _accuracy = 0.75;
		private readonly MapLocation _location;

		private static readonly Random _random = new Random();

		public Tower(MapLocation location, Path path)
		{
			if (path.OnPath(location))
			{
				throw new OnPathException($"{location} is not on the map.");
			}
			else
			{
				_location = location;
			}
		}

		public bool IsSuccessfulShot() => _random.NextDouble() < _accuracy;

		public void FireOnInvaders(Invader[] invaders)
		{

			foreach (Invader invader in invaders)
			{
				if(invader.IsActive && _location.InRangeOf(invader.Location, _range))
				{

					if (IsSuccessfulShot()) {
						invader.DecreaseHealth(_power);
						
						Console.WriteLine("Hit an invader");

						if (invader.IsNeutralized)
						{
							Console.WriteLine("Killed an invader");
						}
					}
					else
					{
						Console.WriteLine("Missed an invader");
					}
					
					break; // This breaks the for-each loop so tower only fires at 1 enemy
				}
			}
		}
	}
}