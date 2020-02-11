namespace XInputDotNetExtended
{
	[System.Serializable]
	public class Vibration
	{
		public float leftMotorStrength;
		public float rightMotorStrength;
		public float duration;

		public Vibration (float leftMotorStrength, float rightMotorStrength, float duration)
		{
			this.leftMotorStrength = leftMotorStrength;
			this.rightMotorStrength = rightMotorStrength;
			this.duration = duration;
		}
	}
}