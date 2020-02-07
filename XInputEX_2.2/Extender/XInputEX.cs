using XInputDotNetPure;
using UnityEngine;
using XInputDotNetExtended.Vibrations;

namespace XInputDotNetExtended
{
	public static class XInputEX
	{
		public const int NumberOfGamePads = 4;

		private static GamePadState[] _prevStates = new GamePadState[NumberOfGamePads];
		private static GamePadState[] _currentStates = new GamePadState[NumberOfGamePads];

		private static VibrationHandler _vibrationHandler = new VibrationHandler();

		static XInputEX ()
		{
			GameObject updaterGO = new GameObject("XInputDotNetUpdater", typeof(XInputDotNetUpdater));
			updaterGO.hideFlags = HideFlags.HideInHierarchy;
			XInputDotNetUpdater.OnUpdate += Update;
		}

		private static void Update ()
		{
			UpdateGamePadStates();

			_vibrationHandler.Update();
		}

		private static void UpdateGamePadStates ()
		{
			for (int i = 0; i < NumberOfGamePads; i++) {
				_prevStates[i] = _currentStates[i];
				_currentStates[i] = GamePad.GetState((XInputDotNetPure.PlayerIndex) i);
			}
		}

		#region GetButton functions
		/// <summary>
		/// Returns true if the given button is pressed, false if it's not.
		/// </summary>
		/// <param name="playerIndex">Which controller would you like to check?</param>
		/// <param name="button">Which button should be checked?</param>
		public static bool GetButton (PlayerIndex playerIndex, Button button)
		{
			switch (button.button) {
				default:
					return false;
				case Button.Buttons.A:
					if (_currentStates[playerIndex].Buttons.A == ButtonState.Pressed)
						return true;
					else
						return false;
				case Button.Buttons.B:
					if (_currentStates[playerIndex].Buttons.B == ButtonState.Pressed)
						return true;
					else
						return false;
				case Button.Buttons.X:
					if (_currentStates[playerIndex].Buttons.X == ButtonState.Pressed)
						return true;
					else
						return false;
				case Button.Buttons.Y:
					if (_currentStates[playerIndex].Buttons.Y == ButtonState.Pressed)
						return true;
					else
						return false;
				case Button.Buttons.Start:
					if (_currentStates[playerIndex].Buttons.Start == ButtonState.Pressed)
						return true;
					else
						return false;
				case Button.Buttons.Back:
					if (_currentStates[playerIndex].Buttons.Back == ButtonState.Pressed)
						return true;
					else
						return false;
				case Button.Buttons.LeftBumper:
					if (_currentStates[playerIndex].Buttons.LeftShoulder == ButtonState.Pressed)
						return true;
					else
						return false;
				case Button.Buttons.RightBumper:
					if (_currentStates[playerIndex].Buttons.RightShoulder == ButtonState.Pressed)
						return true;
					else
						return false;
				case Button.Buttons.LeftStick:
					if (_currentStates[playerIndex].Buttons.LeftStick == ButtonState.Pressed)
						return true;
					else
						return false;
				case Button.Buttons.RightStick:
					if (_currentStates[playerIndex].Buttons.RightStick == ButtonState.Pressed)
						return true;
					else
						return false;
				case Button.Buttons.Guide:
					if (_currentStates[playerIndex].Buttons.Guide == ButtonState.Pressed)
						return true;
					else
						return false;
				case Button.Buttons.DPadUp:
					if (_currentStates[playerIndex].DPad.Up == ButtonState.Pressed)
						return true;
					else
						return false;
				case Button.Buttons.DPadRight:
					if (_currentStates[playerIndex].DPad.Right == ButtonState.Pressed)
						return true;
					else
						return false;
				case Button.Buttons.DPadDown:
					if (_currentStates[playerIndex].DPad.Down == ButtonState.Pressed)
						return true;
					else
						return false;
				case Button.Buttons.DPadLeft:
					if (_currentStates[playerIndex].DPad.Left == ButtonState.Pressed)
						return true;
					else
						return false;

			}
		}
		/// <summary>
		/// Returns true if the given button is pressed and wasn't pressed the previous frame.
		/// </summary>
		/// <param name="playerIndex">Which controller would you like to check?</param>
		/// <param name="button">Which button should be checked?</param>
		public static bool GetButtonDown (PlayerIndex playerIndex, Button button)
		{
			switch (button.button) {
				default:
					return false;
				case Button.Buttons.A:
					if (_prevStates[playerIndex].Buttons.A == ButtonState.Released && _currentStates[playerIndex].Buttons.A == ButtonState.Pressed)
						return true;
					else
						return false;
				case Button.Buttons.B:
					if (_prevStates[playerIndex].Buttons.B == ButtonState.Released && _currentStates[playerIndex].Buttons.B == ButtonState.Pressed)
						return true;
					else
						return false;
				case Button.Buttons.X:
					if (_prevStates[playerIndex].Buttons.X == ButtonState.Released && _currentStates[playerIndex].Buttons.X == ButtonState.Pressed)
						return true;
					else
						return false;
				case Button.Buttons.Y:
					if (_prevStates[playerIndex].Buttons.Y == ButtonState.Released && _currentStates[playerIndex].Buttons.Y == ButtonState.Pressed)
						return true;
					else
						return false;
				case Button.Buttons.Start:
					if (_prevStates[playerIndex].Buttons.Start == ButtonState.Released && _currentStates[playerIndex].Buttons.Start == ButtonState.Pressed)
						return true;
					else
						return false;
				case Button.Buttons.Back:
					if (_prevStates[playerIndex].Buttons.Back == ButtonState.Released && _currentStates[playerIndex].Buttons.Back == ButtonState.Pressed)
						return true;
					else
						return false;
				case Button.Buttons.LeftBumper:
					if (_prevStates[playerIndex].Buttons.LeftShoulder == ButtonState.Released && _currentStates[playerIndex].Buttons.LeftShoulder == ButtonState.Pressed)
						return true;
					else
						return false;
				case Button.Buttons.RightBumper:
					if (_prevStates[playerIndex].Buttons.RightShoulder == ButtonState.Released && _currentStates[playerIndex].Buttons.RightShoulder == ButtonState.Pressed)
						return true;
					else
						return false;
				case Button.Buttons.LeftStick:
					if (_prevStates[playerIndex].Buttons.LeftStick == ButtonState.Released && _currentStates[playerIndex].Buttons.LeftStick == ButtonState.Pressed)
						return true;
					else
						return false;
				case Button.Buttons.RightStick:
					if (_prevStates[playerIndex].Buttons.RightStick == ButtonState.Released && _currentStates[playerIndex].Buttons.RightStick == ButtonState.Pressed)
						return true;
					else
						return false;
				case Button.Buttons.Guide:
					if (_prevStates[playerIndex].Buttons.Guide == ButtonState.Released && _currentStates[playerIndex].Buttons.Guide == ButtonState.Pressed)
						return true;
					else
						return false;
				case Button.Buttons.DPadUp:
					if (_prevStates[playerIndex].DPad.Up == ButtonState.Released && _currentStates[playerIndex].DPad.Up == ButtonState.Pressed)
						return true;
					else
						return false;
				case Button.Buttons.DPadRight:
					if (_prevStates[playerIndex].DPad.Right == ButtonState.Released && _currentStates[playerIndex].DPad.Right == ButtonState.Pressed)
						return true;
					else
						return false;
				case Button.Buttons.DPadDown:
					if (_prevStates[playerIndex].DPad.Down == ButtonState.Released && _currentStates[playerIndex].DPad.Down == ButtonState.Pressed)
						return true;
					else
						return false;
				case Button.Buttons.DPadLeft:
					if (_prevStates[playerIndex].DPad.Left == ButtonState.Released && _currentStates[playerIndex].DPad.Left == ButtonState.Pressed)
						return true;
					else
						return false;

			}
		}
		/// <summary>
		/// Returns true if the given button is released and was pressed the previous frame.
		/// </summary>
		/// <param name="playerIndex">Which controller would you like to check?</param>
		/// <param name="button">Which button should be checked?</param>
		public static bool GetButtonUp (PlayerIndex playerIndex, Button button)
		{
			switch (button.button) {
				default:
					return false;
				case Button.Buttons.A:
					if (_prevStates[playerIndex].Buttons.A == ButtonState.Pressed && _currentStates[playerIndex].Buttons.A == ButtonState.Released)
						return true;
					else
						return false;
				case Button.Buttons.B:
					if (_prevStates[playerIndex].Buttons.B == ButtonState.Pressed && _currentStates[playerIndex].Buttons.B == ButtonState.Released)
						return true;
					else
						return false;
				case Button.Buttons.X:
					if (_prevStates[playerIndex].Buttons.X == ButtonState.Pressed && _currentStates[playerIndex].Buttons.X == ButtonState.Released)
						return true;
					else
						return false;
				case Button.Buttons.Y:
					if (_prevStates[playerIndex].Buttons.Y == ButtonState.Pressed && _currentStates[playerIndex].Buttons.Y == ButtonState.Released)
						return true;
					else
						return false;
				case Button.Buttons.Start:
					if (_prevStates[playerIndex].Buttons.Start == ButtonState.Pressed && _currentStates[playerIndex].Buttons.Start == ButtonState.Released)
						return true;
					else
						return false;
				case Button.Buttons.Back:
					if (_prevStates[playerIndex].Buttons.Back == ButtonState.Pressed && _currentStates[playerIndex].Buttons.Back == ButtonState.Released)
						return true;
					else
						return false;
				case Button.Buttons.LeftBumper:
					if (_prevStates[playerIndex].Buttons.LeftShoulder == ButtonState.Pressed && _currentStates[playerIndex].Buttons.LeftShoulder == ButtonState.Released)
						return true;
					else
						return false;
				case Button.Buttons.RightBumper:
					if (_prevStates[playerIndex].Buttons.RightShoulder == ButtonState.Pressed && _currentStates[playerIndex].Buttons.RightShoulder == ButtonState.Released)
						return true;
					else
						return false;
				case Button.Buttons.LeftStick:
					if (_prevStates[playerIndex].Buttons.LeftStick == ButtonState.Pressed && _currentStates[playerIndex].Buttons.LeftStick == ButtonState.Released)
						return true;
					else
						return false;
				case Button.Buttons.RightStick:
					if (_prevStates[playerIndex].Buttons.RightStick == ButtonState.Pressed && _currentStates[playerIndex].Buttons.RightStick == ButtonState.Released)
						return true;
					else
						return false;
				case Button.Buttons.Guide:
					if (_prevStates[playerIndex].Buttons.Guide == ButtonState.Pressed && _currentStates[playerIndex].Buttons.Guide == ButtonState.Released)
						return true;
					else
						return false;
				case Button.Buttons.DPadUp:
					if (_prevStates[playerIndex].DPad.Up == ButtonState.Pressed && _currentStates[playerIndex].DPad.Up == ButtonState.Released)
						return true;
					else
						return false;
				case Button.Buttons.DPadRight:
					if (_prevStates[playerIndex].DPad.Right == ButtonState.Pressed && _currentStates[playerIndex].DPad.Right == ButtonState.Released)
						return true;
					else
						return false;
				case Button.Buttons.DPadDown:
					if (_prevStates[playerIndex].DPad.Down == ButtonState.Pressed && _currentStates[playerIndex].DPad.Down == ButtonState.Released)
						return true;
					else
						return false;
				case Button.Buttons.DPadLeft:
					if (_prevStates[playerIndex].DPad.Left == ButtonState.Pressed && _currentStates[playerIndex].DPad.Left == ButtonState.Released)
						return true;
					else
						return false;

			}
		}
		#endregion

