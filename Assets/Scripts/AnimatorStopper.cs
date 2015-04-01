using UnityEngine;
using System.Collections;

public class AnimatorStopper : MonoBehaviour {
	public float StopAnimation;
	// Update is called once per frame
	void Update () 
	{
		if (Time.time > StopAnimation) 
		{
			GetComponent<Animator>().enabled = false;
		}
	}
}
