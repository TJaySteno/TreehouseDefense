namespace TreehouseDefense
{
	interface IMappable
	{
		MapLocation? Location { get; }
	}

	interface IMoveable
	{
		void Move();
	}

	interface IInvaderBase : IMappable, IMoveable // Inherit these interfaces, but they can also be used individually by other things.
	{
		// We want all public members of the class.
		// No constructors either.
		// Methods don't have an implementation in an Interface.
			// Remove these implementations, keep the names.
			// State whether it's a getter or setter.
		// Interfaces only define public members so we can remove 'public'.

		bool HasScored { get; }

		int Health { get; }

		bool IsNeutralized { get; }

		bool IsActive { get; }

		void DecreaseHealth(int factor);
	}
}
