namespace XInputDotNetExtended
{
	[System.Serializable]
	public class Direction
	{
		public enum Directions { Up, Right, Down, Left };
		public Directions direction;

		public Direction (Directions direction)
		{
			this.direction = direction;
		}

		#region Shorthand Properties
		public static Direction Up
		{
			get {
				return new Direction(Directions.Up);
			}
		}
		public static Direction Right
		{
			get {
				return new Direction(Directions.Right);
			}
		}
		public static Direction Down
		{
			get {
				return new Direction(Directions.Down);
			}
		}
		public static Direction Left
		{
			get {
				return new Direction(Directions.Left);
			}
		}
		#endregion
	}
}