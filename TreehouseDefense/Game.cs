namespace TreehouseDefense
{
	class Game
	{
		public static void Main()
		{
			Map myMap = new Map(8,5);

			/* ~~ INHERITENCE ~~
			Point point1 = new Point(4, 2);
			Point point2 = new MapLocation(4, 3);
			// MapLocation point3 = new Point(4, 2);
				// This throws errors
					// 
			MapLocation point4 = new MapLocation(4, 5);
			
			Console.WriteLine(myMap.OnMap(point1));
			Console.WriteLine(point1.DistanceTo(5,5));
			Console.WriteLine(point4.DistanceTo(point2));
			
			Console.WriteLine(point1 is Point);
			Console.WriteLine(point4 is Point);
			Console.WriteLine(point1 is MapLocation);
			Console.WriteLine(point4 is MapLocation);
			*/

			try
			{
				Path path = new Path(
					new[] {
						new MapLocation(0,2,myMap),
						new MapLocation(1,2,myMap),
						new MapLocation(2,2,myMap),
						new MapLocation(3,2,myMap),
						new MapLocation(4,2,myMap),
						new MapLocation(5,2,myMap),
						new MapLocation(6,2,myMap),
						new MapLocation(7,2,myMap)
					}
				);

				Invader invader = new Invader(path);
				MapLocation location = new MapLocation(0,0,myMap);
			}
			catch (OutOfBoundsException ex)
			{
				Console.WriteLine(ex.Message);
			}
			catch (TreehouseDefenseException)
			{
				Console.WriteLine("Unhandled TreehouseDefenseException");
			}
			catch (OnPathException)
			{
				Console.WriteLine("Unhandled OnPathException");
			}
			catch (Exception ex)
			{
				Console.WriteLine("Unhandled Exception: " + ex);
			}
		}
	}
}