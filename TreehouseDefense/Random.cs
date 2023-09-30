namespace TreehouseDefense
{
	static class Random
	{
		static System.Random _random = new System.Random();

		public static double NextDouble()
		{
			return _random.NextDouble();
		}
	}
}
