namespace XInputDotNetExtended
{
	[System.Serializable]
	public class PlayerIndex
	{
		public int playerIndex;

		public enum PlayerIndices { One, Two, Three, Four };

		public PlayerIndex (int index)
		{
			if (index >= 0 && index <= XInputEX.NumberOfGamePads) {
				playerIndex = index;
			} else {
				throw new System.ArgumentOutOfRangeException("index", index, "The PlayerIndex must be a value from 0 through 3.");
			}
		}

		#region Shorthand Properties
		public static PlayerIndex One
		{
			get {
				return 0;
			}
		}
		public static PlayerIndex Two
		{
			get {
				return 1;
			}
		}
		public static PlayerIndex Three
		{
			get {
				return 2;
			}
		}
		public static PlayerIndex Four
		{
			get {
				return 3;
			}
		}
		#endregion

		#region Operators
		public static implicit operator PlayerIndex (int value)
		{
			return new PlayerIndex(value);
		}
		public static implicit operator int (PlayerIndex rhs)
		{
			return rhs.playerIndex;
		}
		public static implicit operator XInputDotNetPure.PlayerIndex (PlayerIndex rhs)
		{
			return (XInputDotNetPure.PlayerIndex) rhs.playerIndex;
		}
		public static implicit operator PlayerIndex (PlayerIndices rhs)
		{
			return (int) rhs;
		}
		#endregion
	}
}