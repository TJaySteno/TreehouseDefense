namespace TreehouseDefense
{
	class StrongInvader : InvaderBase
	{
		public override int Health { get; protected set; }

		public StrongInvader(Path path) : base(path)
		{ }
	}
}