		#region GetDirection functions
		/// <summary>
		/// Returns true if the given directional input is held.
		/// </summary>
		/// <param name="playerIndex">Which controller would you like to check?</param>
		/// <param name="directionalInput">Which input would you like to check?</param>
		/// <param name="direction">Which direction would you like to check?</param>
		/// <param name="stickDeadzone">How much of a deadzone should be applied? (sticks only)</param>
		public static bool GetDirection (PlayerIndex playerIndex, DirectionalInput directionalInput, Direction direction, float stickDeadzone = .12f)
		{
			switch (directionalInput.directionalInput) {
				default:
					return false;
				case DirectionalInput.DirectionalInputs.LeftStick:
					switch (direction.direction) {
						default:
							return false;
						case Direction.Directions.Up:
							if (_currentStates[playerIndex].ThumbSticks.Left.Y >= stickDeadzone)
								return true;
							else
								return false;
						case Direction.Directions.Right:
							if (_currentStates[playerIndex].ThumbSticks.Left.X >= stickDeadzone)
								return true;
							else
								return false;
						case Direction.Directions.Down:
							if (_currentStates[playerIndex].ThumbSticks.Left.Y <= -stickDeadzone)
								return true;
							else
								return false;
						case Direction.Directions.Left:
							if (_currentStates[playerIndex].ThumbSticks.Left.X <= -stickDeadzone)
								return true;
							else
								return false;
					}
				case DirectionalInput.DirectionalInputs.RightStick:
					switch (direction.direction) {
						default:
							return false;
						case Direction.Directions.Up:
							if (_currentStates[playerIndex].ThumbSticks.Right.Y >= stickDeadzone)
								return true;
							else
								return false;
						case Direction.Directions.Right:
							if (_currentStates[playerIndex].ThumbSticks.Right.X >= stickDeadzone)
								return true;
							else
								return false;
						case Direction.Directions.Down:
							if (_currentStates[playerIndex].ThumbSticks.Right.Y <= -stickDeadzone)
								return true;
							else
								return false;
						case Direction.Directions.Left:
							if (_currentStates[playerIndex].ThumbSticks.Right.X <= -stickDeadzone)
								return true;
							else
								return false;
					}
				case DirectionalInput.DirectionalInputs.DPad:
					switch (direction.direction) {
						default:
							return false;
						case Direction.Directions.Up:
							if (_currentStates[playerIndex].DPad.Up == ButtonState.Pressed)
								return true;
							else
								return false;
						case Direction.Directions.Right:
							if (_currentStates[playerIndex].DPad.Right == ButtonState.Pressed)
								return true;
							else
								return false;
						case Direction.Directions.Down:
							if (_currentStates[playerIndex].DPad.Down == ButtonState.Pressed)
								return true;
							else
								return false;
						case Direction.Directions.Left:
							if (_currentStates[playerIndex].DPad.Left == ButtonState.Pressed)
								return true;
							else
								return false;
					}
			}
		}
		/// <summary>
		/// Returns true if the given directional input is held and wasn't held the previous frame.
		/// </summary>
		/// <param name="playerIndex">Which controller would you like to check?</param>
		/// <param name="directionalInput">Which input would you like to check?</param>
		/// <param name="direction">Which direction would you like to check?</param>
		/// <param name="stickDeadzone">How much of a deadzone should be applied? (sticks only)</param>
		public static bool GetDirectionDown (PlayerIndex playerIndex, DirectionalInput directionalInput, Direction direction, float stickDeadzone = .12f)
		{
			switch (directionalInput.directionalInput) {
				default:
					return false;
				case DirectionalInput.DirectionalInputs.LeftStick:
					switch (direction.direction) {
						default:
							return false;
						case Direction.Directions.Up:
							if (_prevStates[playerIndex].ThumbSticks.Left.Y < stickDeadzone && _currentStates[playerIndex].ThumbSticks.Left.Y >= stickDeadzone)
								return true;
							else
								return false;
						case Direction.Directions.Right:
							if (_prevStates[playerIndex].ThumbSticks.Left.X < stickDeadzone && _currentStates[playerIndex].ThumbSticks.Left.X >= stickDeadzone)
								return true;
							else
								return false;
						case Direction.Directions.Down:
							if (_prevStates[playerIndex].ThumbSticks.Left.Y > -stickDeadzone && _currentStates[playerIndex].ThumbSticks.Left.Y <= -stickDeadzone)
								return true;
							else
								return false;
						case Direction.Directions.Left:
							if (_prevStates[playerIndex].ThumbSticks.Left.X > -stickDeadzone && _currentStates[playerIndex].ThumbSticks.Left.X <= -stickDeadzone)
								return true;
							else
								return false;
					}
				case DirectionalInput.DirectionalInputs.RightStick:
					switch (direction.direction) {
						default:
							return false;
						case Direction.Directions.Up:
							if (_prevStates[playerIndex].ThumbSticks.Right.Y < stickDeadzone && _currentStates[playerIndex].ThumbSticks.Right.Y >= stickDeadzone)
								return true;
							else
								return false;
						case Direction.Directions.Right:
							if (_prevStates[playerIndex].ThumbSticks.Right.X < stickDeadzone && _currentStates[playerIndex].ThumbSticks.Right.X >= stickDeadzone)
								return true;
							else
								return false;
						case Direction.Directions.Down:
							if (_prevStates[playerIndex].ThumbSticks.Right.Y > -stickDeadzone && _currentStates[playerIndex].ThumbSticks.Right.Y <= -stickDeadzone)
								return true;
							else
								return false;
						case Direction.Directions.Left:
							if (_prevStates[playerIndex].ThumbSticks.Right.X > -stickDeadzone && _currentStates[playerIndex].ThumbSticks.Right.X <= -stickDeadzone)
								return true;
							else
								return false;
					}
				case DirectionalInput.DirectionalInputs.DPad:
					switch (direction.direction) {
						default:
							return false;
						case Direction.Directions.Up:
							if (_prevStates[playerIndex].DPad.Up == ButtonState.Released && _currentStates[playerIndex].DPad.Up == ButtonState.Pressed)
								return true;
							else
								return false;
						case Direction.Directions.Right:
							if (_prevStates[playerIndex].DPad.Right == ButtonState.Released && _currentStates[playerIndex].DPad.Right == ButtonState.Pressed)
								return true;
							else
								return false;
						case Direction.Directions.Down:
							if (_prevStates[playerIndex].DPad.Down == ButtonState.Released && _currentStates[playerIndex].DPad.Down == ButtonState.Pressed)
								return true;
							else
								return false;
						case Direction.Directions.Left:
							if (_prevStates[playerIndex].DPad.Left == ButtonState.Released && _currentStates[playerIndex].DPad.Left == ButtonState.Pressed)
								return true;
							else
								return false;
					}
			}
		}
		/// <summary>
		/// Returns true if the given directional input is released and was held the previous frame.
		/// </summary>
		/// <param name="playerIndex">Which controller would you like to check?</param>
		/// <param name="directionalInput">Which input would you like to check?</param>
		/// <param name="direction">Which direction would you like to check?</param>
		/// <param name="stickDeadzone">How much of a deadzone should be applied? (sticks only)</param>
		public static bool GetDirectionUp (PlayerIndex playerIndex, DirectionalInput directionalInput, Direction direction, float stickDeadzone = .12f)
		{
			switch (directionalInput.directionalInput) {
				default:
					return false;
				case DirectionalInput.DirectionalInputs.LeftStick:
					switch (direction.direction) {
						default:
							return false;
						case Direction.Directions.Up:
							if (_prevStates[playerIndex].ThumbSticks.Left.Y >= stickDeadzone && _currentStates[playerIndex].ThumbSticks.Left.Y < stickDeadzone)
								return true;
							else
								return false;
						case Direction.Directions.Right:
							if (_prevStates[playerIndex].ThumbSticks.Left.X >= stickDeadzone && _currentStates[playerIndex].ThumbSticks.Left.X < stickDeadzone)
								return true;
							else
								return false;
						case Direction.Directions.Down:
							if (_prevStates[playerIndex].ThumbSticks.Left.Y <= -stickDeadzone && _currentStates[playerIndex].ThumbSticks.Left.Y > -stickDeadzone)
								return true;
							else
								return false;
						case Direction.Directions.Left:
							if (_prevStates[playerIndex].ThumbSticks.Left.X <= -stickDeadzone && _currentStates[playerIndex].ThumbSticks.Left.X > -stickDeadzone)
								return true;
							else
								return false;
					}
				case DirectionalInput.DirectionalInputs.RightStick:
					switch (direction.direction) {
						default:
							return false;
						case Direction.Directions.Up:
							if (_prevStates[playerIndex].ThumbSticks.Right.Y >= stickDeadzone && _currentStates[playerIndex].ThumbSticks.Right.Y < stickDeadzone)
								return true;
							else
								return false;
						case Direction.Directions.Right:
							if (_prevStates[playerIndex].ThumbSticks.Right.X >= stickDeadzone && _currentStates[playerIndex].ThumbSticks.Right.X < stickDeadzone)
								return true;
							else
								return false;
						case Direction.Directions.Down:
							if (_prevStates[playerIndex].ThumbSticks.Right.Y <= -stickDeadzone && _currentStates[playerIndex].ThumbSticks.Right.Y > -stickDeadzone)
								return true;
							else
								return false;
						case Direction.Directions.Left:
							if (_prevStates[playerIndex].ThumbSticks.Right.X <= -stickDeadzone && _currentStates[playerIndex].ThumbSticks.Right.X > -stickDeadzone)
								return true;
							else
								return false;
					}
				case DirectionalInput.DirectionalInputs.DPad:
					switch (direction.direction) {
						default:
							return false;
						case Direction.Directions.Up:
							if (_prevStates[playerIndex].DPad.Up == ButtonState.Pressed && _currentStates[playerIndex].DPad.Up == ButtonState.Released)
								return true;
							else
								return false;
						case Direction.Directions.Right:
							if (_prevStates[playerIndex].DPad.Right == ButtonState.Pressed && _currentStates[playerIndex].DPad.Right == ButtonState.Released)
								return true;
							else
								return false;
						case Direction.Directions.Down:
							if (_prevStates[playerIndex].DPad.Down == ButtonState.Pressed && _currentStates[playerIndex].DPad.Down == ButtonState.Released)
								return true;
							else
								return false;
						case Direction.Directions.Left:
							if (_prevStates[playerIndex].DPad.Left == ButtonState.Pressed && _currentStates[playerIndex].DPad.Left == ButtonState.Released)
								return true;
							else
								return false;
					}
			}
		}
		#endregion

