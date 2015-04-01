using UnityEngine;
using System.Collections;

public class TalkOneTransition : MonoBehaviour {

	public void Update()
	{
		if(Input.GetMouseButtonDown(0))
		{
			Application.LoadLevel("First Talk");
		}
	}
}
