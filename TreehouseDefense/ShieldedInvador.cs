namespace TreehouseDefense
{
	class ShieldedInvader : InvaderBase
	{
		public override int Health { get; protected set; }

		public ShieldedInvader(Path path) : base(path) { }

		public override void DecreaseHealth(int factor)
		{
			if(Random.NextDouble() < .5)
			{
				base.DecreaseHealth(factor);
			}
			else
			{
				System.Console.WriteLine("Shot at a shielded invader but it sustained no damage.");
			}	
			
		}
	}
}