		#region GetTrigger functions
		/// <summary>
		/// Returns true if the given trigger is held.
		/// </summary>
		/// <param name="playerIndex">Which controller would you like to check?</param>
		/// <param name="trigger">Which trigger would you like to check?</param>
		/// <param name="deadzone">How much of a deadzone should be applied?</param>
		public static bool GetTrigger (PlayerIndex playerIndex, Trigger trigger, float deadzone = .08f)
		{
			switch (trigger.trigger) {
				default:
					return false;
				case Trigger.Triggers.Left:
					if (_currentStates[playerIndex].Triggers.Left >= deadzone)
						return true;
					else
						return false;
				case Trigger.Triggers.Right:
					if (_currentStates[playerIndex].Triggers.Right >= deadzone)
						return true;
					else
						return false;
			}
		}
		/// <summary>
		/// Returns true if the given trigger is held and wasn't held the previous frame.
		/// </summary>
		/// <param name="playerIndex">Which controller would you like to check?</param>
		/// <param name="trigger">Which trigger would you like to check?</param>
		/// <param name="deadzone">How much of a deadzone should be applied?</param>
		public static bool GetTriggerDown (PlayerIndex playerIndex, Trigger trigger, float deadzone = .08f)
		{
			switch (trigger.trigger) {
				default:
					return false;
				case Trigger.Triggers.Left:
					if (_prevStates[playerIndex].Triggers.Left < deadzone && _currentStates[playerIndex].Triggers.Left >= deadzone)
						return true;
					else
						return false;
				case Trigger.Triggers.Right:
					if (_prevStates[playerIndex].Triggers.Right < deadzone && _currentStates[playerIndex].Triggers.Right >= deadzone)
						return true;
					else
						return false;
			}
		}
		/// <summary>
		/// Returns true if the given trigger is released and was held the previous frame.
		/// </summary>
		/// <param name="playerIndex">Which controller would you like to check?</param>
		/// <param name="trigger">Which trigger would you like to check?</param>
		/// <param name="deadzone">How much of a deadzone should be applied?</param>
		public static bool GetTriggerUp (PlayerIndex playerIndex, Trigger trigger, float deadzone = .08f)
		{
			switch (trigger.trigger) {
				default:
					return false;
				case Trigger.Triggers.Left:
					if (_prevStates[playerIndex].Triggers.Left >= deadzone && _currentStates[playerIndex].Triggers.Left < deadzone)
						return true;
					else
						return false;
				case Trigger.Triggers.Right:
					if (_prevStates[playerIndex].Triggers.Right >= deadzone && _currentStates[playerIndex].Triggers.Right < deadzone)
						return true;
					else
						return false;
			}
		}
		#endregion

