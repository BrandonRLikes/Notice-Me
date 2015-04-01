using UnityEngine;
using System.Collections;

public class MainMenuTransition : MonoBehaviour {

	public void Update()
	{
		if(Input.GetMouseButtonDown(0))
		{
			Application.LoadLevel("Notice Me");
		}
	}
}
