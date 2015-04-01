using UnityEngine;
using System.Collections;

public class YouWinHeart : MonoBehaviour {
	private static int numberOfHeartsRemaining = 0;
	public AudioClip myClip;

	void OnTriggerEnter (Collider collider) 
	{
		Debug.Log ("Trigger: " + collider.tag);
		if (collider.tag == "Player") 
		{
			AudioSource.PlayClipAtPoint(myClip, transform.position);
			Destroy (gameObject);
			
			numberOfHeartsRemaining--;
			Application.LoadLevel("Victory Screen");
		}
	}
}