		#region GetAxis functions
		/// <summary>
		/// Returns a value from -1.0 through 1.0 for the given axis.
		/// </summary>
		/// <param name="playerIndex">Which controller would you like to check?</param>
		/// <param name="axis">Which axis would you like to check?</param>
		/// <returns></returns>
		public static float GetAxis (PlayerIndex playerIndex, Axis axis)
		{
			float result = 0;

			switch (axis.axis) {
				default:
					return 0;
				case Axis.Axes.LeftStickHorizontal:
					return _currentStates[playerIndex].ThumbSticks.Left.X;
				case Axis.Axes.LeftStickVertical:
					return _currentStates[playerIndex].ThumbSticks.Left.Y;
				case Axis.Axes.RightStickHorizontal:
					return _currentStates[playerIndex].ThumbSticks.Right.X;
				case Axis.Axes.RightStickVertical:
					return _currentStates[playerIndex].ThumbSticks.Right.Y;
				case Axis.Axes.DPadHorizontal:
					if (_currentStates[playerIndex].DPad.Left == ButtonState.Pressed)
						result += -1;
					if (_currentStates[playerIndex].DPad.Right == ButtonState.Pressed)
						result += 1;
					return result;
				case Axis.Axes.DPadVertical:
					if (_currentStates[playerIndex].DPad.Down == ButtonState.Pressed)
						result += 1;
					if (_currentStates[playerIndex].DPad.Up == ButtonState.Pressed)
						result += 1;
					return result;
				case Axis.Axes.Triggers:
					result += _currentStates[playerIndex].Triggers.Right;
					result -= _currentStates[playerIndex].Triggers.Left;
					return result;
			}
		}
		/// <summary>
		/// Returns the value of the given axis snapped to -1, 0 or 1.
		/// </summary>
		/// <param name="playerIndex">Which controller would you like to check?</param>
		/// <param name="axis">Which axis would you like to check?</param>
		/// <returns></returns>
		public static float GetAxisRaw (PlayerIndex playerIndex, Axis axis, float deadzone = .08f)
		{
			float axisValue = GetAxis(playerIndex, axis);

			if (axisValue > deadzone) {
				return 1;
			} else if (axisValue < -deadzone) {
				return -1;
			} else {
				return 0;
			}
		}
		#endregion

