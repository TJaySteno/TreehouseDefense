namespace TreehouseDefense
{
	abstract class InvaderBase : IInvaderBase
	{
		private readonly Path _path;
		private int _pathStep = 0;

		protected virtual int StepSize { get; } = 1;
		
		public MapLocation? Location => _path.GetLocationAt(_pathStep);

		public abstract int Health { get; protected set; }

		public bool HasScored => _pathStep >= _path.Length;

		public bool IsNeutralized => Health <= 0;

		public bool IsActive => !(IsNeutralized || HasScored);

		public InvaderBase(Path path) => _path = path;

		public void Move() => _pathStep++;

		public virtual void DecreaseHealth(int factor) => Health -= factor;
	}
}
