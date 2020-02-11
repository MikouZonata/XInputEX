using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XInputDotNetPure;

namespace XInputDotNetExtended.Dependancies
{
	public class VibrationRunner
	{
		private PlayerIndex _playerIndex = 0;
		private float _leftMotorStrength = 0;
		private float _rightMotorStrength = 0;
		private float _timeRemaining = 0;

		public VibrationRunner (PlayerIndex playerIndex)
		{
			_playerIndex = playerIndex;
		}

		public void Update ()
		{
			if (_timeRemaining <= 0) {
				GamePad.SetVibration(_playerIndex, 0, 0);
			} else {
				GamePad.SetVibration(_playerIndex, _leftMotorStrength, _rightMotorStrength);
				_timeRemaining -= Time.deltaTime;
				Debug.Log(_timeRemaining);
			}
		}

		public void StartVibration (Vibration vibration)
		{
			_leftMotorStrength = vibration.leftMotorStrength;
			_rightMotorStrength = vibration.rightMotorStrength;
			_timeRemaining = vibration.duration;
			GamePad.SetVibration(_playerIndex, _leftMotorStrength, _rightMotorStrength);
		}

		public void StopVibration ()
		{
			_timeRemaining = 0;
			GamePad.SetVibration(_playerIndex, 0, 0);
		}
	}
}
