using UnityEngine;
using System.Collections;

public class Timer : MonoBehaviour 
{

	public float CountdownTime;
	public GUIText CountdownText;

	void Start () 
	{
		CountdownTime = 0;
	}
	
	// Update is called once per frame
	void Update () 
	{
		CountdownTime--;
	}
}