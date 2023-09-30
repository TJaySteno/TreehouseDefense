using System;

namespace TreehouseDefense
{
	internal class Tower
	{
		protected virtual int Range { get; } = 1;
		protected virtual int Power { get; } = 1;
		protected virtual double Accuracy { get; } = 0.75;

		protected readonly MapLocation _location;

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

		public bool IsSuccessfulShot() => Random.NextDouble() < Accuracy;

		public void FireOnInvaders(IInvaderBase[] invaders)
		{

			foreach (IInvaderBase invader in invaders)
			{
				if(invader.IsActive && _location.InRangeOf(invader.Location, Range))
				{

					if (IsSuccessfulShot()) {
						invader.DecreaseHealth(Power);
						
						Console.WriteLine("Hit an invader");

						if (invader.IsNeutralized)
						{
							Console.WriteLine($"Killed an invader at {invader.Location}!");
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