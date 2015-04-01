using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class IntroDialog : MonoBehaviour {
	public string FirstName;
	public string LastName;
	public Text text;
	public GameObject Image;
	public string[] Messages = new string[]
	{
		"Hi! My name is Aiko Moto.",
		"I am a second year student at Foebarabu High School.",
		"I have always been very cautious when it came to dating,",
		"but there is one person I have had my eyes on since I first entered Foebarabu.",
		"His name is Blake Shelton, a third year student",
		"He is an all-star, sports, theater, music, academics; you name it he has mastered it.",
		"We have been friends since my first day of high school. I had to go to the nurse's office because " +
		"I hit my head during gym class, he was there learning what the different medicines did."

	};
	
	private int currentMessage = 0; //start with the first entry in the Messages array
	
	void Update () 
	{
		if(Input.GetButtonDown("Submit"))
		{
			if (currentMessage < Messages.Length)
			{
				text.text += " " + Messages[currentMessage]; //add the new message to the existing text
			}
			else //if we've run out of messages to display
			{

			}

				//Make the Message's call number go up one.
				currentMessage++;
				 
		 }
	 }
}
					 