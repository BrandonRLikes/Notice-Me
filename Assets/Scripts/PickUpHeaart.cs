using UnityEngine;
using System.Collections;

public class PickUpHeaart : MonoBehaviour 
{
	
	public AudioClip pickup;
	public ParticleSystem pickupheart;
		
	void OnTriggerEnter (Collider collider)
		{
			if (collider.tag == "Heart")
			{
				;
				;
			}
		}
}
