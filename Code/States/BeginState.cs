using UnityEngine;
using Assets.Code.Interfaces;

namespace Assets.Code.States
{
	public class BeginState : IStateBase
	{
		private StateManager manager;

		public BeginState (StateManager managerRef) //Constructor
		{
			manager = managerRef;
			if (Application.loadedLevelName != "Scene0")
				Application.LoadLevel ("Scene0");
		}
				
		public void StateUpdate()
		{
			if (Input.GetKeyUp (KeyCode.Space))  
			{
			}
		}

		public void ShowIt()
		{
			GUI.DrawTexture (new Rect (0, 0, Screen.width, Screen.height),
			manager.gameDataRef.beginStateSplash,
			ScaleMode.StretchToFill);

			if (GUI.Button (new Rect (100, 150, 500, 70),
			    "Press Here or Any Key to Continue!") ||
				Input.anyKeyDown) 
			{
				manager.SwitchState (new SetupState (manager));
			}
		}
	}
}

