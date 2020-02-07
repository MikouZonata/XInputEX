using UnityEngine;

namespace XInputDotNetPure
{
	public class XInputDotNetUpdater : MonoBehaviour
	{
		public delegate void UpdateHandler ();
		public static event UpdateHandler OnUpdate;
		public delegate void DestroyHandler ();
		public static event DestroyHandler OnOnDestroy;

		private void Awake ()
		{
			DontDestroyOnLoad(gameObject);
		}

		void Update ()
		{
			OnUpdate?.Invoke();
		}

		private void OnDestroy ()
		{
			OnOnDestroy?.Invoke();
		}
	}
}