		#region GetAnyButton functions
		/// <summary>
		/// Returns true if A, B, X, Y, Start, Back, Bumpers, Stick presses or the Guide button is pressed.
		/// </summary>
		/// <param name="playerIndex">Which controller would you like to check?</param>
		public static bool GetAnyButton (PlayerIndex playerIndex)
		{
			if (_currentStates[playerIndex].Buttons.A == ButtonState.Pressed)
				return true;
			if (_currentStates[playerIndex].Buttons.B == ButtonState.Pressed)
				return true;
			if (_currentStates[playerIndex].Buttons.X == ButtonState.Pressed)
				return true;
			if (_currentStates[playerIndex].Buttons.Y == ButtonState.Pressed)
				return true;
			if (_currentStates[playerIndex].Buttons.Start == ButtonState.Pressed)
				return true;
			if (_currentStates[playerIndex].Buttons.Back == ButtonState.Pressed)
				return true;
			if (_currentStates[playerIndex].Buttons.RightShoulder == ButtonState.Pressed)
				return true;
			if (_currentStates[playerIndex].Buttons.LeftShoulder == ButtonState.Pressed)
				return true;
			if (_currentStates[playerIndex].Buttons.LeftStick == ButtonState.Pressed)
				return true;
			if (_currentStates[playerIndex].Buttons.RightStick == ButtonState.Pressed)
				return true;
			if (_currentStates[playerIndex].Buttons.Guide == ButtonState.Pressed)
				return true;

			return false;
		}
		/// <summary>
		/// Returns true if A, B, X, Y, Start, Back, Bumpers, Stick presses or the Guide button is pressed while non of them were pressed the previous frame.
		/// </summary>
		/// <param name="playerIndex">Which controller would you like to check?</param>
		public static bool GetAnyButtonDown (PlayerIndex playerIndex)
		{
			if (_prevStates[playerIndex].Buttons.A == ButtonState.Released && _currentStates[playerIndex].Buttons.A == ButtonState.Pressed)
				return true;
			if (_prevStates[playerIndex].Buttons.B == ButtonState.Released && _currentStates[playerIndex].Buttons.B == ButtonState.Pressed)
				return true;
			if (_prevStates[playerIndex].Buttons.X == ButtonState.Released && _currentStates[playerIndex].Buttons.X == ButtonState.Pressed)
				return true;
			if (_prevStates[playerIndex].Buttons.Y == ButtonState.Released && _currentStates[playerIndex].Buttons.Y == ButtonState.Pressed)
				return true;
			if (_prevStates[playerIndex].Buttons.Start == ButtonState.Released && _currentStates[playerIndex].Buttons.Start == ButtonState.Pressed)
				return true;
			if (_prevStates[playerIndex].Buttons.Back == ButtonState.Released && _currentStates[playerIndex].Buttons.Back == ButtonState.Pressed)
				return true;
			if (_prevStates[playerIndex].Buttons.RightShoulder == ButtonState.Released && _currentStates[playerIndex].Buttons.RightShoulder == ButtonState.Pressed)
				return true;
			if (_prevStates[playerIndex].Buttons.LeftShoulder == ButtonState.Released && _currentStates[playerIndex].Buttons.LeftShoulder == ButtonState.Pressed)
				return true;
			if (_prevStates[playerIndex].Buttons.LeftStick == ButtonState.Released && _currentStates[playerIndex].Buttons.LeftStick == ButtonState.Pressed)
				return true;
			if (_prevStates[playerIndex].Buttons.RightStick == ButtonState.Released && _currentStates[playerIndex].Buttons.RightStick == ButtonState.Pressed)
				return true;
			if (_prevStates[playerIndex].Buttons.Guide == ButtonState.Released && _currentStates[playerIndex].Buttons.Guide == ButtonState.Pressed)
				return true;

			return false;
		}
		/// <summary>
		/// Returns true if A, B, X, Y, Start, Back, Bumpers, Stick presses or the Guide button are released while any of them were pressed the previous frame.
		/// </summary>
		/// <param name="playerIndex">Which controller would you like to check?</param>
		public static bool GetAnyButtonUp (PlayerIndex playerIndex)
		{
			if (_prevStates[playerIndex].Buttons.A == ButtonState.Pressed && _currentStates[playerIndex].Buttons.A == ButtonState.Released)
				return true;
			if (_prevStates[playerIndex].Buttons.B == ButtonState.Pressed && _currentStates[playerIndex].Buttons.B == ButtonState.Released)
				return true;
			if (_prevStates[playerIndex].Buttons.X == ButtonState.Pressed && _currentStates[playerIndex].Buttons.X == ButtonState.Released)
				return true;
			if (_prevStates[playerIndex].Buttons.Y == ButtonState.Pressed && _currentStates[playerIndex].Buttons.Y == ButtonState.Released)
				return true;
			if (_prevStates[playerIndex].Buttons.Start == ButtonState.Pressed && _currentStates[playerIndex].Buttons.Start == ButtonState.Released)
				return true;
			if (_prevStates[playerIndex].Buttons.Back == ButtonState.Pressed && _currentStates[playerIndex].Buttons.Back == ButtonState.Released)
				return true;
			if (_prevStates[playerIndex].Buttons.RightShoulder == ButtonState.Pressed && _currentStates[playerIndex].Buttons.RightShoulder == ButtonState.Released)
				return true;
			if (_prevStates[playerIndex].Buttons.LeftShoulder == ButtonState.Pressed && _currentStates[playerIndex].Buttons.LeftShoulder == ButtonState.Released)
				return true;
			if (_prevStates[playerIndex].Buttons.LeftStick == ButtonState.Pressed && _currentStates[playerIndex].Buttons.LeftStick == ButtonState.Released)
				return true;
			if (_prevStates[playerIndex].Buttons.RightStick == ButtonState.Pressed && _currentStates[playerIndex].Buttons.RightStick == ButtonState.Released)
				return true;
			if (_prevStates[playerIndex].Buttons.Guide == ButtonState.Pressed && _currentStates[playerIndex].Buttons.Guide == ButtonState.Released)
				return true;

			return false;
		}
		#endregion

