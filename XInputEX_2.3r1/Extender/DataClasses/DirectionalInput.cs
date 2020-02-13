namespace XInputDotNetExtended
{
	[System.Serializable]
	public class DirectionalInput
	{
		public enum DirectionalInputs { LeftStick, RightStick, DPad };
		public DirectionalInputs directionalInput;

		public DirectionalInput (DirectionalInputs directionalInput)
		{
			this.directionalInput = directionalInput;
		}

		#region Shorthand Properties
		public static DirectionalInput LeftStick
		{
			get {
				return new DirectionalInput(DirectionalInputs.LeftStick);
			}
		}
		public static DirectionalInput RightStick
		{
			get {
				return new DirectionalInput(DirectionalInputs.RightStick);
			}
		}
		public static DirectionalInput DPad
		{
			get {
				return new DirectionalInput(DirectionalInputs.DPad);
			}
		}

		#endregion
	}
}