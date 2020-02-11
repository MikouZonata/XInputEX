namespace XInputDotNetExtended
{
	[System.Serializable]
	public class Button
	{
		public enum Buttons { A, B, X, Y, Start, Back, LeftBumper, RightBumper, LeftStick, RightStick, Guide, DPadUp, DPadRight, DPadDown, DPadLeft };
		public Buttons button;

		public Button (Buttons button)
		{
			this.button = button;
		}

		#region Shorthand Properties
		public static Button A
		{
			get {
				return new Button(Buttons.A);
			}
		}
		public static Button B
		{
			get {
				return new Button(Buttons.B);
			}
		}
		public static Button X
		{
			get {
				return new Button(Buttons.X);
			}
		}
		public static Button Y
		{
			get {
				return new Button(Buttons.Y);
			}
		}
		public static Button Start
		{
			get {
				return new Button(Buttons.Start);
			}
		}
		public static Button Back
		{
			get {
				return new Button(Buttons.Back);
			}
		}
		public static Button LeftBumper
		{
			get {
				return new Button(Buttons.LeftBumper);
			}
		}
		public static Button RightBumper
		{
			get {
				return new Button(Buttons.RightBumper);
			}
		}
		public static Button LeftStick
		{
			get {
				return new Button(Buttons.LeftStick);
			}
		}
		public static Button RightStick
		{
			get {
				return new Button(Buttons.RightStick);
			}
		}
		public static Button Guide
		{
			get {
				return new Button(Buttons.Guide);
			}
		}
		public static Button DPadUp
		{
			get {
				return new Button(Buttons.DPadUp);
			}
		}
		public static Button DPadRight
		{
			get {
				return new Button(Buttons.DPadRight);
			}
		}
		public static Button DPadDown
		{
			get {
				return new Button(Buttons.DPadDown);
			}
		}
		public static Button DPadLeft
		{
			get {
				return new Button(Buttons.DPadLeft);
			}
		}
		#endregion
	}
}