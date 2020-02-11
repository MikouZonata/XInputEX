namespace XInputDotNetExtended
{
	[System.Serializable]
	public class Axis
	{
		public enum Axes { LeftStickHorizontal, LeftStickVertical, RightStickHorizontal, RightStickVertical, DPadHorizontal, DPadVertical, Triggers };
		public Axes axis;

		public Axis (Axes axis)
		{
			this.axis = axis;
		}

		#region Shorthand Properties
		public static Axis LeftStickHorizontal
		{
			get {
				return new Axis(Axes.LeftStickHorizontal);
			}
		}
		public static Axis LeftStickVertical
		{
			get {
				return new Axis(Axes.LeftStickVertical);
			}
		}
		public static Axis RightStickHorizontal
		{
			get {
				return new Axis(Axes.RightStickHorizontal);
			}
		}
		public static Axis RightStickVertical
		{
			get {
				return new Axis(Axes.RightStickVertical);
			}
		}
		public static Axis DPadHorizontal
		{
			get {
				return new Axis(Axes.DPadHorizontal);
			}
		}
		public static Axis DPadVertical
		{
			get {
				return new Axis(Axes.DPadVertical);
			}
		}
		public static Axis Triggers
		{
			get {
				return new Axis(Axes.Triggers);
			}
		}
		#endregion
	}
}