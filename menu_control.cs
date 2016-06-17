using UnityEngine;
using System.Collections;

public class menu_control : MonoBehaviour {
	#region Public Variables
	public GameObject splashScreen;
	public GameObject menuScreen;
	public GameObject reclinerScreen;

	#endregion

	#region Private Variables
	private int curScreenID = 0;
	#endregion

	#region UI Actions
	public void SwitchScreens(int aID)
	{
		switch (aID)
		{
		case 0:
			if (splashScreen) {
				splashScreen.SetActive (true);
			}
			break;

		case 1:
			if (menuScreen) {
				menuScreen.SetActive (true);
			}
			break;

		case 2:
			if (reclinerScreen) {
				reclinerScreen.SetActive (true);
			}
			break;
		}
	}
	#endregion

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
