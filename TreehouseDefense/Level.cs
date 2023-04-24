namespace TreehouseDefense
{
	internal class Level
	{
		public readonly Invader[] _invaders;
		private const bool _win = true;
		private const bool _lose = false;

		public Tower[] Towers { get; set; }

		public Level(Invader[] invaders) => _invaders = invaders;

		// Returns true if the player wins, otherwise returns false
		public bool Play()
		{
			// Run until all invaders are killed or an invader reaches the end
			int remainingInvaders = _invaders.Length;

			while(remainingInvaders > 0)
			{
				Console.WriteLine(remainingInvaders.ToString());

				// Each tower has opportunity to fire on invaders
				foreach(Tower tower in Towers)
				{
					tower.FireOnInvaders(_invaders);
				}

				// Count and move the invaders that are still active
				remainingInvaders = 0;
				foreach(Invader invader in _invaders)
				{
					if(invader.IsActive)
					{
						invader.Move();
						
						if(invader.HasScored) { return _lose; }

						remainingInvaders++;
					}
				}
			}

			return _win;
		}

	}
}
