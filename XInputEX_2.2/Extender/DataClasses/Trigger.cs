namespace XInputDotNetExtended
{
	[System.Serializable]
	public class Trigger
	{
		public enum Triggers { Left, Right };
		public Triggers trigger;

		public Trigger (Triggers trigger)
		{
			this.trigger = trigger;
		}

		#region Shorthand Properties
		public static Trigger Left
		{
			get {
				return new Trigger(Triggers.Left);
			}
		}
		public static Trigger Right
		{
			get {
				return new Trigger(Triggers.Right);
			}
		}
		#endregion
	}
}