using UnityEngine;
using System.Collections;

public class Sphere : MonoBehaviour {

	private static int numberOfHeartsRemaining = 0;

	public ParticleSystem pickupheart;
	public AudioClip myClip;
	public GameObject target;
	void Start () 
	{
		numberOfHeartsRemaining++;
	}

	void OnTriggerEnter (Collider collider) 
	{
		if (collider.tag == "Player") 
		{
			AudioSource.PlayClipAtPoint(myClip, transform.position);
			Instantiate(pickupheart);
			GetComponent<Animator>().enabled = false;
			Destroy (gameObject);

			numberOfHeartsRemaining--;
			if (numberOfHeartsRemaining == 0)
			{
				target.SetActive(true);
			}
		}
	}
}