		#region GetAnyInput functions
		/// <summary>
		/// Returns true if any button, trigger or directional input is pressed or held in any direction.
		/// </summary>
		/// <param name="playerIndex">Which controller would you like to check?</param>
		/// <param name="stickDeadzone">How much of a deadzone should be applied? (sticks only)</param>
		public static bool GetAnyInput (PlayerIndex playerIndex, float stickDeadzone = .12f)
		{
			if (GetAnyButtonDown(playerIndex))
				return true;
			if (Mathf.Abs(GetAxis(playerIndex, Axis.LeftStickHorizontal)) >= stickDeadzone)
				return true;
			if (Mathf.Abs(GetAxis(playerIndex, Axis.LeftStickVertical)) >= stickDeadzone)
				return true;
			if (Mathf.Abs(GetAxis(playerIndex, Axis.RightStickHorizontal)) >= stickDeadzone)
				return true;
			if (Mathf.Abs(GetAxis(playerIndex, Axis.RightStickVertical)) >= stickDeadzone)
				return true;
			if (GetAxis(playerIndex, Axis.DPadHorizontal) != 0)
				return true;
			if (GetAxis(playerIndex, Axis.DPadVertical) != 0)
				return true;
			if (GetAxis(playerIndex, Axis.Triggers) != 0) {
				return true;
			}

			return false;
		}
		/// <summary>
		/// Returns true if any button, trigger or directional input is pressed or held in any direction while none were pressed or held the previous frame.
		/// </summary>
		/// <param name="playerIndex">Which controller would you like to check?</param>
		/// <param name="stickDeadzone">How much of a deadzone should be applied? (sticks only)</param>
		public static bool GetAnyInputDown (PlayerIndex playerIndex, float stickDeadzone = .12f)
		{
			if (GetAnyButtonDown(playerIndex))
				return true;
			if (GetDirectionDown(playerIndex, DirectionalInput.LeftStick, Direction.Up))
				return true;
			if (GetDirectionDown(playerIndex, DirectionalInput.LeftStick, Direction.Right))
				return true;
			if (GetDirectionDown(playerIndex, DirectionalInput.LeftStick, Direction.Down))
				return true;
			if (GetDirectionDown(playerIndex, DirectionalInput.LeftStick, Direction.Left))
				return true;
			if (GetDirectionDown(playerIndex, DirectionalInput.RightStick, Direction.Up))
				return true;
			if (GetDirectionDown(playerIndex, DirectionalInput.RightStick, Direction.Right))
				return true;
			if (GetDirectionDown(playerIndex, DirectionalInput.RightStick, Direction.Down))
				return true;
			if (GetDirectionDown(playerIndex, DirectionalInput.RightStick, Direction.Left))
				return true;
			if (GetDirectionDown(playerIndex, DirectionalInput.DPad, Direction.Up))
				return true;
			if (GetDirectionDown(playerIndex, DirectionalInput.DPad, Direction.Right))
				return true;
			if (GetDirectionDown(playerIndex, DirectionalInput.DPad, Direction.Down))
				return true;
			if (GetDirectionDown(playerIndex, DirectionalInput.DPad, Direction.Left))
				return true;
			if (GetTriggerDown(playerIndex, Trigger.Left))
				return true;
			if (GetTriggerDown(playerIndex, Trigger.Right))
				return true;

			return false;
		}
		/// <summary>
		/// Returns true if all button, trigger or directional input are released while any were pressed or held the previous frame.
		/// </summary>
		/// <param name="playerIndex">Which controller would you like to check?</param>
		/// <param name="stickDeadzone">How much of a deadzone should be applied? (sticks only)</param>
		public static bool GetAnyInputUp (PlayerIndex playerIndex, float stickDeadzone = .12f)
		{
			if (GetAnyButtonUp(playerIndex))
				return true;
			if (GetDirectionUp(playerIndex, DirectionalInput.LeftStick, Direction.Up, stickDeadzone))
				return true;
			if (GetDirectionUp(playerIndex, DirectionalInput.LeftStick, Direction.Right, stickDeadzone))
				return true;
			if (GetDirectionUp(playerIndex, DirectionalInput.LeftStick, Direction.Down, stickDeadzone))
				return true;
			if (GetDirectionUp(playerIndex, DirectionalInput.LeftStick, Direction.Left, stickDeadzone))
				return true;
			if (GetDirectionUp(playerIndex, DirectionalInput.RightStick, Direction.Up, stickDeadzone))
				return true;
			if (GetDirectionUp(playerIndex, DirectionalInput.RightStick, Direction.Right, stickDeadzone))
				return true;
			if (GetDirectionUp(playerIndex, DirectionalInput.RightStick, Direction.Down, stickDeadzone))
				return true;
			if (GetDirectionUp(playerIndex, DirectionalInput.RightStick, Direction.Left, stickDeadzone))
				return true;
			if (GetDirectionUp(playerIndex, DirectionalInput.DPad, Direction.Up))
				return true;
			if (GetDirectionUp(playerIndex, DirectionalInput.DPad, Direction.Right))
				return true;
			if (GetDirectionUp(playerIndex, DirectionalInput.DPad, Direction.Down))
				return true;
			if (GetDirectionUp(playerIndex, DirectionalInput.DPad, Direction.Left))
				return true;
			if (GetTriggerUp(playerIndex, Trigger.Left))
				return true;
			if (GetTriggerUp(playerIndex, Trigger.Right))
				return true;

			return false;
		}
		#endregion

		#region Vibration functions
		public static void StartVibration (PlayerIndex playerIndex, float leftMotorStrength, float rightMotorStrength, float duration = .3f)
		{
			Vibration vibration = new Vibration(leftMotorStrength, rightMotorStrength, duration);
			_vibrationHandler.StartVibration(playerIndex, vibration);
		}

		public static void StartVibration (PlayerIndex playerIndex, Vibration vibration)
		{
			_vibrationHandler.StartVibration(playerIndex, vibration);
		}

		public static void StopVibration (PlayerIndex playerIndex)
		{
			_vibrationHandler.StopVibration(playerIndex);
		}
		#endregion
	}
}
