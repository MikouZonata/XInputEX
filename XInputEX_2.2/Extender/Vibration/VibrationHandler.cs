using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XInputDotNetPure;

namespace XInputDotNetExtended.Vibrations
{
	public class VibrationHandler
	{
		private VibrationRunner[] _vibrationRunners = new VibrationRunner[XInputEX.NumberOfGamePads];

		public VibrationHandler ()
		{
			for (int i = 0; i < XInputEX.NumberOfGamePads; i++) {
				_vibrationRunners[i] = new VibrationRunner(i);
			}

			XInputDotNetUpdater.OnOnDestroy += OnDestroy;
		}

		void OnDestroy ()
		{
			foreach (VibrationRunner vr in _vibrationRunners) {
				vr.StopVibration();
			}

			XInputDotNetUpdater.OnOnDestroy -= OnDestroy;
		}

		public void Update ()
		{
			foreach (VibrationRunner vr in _vibrationRunners) {
				vr.Update();
			}
		}

		#region Public Functions
		public void StartVibration (PlayerIndex playerIndex, Vibration vibration)
		{
			_vibrationRunners[playerIndex].StartVibration(vibration);
		}

		public void StopVibration (PlayerIndex playerIndex)
		{
			_vibrationRunners[playerIndex].StopVibration();
			GamePad.SetVibration(playerIndex, 0, 0);
		}
		#endregion
	}
}
