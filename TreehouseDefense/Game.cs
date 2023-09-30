namespace TreehouseDefense
{
	class Game
	{
		public static void Main()
		{
			Map map = new Map(8,5);

			try
			{
				Path path = new Path(
					new[] {
						new MapLocation(0,2,map),
						new MapLocation(1,2,map),
						new MapLocation(2,2,map),
						new MapLocation(3,2,map),
						new MapLocation(4,2,map),
						new MapLocation(5,2,map),
						new MapLocation(6,2,map),
						new MapLocation(7,2,map)
					}
				);

				IInvaderBase[] invaders = {
					new BasicInvader(path),
					new ResurrectingInvader(path),
					new ShieldedInvader(path),
					new StrongInvader(path)
				};

				Tower[] towers = {
					new Tower (new MapLocation(1,3,map), path),
					new Tower (new MapLocation(3,3,map), path),
					new Tower (new MapLocation(4,3,map), path),
					new Tower (new MapLocation(5,3,map), path)
				};

				Level level = new Level(invaders);
				level.Towers = towers;

				bool playerwon = level.Play();

				Console.WriteLine($"Player {(playerwon ? "won! Good job!" : "lost. Friggin loser, get rekt!")}.");
			}
			catch (OutOfBoundsException ex)
			{
				Console.WriteLine(ex.Message);
			}
			catch (OnPathException ex)
			{
				Console.WriteLine(ex.Message);
			}
			catch (TreehouseDefenseException)
			{
				Console.WriteLine("Unhandled TreehouseDefenseException");
			}
			catch (Exception ex)
			{
				Console.WriteLine("Unhandled Exception: " + ex);
			}
		}
	}
}