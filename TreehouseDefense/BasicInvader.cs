namespace TreehouseDefense
{
	class BasicInvader : InvaderBase
	{
		public override int Health { get; protected set; }
		public BasicInvader(Path path) : base(path)
		{ }
	}
}